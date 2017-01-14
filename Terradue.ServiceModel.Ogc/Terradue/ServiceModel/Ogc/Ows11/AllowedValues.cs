using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class AllowedValues
    {
        private Collection<object> _values = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Range", Type = typeof(RangeType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", Type = typeof(ValueType), IsNullable = false)]
        [System.Xml.Serialization.XmlArray("AllowedValues")]
        public Collection<object> Values
        {
            get
            {
                return this._values;
            }
        }
    }
}
