using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.WebService.Common;
using Terradue.ServiceModel.Ogc.WebService.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Represents a sample GetCapabilities request handler
    /// </summary>
    public class GetCapabilitiesOperation : BaseSosOperation
    {
        /// <summary>
        /// Gets sensor query
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static IQueryable<Offering> GetOfferingsQuery(SosEntities data)
        {
            var result = from offering in data.Offerings.Include("ObservedProperties").Include("Sensors").Include("FeaturesOfInterest")
                         select offering;

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result;
        }

        /// <summary>
        /// Object used for thread synchronization
        /// </summary>
        private static object _lock = new object();

        /// <summary>
        /// Instace of <see cref="ServiceProvider"/>.
        /// </summary>
        private static ServiceProvider _serviceProvider;

        /// <summary>
        /// Instance of <see cref="ServiceIdentification"/>.
        /// </summary>
        private static ServiceIdentification _serviceIdentification;

        /// <summary>
        /// Specifies list of supported formats.
        /// </summary>
        private List<OutputFormat> _supportedFormats = new List<OutputFormat>()
        {
            OutputFormat.TextXml,
            OutputFormat.ApplicationXml,
        };

        private ReadOnlyCollection<string> _supportedVersions;
        /// <summary>
        /// Gets list of supported versions
        /// </summary>
        protected virtual ReadOnlyCollection<string> SupportedVersions
        {
            get
            {
                if (this._supportedVersions == null)
                {
                    this._supportedVersions = (from a in base.Services.ToList()
                                               where
                                                   a.Service == this.ServiceName
                                                   && a.Version.ToVersionNumber() > -1
                                               select a.Version).Distinct().ToList().AsReadOnly();
                }

                return this._supportedVersions;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCapabilitiesOperation"/> class.
        /// </summary>
        /// <param name="configuration">Operation configuration.</param>
        public GetCapabilitiesOperation(ServiceOperationElement configuration)
            : base(configuration)
        {
        }

        #region BaseOperation abstract methods

        /// <summary>
        /// Gets operation parameters list for GetObservation operation
        /// </summary>
        public override Collection<DomainType> OperationParameters
        {
            get
            {
                Collection<DomainType> parameters = new Collection<DomainType>();

                parameters.Add(new DomainType()
                {
                    Name = "updateSequence",
                    AnyValue = new AnyValue(),
                });

                parameters.Add(new DomainType()
                {
                    Name = "AcceptFormats",
                    AllowedValues = new Collection<object>(),
                });

                if (this._supportedFormats.Count > 0)
                {
                    DomainType parameter = parameters[parameters.Count - 1];

                    foreach (var format in this._supportedFormats)
                    {
                        parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(format.ToStringValue()));
                    }
                }

                parameters.Add(new DomainType()
                {
                    Name = "AcceptVersions",
                    AllowedValues = new Collection<object>(),
                });

                if (this.SupportedVersions.Count > 0)
                {
                    DomainType parameter = parameters[parameters.Count - 1];

                    foreach (var version in this.SupportedVersions)
                    {
                        parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(version));
                    }
                }

                parameters.Add(new DomainType()
                {
                    Name = "Sections",
                    AllowedValues = new Collection<object>()
                    {
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType("ServiceIdentification"),
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType("ServiceProvider"),
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType("OperationsMetadata"),
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType("Contents"),
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType("Filter_Capabilities"),
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType("All"),
                    },
                });

                return parameters;
            }
        }

        /// <summary>
        /// Gets operation dcp list for GetObservation operation
        /// </summary>
        public override Collection<Dcp> OperationDcps
        {
            get
            {
                Collection<Dcp> dcps = new Collection<Dcp>();
                Dcp dcp = new Dcp();

                dcp.Http.PostMethods.Add(new RequestMethodType()
                {
                    Href = string.Format(CultureInfo.InvariantCulture, "{0}/?service={1}&request={2}", this.ServiceBaseUri, this.ServiceName, this.RequestName)
                });

                dcp.Http.GetMethods.Add(new RequestMethodType()
                {
                    Href = string.Format(CultureInfo.InvariantCulture, "{0}/?service={1}&request={2}", this.ServiceBaseUri, this.ServiceName, this.RequestName)
                });

                dcps.Add(dcp);

                return dcps;
            }
        }

        /// <summary>
        /// Gets operation constraints list for GetObservation operation
        /// </summary>
        public override Collection<DomainType> OperationConstraints
        {
            get { return null; }
        }

        /// <summary>
        /// Gets operation metadata list for GetObservation operation
        /// </summary>
        public override Collection<MetadataType> OperationMetadata
        {
            get { return null; }
        }

        /// <summary>
        /// Gets a type of request object to be used for current operation
        /// </summary>
        public override Type RequestType
        {
            get { return typeof(GetCapabilities); }
        }

        /// <summary>
        /// Process operation request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Resposne object to be sent back to the client</returns>
        public override OperationResult ProcessRequest(object request)
        {
            GetCapabilities getCapabilities = request as GetCapabilities;

            //  Validate request parameter
            if (getCapabilities == null)
            {
                throw new NoApplicableCodeException(string.Format(CultureInfo.CurrentCulture, "Type '{0}' is invalid request type.", request.GetType().FullName));
            }

            OperationResult result = new OperationResult();

            //  TODO:   Filter_Capabilities is not yet implemented
            //  TODO:   Consider to implement updateSequence as described in OGC 06-121r3 7.3.4

            //  Validate acceptFormats parameter
            if (getCapabilities.AcceptFormats != null)
            {
                var formats = from sf in this._supportedFormats
                              from af in getCapabilities.AcceptFormats
                              where sf.ToStringValue() == af.Trim()
                              select sf;
                if (formats.Count() > 0)
                {
                    result.OutputFormat = formats.First();
                }
            }

            Capabilities capabilities = new Capabilities();

            //  Make sure client can accept current version of response
            if (getCapabilities.AcceptVersions != null && !getCapabilities.AcceptVersions.Contains(capabilities.Version))
            {
                throw new VersionNegotiationException(string.Format(CultureInfo.InvariantCulture, "Only '{0}' version is supported", capabilities.Version));
            }

            //  Make sure client can accept current formats
            if (getCapabilities.AcceptFormats != null)
            {
                bool supportedFormatFound = false;
                foreach (var format in getCapabilities.AcceptFormats)
                {
                    OutputFormat outputFormat;
                    supportedFormatFound = format.TryParseEnum<OutputFormat>(out outputFormat);
                    if (supportedFormatFound)
                    {
                        break;
                    }
                }
                if (!supportedFormatFound)
                {
                    throw new InvalidParameterValueException("Provided accept formats are not supported");
                }
            }

            //  TODO:   updateSequence currently not implemented
            //capabilities.UpdateSequence = DateTime.UtcNow.ToUnicodeStringValue();

            if (getCapabilities.Sections == null || getCapabilities.Sections.Contains("ServiceProvider"))
            {
                capabilities.ServiceProvider = this.GetServiceProvider();
            }

            if (getCapabilities.Sections == null || getCapabilities.Sections.Contains("ServiceIdentification"))
            {
                capabilities.ServiceIdentification = this.GetServiceIdentification();
            }

            if (getCapabilities.Sections == null || getCapabilities.Sections.Contains("OperationsMetadata"))
            {
                capabilities.OperationsMetadata = this.GetOperationsMetadata();
            }

            if (getCapabilities.Sections == null || getCapabilities.Sections.Contains("Filter_Capabilities"))
            {
                capabilities.FilterCapabilities = this.GetFilterCapabilities();
            }

            if (getCapabilities.Sections == null || getCapabilities.Sections.Contains("Contents"))
            {
                capabilities.Contents = this.GetContents();
            }

            result.ResultObject = capabilities;

            return result;
        }

        #endregion

        /// <summary>
        /// Gets ServiceProvider section
        /// </summary>
        /// <returns></returns>
        protected virtual ServiceProvider GetServiceProvider()
        {
            if (_serviceProvider == null)
            {
                //  Get ServiceProvider from XML file
                XmlSerializer serializer = new XmlSerializer(typeof(ServiceProvider));
                string filePath = string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\GetCapabilities.ServiceProvider.xml", HttpContext.Current.Server.MapPath("~/App_Data"), this.ServiceName);
                ServiceProvider sp = (ServiceProvider)serializer.Deserialize(File.OpenText(filePath));

                lock (_lock)
                {
                    if (_serviceProvider == null)
                    {
                        _serviceProvider = sp;
                    }
                }
            }

            return _serviceProvider;
        }

        /// <summary>
        /// Gets ServiceIdentification section
        /// </summary>
        /// <returns></returns>
        protected virtual ServiceIdentification GetServiceIdentification()
        {
            if (_serviceIdentification == null)
            {
                //  Get ServiceProvider from XML file
                XmlSerializer serializer = new XmlSerializer(typeof(ServiceIdentification));
                string filePath = string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\GetCapabilities.ServiceIdentification.xml", HttpContext.Current.Server.MapPath("~/App_Data"), this.ServiceName);
                ServiceIdentification si = (ServiceIdentification)serializer.Deserialize(File.OpenText(filePath));

                lock (_lock)
                {
                    if (_serviceIdentification == null)
                    {
                        _serviceIdentification = si;
                    }
                }
            }

            return _serviceIdentification;
        }

        /// <summary>
        /// Gets OperationsMetadata section
        /// </summary>
        /// <returns></returns>
        protected virtual OperationsMetadata GetOperationsMetadata()
        {
            OperationsMetadata om = new OperationsMetadata();

            //  Add services information base on configuration
            foreach (ServiceOperationElement operationInfo in this.Services.ToList())
            {
                //  Take only SOS services
                if (!operationInfo.Service.Equals(this.ServiceName, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                BaseOperation operationHandler = operationInfo.CreateHandlerInstance();

                Operation operation = new Operation();

                operation.Name = operationInfo.Operation;

                //  Add operation dcps
                if (operationHandler.OperationDcps != null)
                {
                    foreach (Dcp dcp in operationHandler.OperationDcps)
                    {
                        operation.Dcps.Add(dcp);
                    }
                }

                //  Add operation parameters
                if (operationHandler.OperationParameters != null)
                {
                    foreach (DomainType parameter in operationHandler.OperationParameters)
                    {
                        operation.Parameters.Add(parameter);
                    }
                }

                //  Add operation constrains
                if (operationHandler.OperationConstraints != null)
                {
                    foreach (DomainType constraint in operationHandler.OperationConstraints)
                    {
                        operation.Constraints.Add(constraint);
                    }
                }

                //  Add operation metadata
                if (operationHandler.OperationMetadata != null)
                {
                    foreach (MetadataType metadata in operationHandler.OperationMetadata)
                    {
                        operation.Metadata.Add(metadata);
                    }
                }

                om.Operations.Add(operation);
            }

            //  Specify service parameter
            om.Parameters.Add(new DomainType()
            {
                Name = "service",
                AllowedValues = new Collection<object>()
                { 
                    new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(this.ServiceName),
                },
            });

            om.Parameters.Add(new DomainType()
            {
                Name = "version",
                AllowedValues = new Collection<object>(),
            });

            if (this.SupportedVersions.Count > 0)
            {
                DomainType parameter = om.Parameters[om.Parameters.Count - 1];

                foreach (var version in this.SupportedVersions)
                {
                    parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(version));
                }
            }

            return om;
        }

        /// <summary>
        /// Gets Filter_Capabilities section
        /// </summary>
        /// <returns></returns>
        protected virtual FilterCapabilities GetFilterCapabilities()
        {
            return null;
        }

        /// <summary>
        /// Gets Contents section
        /// </summary>
        /// <returns></returns>
        protected virtual Contents GetContents()
        {
            Contents c = new Contents();

            using (SosEntities data = this.GetSosEntities())
            {
                var offerings = GetOfferingsQuery(data);

                foreach (var offering in offerings)
                {
                    ObservationOfferingType obs = new ObservationOfferingType();

                    //  Add site infromation
                    obs.Id = this.OfferingNames[offering.Code];
                    obs.Names.Add(this.GetOfferingInformation(offering));

                    //  Add boundedBy
                    obs.BoundedBy = new BoundingShapeType()
                    {
                        Item = this.GetOfferingBoundaries(offering),
                    };

                    //  Add time
                    obs.Time.TimeGeometricPrimitive = this.GetOfferingTime(offering);

                    //  Add procedures
                    obs.Procedures.Add(this.GetOfferingProcedures(offering));

                    //  Add observedProperty                    
                    obs.ObservedProperties.Add(this.GetOfferingObservedProperties(offering));

                    //  Add featureOfInterest
                    obs.FeaturesOfInterest.Add(this.GetOfferingFeatureOfInterest(offering));

                    //  Add responseFormat
                    obs.ResponseFormats.Add(this.GetOfferingResponseFormats(offering));

                    //  Add resultModel
                    obs.ResultModels.Add(this.GetOfferingResultModels(offering));

                    //  Add responseMode
                    obs.ResponseModes.Add(this.GetOfferingResponseModes(offering));

                    c.ObservationOfferings.Add(obs);
                }
            }

            return c;
        }

        #region AddOffering methods

        /// <summary>
        /// Gets offering information
        /// </summary>
        /// <param name="offering">Offering to get an information for</param>
        /// <returns>Offering information</returns>
        protected virtual Collection<Renci.Data.Interop.OpenGIS.Gml.CodeType> GetOfferingInformation(Offering offering)
        {
            Collection<Renci.Data.Interop.OpenGIS.Gml.CodeType> info = new Collection<Renci.Data.Interop.OpenGIS.Gml.CodeType>();

            info.Add(offering.Name);
            if (!string.IsNullOrEmpty(offering.SrsName))
            {
                info.Add((SrsName)offering.SrsName);
            }

            return info;
        }

        /// <summary>
        /// Get offering bounderies envelope
        /// </summary>
        /// <param name="offering">Offering to get a bounderies envelope for</param>
        /// <returns>Offering bounderies envelope</returns>
        protected virtual EnvelopeType GetOfferingBoundaries(Offering offering)
        {
            EnvelopeType envelope = new EnvelopeType();

            if (!string.IsNullOrEmpty(offering.SrsName))
            {
                envelope.SrsName = offering.SrsName;
            }

            SqlGeometry location = SqlGeometry.STGeomFromText(new System.Data.SqlTypes.SqlChars(new System.Data.SqlTypes.SqlString(offering.GeoLocation)), 4326);

            if (location.STNumPoints() > 1)
            {
                envelope.Items.Add(new LowerCornerPositionType(location.STPointN(3).STX.Value, location.STPointN(3).STY.Value));
                envelope.Items.Add(new UpperCornerPositionType(location.STPointN(1).STX.Value, location.STPointN(1).STY.Value));
            }
            else
            {
                envelope.Items.Add(new LowerCornerPositionType(location.STX.Value, location.STY.Value));
                envelope.Items.Add(new UpperCornerPositionType(location.STX.Value, location.STY.Value));
            }

            return envelope;
        }

        /// <summary>
        /// Gets offering time
        /// </summary>
        /// <param name="offering">Offering to get a time for</param>
        /// <returns>Offering time</returns>
        protected virtual AbstractTimeGeometricPrimitiveType GetOfferingTime(Offering offering)
        {
            return new TimePeriodType()
            {
                BeginTime = new TimePositionType() { Value = offering.BeginTime.ToUnicodeStringValue() },
                EndTime = new TimePositionType() { Value = offering.EndTime.ToUnicodeStringValue() },
            };
        }

        /// <summary>
        /// Gets list of available procedures
        /// </summary>
        /// <param name="offering">Offering to get an available procedures for</param>
        /// <returns>List of available procedures</returns>
        protected virtual Collection<ReferenceType> GetOfferingProcedures(Offering offering)
        {
            Collection<ReferenceType> procedures = new Collection<ReferenceType>();
            foreach (var sensor in offering.Sensors)
            {
                //  Add procedure
                procedures.Add(new ReferenceType { Href = this.UriManager.GetSensorUri(sensor.Code).ToString(), });
            }
            return procedures;
        }

        /// <summary>
        /// Gets list of available observed properties
        /// </summary>
        /// <param name="offering">Offering to get an observed properties for</param>
        /// <returns>List of available observed properties</returns>
        protected virtual Collection<PhenomenonPropertyType> GetOfferingObservedProperties(Offering offering)
        {
            Collection<PhenomenonPropertyType> properties = new Collection<PhenomenonPropertyType>();
            foreach (var property in offering.ObservedProperties)
            {
                properties.Add(new PhenomenonPropertyType { Href = this.UriManager.GetPropertyUri(property.Code).ToString(), });
            }
            return properties;
        }

        /// <summary>
        /// Gets list of avaialble features
        /// </summary>
        /// <param name="offering">Offering to get an avaialble features for</param>
        /// <returns>List of afaialble features</returns>
        protected virtual Collection<ReferenceType> GetOfferingFeatureOfInterest(Offering offering)
        {
            Collection<ReferenceType> features = new Collection<ReferenceType>();
            foreach (var feature in offering.FeaturesOfInterest)
            {
                features.Add(new ReferenceType { Href = this.UriManager.GetFeatureOfInterestUri(feature.Code).ToString(), });
            }
            return features;
        }

        /// <summary>
        /// Gets list of supported response formats
        /// </summary>
        /// <param name="offering">Offering to get a response formats for</param>
        /// <returns>List of supported response formats</returns>
        protected virtual Collection<string> GetOfferingResponseFormats(Offering offering)
        {
            return new Collection<string>()
            {
                "text/xml; subtype=\"om/0.0.0\""
            };
        }

        /// <summary>
        /// Gets list of of supported result models
        /// </summary>
        /// <param name="offering">Offering to get a result models for</param>
        /// <returns>List of of supported result models</returns>
        protected virtual Collection<XmlQualifiedName> GetOfferingResultModels(Offering offering)
        {
            Collection<XmlQualifiedName> resultModes = new Collection<XmlQualifiedName>();
            resultModes.Add(typeof(Renci.Data.Interop.OpenGIS.Om_10.ObservationCollectionType).GetXmlQualifiedName());
            return resultModes;
        }

        /// <summary>
        /// Gets list of supported response modes
        /// </summary>
        /// <param name="offering">Offering to get a response modes for</param>
        /// <returns>List of suported response modes</returns>
        protected virtual Collection<ResponseModeType> GetOfferingResponseModes(Offering offering)
        {
            Collection<ResponseModeType> responseModes = new Collection<ResponseModeType>();

            responseModes.Add(ResponseModeType.Inline);
            responseModes.Add(ResponseModeType.OutOfBand);

            return responseModes;
        }

        #endregion
    }
}
