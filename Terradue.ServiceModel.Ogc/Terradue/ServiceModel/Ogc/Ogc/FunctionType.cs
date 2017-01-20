using System.Collections.ObjectModel;
namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Function", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class FunctionType : ExpressionType
    {

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
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }
}
