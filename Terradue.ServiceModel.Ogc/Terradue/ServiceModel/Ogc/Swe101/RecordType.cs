using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Record", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class RecordType
    {
        private Collection<ItemPropertyType> _fields = new Collection<ItemPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("field")]
        public Collection<ItemPropertyType> Fields
        {
            get
            {
                return this._fields;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("RS", DataType = "anyURI")]
        public string Rs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("fieldCount", DataType = "positiveInteger")]
        public string FieldCount { get; set; }
    }
}
