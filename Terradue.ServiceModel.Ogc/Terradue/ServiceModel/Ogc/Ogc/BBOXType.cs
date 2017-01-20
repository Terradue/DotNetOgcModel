using Terradue.ServiceModel.Ogc.Gml311;
namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("BBOX", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class BBOXType : SpatialOpsType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyName")]
        public PropertyNameType PropertyName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Envelope", Namespace = "http://www.opengis.net/gml")]
        public EnvelopeType Envelope { get; set; }
    }
}
