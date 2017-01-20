using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public abstract class AbstractDerivableProcessType : AbstractProcessType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inputs")]
        public InputsPropertyType Inputs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outputs")]
        public OutputsPropertyType Outputs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameters")]
        public ParametersPropertyType Parameters { get; set; }

        private Collection<object> _items = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("components", Type = typeof(ComponentsPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("connections", Type = typeof(ConnectionsPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("dataSources", Type = typeof(DataSourcesPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("method", Type = typeof(MethodPropertyType))]
        public Collection<object> Items
        {
            get
            {
                return this._items;
            }
        }
    }
}
