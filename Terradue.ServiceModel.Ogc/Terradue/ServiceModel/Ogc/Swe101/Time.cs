namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Time", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class Time : AbstractDataComponentType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("uom")]
        public UomPropertyType Uom
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("constraint")]
        public AllowedTimesPropertyType Constraint
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quality")]
        public QualityPropertyType Quality
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public string Value
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("referenceTime")]
        public string ReferenceTime
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("referenceFrame", DataType = "anyURI")]
        public string ReferenceFrame
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("localFrame", DataType = "anyURI")]
        public string LocalFrame
        {
            get;
            set;
        }
    }
}
