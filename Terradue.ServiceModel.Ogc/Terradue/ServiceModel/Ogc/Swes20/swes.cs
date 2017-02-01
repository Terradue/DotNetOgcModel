using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Oasis;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.W3c;

namespace Terradue.ServiceModel.Ogc.Swes20 {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractContentsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractOfferingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SWESEventType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferingChangedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SensorChangedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SensorDescriptionUpdatedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilterDialectMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotificationProducerMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotificationBrokerMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractSWES", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public abstract partial class AbstractSWESType {
        
        private string descriptionField;
        
        private string identifierField;
        
        private Gml321.CodeType[] nameField;
        
        private object[] extensionField;
        
        private string idField;
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public Gml321.CodeType[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public object[] extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class SensorDescriptionUpdatedPropertyType {
        
        private SensorDescriptionUpdatedType sensorDescriptionUpdatedField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public SensorDescriptionUpdatedType SensorDescriptionUpdated {
            get {
                return this.sensorDescriptionUpdatedField;
            }
            set {
                this.sensorDescriptionUpdatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SensorDescriptionUpdated", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class SensorDescriptionUpdatedType : SensorChangedType {
        
        private SensorDescriptionUpdatedTypeValidTime validTimeField;
        
        /// <remarks/>
        public SensorDescriptionUpdatedTypeValidTime validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class SensorDescriptionUpdatedTypeValidTime {
        
        private AbstractTimeGeometricPrimitiveType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeInstant", typeof(TimeInstantType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("TimePeriod", typeof(TimePeriodType), Namespace="http://www.opengis.net/gml/3.2")]
        public AbstractTimeGeometricPrimitiveType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SensorDescriptionUpdatedType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SensorChanged", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class SensorChangedType : SWESEventType {
        
        private string procedureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferingChangedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SensorChangedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SensorDescriptionUpdatedType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SWESEvent", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class SWESEventType : AbstractSWESType {
        
        private System.DateTime eventTimeField;
        
        private string codeField;
        
        private LanguageStringType[] messageField;
        
        private SWESEventTypeService serviceField;
        
        /// <remarks/>
        public System.DateTime eventTime {
            get {
                return this.eventTimeField;
            }
            set {
                this.eventTimeField = value;
            }
        }
        
        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public LanguageStringType[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public SWESEventTypeService service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class SWESEventTypeService {
        
        private EndpointReferenceType endpointReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing")]
        public EndpointReferenceType EndpointReference {
            get {
                return this.endpointReferenceField;
            }
            set {
                this.endpointReferenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("OfferingChanged", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class OfferingChangedType : SWESEventType {
        
        private string offeringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string offering {
            get {
                return this.offeringField;
            }
            set {
                this.offeringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class OfferingChangedPropertyType {
        
        private OfferingChangedType offeringChangedField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public OfferingChangedType OfferingChanged {
            get {
                return this.offeringChangedField;
            }
            set {
                this.offeringChangedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class FilterDialectMetadataPropertyType {
        
        private FilterDialectMetadataType filterDialectMetadataField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public FilterDialectMetadataType FilterDialectMetadata {
            get {
                return this.filterDialectMetadataField;
            }
            set {
                this.filterDialectMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FilterDialectMetadata", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class FilterDialectMetadataType : AbstractSWESType {
        
        private string[] topicExpressionDialectField;
        
        private string[] messageContentDialectField;
        
        private string[] producerPropertiesDialectField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("topicExpressionDialect", DataType="anyURI")]
        public string[] topicExpressionDialect {
            get {
                return this.topicExpressionDialectField;
            }
            set {
                this.topicExpressionDialectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("messageContentDialect", DataType="anyURI")]
        public string[] messageContentDialect {
            get {
                return this.messageContentDialectField;
            }
            set {
                this.messageContentDialectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("producerPropertiesDialect", DataType="anyURI")]
        public string[] producerPropertiesDialect {
            get {
                return this.producerPropertiesDialectField;
            }
            set {
                this.producerPropertiesDialectField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class SensorChangedPropertyType {
        
        private SensorChangedType itemField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SensorChanged", typeof(SensorChangedType))]
        [System.Xml.Serialization.XmlElementAttribute("SensorDescriptionUpdated", typeof(SensorDescriptionUpdatedType))]
        public SensorChangedType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class SWESEventPropertyType {
        
        private SWESEventType itemField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OfferingChanged", typeof(OfferingChangedType))]
        [System.Xml.Serialization.XmlElementAttribute("SWESEvent", typeof(SWESEventType))]
        [System.Xml.Serialization.XmlElementAttribute("SensorChanged", typeof(SensorChangedType))]
        public SWESEventType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class NotificationBrokerMetadataPropertyType {
        
        private NotificationBrokerMetadataType notificationBrokerMetadataField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public NotificationBrokerMetadataType NotificationBrokerMetadata {
            get {
                return this.notificationBrokerMetadataField;
            }
            set {
                this.notificationBrokerMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("NotificationBrokerMetadata", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class NotificationBrokerMetadataType : NotificationProducerMetadataType {
        
        private bool requiresRegistrationField;
        
        /// <remarks/>
        public bool requiresRegistration {
            get {
                return this.requiresRegistrationField;
            }
            set {
                this.requiresRegistrationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotificationBrokerMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("NotificationProducerMetadata", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class NotificationProducerMetadataType : AbstractSWESType {
        
        private NotificationProducerMetadataTypeProducerEndpoint producerEndpointField;
        
        private NotificationProducerMetadataTypeSupportedDialects supportedDialectsField;
        
        private bool fixedTopicSetField;
        
        private NotificationProducerMetadataTypeServedTopics servedTopicsField;
        
        private TopicNamespaceType[] usedTopicNamespaceField;
        
        /// <remarks/>
        public NotificationProducerMetadataTypeProducerEndpoint producerEndpoint {
            get {
                return this.producerEndpointField;
            }
            set {
                this.producerEndpointField = value;
            }
        }
        
        /// <remarks/>
        public NotificationProducerMetadataTypeSupportedDialects supportedDialects {
            get {
                return this.supportedDialectsField;
            }
            set {
                this.supportedDialectsField = value;
            }
        }
        
        /// <remarks/>
        public bool fixedTopicSet {
            get {
                return this.fixedTopicSetField;
            }
            set {
                this.fixedTopicSetField = value;
            }
        }
        
        /// <remarks/>
        public NotificationProducerMetadataTypeServedTopics servedTopics {
            get {
                return this.servedTopicsField;
            }
            set {
                this.servedTopicsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usedTopicNamespace")]
        public TopicNamespaceType[] usedTopicNamespace {
            get {
                return this.usedTopicNamespaceField;
            }
            set {
                this.usedTopicNamespaceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class NotificationProducerMetadataTypeProducerEndpoint {
        
        private EndpointReferenceType endpointReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing")]
        public EndpointReferenceType EndpointReference {
            get {
                return this.endpointReferenceField;
            }
            set {
                this.endpointReferenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class NotificationProducerMetadataTypeSupportedDialects {
        
        private FilterDialectMetadataType filterDialectMetadataField;
        
        /// <remarks/>
        public FilterDialectMetadataType FilterDialectMetadata {
            get {
                return this.filterDialectMetadataField;
            }
            set {
                this.filterDialectMetadataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class NotificationProducerMetadataTypeServedTopics {
        
        private TopicSetType topicSetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1")]
        public TopicSetType TopicSet {
            get {
                return this.topicSetField;
            }
            set {
                this.topicSetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class NotificationProducerMetadataPropertyType {
        
        private NotificationProducerMetadataType itemField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationBrokerMetadata", typeof(NotificationBrokerMetadataType))]
        [System.Xml.Serialization.XmlElementAttribute("NotificationProducerMetadata", typeof(NotificationProducerMetadataType))]
        public NotificationProducerMetadataType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class DeleteSensorResponsePropertyType {
        
        private DeleteSensorResponseType deleteSensorResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public DeleteSensorResponseType DeleteSensorResponse {
            get {
                return this.deleteSensorResponseField;
            }
            set {
                this.deleteSensorResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DeleteSensorResponse", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class DeleteSensorResponseType : ExtensibleResponseType {
        
        private string deletedProcedureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string deletedProcedure {
            get {
                return this.deletedProcedureField;
            }
            set {
                this.deletedProcedureField = value;
            }
        }
    }
    
    
    
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class DescribeSensorResponseTypeDescription {
        
        private SensorDescriptionType sensorDescriptionField;
        
        /// <remarks/>
        public SensorDescriptionType SensorDescription {
            get {
                return this.sensorDescriptionField;
            }
            set {
                this.sensorDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SensorDescription", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class SensorDescriptionType {
        
        private SensorDescriptionTypeValidTime validTimeField;
        
        private System.Xml.XmlElement dataField;
        
        /// <remarks/>
        public SensorDescriptionTypeValidTime validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
        
        /// <remarks/>
        public System.Xml.XmlElement data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class SensorDescriptionTypeValidTime {
        
        private AbstractTimeGeometricPrimitiveType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeInstant", typeof(TimeInstantType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("TimePeriod", typeof(TimePeriodType), Namespace="http://www.opengis.net/gml/3.2")]
        public AbstractTimeGeometricPrimitiveType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertSensorResponse", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class InsertSensorResponseType : ExtensibleResponseType {
        
        private string assignedProcedureField;
        
        private string assignedOfferingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string assignedProcedure {
            get {
                return this.assignedProcedureField;
            }
            set {
                this.assignedProcedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string assignedOffering {
            get {
                return this.assignedOfferingField;
            }
            set {
                this.assignedOfferingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("UpdateSensorDescriptionResponse", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class UpdateSensorDescriptionResponseType : ExtensibleResponseType {
        
        private string updatedProcedureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string updatedProcedure {
            get {
                return this.updatedProcedureField;
            }
            set {
                this.updatedProcedureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class DeleteSensorPropertyType {
        
        private DeleteSensorType deleteSensorField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public DeleteSensorType DeleteSensor {
            get {
                return this.deleteSensorField;
            }
            set {
                this.deleteSensorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DeleteSensor", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class DeleteSensorType : ExtensibleRequestType {
        
        private string procedureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
    }
    
    
    
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class DescribeSensorTypeValidTime {
        
        private AbstractTimeGeometricPrimitiveType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeInstant", typeof(TimeInstantType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("TimePeriod", typeof(TimePeriodType), Namespace="http://www.opengis.net/gml/3.2")]
        public AbstractTimeGeometricPrimitiveType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertSensor", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class InsertSensorType : ExtensibleRequestType {
        
        private string procedureDescriptionFormatField;
        
        private System.Xml.XmlElement procedureDescriptionField;
        
        private string[] observablePropertyField;
        
        private InsertSensorTypeRelatedFeature[] relatedFeatureField;
        
        private InsertSensorTypeMetadata[] metadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedureDescriptionFormat {
            get {
                return this.procedureDescriptionFormatField;
            }
            set {
                this.procedureDescriptionFormatField = value;
            }
        }
        
        /// <remarks/>
        public System.Xml.XmlElement procedureDescription {
            get {
                return this.procedureDescriptionField;
            }
            set {
                this.procedureDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observableProperty", DataType="anyURI")]
        public string[] observableProperty {
            get {
                return this.observablePropertyField;
            }
            set {
                this.observablePropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedFeature")]
        public InsertSensorTypeRelatedFeature[] relatedFeature {
            get {
                return this.relatedFeatureField;
            }
            set {
                this.relatedFeatureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metadata")]
        public InsertSensorTypeMetadata[] metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class InsertSensorTypeRelatedFeature {
        
        private FeatureRelationshipType featureRelationshipField;
        
        /// <remarks/>
        public FeatureRelationshipType FeatureRelationship {
            get {
                return this.featureRelationshipField;
            }
            set {
                this.featureRelationshipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureRelationship", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class FeatureRelationshipType {
        
        private string roleField;
        
        private FeaturePropertyType targetField;
        
        public FeatureRelationshipType() {
            this.roleField = "http://www.opengis.net/def/nil/OGC/0/unknown";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        [System.ComponentModel.DefaultValueAttribute("http://www.opengis.net/def/nil/OGC/0/unknown")]
        public string role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public FeaturePropertyType target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class InsertSensorTypeMetadata {
        
        private InsertionMetadataType insertionMetadataField;
        
        /// <remarks/>
        public InsertionMetadataType InsertionMetadata {
            get {
                return this.insertionMetadataField;
            }
            set {
                this.insertionMetadataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertionMetadata", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public abstract partial class InsertionMetadataType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("UpdateSensorDescription", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class UpdateSensorDescriptionType : ExtensibleRequestType {
        
        private string procedureField;
        
        private string procedureDescriptionFormatField;
        
        private UpdateSensorDescriptionTypeDescription[] descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedureDescriptionFormat {
            get {
                return this.procedureDescriptionFormatField;
            }
            set {
                this.procedureDescriptionFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public UpdateSensorDescriptionTypeDescription[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class UpdateSensorDescriptionTypeDescription {
        
        private SensorDescriptionType sensorDescriptionField;
        
        /// <remarks/>
        public SensorDescriptionType SensorDescription {
            get {
                return this.sensorDescriptionField;
            }
            set {
                this.sensorDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class DescribeSensorPropertyType {
        
        private DescribeSensorType describeSensorField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public DescribeSensorType DescribeSensor {
            get {
                return this.describeSensorField;
            }
            set {
                this.describeSensorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class DescribeSensorResponsePropertyType {
        
        private DescribeSensorResponseType describeSensorResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public DescribeSensorResponseType DescribeSensorResponse {
            get {
                return this.describeSensorResponseField;
            }
            set {
                this.describeSensorResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class AbstractContentsPropertyType {
        
        private AbstractContentsType abstractContentsField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractContentsType AbstractContents {
            get {
                return this.abstractContentsField;
            }
            set {
                this.abstractContentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractContents", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public abstract partial class AbstractContentsType : AbstractSWESType {
        
        private string[] procedureDescriptionFormatField;
        
        private string[] observablePropertyField;
        
        private AbstractContentsTypeRelatedFeature[] relatedFeatureField;
        
        private AbstractContentsTypeOffering[] offeringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procedureDescriptionFormat", DataType="anyURI")]
        public string[] procedureDescriptionFormat {
            get {
                return this.procedureDescriptionFormatField;
            }
            set {
                this.procedureDescriptionFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observableProperty", DataType="anyURI")]
        public string[] observableProperty {
            get {
                return this.observablePropertyField;
            }
            set {
                this.observablePropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedFeature")]
        public AbstractContentsTypeRelatedFeature[] relatedFeature {
            get {
                return this.relatedFeatureField;
            }
            set {
                this.relatedFeatureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offering")]
        public AbstractContentsTypeOffering[] offering {
            get {
                return this.offeringField;
            }
            set {
                this.offeringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class AbstractContentsTypeRelatedFeature {
        
        private FeatureRelationshipType featureRelationshipField;
        
        /// <remarks/>
        public FeatureRelationshipType FeatureRelationship {
            get {
                return this.featureRelationshipField;
            }
            set {
                this.featureRelationshipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class AbstractContentsTypeOffering {
        
        private AbstractOfferingType abstractOfferingField;
        
        /// <remarks/>
        public AbstractOfferingType AbstractOffering {
            get {
                return this.abstractOfferingField;
            }
            set {
                this.abstractOfferingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractOffering", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public abstract partial class AbstractOfferingType : AbstractSWESType {
        
        private string procedureField;
        
        private string[] procedureDescriptionFormatField;
        
        private string[] observablePropertyField;
        
        private AbstractOfferingTypeRelatedFeature[] relatedFeatureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procedureDescriptionFormat", DataType="anyURI")]
        public string[] procedureDescriptionFormat {
            get {
                return this.procedureDescriptionFormatField;
            }
            set {
                this.procedureDescriptionFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observableProperty", DataType="anyURI")]
        public string[] observableProperty {
            get {
                return this.observablePropertyField;
            }
            set {
                this.observablePropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedFeature")]
        public AbstractOfferingTypeRelatedFeature[] relatedFeature {
            get {
                return this.relatedFeatureField;
            }
            set {
                this.relatedFeatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swes/2.0")]
    public partial class AbstractOfferingTypeRelatedFeature {
        
        private FeatureRelationshipType featureRelationshipField;
        
        /// <remarks/>
        public FeatureRelationshipType FeatureRelationship {
            get {
                return this.featureRelationshipField;
            }
            set {
                this.featureRelationshipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class AbstractOfferingPropertyType {
        
        private AbstractOfferingType abstractOfferingField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractOfferingType AbstractOffering {
            get {
                return this.abstractOfferingField;
            }
            set {
                this.abstractOfferingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class InsertSensorResponsePropertyType {
        
        private InsertSensorResponseType insertSensorResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertSensorResponseType InsertSensorResponse {
            get {
                return this.insertSensorResponseField;
            }
            set {
                this.insertSensorResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class InsertionMetadataPropertyType {
        
        private InsertionMetadataType insertionMetadataField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertionMetadataType InsertionMetadata {
            get {
                return this.insertionMetadataField;
            }
            set {
                this.insertionMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class InsertSensorPropertyType {
        
        private InsertSensorType insertSensorField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertSensorType InsertSensor {
            get {
                return this.insertSensorField;
            }
            set {
                this.insertSensorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class UpdateSensorDescriptionResponsePropertyType {
        
        private UpdateSensorDescriptionResponseType updateSensorDescriptionResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public UpdateSensorDescriptionResponseType UpdateSensorDescriptionResponse {
            get {
                return this.updateSensorDescriptionResponseField;
            }
            set {
                this.updateSensorDescriptionResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class UpdateSensorDescriptionPropertyType {
        
        private UpdateSensorDescriptionType updateSensorDescriptionField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public UpdateSensorDescriptionType UpdateSensorDescription {
            get {
                return this.updateSensorDescriptionField;
            }
            set {
                this.updateSensorDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class ExtensibleRequestPropertyType {
        
        private ExtensibleRequestType itemField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeleteSensor", typeof(DeleteSensorType))]
        [System.Xml.Serialization.XmlElementAttribute("DescribeSensor", typeof(DescribeSensorType))]
        [System.Xml.Serialization.XmlElementAttribute("InsertSensor", typeof(InsertSensorType))]
        [System.Xml.Serialization.XmlElementAttribute("UpdateSensorDescription", typeof(UpdateSensorDescriptionType))]
        public ExtensibleRequestType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class ExtensibleResponsePropertyType {
        
        private ExtensibleResponseType itemField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeleteSensorResponse", typeof(DeleteSensorResponseType))]
        [System.Xml.Serialization.XmlElementAttribute("DescribeSensorResponse", typeof(DescribeSensorResponseType))]
        [System.Xml.Serialization.XmlElementAttribute("InsertSensorResponse", typeof(InsertSensorResponseType))]
        [System.Xml.Serialization.XmlElementAttribute("UpdateSensorDescriptionResponse", typeof(UpdateSensorDescriptionResponseType))]
        public ExtensibleResponseType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class FeatureRelationshipPropertyType {
        
        private FeatureRelationshipType featureRelationshipField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public FeatureRelationshipType FeatureRelationship {
            get {
                return this.featureRelationshipField;
            }
            set {
                this.featureRelationshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class SensorDescriptionPropertyType {
        
        private SensorDescriptionType sensorDescriptionField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public SensorDescriptionType SensorDescription {
            get {
                return this.sensorDescriptionField;
            }
            set {
                this.sensorDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    public partial class AbstractSWESPropertyType {
        
        private AbstractSWESType itemField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FilterDialectMetadata", typeof(FilterDialectMetadataType))]
        [System.Xml.Serialization.XmlElementAttribute("NotificationProducerMetadata", typeof(NotificationProducerMetadataType))]
        [System.Xml.Serialization.XmlElementAttribute("SWESEvent", typeof(SWESEventType))]
        public AbstractSWESType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.opengis.net/gml/3.2", DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
