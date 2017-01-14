namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Title", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class LanguageStringType
    {
        /// <remarks/>
        public LanguageStringType()
        {
            this.Language = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("lang", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        [System.ComponentModel.DefaultValueAttribute("en")]
        public string Language
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get;
            set;
        }
    }
}
