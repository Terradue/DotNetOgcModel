using System.Collections.ObjectModel;
namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public abstract class BinaryComparisonOpType : ComparisonOpsType
    {
        /// <remarks/>
        public BinaryComparisonOpType()
        {
            this.MatchCase = true;
        }

        private Collection<ExpressionType> _expressions = new Collection<ExpressionType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public Collection<ExpressionType> Expressions
        {
            get
            {
                return this._expressions;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("matchCase")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool MatchCase { get; set; }
    }
}
