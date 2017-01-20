using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Om10;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDerivableComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDerivableProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataSourceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractRestrictedProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractPureProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProcessChainType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProcessModelType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalculationProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObservationProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstrumentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public abstract class AbstractProcessType : AbstractSmlType
    {
        private Collection<Keywords> _keywords = new Collection<Keywords>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywords")]
        public Collection<Keywords> Keywords
        {
            get
            {
                return this._keywords;
            }
        }

        private Collection<Identification> _identifications = new Collection<Identification>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("identification")]
        public Collection<Identification> Identifications
        {
            get
            {
                return this._identifications;
            }
        }

        private Collection<Classification> _classifications = new Collection<Classification>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classification")]
        public Collection<Classification> Classifications
        {
            get
            {
                return this._classifications;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validTime")]
        public ValidTime ValidTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("securityConstraint")]
        public SecurityConstraint SecurityConstraint { get; set; }

        private Collection<LegalConstraint> _legalConstraints = new Collection<LegalConstraint>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("legalConstraint")]
        public Collection<LegalConstraint> LegalConstraints
        {
            get
            {
                return this._legalConstraints;
            }
        }

        private Collection<Characteristics> _characteristics = new Collection<Characteristics>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("characteristics")]
        public Collection<Characteristics> Characteristics
        {
            get
            {
                return this._characteristics;
            }
        }

        private Collection<Capabilities> _capabilities = new Collection<Capabilities>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("capabilities")]
        public Collection<Capabilities> Capabilities
        {
            get
            {
                return this._capabilities;
            }
        }

        private Collection<Contact> _contacts = new Collection<Contact>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public Collection<Contact> Contacts
        {
            get
            {
                return this._contacts;
            }
        }

        private Collection<Documentation> _documentation = new Collection<Documentation>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public Collection<Documentation> Documentation
        {
            get
            {
                return this._documentation;
            }
        }

        private Collection<History> _history = new Collection<History>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("history")]
        public Collection<History> History
        {
            get
            {
                return this._history;
            }
        }
    }
}
