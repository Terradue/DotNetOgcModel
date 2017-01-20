using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class InterfacesInterfaceList
    {
        private Collection<Interface> _interfaces = new Collection<Interface>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interface")]
        public Collection<Interface> Interfaces
        {
            get
            {
                return this._interfaces;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id { get; set; }
    }
}
