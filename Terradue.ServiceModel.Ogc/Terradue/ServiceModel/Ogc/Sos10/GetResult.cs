using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetResult", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class GetResult : RequestBaseType
    {
        /// <remarks/>
        public GetResult()
        {
            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add(string.Empty, "http://www.opengis.net/sos/1.0");
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObservationTemplateId", DataType = "anyURI")]
        public string ObservationTemplateId { get; set; }

        private Collection<EventTime> _eventTime = new Collection<EventTime>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eventTime")]
        public Collection<EventTime> EventTime
        {
            get
            {
                return this._eventTime;
            }
        }
    }
}
