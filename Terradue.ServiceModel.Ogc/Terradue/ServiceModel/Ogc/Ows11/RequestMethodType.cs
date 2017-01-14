using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class RequestMethodType : OnlineResourceType
    {
        private Collection<DomainType> _constraints = new Collection<DomainType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public Collection<DomainType> Constraints
        {
            get
            {
                return this._constraints;
            }
        }
    }
}
