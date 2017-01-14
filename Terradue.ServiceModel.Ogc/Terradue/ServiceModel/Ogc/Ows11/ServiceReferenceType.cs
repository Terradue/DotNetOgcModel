namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceReference", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ServiceReferenceType : ReferenceType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestMessage", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("RequestMessageReference", typeof(string), DataType = "anyURI")]
        public object RequestMessage { get; set; }
    }
}
