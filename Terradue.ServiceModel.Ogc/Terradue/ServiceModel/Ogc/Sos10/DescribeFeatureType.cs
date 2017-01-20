using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies a request to perform an operation to request detailed information concerning the observation's target
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeFeatureType", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class DescribeFeatureType : RequestBaseType
    {
        /// <summary>
        /// Creates a default instance of <see cref="DescribeFeatureType"/>
        /// </summary>
        public DescribeFeatureType()
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
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <summary>
        /// Gets or sets identifier of the feature for which detailed information is requested.
        /// </summary>
        /// <remarks>These identifiers are usually listed in the Contents section of the service metadata (Capabilities) document.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("FeatureId", DataType = "anyURI")]
        public string FeatureId { get; set; }
    }
}
