using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Swe.Common;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedValues", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class AllowedValues
    {
        private Collection<object> _items = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interval", Type = typeof(GenericPairType<double>))]
        [System.Xml.Serialization.XmlElementAttribute("max", Type = typeof(MaximumType<double>))]
        [System.Xml.Serialization.XmlElementAttribute("min", Type = typeof(MinimumType<double>))]
        [System.Xml.Serialization.XmlElementAttribute("valueList", Type = typeof(GenericCollectionType<double>))]
        public Collection<object> Items
        {
            get
            {
                return this._items;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id
        {
            get;
            set;
        }
    }
}
