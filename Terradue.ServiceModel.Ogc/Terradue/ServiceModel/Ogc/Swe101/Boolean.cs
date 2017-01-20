namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Boolean", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class Boolean : AbstractDataComponentType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quality")]
        public QualityPropertyType Quality { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public bool Value { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("referenceFrame", DataType = "anyURI")]
        public string ReferenceFrame { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("axisID", DataType = "token")]
        public string AxisId { get; set; }
    }
}
