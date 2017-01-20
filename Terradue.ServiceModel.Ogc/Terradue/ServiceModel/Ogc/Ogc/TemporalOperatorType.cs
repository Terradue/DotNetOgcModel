using System.Collections.ObjectModel;
using System.Xml;

namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public class TemporalOperatorType
    {
        private Collection<XmlQualifiedName> _temporalOperands = new Collection<XmlQualifiedName>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperand", IsNullable = false)]
        [System.Xml.Serialization.XmlArray("TemporalOperands")]
        public Collection<XmlQualifiedName> TemporalOperands
        {
            get
            {
                return this._temporalOperands;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public TemporalOperatorNameType Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameSpecified { get; set; }
    }
}
