using System.Collections.ObjectModel;
namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Scalar_Capabilities", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class ScalarCapabilitiesType
    {
        /// <remarks/>
        public LogicalOperators LogicalOperators
        {
            get;
            set;
        }

        /// <remarks/>
        public ComparisonOperatorsType ComparisonOperators
        {
            get;
            set;
        }

        private Collection<object> _arithmeticOperators = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Functions", Type = typeof(FunctionsType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SimpleArithmetic", Type = typeof(SimpleArithmetic), IsNullable = false)]
        public Collection<object> ArithmeticOperators 
        {
            get
            {
                return this._arithmeticOperators;
            }
        }
    }
}
