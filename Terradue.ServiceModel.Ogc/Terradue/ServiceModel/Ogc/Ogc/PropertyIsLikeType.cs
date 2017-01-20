namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsLike", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class PropertyIsLikeType : ComparisonOpsType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyName")]
        public PropertyNameType PropertyName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Literal")]
        public LiteralType Literal { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("wildCard")]
        public string WildCard { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("singleChar")]
        public string SingleChar { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("escapeChar")]
        public string EscapeChar { get; set; }
    }
}
