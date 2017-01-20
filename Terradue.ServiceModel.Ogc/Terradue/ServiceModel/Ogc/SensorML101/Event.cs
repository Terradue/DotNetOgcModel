using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Swe10;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Event", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Event
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("date")]
        public string Date { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description", Namespace = "http://www.opengis.net/gml")]
        public StringOrRefType Description { get; set; }

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

        private Collection<Contact> _contacts = new Collection<Contact>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public Collection<Contact> Contacts
        {
            get
            {
                return this._contacts;
            }
        }

        private Collection<Documentation> _documentation = new Collection<Documentation>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public Collection<Documentation> Documentation
        {
            get
            {
                return this._documentation;
            }
        }

        private Collection<DataComponentPropertyType> _properties = new Collection<DataComponentPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public Collection<DataComponentPropertyType> Properties
        {
            get
            {
                return this._properties;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml", DataType = "ID")]
        public string Id { get; set; }
    }
}
