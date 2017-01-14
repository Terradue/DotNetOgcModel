namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ValuesReference", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ValuesReference
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("reference", Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
        public string Reference
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
