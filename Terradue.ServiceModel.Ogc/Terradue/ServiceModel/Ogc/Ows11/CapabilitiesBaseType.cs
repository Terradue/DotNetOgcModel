namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class CapabilitiesBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceIdentification", Namespace = "http://www.opengis.net/ows/1.1")]
        public ServiceIdentification ServiceIdentification
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProvider", Namespace = "http://www.opengis.net/ows/1.1")]
        public ServiceProvider ServiceProvider
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsMetadata", Namespace = "http://www.opengis.net/ows/1.1")]
        public OperationsMetadata OperationsMetadata
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "version")]
        public string Version
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "updateSequence")]
        public string UpdateSequence
        {
            get;
            set;
        }
    }
}
