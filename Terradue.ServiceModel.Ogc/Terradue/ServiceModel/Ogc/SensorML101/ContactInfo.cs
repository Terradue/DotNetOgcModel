using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("contactInfo", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class ContactInfo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public ContactInfoPhone Phone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address")]
        public ContactInfoAddress Address { get; set; }

        private Collection<OnlineResource> _onlineResource = new Collection<OnlineResource>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("onlineResource")]
        public Collection<OnlineResource> OnlineResource
        {
            get
            {
                return this._onlineResource;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hoursOfService")]
        public string HoursOfService { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contactInstructions")]
        public string ContactInstructions { get; set; }
    }
}
