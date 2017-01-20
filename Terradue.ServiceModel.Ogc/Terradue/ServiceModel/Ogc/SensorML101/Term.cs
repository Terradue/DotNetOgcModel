using Terradue.ServiceModel.Ogc.Swe10;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Term", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Term
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("codeSpace")]
        public CodeSpacePropertyType codeSpace { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value", DataType = "token")]
        public string Value { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("definition", DataType = "anyURI")]
        public string Definition { get; set; }
    }
}
