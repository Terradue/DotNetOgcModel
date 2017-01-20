using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ArrayLink", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class ArrayLink
    {
        private Collection<object> _items = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("destinationArray", Type = typeof(ArrayLinkDestinationArray))]
        [System.Xml.Serialization.XmlElementAttribute("destinationIndex", Type = typeof(ArrayLinkDestinationIndex))]
        [System.Xml.Serialization.XmlElementAttribute("sourceArray", Type = typeof(ArrayLinkSourceArray))]
        [System.Xml.Serialization.XmlElementAttribute("sourceIndex", Type = typeof(ArrayLinkSourceIndex))]
        public Collection<object> Items
        {
            get
            {
                return this._items;
            }
        }

        private Collection<Connection> _connections = new Collection<Connection>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connection")]
        public Collection<Connection> Connections
        {
            get
            {
                return this._connections;
            }
        }
    }
}
