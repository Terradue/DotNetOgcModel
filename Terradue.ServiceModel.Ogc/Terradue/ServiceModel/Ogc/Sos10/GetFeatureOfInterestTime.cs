using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies a request to perform an operation to request the time that specified target feature instances or target locations are available.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeatureOfInterestTime", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class GetFeatureOfInterestTime : RequestBaseType
    {
        /// <summary>
        /// Creates a default instance of <see cref="GetFeatureOfInterestTime"/>.
        /// </summary>
        public GetFeatureOfInterestTime()
        {
            Init();
        }

        /// <summary>
        /// Creates an instance of <see cref="GetFeatureOfInterestTime"/>.
        /// </summary>
        /// <param name="queryParameters">Object initial parameters.</param>
        public GetFeatureOfInterestTime(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            Init();
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <summary>
        /// Gets or sets an identifier of the feature of interest, for which detailed information is requested.
        /// </summary>
        /// <remarks>These identifiers are usually listed in the Contents section of the service metadata (Capabilities) document.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FeatureOfInterestId", DataType = "anyURI")]
        public string FeatureOfInterestId { get; set; }

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
