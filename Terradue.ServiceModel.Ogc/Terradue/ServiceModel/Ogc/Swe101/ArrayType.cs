using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Array", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class ArrayType
    {
        private Collection<XmlDataPropertyType> _elements = new Collection<XmlDataPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("element")]
        public Collection<XmlDataPropertyType> Elements
        {
            get
            {
                return this._elements;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("RS", DataType = "anyURI")]
        public string Rs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("elementCount", DataType = "positiveInteger")]
        public string ElementCount { get; set; }
    }
}
