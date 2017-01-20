using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("connections", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Connections
    {
        private Collection<Connection> _connectionList = new Collection<Connection>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public Collection<Connection> ConnectionList
        {
            get
            {
                return this._connectionList;
            }
        }
    }
}
