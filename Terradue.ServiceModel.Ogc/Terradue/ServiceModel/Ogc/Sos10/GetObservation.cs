using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Exceptions;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Ogc;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies a request to perform an operation to request sensor data from live sensors as well as sensor data archives.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetObservation", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class GetObservation : RequestBaseType
    {
        /// <summary>
        /// Creates a default instance of <see cref="GetObservation"/>.
        /// </summary>
        public GetObservation()
        {
            Init();
        }

        /// <summary>
        /// Creates an instance of <see cref="GetObservation"/>.
        /// </summary>
        /// <param name="queryParameters">Object initial parameters.</param>
        public GetObservation(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            Init();

            string eventTimes = queryParameters["eventTime"] ?? string.Empty;
            string procedures = queryParameters["procedure"] ?? string.Empty;
            string observedProperties = queryParameters["observedProperty"] ?? string.Empty;
            string featureOfInterest = queryParameters["featureOfInterest"];
            string result = queryParameters["result"];
            string resultModel = queryParameters["resultModel"];
            string responseMode = queryParameters["responseMode"];

            this.SrsName = queryParameters["srsName"];
            this.Offering = queryParameters["offering"];

            if (!string.IsNullOrEmpty(eventTimes))
            {
                foreach (var currentEventTime in eventTimes.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries))
                {
                    EventTime eventTime = new EventTime();

                    string[] times = currentEventTime.Split(new char[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);

                    if (times.Length > 1)
                    {
                        eventTime.TimeType = EventTimeType.During;
                        eventTime.Time = new BinaryTemporalOpType()
                        {
                            Time = new TimePeriodType()
                            {
                                beginPosition = new TimePositionType()
                                {
                                    Value = times[0]
                                },
                                endPosition = new TimePositionType()
                                {
                                    Value = times[1]
                                },
                            }
                        };
                    }
                    else
                    {
                        eventTime.TimeType = EventTimeType.After;
                        eventTime.Time = new BinaryTemporalOpType()
                            {
                                Time = new TimePeriodType()
                                {
                                    beginPosition = new TimePositionType()
                                    {
                                        Value = times[0]
                                    },
                                },
                            };
                    }

                    eventTime.Time.PropertyNames.Add(new PropertyNameType()
                    {
                        Text = "om:samplingTime",
                    });

                    this.EventTimes.Add(eventTime);
                }
            }


            foreach (var procedure in procedures.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries))
            {
                this.Procedures.Add(procedure);
            }

            foreach (var observedProperty in observedProperties.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries))
            {
                this.ObservedProperties.Add(observedProperty);
            }

            if (!string.IsNullOrEmpty(featureOfInterest))
            {
                this.FeatureOfInterest = new GetObservationFeatureOfInterest
                {
                    ObjectId = featureOfInterest,
                };
            }

            if (!string.IsNullOrEmpty(result))
            {
                //  This parameter is ignored for now when provided in URI
            }

            this.ResponseFormat = queryParameters["responseFormat"];

            if (!string.IsNullOrEmpty(resultModel))
            {
                //  This parameter is ignored for now when provided in URI
            }

            if (!string.IsNullOrEmpty(responseMode))
            {
                this.ResponseMode = responseMode.ParseEnum<ResponseModeType>();
            }

            //  Proccess additional parameters
            this.ObservationID = queryParameters["observationId"];

            DateTime date;
            if (DateTime.TryParseExact(queryParameters["beginDate"], "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                this.SampleBeginDate = date;
            }

            if (DateTime.TryParseExact(queryParameters["endDate"], "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                this.SampleEndDate = date;
            }

        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <summary>
        /// Gets or sets an offering URI advertised in the GetCapabilities document.
        /// </summary>
        /// <remarks>This must match the gml:name of the offering or be constructed as a URL with a fragment identifier resolving to the offering gml:id. All of the following parameters are dependent on the selected offering.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("offering", DataType = "anyURI")]
        public string Offering { get; set; }

        private Collection<EventTime> _eventTimes = new Collection<EventTime>();
        /// <summary>
        /// Gets or sets the time period(s) for which observations are requested. 
        /// </summary>
        /// <remarks>
        /// This allows a client to request observations from a specific instant, multiple instances or periods of time in the past, present and future. The supported range is listed in the selected offering capabilities.
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute("eventTime")]
        public Collection<EventTime> EventTimes
        {
            get
            {
                return this._eventTimes;
            }
        }

        private Collection<string> _procedures = new Collection<string>();
        /// <summary>
        /// Gets or sets the sensor system(s) for which observations are requested.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("procedure", DataType = "anyURI")]
        public Collection<string> Procedures
        {
            get
            {
                return this._procedures;
            }
        }

        private Collection<string> _observedProperties = new Collection<string>();
        /// <summary>
        /// Gets or sets the phenomenon for which observations are requested.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("observedProperty", DataType = "anyURI")]
        public Collection<string> ObservedProperties
        {
            get
            {
                return this._observedProperties;
            }
        }

        /// <summary>
        /// Gets or sets the feature for which observations are requested. 
        /// </summary>
        /// <remarks>This can either be represented by a reference to a feature ID advertised in the capabilities document or can be a spatial constraint.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterest")]
        public GetObservationFeatureOfInterest FeatureOfInterest { get; set; }

        /// <summary>
        /// Gets or sets an OGC filter expressions based on property values.
        /// </summary>
        /// <remarks>This instructs the SOS to only return observations where the result matches this expression.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("result")]
        public GetObservationResult Result { get; set; }

        /// <summary>
        /// Gets or sets the desired resultFormat MIME content type for transport of the results (e.g. TML, O&amp;M native format, or MPEG stream out-of-band). 
        /// </summary>
        /// <remarks>The supported output formats are listed in the selected offering capabilities.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("responseFormat")]
        public string ResponseFormat { get; set; }

        /// <summary>
        /// Gets or sets the QName of the root element of an O&amp;M Observation or element in the appropriate substitution group.
        /// </summary>
        /// <remarks>The resultModels supported by a SOS server are listed in the resultModel elements of the offerings in the service capabilities.</remarks>
        /// <exception cref="OptionNotSupportedException">The requested resultModel is not supported by the SOS server</exception>
        [System.Xml.Serialization.XmlElementAttribute("resultModel")]
        public System.Xml.XmlQualifiedName ResultModel { get; set; }

        /// <summary>
        /// Gets or sets resposne mode.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("responseMode")]
        public ResponseModeType ResponseMode { get; set; }

        /// <summary>
        /// Gets or sets whether <see cref="ResponseMode"/> property is specified.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResponseModeSpecified { get; set; }

        /// <summary>
        /// Gets or sets the spatial reference system that should be used for any geometries that are returned in the response. 
        /// </summary>
        /// <remarks>This must be one of the advertised values in the offering specified in gml:srsName elements.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("srsName", DataType = "anyURI")]
        public string SrsName { get; set; }

        #region Additional parameters

        /// <summary>
        /// Gets or sets observation ID
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public string ObservationID { get; set; }

        /// <summary>
        /// Gets or sets begin date of observation specified by <see cref="ObservationID"/> property.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public DateTime? SampleBeginDate { get; set; }

        /// <summary>
        /// Gets or sets end date of observation specified by <see cref="ObservationID"/> property.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public DateTime? SampleEndDate { get; set; }

        #endregion

        /// <summary>
        /// Perfoms object initialization tasks
        /// </summary>
        private void Init()
        {
            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add(string.Empty, "http://www.opengis.net/sos/1.0");
            this.Xmlns.Add("gml", "http://www.opengis.net/gml");
            this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            this.Xmlns.Add("swe", "http://www.opengis.net/swe/1.0.1");
            this.Xmlns.Add("om", "http://www.opengis.net/om/1.0");
            this.Xmlns.Add("sos", "http://www.opengis.net/sos/1.0");
            this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("ogc", "http://www.opengis.net/ogc");
            this.Xmlns.Add("tml", "http://www.opengis.net/tml");
            this.Xmlns.Add("sml", "http://www.opengis.net/sensorML/1.0.1");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (string.IsNullOrEmpty(this.ObservationID))
            {
                if (string.IsNullOrEmpty(this.Offering))
                    throw new MissingParameterValueException("offering");

                if (string.IsNullOrEmpty(this.ResponseFormat))
                    throw new MissingParameterValueException("responseFormat");

                if (this.ObservedProperties.Count < 1)
                    throw new MissingParameterValueException("observedProperty");
            }
            else
            {
                if (this.SampleBeginDate == null)
                    throw new MissingParameterValueException("beginDate");

                if (this.SampleEndDate == null)
                    throw new MissingParameterValueException("endDate");
            }
        }
    }
}
