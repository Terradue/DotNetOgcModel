using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class PositionsPositionList
    {
        private Collection<object> _items = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("position", Type = typeof(Position))]
        [System.Xml.Serialization.XmlElementAttribute("timePosition", Type = typeof(TimePosition))]
        public Collection<object> Items
        {
            get
            {
                return this._items;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id { get; set; }
    }
}
