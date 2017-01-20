using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies a request to perform an operation to request target feaure instances.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeatureOfInterest", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class GetFeatureOfInterest : RequestBaseType
    {
        /// <summary>
        /// Creates a default instance of <see cref="GetCapabilities"/>.
        /// </summary>
        public GetFeatureOfInterest()
        {
            Init();
        }

        /// <summary>
        /// Creates an instance of <see cref="GetFeatureOfInterest"/>.
        /// </summary>
        /// <param name="queryParameters">Object initial parameters.</param>
        public GetFeatureOfInterest(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            Init();
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        private Collection<string> _featureOfInterestIds = new Collection<string>();
        /// <summary>
        /// Gets or sets identifiers of the feature of interest for which detailed information is requested.
        /// </summary>
        /// <remarks>These identifiers are usually listed in the Contents section of the service metadata (Capabilities) document.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FeatureOfInterestId", DataType = "anyURI")]
        public Collection<string> FeatureOfInterestIds
        {
            get
            {
                return this._featureOfInterestIds;
            }
        }

        private Collection<GetFeatureOfInterestLocation> _locations = new Collection<GetFeatureOfInterestLocation>();
        /// <summary>
        /// Gets or set a spatial filter expressions for which detailed information is requested.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public Collection<GetFeatureOfInterestLocation> Locations
        {
            get
            {
                return this._locations;
            }
        }

        private Collection<EventTime> _eventTimes = new Collection<EventTime>();
        /// <summary>
        /// Gets or sets a time for which the feature of interest is to be queried.
        /// </summary>
        /// <remarks>This uses a modified version of filter.xsd and allows a client to request targets from a specific instance, multiple instances or periods of time in the past, present and future. This is useful for dynamic sensors for which the properties of the feature of interest are timedependent. Multiple time parameters may be indicated so that the client may request details of the observation target at multiple times. The supported range is listed in the contents section of the service metadata.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("eventTime")]
        public Collection<EventTime> EventTimes
        {
            get
            {
                return this._eventTimes;
            }
        }

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
        }
    }
}
