namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public class SortPropertyType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyName")]
        public PropertyNameType PropertyName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SortOrder")]
        public SortOrderType SortOrder { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified { get; set; }
    }
}
