using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Swe20;

namespace Terradue.ServiceModel.Ogc.SensorMl20
{

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AggregateProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractPhysicalProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribedObject", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public abstract partial class DescribedObjectType : AbstractFeatureType
    {

        private object[] extensionField;

        private KeywordListPropertyType[] keywordsField;

        private IdentifierListPropertyType[] identificationField;

        private ClassifierListPropertyType[] classificationField;

        private DescribedObjectTypeValidTime[] validTimeField;

        private object[] securityConstraintsField;

        private MD_LegalConstraints_PropertyType[] legalConstraintsField;

        private DescribedObjectTypeCharacteristics[] characteristicsField;

        private DescribedObjectTypeCapabilities[] capabilitiesField;

        private ContactListPropertyType[] contactsField;

        private DocumentListPropertyType[] documentationField;

        private EventListPropertyType[] historyField;

        private string langField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public object[] extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywords")]
        public KeywordListPropertyType[] keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("identification")]
        public IdentifierListPropertyType[] identification
        {
            get
            {
                return this.identificationField;
            }
            set
            {
                this.identificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classification")]
        public ClassifierListPropertyType[] classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validTime")]
        public DescribedObjectTypeValidTime[] validTime
        {
            get
            {
                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("securityConstraints")]
        public object[] securityConstraints
        {
            get
            {
                return this.securityConstraintsField;
            }
            set
            {
                this.securityConstraintsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("legalConstraints")]
        public MD_LegalConstraints_PropertyType[] legalConstraints
        {
            get
            {
                return this.legalConstraintsField;
            }
            set
            {
                this.legalConstraintsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("characteristics")]
        public DescribedObjectTypeCharacteristics[] characteristics
        {
            get
            {
                return this.characteristicsField;
            }
            set
            {
                this.characteristicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("capabilities")]
        public DescribedObjectTypeCapabilities[] capabilities
        {
            get
            {
                return this.capabilitiesField;
            }
            set
            {
                this.capabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contacts")]
        public ContactListPropertyType[] contacts
        {
            get
            {
                return this.contactsField;
            }
            set
            {
                this.contactsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public DocumentListPropertyType[] documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("history")]
        public EventListPropertyType[] history
        {
            get
            {
                return this.historyField;
            }
            set
            {
                this.historyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }
    
}
