using Terradue.ServiceModel.Ogc.Fes20;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Om20;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.Swe20;
using Terradue.ServiceModel.Ogc.Swes20;

namespace Terradue.ServiceModel.Ogxc.Sos20 {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ObservationOffering", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class ObservationOfferingType : AbstractOfferingType {
        
        private ObservationOfferingTypeObservedArea observedAreaField;
        
        private ObservationOfferingTypePhenomenonTime phenomenonTimeField;
        
        private ObservationOfferingTypeResultTime resultTimeField;
        
        private string[] responseFormatField;
        
        private string[] observationTypeField;
        
        private string[] featureOfInterestTypeField;
        
        /// <remarks/>
        public ObservationOfferingTypeObservedArea observedArea {
            get {
                return this.observedAreaField;
            }
            set {
                this.observedAreaField = value;
            }
        }
        
        /// <remarks/>
        public ObservationOfferingTypePhenomenonTime phenomenonTime {
            get {
                return this.phenomenonTimeField;
            }
            set {
                this.phenomenonTimeField = value;
            }
        }
        
        /// <remarks/>
        public ObservationOfferingTypeResultTime resultTime {
            get {
                return this.resultTimeField;
            }
            set {
                this.resultTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseFormat", DataType="anyURI")]
        public string[] responseFormat {
            get {
                return this.responseFormatField;
            }
            set {
                this.responseFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observationType", DataType="anyURI")]
        public string[] observationType {
            get {
                return this.observationTypeField;
            }
            set {
                this.observationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterestType", DataType="anyURI")]
        public string[] featureOfInterestType {
            get {
                return this.featureOfInterestTypeField;
            }
            set {
                this.featureOfInterestTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ObservationOfferingTypeObservedArea {
        
        private EnvelopeType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof(EnvelopeType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("EnvelopeWithTimePeriod", typeof(EnvelopeWithTimePeriodType), Namespace="http://www.opengis.net/gml/3.2")]
        public EnvelopeType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertionCapabilitiesPropertyType {
        
        private InsertionCapabilitiesType insertionCapabilitiesField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertionCapabilitiesType InsertionCapabilities {
            get {
                return this.insertionCapabilitiesField;
            }
            set {
                this.insertionCapabilitiesField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertionCapabilities", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class InsertionCapabilitiesType {
        
        private string[] procedureDescriptionFormatField;
        
        private string[] featureOfInterestTypeField;
        
        private string[] observationTypeField;
        
        private string[] supportedEncodingField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterestType", DataType="anyURI")]
        public string[] featureOfInterestType {
            get {
                return this.featureOfInterestTypeField;
            }
            set {
                this.featureOfInterestTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observationType", DataType="anyURI")]
        public string[] observationType {
            get {
                return this.observationTypeField;
            }
            set {
                this.observationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("supportedEncoding", DataType="anyURI")]
        public string[] supportedEncoding {
            get {
                return this.supportedEncodingField;
            }
            set {
                this.supportedEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertResultResponsePropertyType {
        
        private InsertResultResponseType insertResultResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertResultResponseType InsertResultResponse {
            get {
                return this.insertResultResponseField;
            }
            set {
                this.insertResultResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertResultResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class InsertResultResponseType : ExtensibleResponseType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetResultTemplateResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetResultTemplateResponseType : ExtensibleResponseType {
        
        private GetResultTemplateResponseTypeResultStructure resultStructureField;
        
        private GetResultTemplateResponseTypeResultEncoding resultEncodingField;
        
        /// <remarks/>
        public GetResultTemplateResponseTypeResultStructure resultStructure {
            get {
                return this.resultStructureField;
            }
            set {
                this.resultStructureField = value;
            }
        }
        
        /// <remarks/>
        public GetResultTemplateResponseTypeResultEncoding resultEncoding {
            get {
                return this.resultEncodingField;
            }
            set {
                this.resultEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultTemplateResponseTypeResultStructure {
        
        private AbstractDataComponentType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataArray", typeof(DataArrayType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DataChoice", typeof(DataChoiceType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DataRecord", typeof(DataRecordType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Vector", typeof(Ogc.Swe20.VectorType), Namespace="http://www.opengis.net/swe/2.0")]
        public AbstractDataComponentType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultTemplateResponseTypeResultEncoding {
        
        private AbstractEncodingType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryEncoding", typeof(BinaryEncodingType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TextEncoding", typeof(TextEncodingType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("XMLEncoding", typeof(XMLEncodingType), Namespace="http://www.opengis.net/swe/2.0")]
        public AbstractEncodingType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetObservationByIdResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetObservationByIdResponseType : ExtensibleResponseType {
        
        private GetObservationByIdResponseTypeObservation[] observationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observation")]
        public GetObservationByIdResponseTypeObservation[] observation {
            get {
                return this.observationField;
            }
            set {
                this.observationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationByIdResponseTypeObservation {
        
        private OM_ObservationType oM_ObservationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/om/2.0")]
        public OM_ObservationType OM_Observation {
            get {
                return this.oM_ObservationField;
            }
            set {
                this.oM_ObservationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertObservationResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class InsertObservationResponseType : ExtensibleResponseType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertResultTemplateResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class InsertResultTemplateResponseType : ExtensibleResponseType {
        
        private string acceptedTemplateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string acceptedTemplate {
            get {
                return this.acceptedTemplateField;
            }
            set {
                this.acceptedTemplateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeatureOfInterestResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetFeatureOfInterestResponseType : ExtensibleResponseType {
        
        private FeaturePropertyType[] featureMemberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureMember")]
        public FeaturePropertyType[] featureMember {
            get {
                return this.featureMemberField;
            }
            set {
                this.featureMemberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetObservationResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetObservationResponseType : ExtensibleResponseType {
        
        private GetObservationResponseTypeObservationData[] observationDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observationData")]
        public GetObservationResponseTypeObservationData[] observationData {
            get {
                return this.observationDataField;
            }
            set {
                this.observationDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationResponseTypeObservationData {
        
        private OM_ObservationType oM_ObservationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/om/2.0")]
        public OM_ObservationType OM_Observation {
            get {
                return this.oM_ObservationField;
            }
            set {
                this.oM_ObservationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetResultResponse", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetResultResponseType : ExtensibleResponseType {
        
        private object resultValuesField;
        
        /// <remarks/>
        public object resultValues {
            get {
                return this.resultValuesField;
            }
            set {
                this.resultValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertResultPropertyType {
        
        private InsertResultType insertResultField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertResultType InsertResult {
            get {
                return this.insertResultField;
            }
            set {
                this.insertResultField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertResult", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class InsertResultType : ExtensibleRequestType {
        
        private string templateField;
        
        private object resultValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string template {
            get {
                return this.templateField;
            }
            set {
                this.templateField = value;
            }
        }
        
        /// <remarks/>
        public object resultValues {
            get {
                return this.resultValuesField;
            }
            set {
                this.resultValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetResultTemplate", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetResultTemplateType : ExtensibleRequestType {
        
        private string offeringField;
        
        private string observedPropertyField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string observedProperty {
            get {
                return this.observedPropertyField;
            }
            set {
                this.observedPropertyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetObservationById", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetObservationByIdType : ExtensibleRequestType {
        
        private string[] observationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observation", DataType="anyURI")]
        public string[] observation {
            get {
                return this.observationField;
            }
            set {
                this.observationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertObservation", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class InsertObservationType : ExtensibleRequestType {
        
        private string[] offeringField;
        
        private InsertObservationTypeObservation[] observationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offering", DataType="anyURI")]
        public string[] offering {
            get {
                return this.offeringField;
            }
            set {
                this.offeringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observation")]
        public InsertObservationTypeObservation[] observation {
            get {
                return this.observationField;
            }
            set {
                this.observationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertObservationTypeObservation {
        
        private OM_ObservationType oM_ObservationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/om/2.0")]
        public OM_ObservationType OM_Observation {
            get {
                return this.oM_ObservationField;
            }
            set {
                this.oM_ObservationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InsertResultTemplate", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class InsertResultTemplateType : ExtensibleRequestType {
        
        private InsertResultTemplateTypeProposedTemplate proposedTemplateField;
        
        /// <remarks/>
        public InsertResultTemplateTypeProposedTemplate proposedTemplate {
            get {
                return this.proposedTemplateField;
            }
            set {
                this.proposedTemplateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertResultTemplateTypeProposedTemplate {
        
        private ResultTemplateType resultTemplateField;
        
        /// <remarks/>
        public ResultTemplateType ResultTemplate {
            get {
                return this.resultTemplateField;
            }
            set {
                this.resultTemplateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ResultTemplate", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class ResultTemplateType : AbstractSWESType {
        
        private string offeringField;
        
        private ResultTemplateTypeObservationTemplate observationTemplateField;
        
        private ResultTemplateTypeResultStructure resultStructureField;
        
        private ResultTemplateTypeResultEncoding resultEncodingField;
        
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
        
        /// <remarks/>
        public ResultTemplateTypeObservationTemplate observationTemplate {
            get {
                return this.observationTemplateField;
            }
            set {
                this.observationTemplateField = value;
            }
        }
        
        /// <remarks/>
        public ResultTemplateTypeResultStructure resultStructure {
            get {
                return this.resultStructureField;
            }
            set {
                this.resultStructureField = value;
            }
        }
        
        /// <remarks/>
        public ResultTemplateTypeResultEncoding resultEncoding {
            get {
                return this.resultEncodingField;
            }
            set {
                this.resultEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ResultTemplateTypeObservationTemplate {
        
        private OM_ObservationType oM_ObservationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/om/2.0")]
        public OM_ObservationType OM_Observation {
            get {
                return this.oM_ObservationField;
            }
            set {
                this.oM_ObservationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ResultTemplateTypeResultStructure {
        
        private AbstractDataComponentType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataArray", typeof(DataArrayType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DataChoice", typeof(DataChoiceType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DataRecord", typeof(DataRecordType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Vector", typeof(Ogc.Swe20.VectorType), Namespace="http://www.opengis.net/swe/2.0")]
        public AbstractDataComponentType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ResultTemplateTypeResultEncoding {
        
        private AbstractEncodingType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryEncoding", typeof(BinaryEncodingType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TextEncoding", typeof(TextEncodingType), Namespace="http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("XMLEncoding", typeof(XMLEncodingType), Namespace="http://www.opengis.net/swe/2.0")]
        public AbstractEncodingType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Contents", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class ContentsType : AbstractContentsType {
        
        private string[] responseFormatField;
        
        private string[] observationTypeField;
        
        private string[] featureOfInterestTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseFormat", DataType="anyURI")]
        public string[] responseFormat {
            get {
                return this.responseFormatField;
            }
            set {
                this.responseFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observationType", DataType="anyURI")]
        public string[] observationType {
            get {
                return this.observationTypeField;
            }
            set {
                this.observationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterestType", DataType="anyURI")]
        public string[] featureOfInterestType {
            get {
                return this.featureOfInterestTypeField;
            }
            set {
                this.featureOfInterestTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetFeatureOfInterest", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetFeatureOfInterestType : ExtensibleRequestType {
        
        private string[] procedureField;
        
        private string[] observedPropertyField;
        
        private string[] featureOfInterestField;
        
        private GetFeatureOfInterestTypeSpatialFilter[] spatialFilterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procedure", DataType="anyURI")]
        public string[] procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observedProperty", DataType="anyURI")]
        public string[] observedProperty {
            get {
                return this.observedPropertyField;
            }
            set {
                this.observedPropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterest", DataType="anyURI")]
        public string[] featureOfInterest {
            get {
                return this.featureOfInterestField;
            }
            set {
                this.featureOfInterestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spatialFilter")]
        public GetFeatureOfInterestTypeSpatialFilter[] spatialFilter {
            get {
                return this.spatialFilterField;
            }
            set {
                this.spatialFilterField = value;
            }
        }
    }
    
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0", IncludeInSchema=false)]
    public enum ItemChoiceType24 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:BBOX")]
        BBOX,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Beyond")]
        Beyond,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Contains")]
        Contains,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Crosses")]
        Crosses,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:DWithin")]
        DWithin,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Disjoint")]
        Disjoint,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Equals")]
        Equals,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Intersects")]
        Intersects,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Overlaps")]
        Overlaps,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Touches")]
        Touches,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Within")]
        Within,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetObservation", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetObservationType : ExtensibleRequestType {
        
        private string[] procedureField;
        
        private string[] offeringField;
        
        private string[] observedPropertyField;
        
        private GetObservationTypeTemporalFilter[] temporalFilterField;
        
        private string[] featureOfInterestField;
        
        private GetObservationTypeSpatialFilter spatialFilterField;
        
        private string responseFormatField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procedure", DataType="anyURI")]
        public string[] procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offering", DataType="anyURI")]
        public string[] offering {
            get {
                return this.offeringField;
            }
            set {
                this.offeringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observedProperty", DataType="anyURI")]
        public string[] observedProperty {
            get {
                return this.observedPropertyField;
            }
            set {
                this.observedPropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("temporalFilter")]
        public GetObservationTypeTemporalFilter[] temporalFilter {
            get {
                return this.temporalFilterField;
            }
            set {
                this.temporalFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterest", DataType="anyURI")]
        public string[] featureOfInterest {
            get {
                return this.featureOfInterestField;
            }
            set {
                this.featureOfInterestField = value;
            }
        }
        
        /// <remarks/>
        public GetObservationTypeSpatialFilter spatialFilter {
            get {
                return this.spatialFilterField;
            }
            set {
                this.spatialFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string responseFormat {
            get {
                return this.responseFormatField;
            }
            set {
                this.responseFormatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationTypeTemporalFilter {
        
        private BinaryTemporalOpType itemField;
        
        private ItemChoiceType22 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("After", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("AnyInteracts", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Before", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Begins", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("BegunBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("During", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("EndedBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Ends", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Meets", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("MetBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("OverlappedBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TContains", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TEquals", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TOverlaps", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public BinaryTemporalOpType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType22 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0", IncludeInSchema=false)]
    public enum ItemChoiceType22 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:After")]
        After,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:AnyInteracts")]
        AnyInteracts,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Before")]
        Before,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Begins")]
        Begins,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:BegunBy")]
        BegunBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:During")]
        During,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:EndedBy")]
        EndedBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Ends")]
        Ends,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Meets")]
        Meets,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:MetBy")]
        MetBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:OverlappedBy")]
        OverlappedBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:TContains")]
        TContains,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:TEquals")]
        TEquals,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:TOverlaps")]
        TOverlaps,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationTypeSpatialFilter {
        
        private SpatialOpsType itemField;
        
        private ItemChoiceType23 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BBOX", typeof(BBOXType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Beyond", typeof(DistanceBufferType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Contains", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Crosses", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DWithin", typeof(DistanceBufferType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Disjoint", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Equals", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Intersects", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Overlaps", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Touches", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Within", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public SpatialOpsType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType23 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0", IncludeInSchema=false)]
    public enum ItemChoiceType23 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:BBOX")]
        BBOX,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Beyond")]
        Beyond,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Contains")]
        Contains,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Crosses")]
        Crosses,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:DWithin")]
        DWithin,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Disjoint")]
        Disjoint,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Equals")]
        Equals,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Intersects")]
        Intersects,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Overlaps")]
        Overlaps,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Touches")]
        Touches,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Within")]
        Within,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SosInsertionMetadata", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class SosInsertionMetadataType : InsertionMetadataType {
        
        private string[] observationTypeField;
        
        private string[] featureOfInterestTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observationType", DataType="anyURI")]
        public string[] observationType {
            get {
                return this.observationTypeField;
            }
            set {
                this.observationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterestType", DataType="anyURI")]
        public string[] featureOfInterestType {
            get {
                return this.featureOfInterestTypeField;
            }
            set {
                this.featureOfInterestTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetResult", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetResultType : ExtensibleRequestType {
        
        private string offeringField;
        
        private string observedPropertyField;
        
        private GetResultTypeTemporalFilter[] temporalFilterField;
        
        private string[] featureOfInterestField;
        
        private GetResultTypeSpatialFilter spatialFilterField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string observedProperty {
            get {
                return this.observedPropertyField;
            }
            set {
                this.observedPropertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("temporalFilter")]
        public GetResultTypeTemporalFilter[] temporalFilter {
            get {
                return this.temporalFilterField;
            }
            set {
                this.temporalFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterest", DataType="anyURI")]
        public string[] featureOfInterest {
            get {
                return this.featureOfInterestField;
            }
            set {
                this.featureOfInterestField = value;
            }
        }
        
        /// <remarks/>
        public GetResultTypeSpatialFilter spatialFilter {
            get {
                return this.spatialFilterField;
            }
            set {
                this.spatialFilterField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultTypeTemporalFilter {
        
        private BinaryTemporalOpType itemField;
        
        private ItemChoiceType20 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("After", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("AnyInteracts", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Before", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Begins", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("BegunBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("During", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("EndedBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Ends", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Meets", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("MetBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("OverlappedBy", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TContains", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TEquals", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TOverlaps", typeof(BinaryTemporalOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public BinaryTemporalOpType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType20 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0", IncludeInSchema=false)]
    public enum ItemChoiceType20 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:After")]
        After,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:AnyInteracts")]
        AnyInteracts,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Before")]
        Before,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Begins")]
        Begins,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:BegunBy")]
        BegunBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:During")]
        During,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:EndedBy")]
        EndedBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Ends")]
        Ends,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Meets")]
        Meets,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:MetBy")]
        MetBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:OverlappedBy")]
        OverlappedBy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:TContains")]
        TContains,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:TEquals")]
        TEquals,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:TOverlaps")]
        TOverlaps,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultTypeSpatialFilter {
        
        private SpatialOpsType itemField;
        
        private ItemChoiceType21 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BBOX", typeof(BBOXType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Beyond", typeof(DistanceBufferType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Contains", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Crosses", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DWithin", typeof(DistanceBufferType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Disjoint", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Equals", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Intersects", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Overlaps", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Touches", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Within", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public SpatialOpsType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType21 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0", IncludeInSchema=false)]
    public enum ItemChoiceType21 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:BBOX")]
        BBOX,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Beyond")]
        Beyond,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Contains")]
        Contains,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Crosses")]
        Crosses,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:DWithin")]
        DWithin,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Disjoint")]
        Disjoint,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Equals")]
        Equals,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Intersects")]
        Intersects,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Overlaps")]
        Overlaps,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Touches")]
        Touches,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.opengis.net/fes/2.0:Within")]
        Within,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class CapabilitiesPropertyType {
        
        private CapabilitiesType capabilitiesField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public CapabilitiesType Capabilities {
            get {
                return this.capabilitiesField;
            }
            set {
                this.capabilitiesField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Capabilities", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class CapabilitiesType : CapabilitiesBaseType {
        
        private object[] extensionField;
        
        private CapabilitiesTypeFilterCapabilities filterCapabilitiesField;
        
        private CapabilitiesTypeContents contentsField;
        
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
        public CapabilitiesTypeFilterCapabilities filterCapabilities {
            get {
                return this.filterCapabilitiesField;
            }
            set {
                this.filterCapabilitiesField = value;
            }
        }
        
        /// <remarks/>
        public CapabilitiesTypeContents contents {
            get {
                return this.contentsField;
            }
            set {
                this.contentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class CapabilitiesTypeFilterCapabilities {
        
        private Filter_Capabilities filter_CapabilitiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/fes/2.0")]
        public Filter_Capabilities Filter_Capabilities {
            get {
                return this.filter_CapabilitiesField;
            }
            set {
                this.filter_CapabilitiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class CapabilitiesTypeContents {
        
        private ContentsType contentsField;
        
        /// <remarks/>
        public ContentsType Contents {
            get {
                return this.contentsField;
            }
            set {
                this.contentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetCapabilitiesPropertyType {
        
        private GetCapabilitiesType1 getCapabilitiesField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetCapabilitiesType1 GetCapabilities {
            get {
                return this.getCapabilitiesField;
            }
            set {
                this.getCapabilitiesField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="GetCapabilitiesType", Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class GetCapabilitiesType1 : GetCapabilitiesType {
        
        private object[] extensionField;
        
        private string serviceField;
        
        public GetCapabilitiesType1() {
            this.serviceField = "SOS";
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("SOS")]
        public string service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class SosInsertionMetadataPropertyType {
        
        private SosInsertionMetadataType sosInsertionMetadataField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public SosInsertionMetadataType SosInsertionMetadata {
            get {
                return this.sosInsertionMetadataField;
            }
            set {
                this.sosInsertionMetadataField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultTemplatePropertyType {
        
        private GetResultTemplateType getResultTemplateField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetResultTemplateType GetResultTemplate {
            get {
                return this.getResultTemplateField;
            }
            set {
                this.getResultTemplateField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultTemplateResponsePropertyType {
        
        private GetResultTemplateResponseType getResultTemplateResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetResultTemplateResponseType GetResultTemplateResponse {
            get {
                return this.getResultTemplateResponseField;
            }
            set {
                this.getResultTemplateResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationByIdPropertyType {
        
        private GetObservationByIdType getObservationByIdField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetObservationByIdType GetObservationById {
            get {
                return this.getObservationByIdField;
            }
            set {
                this.getObservationByIdField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationByIdResponsePropertyType {
        
        private GetObservationByIdResponseType getObservationByIdResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetObservationByIdResponseType GetObservationByIdResponse {
            get {
                return this.getObservationByIdResponseField;
            }
            set {
                this.getObservationByIdResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertObservationPropertyType {
        
        private InsertObservationType insertObservationField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertObservationType InsertObservation {
            get {
                return this.insertObservationField;
            }
            set {
                this.insertObservationField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertObservationResponsePropertyType {
        
        private InsertObservationResponseType insertObservationResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertObservationResponseType InsertObservationResponse {
            get {
                return this.insertObservationResponseField;
            }
            set {
                this.insertObservationResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertResultTemplateResponsePropertyType {
        
        private InsertResultTemplateResponseType insertResultTemplateResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertResultTemplateResponseType InsertResultTemplateResponse {
            get {
                return this.insertResultTemplateResponseField;
            }
            set {
                this.insertResultTemplateResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class InsertResultTemplatePropertyType {
        
        private InsertResultTemplateType insertResultTemplateField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public InsertResultTemplateType InsertResultTemplate {
            get {
                return this.insertResultTemplateField;
            }
            set {
                this.insertResultTemplateField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ResultTemplatePropertyType {
        
        private ResultTemplateType resultTemplateField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public ResultTemplateType ResultTemplate {
            get {
                return this.resultTemplateField;
            }
            set {
                this.resultTemplateField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetFeatureOfInterestResponsePropertyType {
        
        private GetFeatureOfInterestResponseType getFeatureOfInterestResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetFeatureOfInterestResponseType GetFeatureOfInterestResponse {
            get {
                return this.getFeatureOfInterestResponseField;
            }
            set {
                this.getFeatureOfInterestResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetFeatureOfInterestPropertyType {
        
        private GetFeatureOfInterestType getFeatureOfInterestField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetFeatureOfInterestType GetFeatureOfInterest {
            get {
                return this.getFeatureOfInterestField;
            }
            set {
                this.getFeatureOfInterestField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationResponsePropertyType {
        
        private GetObservationResponseType getObservationResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetObservationResponseType GetObservationResponse {
            get {
                return this.getObservationResponseField;
            }
            set {
                this.getObservationResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetObservationPropertyType {
        
        private GetObservationType getObservationField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetObservationType GetObservation {
            get {
                return this.getObservationField;
            }
            set {
                this.getObservationField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultResponsePropertyType {
        
        private GetResultResponseType getResultResponseField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetResultResponseType GetResultResponse {
            get {
                return this.getResultResponseField;
            }
            set {
                this.getResultResponseField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class GetResultPropertyType {
        
        private GetResultType getResultField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GetResultType GetResult {
            get {
                return this.getResultField;
            }
            set {
                this.getResultField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ContentsPropertyType {
        
        private ContentsType contentsField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public ContentsType Contents {
            get {
                return this.contentsField;
            }
            set {
                this.contentsField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ObservationOfferingPropertyType {
        
        private ObservationOfferingType observationOfferingField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public ObservationOfferingType ObservationOffering {
            get {
                return this.observationOfferingField;
            }
            set {
                this.observationOfferingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ObservationOfferingTypePhenomenonTime {
        
        private TimePeriodType timePeriodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public TimePeriodType TimePeriod {
            get {
                return this.timePeriodField;
            }
            set {
                this.timePeriodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class ObservationOfferingTypeResultTime {
        
        private TimePeriodType timePeriodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml/3.2")]
        public TimePeriodType TimePeriod {
            get {
                return this.timePeriodField;
            }
            set {
                this.timePeriodField = value;
            }
        }
    }
}
