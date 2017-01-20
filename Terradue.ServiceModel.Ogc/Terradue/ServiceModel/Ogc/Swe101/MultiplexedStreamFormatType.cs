namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("MultiplexedStreamFormat", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class MultiplexedStreamFormatType : AbstractEncodingType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type", DataType = "anyURI")]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("version")]
        public string Version { get; set; }
    }
}
