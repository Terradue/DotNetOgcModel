using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Threading;
using Terradue.ServiceModel.Ogc.WebService.Common;
using Terradue.ServiceModel.Ogc.WebService.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Represents a sample GetObservation request handler
    /// </summary>
    public class GetObservationOperation : BaseSosOperation
    {
        /// <summary>
        /// This delegates used to point ProccessRequest method to an appropriate method to handle the request based on incoming parameters.
        /// </summary>
        /// <param name="observation"></param>
        /// <param name="responseMode"></param>
        /// <param name="samplingBeginDate"></param>
        /// <param name="samplingEndDate"></param>
        /// <param name="offering"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        private delegate ObservationPropertyType GetObservationDelegate(Observation observation, ResponseModeType responseMode, DateTime samplingBeginDate, DateTime samplingEndDate, string offering, BaseObservationFormatter formatter);

        /// <summary>
        /// Gets observation values query
        /// </summary>
        /// <param name="data"></param>
        /// <param name="observationCode"></param>
        /// <returns></returns>
        private IQueryable<ObservationValue> GetObservationValuesQuery(SosEntities data, string observationCode)
        {
            //  This parameter used internally and therfor no transformation is required.
            var code = observationCode;

            var result = from ov in data.ObservationValues.Include("Observation")
                         where
                            ov.Observation.Code == code
                         select ov;

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result;
        }

        /// <summary>
        /// Gets observation values query
        /// </summary>
        /// <param name="data"></param>
        /// <param name="observationCode"></param>
        /// <param name="whereClauses"></param>
        /// <returns></returns>
        private IQueryable<ObservationValue> GetObservationValuesQuery(SosEntities data, string observationCode, List<Expression<Func<ObservationValue, bool>>> whereClauses)
        {
            //  This parameter used internally and therfor no transformation is required.
            var code = observationCode;

            var result = from ov in data.ObservationValues.Include("Observation")
                         where
                            ov.Observation.Code == code
                         select ov;

            //  Apply Where clauses
            if (whereClauses != null)
            {
                foreach (var whereClause in whereClauses)
                {
                    result = result.Where(whereClause);
                }
            }

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result;
        }

        /// <summary>
        /// Gets observation values query
        /// </summary>
        /// <param name="data"></param>
        /// <param name="observationCode"></param>
        /// <param name="samplingBeginDate"></param>
        /// <param name="samplingEndDate"></param>
        /// <returns></returns>
        private IQueryable<ObservationValue> GetObservationValuesQuery(SosEntities data, string observationCode, DateTime samplingBeginDate, DateTime samplingEndDate)
        {
            //  This parameter used internally and therfor no transformation is required.
            var code = observationCode;

            var result = from ov in data.ObservationValues.Include("Observation")
                         where
                            ov.Observation.Code == code &&
                            ov.Time >= samplingBeginDate &&
                            ov.Time <= samplingEndDate
                         select ov;

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result;
        }

        /// <summary>
        /// Gets observation query
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="observationCode">The observation code.</param>
        /// <returns></returns>
        private static Observation GetObservationQuery(SosEntities data, string observationCode)
        {
            //  This parameter used internally and therfor no transformation is required.
            var code = observationCode;

            var result = from sc in data.Observations.Include("Sensor").Include("ObservedProperty").Include("Offering").Include("FeatureOfInterest")
                         where sc.Code == code
                         select sc;

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result.FirstOrDefault();
        }

        /// <summary>
        /// Gets observations query
        /// </summary>
        /// <param name="data"></param>
        /// <param name="whereClauses"></param>
        /// <returns></returns>
        private static IQueryable<Observation> GetObservationsQuery(SosEntities data, ReadOnlyCollection<Expression<Func<Observation, bool>>> whereClauses)
        {
            var result = from sc in data.Observations.Include("Sensor").Include("ObservedProperty").Include("Offering").Include("FeatureOfInterest")
                         select sc;

            //  Apply Where clauses
            if (whereClauses != null)
            {
                foreach (var whereClause in whereClauses)
                {
                    result = result.Where(whereClause);
                }
            }

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObservationOperation"/> class.
        /// </summary>
        /// <param name="configuration">Operation configuration.</param>
        public GetObservationOperation(ServiceOperationElement configuration)
            : base(configuration)
        {
        }

        private IDictionary<System.Net.Mime.ContentType, BaseObservationFormatter> _responseFormatHandlers;

        /// <summary>
        /// Gets the response format handlers.
        /// </summary>
        /// <value>The response format handlers.</value>
        public IDictionary<System.Net.Mime.ContentType, BaseObservationFormatter> ResponseFormatHandlers
        {
            get
            {
                if (_responseFormatHandlers == null)
                {
                    _responseFormatHandlers = new Dictionary<ContentType, BaseObservationFormatter>();
                    foreach (var responseFormatter in this.Configuration.ServiceConfiguration.ResponseFormatters)
                    {
                        var type = Type.GetType(responseFormatter.HandlerType);
                        
                        if (type == null)
                        {
                            throw new ConfigurationErrorsException(string.Format(CultureInfo.InvariantCulture, "Formatter type '{0}' is invalid or not found.", responseFormatter.HandlerType));
                        }

                        _responseFormatHandlers.Add(new ContentType(responseFormatter.ContentType), Activator.CreateInstance(type, new object[] { this }) as BaseObservationFormatter);
                    }
                }
                return _responseFormatHandlers.ToReadOnly();
            }
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
                    Name = "eventTime",
                    AnyValue = new AnyValue(),
                    Meaning = new DomainMetadataType
                    {
                        Value = "Valid event time. For example: 2008-11-06T18:50:00Z or to specify range 2009-01-01/2009-02-01",
                    }
                });
                parameters.Add(new DomainType()
                {
                    Name = "procedure",
                    AllowedValues = new Collection<object>(),
                });

                DomainType parameter = parameters[parameters.Count - 1];

                foreach (var sensorName in this.UrnManager.SensorNames)
                {
                    parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(this.UrnManager.GetSensorUrn(sensorName).ToString()));
                }

                parameters.Add(new DomainType()
                {
                    Name = "responseFormat",
                    AllowedValues = new Collection<object>(),
                });

                parameter = parameters[parameters.Count - 1];

                foreach (var code in this.ResponseFormatHandlers.Keys)
                {
                    parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(code.ToString()));
                }

                parameters.Add(new DomainType()
                {
                    Name = "observedProperty",
                    AllowedValues = new Collection<object>(),
                });

                parameter = parameters[parameters.Count - 1];

                foreach (var observedProperty in this.UrnManager.ObservedPropertyNames)
                {
                    parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(this.UrnManager.GetPropertyUrn(observedProperty).ToString()));
                }

                parameters.Add(new DomainType()
                {
                    Name = "featureOfInterest",
                    AllowedValues = new Collection<object>(),
                });

                parameter = parameters[parameters.Count - 1];

                foreach (var featureOfInterest in this.UrnManager.FeatureOfInterestNames)
                {
                    parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(this.UrnManager.GetFeatureOfInterestUrn(featureOfInterest).ToString()));
                }

                parameters.Add(new DomainType()
                {
                    Name = "result",
                    NoValues = new NoValues(),
                    Meaning = new DomainMetadataType
                    {
                        Value = "Currently not supported",
                    }
                });

                //  TODO:   Check why Qulified name usses full name and not prefix
                parameters.Add(new DomainType()
                {
                    Name = "resultModel",
                    AllowedValues = new Collection<object>()
                    {
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(typeof(ObservationCollectionType).GetXmlQualifiedName().ToString())
                    },
                });
                parameters.Add(new DomainType()
                {
                    Name = "responseMode",
                    AllowedValues = new Collection<object>()
                    {
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(ResponseModeType.Inline.ToStringValue()),
                        new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(ResponseModeType.OutOfBand.ToStringValue()),
                    }
                });
                parameters.Add(new DomainType()
                {
                    Name = "srsName",
                    AnyValue = new AnyValue(),
                    Meaning = new DomainMetadataType
                    {
                        Value = "Valid srsName name",
                    }
                });
                parameters.Add(new DomainType()
                {
                    Name = "offering",
                    AnyValue = new AnyValue(),
                    Meaning = new DomainMetadataType
                    {
                        Value = "Valid offering name",
                    }
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
                    Href = string.Format(CultureInfo.InvariantCulture, "{0}/", this.ServiceBaseUri)
                });
                dcp.Http.GetMethods.Add(new RequestMethodType()
                {
                    Href = string.Format(CultureInfo.InvariantCulture, "{0}/", this.ServiceBaseUri)
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
            get { return typeof(Terradue.ServiceModel.Ogc.Sos10.GetObservation); }
        }

        /// <summary>
        /// Process operation request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Resposne object to be sent back to the client</returns>
        public override OperationResult ProcessRequest(object request)
        {
            Terradue.ServiceModel.Ogc.Sos10.GetObservation gor = request as Terradue.ServiceModel.Ogc.Sos10.GetObservation;

            //  Make sure there is valid request parameter
            if (gor == null)
            {
                throw new NoApplicableCodeException(string.Format(CultureInfo.CurrentCulture, "Type '{0}' is not supported by GetObservation operation.", request.GetType().FullName));
            }

            if (!string.IsNullOrEmpty(gor.ObservationID))
            {
                return new OperationResult()
                {
                    ResultObject = this.GetOutOfBandData(gor.ObservationID, gor.SampleBeginDate.Value, gor.SampleEndDate.Value),
                    OutputFormat = OutputFormat.TextCsv,
                };
            }

            List<Expression<Func<Observation, bool>>> observationsWhereClauses = new List<Expression<Func<Observation, bool>>>();
            List<List<Expression<Func<ObservationValue, bool>>>> dataValueWhereClausesGroup = new List<List<Expression<Func<ObservationValue, bool>>>>();

            #region Handle result parameter

            if (gor.Result != null)
            {
                throw new OptionNotSupportedException("result");
            }

            #endregion

            #region Handle offering parameter

            observationsWhereClauses.Add(c => c.Offering.Name == gor.Offering);

            #endregion

            #region Handle srsName parameter

            if (!string.IsNullOrEmpty(gor.SrsName))
            {
                observationsWhereClauses.Add(item => item.SrsName == gor.SrsName);
            }

            #endregion

            #region Handle observedProperty parameter

            var observedProperties = from p in gor.ObservedProperties select this.UrnManager.GetUrnValue(new Uri(p));

            observationsWhereClauses.Add((BuildContainsExpression<Observation, string>(item => item.ObservedProperty.Code, observedProperties.ToList())));

            #endregion

            #region Handle procedure parameter

            if (gor.Procedures.Count > 0)
            {
                var procedures = from p in gor.Procedures select this.UrnManager.GetUrnValue(new Uri(p));
                observationsWhereClauses.Add((BuildContainsExpression<Observation, string>(item => item.Sensor.Code, procedures.ToList())));
            }

            #endregion

            #region Handle featureOfInterest parameter

            if (gor.FeatureOfInterest != null)
            {
                if (gor.FeatureOfInterest.ObjectId != null)
                {
                    var featureOfInterest = this.UrnManager.GetUrnValue(new Uri(gor.FeatureOfInterest.ObjectId));

                    observationsWhereClauses.Add(item => item.FeatureOfInterest.Code == featureOfInterest);
                }
                else if (gor.FeatureOfInterest.SpatialOperators != null)
                {
                    throw new OptionNotSupportedException("spatialOps");
                }
            }

            #endregion

            #region Handle eventTime parameter
            if (gor.EventTimes.Count > 0)
            {
                foreach (var eventTime in gor.EventTimes)
                {
                    List<Expression<Func<ObservationValue, bool>>> dataValueWhereClauses = new List<Expression<Func<ObservationValue, bool>>>();

                    //  Must have only one property which has value "om:samplingTime"
                    if (eventTime.Time.PropertyNames.Count != 1 && !eventTime.Time.PropertyNames[0].Text.EndsWith("samplingTime", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    switch (eventTime.TimeType)
                    {
                        case EventTimeType.During:
                            if (eventTime.Time.GetTime<Renci.Data.Interop.OpenGIS.Gml.TimePeriodType>() != null)
                            {
                                //  Get begin time
                                Renci.Data.Interop.OpenGIS.Gml.TimePositionType timePosition = eventTime.Time.GetTime<Renci.Data.Interop.OpenGIS.Gml.TimePeriodType>().GetBeginTime<Renci.Data.Interop.OpenGIS.Gml.TimePositionType>();
                                if (timePosition != null)
                                {
                                    DateTime dt;
                                    if (timePosition.IndeterminatePositionSpecified && timePosition.IndeterminatePosition == Renci.Data.Interop.OpenGIS.Gml.TimeIndeterminateValueType.Now)
                                    {
                                        dt = DateTime.Now.ToUniversalTime();
                                    }
                                    else
                                    {
                                        dt = DateTime.Parse(timePosition.Value, CultureInfo.CurrentCulture);
                                    }

                                    dataValueWhereClauses.Add(sc => sc.Time > dt);
                                }

                                //  Get end time
                                timePosition = eventTime.Time.GetTime<Renci.Data.Interop.OpenGIS.Gml.TimePeriodType>().GetEndTime<Renci.Data.Interop.OpenGIS.Gml.TimePositionType>();
                                if (timePosition != null)
                                {
                                    DateTime dt;
                                    if (timePosition.IndeterminatePositionSpecified && timePosition.IndeterminatePosition == Renci.Data.Interop.OpenGIS.Gml.TimeIndeterminateValueType.Now)
                                    {
                                        dt = DateTime.Now.ToUniversalTime();
                                    }
                                    else
                                    {
                                        dt = DateTime.Parse(timePosition.Value, CultureInfo.CurrentCulture);
                                    }

                                    dataValueWhereClauses.Add(sc => sc.Time < dt);
                                }
                            }
                            else
                            {
                                throw new OptionNotSupportedException(eventTime.Time.Time.GetType().Name);
                            }

                            break;
                        case EventTimeType.After:
                            if (eventTime.Time.GetTime<Renci.Data.Interop.OpenGIS.Gml.TimePeriodType>() != null)
                            {
                                //  Get begin time
                                Renci.Data.Interop.OpenGIS.Gml.TimePositionType timePosition = eventTime.Time.GetTime<Renci.Data.Interop.OpenGIS.Gml.TimePeriodType>().GetBeginTime<Renci.Data.Interop.OpenGIS.Gml.TimePositionType>();
                                if (timePosition != null)
                                {
                                    DateTime dt;
                                    if (timePosition.IndeterminatePositionSpecified && timePosition.IndeterminatePosition == Renci.Data.Interop.OpenGIS.Gml.TimeIndeterminateValueType.Now)
                                    {
                                        dt = DateTime.Now.ToUniversalTime();
                                    }
                                    else
                                    {
                                        dt = DateTime.Parse(timePosition.Value, CultureInfo.CurrentCulture);
                                    }

                                    dataValueWhereClauses.Add(sc => sc.Time > dt);
                                }
                            }
                            else
                            {
                                throw new OptionNotSupportedException(eventTime.Time.Time.GetType().Name);
                            }

                            break;
                        case EventTimeType.Before:
                            if (eventTime.Time.GetTime<Renci.Data.Interop.OpenGIS.Gml.TimePeriodType>() != null)
                            {
                                //  Get end time
                                Renci.Data.Interop.OpenGIS.Gml.TimePositionType timePosition = eventTime.Time.GetTime<Renci.Data.Interop.OpenGIS.Gml.TimePeriodType>().GetEndTime<Renci.Data.Interop.OpenGIS.Gml.TimePositionType>();
                                if (timePosition != null)
                                {
                                    DateTime dt;
                                    if (timePosition.IndeterminatePositionSpecified && timePosition.IndeterminatePosition == Renci.Data.Interop.OpenGIS.Gml.TimeIndeterminateValueType.Now)
                                    {
                                        dt = DateTime.Now.ToUniversalTime();
                                    }
                                    else
                                    {
                                        dt = DateTime.Parse(timePosition.Value, CultureInfo.CurrentCulture);
                                    }

                                    dataValueWhereClauses.Add(sc => sc.Time < dt);
                                }
                            }
                            else
                            {
                                throw new OptionNotSupportedException(eventTime.Time.Time.GetType().Name);
                            }

                            break;
                        default:
                            throw new OptionNotSupportedException(eventTime.Time.Time.GetType().Name);
                    }

                    dataValueWhereClausesGroup.Add(dataValueWhereClauses);
                }
            }
            else
            {
                List<Expression<Func<ObservationValue, bool>>> dataValueWhereClauses = new List<Expression<Func<ObservationValue, bool>>>();

                dataValueWhereClauses.Add(sc => sc.Time == sc.Observation.EndTime);

                dataValueWhereClausesGroup.Add(dataValueWhereClauses);
            }

            #endregion

            BaseObservationFormatter formatter = null;

            var responseFormatType = new ContentType(gor.ResponseFormat);
            if (this.ResponseFormatHandlers.ContainsKey(responseFormatType))
            {
                formatter = this.ResponseFormatHandlers[responseFormatType];
            }
            else
            {
                throw new InvalidParameterValueException("responseFormat", gor.ResponseFormat);
            }

            if (formatter == null)
            {
                throw new ConfigurationErrorsException("Response format handler is not set.");
            }

            object result = null;

            if (gor.ResultModel == null || gor.ResultModel == typeof(ObservationCollectionType).GetXmlQualifiedName())
            {
                //  This is default result model
                result = this.GetObservationCollection(observationsWhereClauses.AsReadOnly(), dataValueWhereClausesGroup.AsReadOnly(), gor.ResponseMode, gor.Offering, formatter);
            }
            else
            {
                throw new OptionNotSupportedException(gor.ResultModel.ToString());
            }

            return new OperationResult()
            {
                ResultObject = result,
                OutputFormat = formatter.OutputFormat,
            };
        }

        #endregion

        /// <summary>
        /// Gets collection of observations
        /// </summary>
        /// <param name="observationsWhereClauses">The observations where clauses.</param>
        /// <param name="dataValueWhereClausesGroup">The data value where clauses group.</param>
        /// <param name="responseMode">The response mode.</param>
        /// <param name="offering">The offering.</param>
        /// <param name="formatter">The formatter.</param>
        /// <returns></returns>
        protected virtual ObservationCollectionType GetObservationCollection(ReadOnlyCollection<Expression<Func<Observation, bool>>> observationsWhereClauses, ReadOnlyCollection<List<Expression<Func<ObservationValue, bool>>>> dataValueWhereClausesGroup, ResponseModeType responseMode, string offering, BaseObservationFormatter formatter)
        {
            GetObservationDelegate getObservation = new GetObservationDelegate(this.GetObservation);

            List<WaitHandle> asyncResults = new List<WaitHandle>();

            ObservationCollectionType oc = new ObservationCollectionType();

            using (SosEntities data = this.GetSosEntities())
            {
                //  Create an observation query.
                var observations = GetObservationsQuery(data, observationsWhereClauses);

                foreach (Observation observation in observations)
                {
                    List<ObservationValuesSummary> observationValuesSummary = new List<ObservationValuesSummary>();

                    IQueryable<ObservationValuesSummary> summariesQuery = null;

                    foreach (var dataValueWhereClauses in dataValueWhereClausesGroup)
                    {
                        var observationValues = this.GetObservationValuesQuery(data, observation.Code, dataValueWhereClauses);

                        var summaryQuery = from dv in observationValues
                                           group dv by dv.Observation.Code into g
                                           select new ObservationValuesSummary()
                                           {
                                               ObservationCode = g.Key,
                                               Total = g.Count(),
                                               SamplingBeginDate = g.Min(dv => dv.Time),
                                               SamplingEndDate = g.Max(dv => dv.Time),
                                           };
                        if (summariesQuery == null)
                        {
                            summariesQuery = summaryQuery;
                        }
                        else
                        {
                            summariesQuery = summariesQuery.Union(summaryQuery);
                        }
                    }

                    observationValuesSummary = summariesQuery.ToList();

                    int maxExecutedThreads = 8;
                    foreach (var dataSummary in observationValuesSummary)
                    {
                        //  Make sure we dont execute to many threads
                        if (asyncResults.Count > maxExecutedThreads)
                        {
                            int i = System.Threading.WaitHandle.WaitAny(asyncResults.ToArray());
                            asyncResults.RemoveAt(i);
                        }

                        IAsyncResult asyncResult = getObservation.BeginInvoke(
                            observation,
                            responseMode,
                            dataSummary.SamplingBeginDate,
                            dataSummary.SamplingEndDate,
                            offering,
                            formatter,
                            (ar) =>
                            {
                                ObservationPropertyType obp = getObservation.EndInvoke(ar);

                                oc.Members.Add(obp);
                            },
                            null);

                        asyncResults.Add(asyncResult.AsyncWaitHandle);
                    }
                }
            }

            //  Wait for all threads to finish if any
            if (asyncResults.Count > 0)
            {
                System.Threading.WaitHandle.WaitAll(asyncResults.ToArray());
            }

            //  Clode all handles
            asyncResults.ForEach((handle) => handle.Close());

            return oc;
        }

        /// <summary>
        /// Gets observation
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <param name="responseMode">The response mode.</param>
        /// <param name="samplingBeginDate">The sampling begin date.</param>
        /// <param name="samplingEndDate">The sampling end date.</param>
        /// <param name="offering">The offering.</param>
        /// <param name="formatter">The formatter to use to create the result.</param>
        /// <returns></returns>
        protected virtual ObservationPropertyType GetObservation(Observation observation, ResponseModeType responseMode, DateTime samplingBeginDate, DateTime samplingEndDate, string offering, BaseObservationFormatter formatter)
        {
            ObservationPropertyType obp = new ObservationPropertyType()
            {
                Observation = new ObservationType()
                {
                    Id = this.ObservationNames[observation.Code],
                },
            };

            obp.Observation.Names.Add(new Renci.Data.Interop.OpenGIS.Gml.CodeType(offering));

            obp.Observation.SamplingTime.Time = new Renci.Data.Interop.OpenGIS.Gml.TimePeriodType()
            {
                BeginTime = new Renci.Data.Interop.OpenGIS.Gml.TimePositionType() { Value = samplingBeginDate.ToUnicodeStringValue() },
                EndTime = new Renci.Data.Interop.OpenGIS.Gml.TimePositionType() { Value = samplingEndDate.ToUnicodeStringValue() },
            };

            obp.Observation.Procedure = formatter.GetObservationProcedure(observation);

            obp.Observation.ObservedProperty = formatter.GetObservationProperty(observation);

            obp.Observation.FeatureOfInterest = formatter.GetObservationFeatureOfInterest(observation);

            obp.Observation.Result = formatter.GetObservationResult(observation, responseMode, samplingBeginDate, samplingEndDate);

            return obp;
        }

        /// <summary>
        /// Gets CSV file lines.
        /// </summary>
        /// <param name="observationCode"></param>
        /// <param name="samplingBeginDate"></param>
        /// <param name="samplingEndDate"></param>
        /// <returns></returns>
        protected virtual ReadOnlyCollection<string> GetOutOfBandData(string observationCode, DateTime samplingBeginDate, DateTime samplingEndDate)
        {
            List<string> result = new List<string>();

            using (SosEntities data = this.GetSosEntities())
            {
                var observation = GetObservationQuery(data, observationCode);

                result.Add(string.Format(CultureInfo.InvariantCulture, "Time, {0}", observation.ObservedProperty.Name));

                var dataValues = this.GetObservationValuesQuery(data, observationCode, samplingBeginDate, samplingEndDate);

                foreach (ObservationValue value in dataValues)
                {
                    result.Add(string.Format(CultureInfo.InvariantCulture, "{0},{1}", value.Time, value.Value));
                }
            }
            return result.AsReadOnly();
        }

        /// <summary>
        /// Helper function which used in lambda expressions
        /// </summary>
        /// <typeparam name="TElement">The type of the element.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="valueSelector">The value selector.</param>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        private static Expression<Func<TElement, bool>> BuildContainsExpression<TElement, TValue>(Expression<Func<TElement, TValue>> valueSelector, IEnumerable<TValue> values)
        {
            if (null == valueSelector)
            {
                throw new ArgumentNullException("valueSelector");
            }

            if (null == values)
            {
                throw new ArgumentNullException("values");
            }

            ParameterExpression p = valueSelector.Parameters.Single();

            // p => valueSelector(p) == values[0] || valueSelector(p) == ...
            if (!values.Any())
            {
                return e => false;
            }

            var equals = values.Select(value => (Expression)Expression.Equal(valueSelector.Body, Expression.Constant(value, typeof(TValue))));

            var body = equals.Aggregate<Expression>((accumulate, equal) => Expression.Or(accumulate, equal));

            return Expression.Lambda<Func<TElement, bool>>(body, p);
        }

        #region Helper classes

        private class ObservationValuesSummary
        {
            public string ObservationCode { get; set; }
            public int Total { get; set; }
            public DateTime SamplingBeginDate { get; set; }
            public DateTime SamplingEndDate { get; set; }
        }

        #endregion
    }
}
