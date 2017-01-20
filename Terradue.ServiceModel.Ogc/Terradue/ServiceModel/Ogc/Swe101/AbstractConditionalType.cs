using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConditionalValueType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public abstract class AbstractConditionalType : AbstractDataRecordType
    {
        private Collection<AbstractConditionalTypeCondition> _conditions = new Collection<AbstractConditionalTypeCondition>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("condition")]
        public Collection<AbstractConditionalTypeCondition> Conditions
        {
            get
            {
                return this._conditions;
            }
        }
    }
}
