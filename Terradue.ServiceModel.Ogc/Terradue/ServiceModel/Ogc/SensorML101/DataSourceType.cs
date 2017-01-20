using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("DataSource", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class DataSourceType : AbstractProcessType
    {
        private Collection<object> _items = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dataDefinition", Type = typeof(DataSourceTypeDataDefinition))]
        [System.Xml.Serialization.XmlElementAttribute("observationReference", Type = typeof(DataSourceTypeObservationReference))]
        [System.Xml.Serialization.XmlElementAttribute("values", Type = typeof(DataSourceTypeValues))]
        public Collection<object> Items
        {
            get
            {
                return this._items;
            }
        }
    }
}
