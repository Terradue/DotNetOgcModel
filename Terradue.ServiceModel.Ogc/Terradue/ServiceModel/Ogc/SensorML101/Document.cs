using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Document", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Document
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description", Namespace = "http://www.opengis.net/gml")]
        public StringOrRefType Description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("date")]
        public string Date { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public Contact Contact { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("format", DataType = "token")]
        public string Format { get; set; }

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
        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml", DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("version", DataType = "token")]
        public string Version { get; set; }
    }
}
