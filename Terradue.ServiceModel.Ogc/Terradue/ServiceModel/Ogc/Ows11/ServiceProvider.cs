namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceProvider", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ServiceProvider
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProviderName")]
        public string ProviderName
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProviderSite")]
        public OnlineResourceType ProviderSite
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceContact")]
        public ResponsiblePartySubsetType ServiceContact
        {
            get;
            set;
        }
    }
}
