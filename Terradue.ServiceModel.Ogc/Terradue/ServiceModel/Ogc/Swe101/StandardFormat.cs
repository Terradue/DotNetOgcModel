namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("StandardFormat", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class StandardFormat : AbstractEncodingType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("mimeType", DataType = "token")]
        public string MimeType
        {
            get;
            set;
        }
    }
}
