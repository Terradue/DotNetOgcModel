namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WGS84BoundingBoxType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("BoundingBox", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class BoundingBoxType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LowerCorner")]
        public string LowerCorner { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UpperCorner")]
        public string UpperCorner { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("crs", DataType = "anyURI")]
        public string Crs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dimensions", DataType = "positiveInteger")]
        public string Dimensions { get; set; }
    }
}
