using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedTokens", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class AllowedTokens
    {

        private Collection<string> _values = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("valueList")]
        public Collection<string> Values
        {
            get
            {
                return this._values;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string id
        {
            get;
            set;
        }
    }
}
