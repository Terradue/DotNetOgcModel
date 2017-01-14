using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("OperationsMetadata", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class OperationsMetadata
    {
        private Collection<Operation> _operations = new Collection<Operation>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Operation")]
        public Collection<Operation> Operations
        {
            get
            {
                return this._operations;
            }
        }

        private Collection<DomainType> _parameters = new Collection<DomainType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public Collection<DomainType> Parameters
        {
            get
            {
                return this._parameters;
            }
        }

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

        /// <summary>
        /// Individual software vendors and servers can use this property to provide metadata about any additional server abilities.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ExtendedCapabilities")]
        public object ExtendedCapabilities
        {
            get;
            set;
        }
    }
}
