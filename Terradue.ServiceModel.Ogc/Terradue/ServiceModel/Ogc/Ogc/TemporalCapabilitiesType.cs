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
    [System.Xml.Serialization.XmlRootAttribute("Temporal_Capabilities", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class TemporalCapabilitiesType
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

        private Collection<TemporalOperatorType> _temporalOperators = new Collection<TemporalOperatorType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperator", IsNullable = false)]
        [System.Xml.Serialization.XmlArray("TemporalOperators")]
        public Collection<TemporalOperatorType> TemporalOperators
        {
            get
            {
                return this._temporalOperators;
            }
        }
    }
}
