namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ContactInfo", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ContactType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Phone")]
        public TelephoneType Phone
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address")]
        public AddressType Address
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OnlineResource")]
        public OnlineResourceType OnlineResource
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HoursOfService")]
        public string HoursOfService
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactInstructions")]
        public string ContactInstructions
        {
            get;
            set;
        }
    }
}
