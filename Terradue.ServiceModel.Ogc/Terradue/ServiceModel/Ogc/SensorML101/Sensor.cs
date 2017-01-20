using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("SensorML", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Sensor
    {
        /// <remarks/>
        public Sensor()
        {
            this.Version = "1.0.1";

            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add("gml", "http://www.opengis.net/gml");
            this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            this.Xmlns.Add("swe", "http://www.opengis.net/swe/1.0.1");
            this.Xmlns.Add("om", "http://www.opengis.net/om/1.0");
            this.Xmlns.Add("sos", "http://www.opengis.net/sos/1.0");
            this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("ogc", "http://www.opengis.net/ogc");
            this.Xmlns.Add("tml", "http://www.opengis.net/tml");
            this.Xmlns.Add("sml", "http://www.opengis.net/sensorML/1.0.1");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        private Collection<Keywords> _keywords = new Collection<Keywords>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywords")]
        public Collection<Keywords> Keywords
        {
            get
            {
                return this._keywords;
            }
        }

        private Collection<Identification> _identifications = new Collection<Identification>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("identification")]
        public Collection<Identification> Identifications
        {
            get
            {
                return this._identifications;
            }
        }

        private Collection<Classification> _classifications = new Collection<Classification>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classification")]
        public Collection<Classification> Classifications
        {
            get
            {
                return this._classifications;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validTime")]
        public ValidTime ValidTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("securityConstraint")]
        public SecurityConstraint SecurityConstraint { get; set; }

        private Collection<LegalConstraint> _legalConstraints = new Collection<LegalConstraint>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("legalConstraint")]
        public Collection<LegalConstraint> LegalConstraints
        {
            get
            {
                return this._legalConstraints;
            }
        }

        private Collection<Characteristics> _characteristics = new Collection<Characteristics>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("characteristics")]
        public Collection<Characteristics> Characteristics
        {
            get
            {
                return this._characteristics;
            }
        }

        private Collection<Capabilities> _capabilities = new Collection<Capabilities>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("capabilities")]
        public Collection<Capabilities> Capabilities
        {
            get
            {
                return this._capabilities;
            }
        }

        private Collection<Contact> contacts = new Collection<Contact>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public Collection<Contact> Contacts
        {
            get
            {
                return this.contacts;
            }
        }

        private Collection<Documentation> _documentations = new Collection<Documentation>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public Collection<Documentation> Documentations
        {
            get
            {
                return this._documentations;
            }
        }

        private Collection<History> _histories = new Collection<History>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("history")]
        public Collection<History> Histories
        {
            get
            {
                return this._histories;
            }
        }

        private Collection<SensorMember> _members = new Collection<SensorMember>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public Collection<SensorMember> Members
        {
            get
            {
                return this._members;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("version", DataType = "token")]
        public string Version { get; set; }
    }
}
