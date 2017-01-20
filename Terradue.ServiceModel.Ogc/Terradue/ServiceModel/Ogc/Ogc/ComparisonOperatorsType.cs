using System.Collections.ObjectModel;
namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public class ComparisonOperatorsType
    {
        private Collection<ComparisonOperatorType> _comparisonOperators = new Collection<ComparisonOperatorType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComparisonOperator")]
        public Collection<ComparisonOperatorType> ComparisonOperators 
        {
            get
            {
                return this._comparisonOperators;
            }
        }
    }
}
