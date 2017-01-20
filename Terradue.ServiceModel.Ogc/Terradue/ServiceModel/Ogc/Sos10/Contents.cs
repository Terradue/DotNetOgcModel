using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies data and functions that the SOS server provides.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("Contents", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class Contents
    {
        /// <summary>
        /// Creates a default instance of <see cref="Contents"/>.
        /// </summary>
        public Contents()
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

        private Collection<ObservationOfferingType> _observationOfferings = new Collection<ObservationOfferingType>();
        /// <summary>
        /// Gets or sets list of observation offerings
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObservationOffering", IsNullable = false)]
        [System.Xml.Serialization.XmlArray("ObservationOfferingList")]
        public Collection<ObservationOfferingType> ObservationOfferings
        {
            get
            {
                return this._observationOfferings;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
    }
}
