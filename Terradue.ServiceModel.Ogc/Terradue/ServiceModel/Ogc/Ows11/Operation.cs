using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Operation", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class Operation
    {
        private Collection<Dcp> _dcps = new Collection<Dcp>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DCP")]
        public Collection<Dcp> Dcps
        {
            get
            {
                return this._dcps;
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

        private Collection<MetadataType> _metadata = new Collection<MetadataType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public Collection<MetadataType> Metadata
        {
            get
            {
                return this._metadata;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }
}
