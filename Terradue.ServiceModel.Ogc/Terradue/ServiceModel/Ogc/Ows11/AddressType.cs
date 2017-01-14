using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class AddressType
    {
        /// <summary>
        /// Default constructor required for serialization
        /// </summary>
        public AddressType()
        {

        }

        /// <remarks/>
        public AddressType(string deliveryPoint, string city, string postalCode, string country, string email, string administrativeArea)
        {
            this.DeliveryPoints.Add(deliveryPoint);
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
            this.Emails.Add(email);
            this.AdministrativeArea = administrativeArea;
        }

        private Collection<string> _deliveryPoints = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryPoint")]
        public Collection<string> DeliveryPoints
        {
            get
            {
                return this._deliveryPoints;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("City")]
        public string City
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdministrativeArea")]
        public string AdministrativeArea
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostalCode")]
        public string PostalCode
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Country")]
        public string Country
        {
            get;
            set;
        }

        private Collection<string> _emails = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicMailAddress")]
        public Collection<string> Emails
        {
            get
            {
                return this._emails;
            }
        }
    }
}
