using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Swe10;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class ParametersParameterList
    {
        private Collection<DataComponentPropertyType> _parameters = new Collection<DataComponentPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public Collection<DataComponentPropertyType> Parameters
        {
            get
            {
                return this._parameters;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id { get; set; }
    }
}
