using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Web;
using System.Net.Http;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.Linq;
using Terradue.ServiceModel.Ogc.WebService.Configuration;
using Terradue.ServiceModel.Ogc.WebService.Common;

namespace Terradue.ServiceModel.Ogc.WebService
{
    /// <summary>
    /// This class handles HTTP operations that can be used for OGC Service. 
    /// </summary>
    public class OwsHttpRequestHandler
    {
       
        /// <summary>
        /// Proccesses HTTP request.
        /// </summary>
        /// <param name="messageRequest">Message with request details</param>
        /// <returns>Response to the request.</returns>
        private static HttpResponseMessage ProccessRequest(HttpRequestMessage messageRequest)
        {
            HttpResponseMessage resultMessage = null;

            try
            {
                XDocument doc = null;
                OperationResult result = null;

                if (messageRequest != null)
                {
                    doc = XDocument.Load(messageRequest.Content.ReadAsStreamAsync().Result);
                }

                NameValueCollection queryParameters = HttpUtility.ParseQueryString(messageRequest.RequestUri.Query);

                //  Apply global defaults
                if (queryParameters["service"] == null)
                {
                    queryParameters.Add("service", ServiceConfiguration.Settings.DefaultService);
                }
                if (queryParameters["version"] == null)
                {
                    queryParameters.Add("version", ServiceConfiguration.Settings.DefaultVersion);
                }

                var operation = GetServiceOperation(doc, queryParameters);

                //  Apply operation specific defaults
                foreach (var defaultValue in operation.DefaultValues)
                {
                    if (queryParameters[defaultValue.Name] == null)
                    {
                        queryParameters.Add(defaultValue.Name, defaultValue.DefaultValue);
                    }
                }

                string cacheKey = string.Empty;

                if (operation.CacheEnabled)
                {
                    //  Create cache key to be used to store results in cache
                    cacheKey = messageRequest.RequestUri.ToString();

                    if (doc != null)
                    {
                        cacheKey = doc.CreateReader().ReadInnerXml();
                    }

                    //  Get cahce resuls if exists
                    result = HttpContext.Current.Cache[cacheKey] as OperationResult;
                }

                if (result == null)
                {
                    //  Get request handler object for selected operation
                    BaseOperation requestHandler = operation.CreateHandlerInstance();

                    OwsRequestBase request = null;

                    //  If xmlRequest is null then use query parameters to build an request object
                    if (doc == null)
                    {
                        request = Activator.CreateInstance(requestHandler.RequestType, new object[] { queryParameters }) as OwsRequestBase;
                    }
                    else
                    {
                        XmlSerializer serializer = requestHandler.RequestType.GetSerializer();
                        request = serializer.Deserialize(doc.CreateReader()) as OwsRequestBase;
                    }

                    request.Validate();

                    //  Hanle request and return results back
                    result = requestHandler.ProcessRequest(request);

                    //  Add result to cache
                    if (operation.CacheEnabled)
                    {
                        HttpContext.Current.Cache.Add(cacheKey, result, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(operation.CacheTimeout), CacheItemPriority.Normal, null);
                    }
                }

                //  Performs special service operation if specified
                if ((from k in queryParameters.AllKeys
                     where k.StartsWith("$$", StringComparison.OrdinalIgnoreCase)
                     select k).Count() > 0)
                    result = HandleCustomAction(result, queryParameters);

                resultMessage = result.GetResultMessage();
            }
            catch (OgcException exp)
            {
                //  Handle OGC specific errors
                var result = new OperationResult()
                {
                    ResultObject = exp.ExceptionReport,
                };
                resultMessage = result.GetResultMessage();
            }
            catch (System.Exception exp)
            {
                //  Handle all other .NET errors
                var result = new OperationResult()
                {
                    ResultObject = new NoApplicableCodeException("Application error.", exp).ExceptionReport,
                };
                resultMessage = result.GetResultMessage();
            }

            return resultMessage;
        }

        /// <summary>
        /// Gets the service operation.
        /// </summary>
        /// <param name="xmlDocument">The XML request.</param>
        /// <param name="queryParameters">The query parameters.</param>
        /// <returns></returns>
        private static ServiceOperationElement GetServiceOperation(XDocument xmlDocument, NameValueCollection queryParameters)
        {
            string requestName = queryParameters["request"];
            string serviceName = queryParameters["service"];
            string requestVersion;

            //  Validate "request" parameter
            if (string.IsNullOrEmpty(requestName))
            {
                throw new MissingParameterValueException("request");
            }

            //  Validate "service" parameter
            if (string.IsNullOrEmpty(serviceName))
            {
                throw new MissingParameterValueException("service");
            }

            //  Get version if possible
            if (xmlDocument != null)
            {
                requestVersion = xmlDocument.GetAttribute("version");
            }
            else
            {
                requestVersion = queryParameters["version"];
            }

            //  Get operation configuration or the default one
            var versionOperations = (from o in ServiceConfiguration.Settings.Services
                                     where
                                        o.Operation == requestName
                                        && o.Service == serviceName
                                         && o.Version.ToVersionNumber() == requestVersion.ToVersionNumber()
                                     select o).ToList();

            var defaultOperation = (from o in ServiceConfiguration.Settings.Services
                                    orderby o.Version descending
                                    where
                                       o.Operation == requestName
                                       && o.Service == serviceName
                                    select o).FirstOrDefault();

            //  Make sure there are no multiple configurations for the service
            if (versionOperations.Count() > 1)
            {
                throw new ConfigurationErrorsException(string.Format(CultureInfo.InvariantCulture, "Operation '{1}' of service '{0}' has multiple handlers.", serviceName, requestName));
            }

            //  Get a service configuration
            var operation = versionOperations.FirstOrDefault() ?? defaultOperation;

            //  Make sure service configuration is found
            if (operation == null)
            {
                throw new OperationNotSupportedException(requestName, string.Format(CultureInfo.InvariantCulture, "Operation '{0}' of '{1}' service is not supported.", requestName, serviceName));
            }

            return operation;
        }

        /// <summary>
        /// Handles the custom action specified in URL query path.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="queryParameters">The query parameters.</param>
        /// <returns></returns>
        private static OperationResult HandleCustomAction(OperationResult result, NameValueCollection queryParameters)
        {
            if (queryParameters.AllKeys.Contains("$$validate"))
            {
                Renci.Data.Interop.OpenGIS.Ows.ExceptionReport report = new Renci.Data.Interop.OpenGIS.Ows.ExceptionReport();

                var errors = ValidateXml(result.GetResultMessage());

                var exception = new Renci.Data.Interop.OpenGIS.Ows.ExceptionType
                {
                    ExceptionCode = Renci.Data.Interop.OpenGIS.Ows.ExceptionCode.NoApplicableCode,
                };

                report.Exceptions.Add(exception);

                if (errors.Count > 0)
                {
                    foreach (var error in errors)
                    {
                        exception.ExceptionText.Add(error);
                    }
                }
                else
                {
                    exception.ExceptionText.Add(string.Format(CultureInfo.InvariantCulture, "Result XML has been successfully validated."));
                }

                result = new OperationResult()
                {
                    ResultObject = report,
                };
            }
            return result;
        }

       
    }
}