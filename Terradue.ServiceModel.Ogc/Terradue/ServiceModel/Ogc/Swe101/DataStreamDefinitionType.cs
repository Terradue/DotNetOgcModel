using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("DataStreamDefinition", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class DataStreamDefinitionType
    {
        private Collection<DataBlockDefinitionPropertyType> _streamComponents = new Collection<DataBlockDefinitionPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("streamComponent")]
        public Collection<DataBlockDefinitionPropertyType> StreamComponents
        {
            get
            {
                return this._streamComponents;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("streamEncoding")]
        public MultiplexedStreamFormatPropertyType StreamEncoding { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id { get; set; }
    }
}
