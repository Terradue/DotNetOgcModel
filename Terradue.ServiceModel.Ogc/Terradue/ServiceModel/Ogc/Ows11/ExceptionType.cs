namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Exception", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ExceptionType
    {
        /// <summary>
        /// Text describing specific exception represented by the <see cref="ExceptionCode"/>.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("exceptionText")]
        public string ExceptionText { get; set; }

        /// <summary>
        /// Code representing type of this exception.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("exceptionCode")]
        public ExceptionCode ExceptionCode { get; set; }

        /// <summary>
        /// Indicator of location in the client's operation request where this exception was encountered.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("locator")]
        public string Locator { get; set; }
    }
}
