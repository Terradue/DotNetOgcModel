using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class ContactInfoAddress
    {
        private Collection<string> _deliveryPoints = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deliveryPoint")]
        public Collection<string> DeliveryPoints
        {
            get
            {
                return this._deliveryPoints;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("city")]
        public string City { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("administrativeArea")]
        public string AdministrativeArea { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("postalCode")]
        public string PostalCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("country")]
        public string Country { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("electronicMailAddress")]
        public string ElectronicMailAddress { get; set; }
    }
}
