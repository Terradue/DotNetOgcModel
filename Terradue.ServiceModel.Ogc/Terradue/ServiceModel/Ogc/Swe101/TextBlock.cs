namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("TextBlock", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class TextBlock : AbstractEncodingType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tokenSeparator")]
        public string TokenSeparator
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("blockSeparator")]
        public string BlockSeparator
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("decimalSeparator", DataType = "token")]
        public string DecimalSeparator
        {
            get;
            set;
        }
    }
}
