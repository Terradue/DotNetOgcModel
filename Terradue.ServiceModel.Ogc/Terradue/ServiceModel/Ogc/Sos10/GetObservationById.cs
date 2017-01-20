using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies a request to perform the GetObservation operation using an Observation ID.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetObservationById", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class GetObservationById : RequestBaseType
    {
        /// <summary>
        /// Creates a default instance of <see cref="GetObservationById"/>.
        /// </summary>
        public GetObservationById()
        {
            Init();
        }

        /// <summary>
        /// Creates an instance of <see cref="GetObservationById"/>.
        /// </summary>
        /// <param name="queryParameters">Object initial parameters.</param>
        public GetObservationById(System.Collections.Specialized.NameValueCollection queryParameters)
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
        /// Gets or sets an id of the requested observation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ObservationId", DataType = "anyURI")]
        public string ObservationId { get; set; }

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
        /// <exception cref="Terradue.ServiceModel.Ogc.Exceptions.OptionNotSupportedException">The requested resultModel is not supported by the SOS server</exception>
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
