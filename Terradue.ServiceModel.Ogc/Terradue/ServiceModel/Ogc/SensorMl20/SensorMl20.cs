using Terradue.ServiceModel.Ogc.Gmd;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Swe20;

namespace Terradue.ServiceModel.Ogc.SensorMl20
{


    

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ProcessMethodPropertyType
    {

        private ProcessMethodType processMethodField;

        /// <remarks/>
        public ProcessMethodType ProcessMethod
        {
            get
            {
                return this.processMethodField;
            }
            set
            {
                this.processMethodField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ProcessMethod", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ProcessMethodType : AbstractSWEIdentifiableType
    {

        private ProcessMethodTypeAlgorithm[] algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("algorithm")]
        public ProcessMethodTypeAlgorithm[] algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ProcessMethodTypeAlgorithm
    {

        private AbstractAlgorithmType abstractAlgorithmField;

        /// <remarks/>
        public AbstractAlgorithmType AbstractAlgorithm
        {
            get
            {
                return this.abstractAlgorithmField;
            }
            set
            {
                this.abstractAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractAlgorithm", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public abstract partial class AbstractAlgorithmType
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class LinkPropertyType
    {

        private LinkType linkField;

        /// <remarks/>
        public LinkType Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Link", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class LinkType
    {

        private DataComponentRefPropertyType sourceField;

        private DataComponentRefPropertyType destinationField;

        private string idField;

        /// <remarks/>
        public DataComponentRefPropertyType source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public DataComponentRefPropertyType destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DataComponentRefPropertyType
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AggregateProcessPropertyType
    {

        private AggregateProcessType aggregateProcessField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public AggregateProcessPropertyType()
        {
            this.ownsField = false;
        }

        /// <remarks/>
        public AggregateProcessType AggregateProcess
        {
            get
            {
                return this.aggregateProcessField;
            }
            set
            {
                this.aggregateProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AggregateProcess", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class AggregateProcessType : AbstractProcessType
    {

        private ComponentListPropertyType componentsField;

        private ConnectionListPropertyType connectionsField;

        /// <remarks/>
        public ComponentListPropertyType components
        {
            get
            {
                return this.componentsField;
            }
            set
            {
                this.componentsField = value;
            }
        }

        /// <remarks/>
        public ConnectionListPropertyType connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ComponentListPropertyType
    {

        private ComponentListType componentListField;

        /// <remarks/>
        public ComponentListType ComponentList
        {
            get
            {
                return this.componentListField;
            }
            set
            {
                this.componentListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ComponentList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ComponentListType : AbstractSWEType
    {

        private ComponentListTypeComponent[] componentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("component")]
        public ComponentListTypeComponent[] component
        {
            get
            {
                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ComponentListTypeComponent : AbstractProcessPropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractProcessPropertyType
    {

        private AbstractProcessType itemField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public AbstractProcessPropertyType()
        {
            this.ownsField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AggregateProcess", typeof(AggregateProcessType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleProcess", typeof(SimpleProcessType))]
        public AbstractProcessType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ConnectionList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ConnectionListType : AbstractSWEType
    {

        private ConnectionListTypeConnection[] connectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connection")]
        public ConnectionListTypeConnection[] connection
        {
            get
            {
                return this.connectionField;
            }
            set
            {
                this.connectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ConnectionListTypeConnection
    {

        private LinkType linkField;

        /// <remarks/>
        public LinkType Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModeChoiceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractModes", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class AbstractModesType : AbstractSWEType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ModeChoice", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ModeChoiceType : AbstractModesType
    {

        private ModePropertyType[] modeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mode")]
        public ModePropertyType[] mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ModePropertyType
    {

        private ModeType modeField;

        /// <remarks/>
        public ModeType Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Mode", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ModeType : DescribedObjectType
    {

        private SettingsPropertyType configurationField;

        /// <remarks/>
        public SettingsPropertyType configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class SettingsPropertyType
    {

        private SettingsType settingsField;

        /// <remarks/>
        public SettingsType Settings
        {
            get
            {
                return this.settingsField;
            }
            set
            {
                this.settingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Settings", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class SettingsType : AbstractSettingsType
    {

        private ValueSettingPropertyType[] setValueField;

        private ArraySettingPropertyType[] setArrayValuesField;

        private ConstraintSettingPropertyType[] setConstraintField;

        private ModeSettingPropertyType[] setModeField;

        private StatusSettingPropertyType[] setStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setValue")]
        public ValueSettingPropertyType[] setValue
        {
            get
            {
                return this.setValueField;
            }
            set
            {
                this.setValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setArrayValues")]
        public ArraySettingPropertyType[] setArrayValues
        {
            get
            {
                return this.setArrayValuesField;
            }
            set
            {
                this.setArrayValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setConstraint")]
        public ConstraintSettingPropertyType[] setConstraint
        {
            get
            {
                return this.setConstraintField;
            }
            set
            {
                this.setConstraintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setMode")]
        public ModeSettingPropertyType[] setMode
        {
            get
            {
                return this.setModeField;
            }
            set
            {
                this.setModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setStatus")]
        public StatusSettingPropertyType[] setStatus
        {
            get
            {
                return this.setStatusField;
            }
            set
            {
                this.setStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ValueSettingPropertyType
    {

        private string refField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "token")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ArraySettingPropertyType
    {

        private ArraySettingPropertyTypeArrayValues arrayValuesField;

        private string refField;

        /// <remarks/>
        public ArraySettingPropertyTypeArrayValues ArrayValues
        {
            get
            {
                return this.arrayValuesField;
            }
            set
            {
                this.arrayValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ArraySettingPropertyTypeArrayValues
    {

        private ArraySettingPropertyTypeArrayValuesEncoding encodingField;

        private EncodedValuesPropertyType valueField;

        /// <remarks/>
        public ArraySettingPropertyTypeArrayValuesEncoding encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }

        /// <remarks/>
        public EncodedValuesPropertyType value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ArraySettingPropertyTypeArrayValuesEncoding
    {

        private AbstractEncodingType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryEncoding", typeof(BinaryEncodingType), Namespace = "http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("TextEncoding", typeof(TextEncodingType), Namespace = "http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("XMLEncoding", typeof(XMLEncodingType), Namespace = "http://www.opengis.net/swe/2.0")]
        public AbstractEncodingType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ConstraintSettingPropertyType
    {

        private AllowedTimesType allowedTimesField;

        private AllowedTokensType allowedTokensField;

        private AllowedValuesType allowedValuesField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public AllowedTimesType AllowedTimes
        {
            get
            {
                return this.allowedTimesField;
            }
            set
            {
                this.allowedTimesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public AllowedTokensType AllowedTokens
        {
            get
            {
                return this.allowedTokensField;
            }
            set
            {
                this.allowedTokensField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public AllowedValuesType AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ModeSettingPropertyType
    {

        private string refField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "NCName")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class StatusSettingPropertyType
    {

        private string refField;

        private StatusType valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public StatusType Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public enum StatusType
    {

        /// <remarks/>
        enabled,

        /// <remarks/>
        disabled,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SettingsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractSettings", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class AbstractSettingsType : AbstractSWEType
    {
    }

    

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class KeywordListPropertyType
    {

        private KeywordListType keywordListField;

        /// <remarks/>
        public KeywordListType KeywordList
        {
            get
            {
                return this.keywordListField;
            }
            set
            {
                this.keywordListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("KeywordList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class KeywordListType : AbstractMetadataListType
    {

        private Reference codeSpaceField;

        private string[] keywordField;

        /// <remarks/>
        public Reference codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keyword")]
        public string[] keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClassifierListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EventListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilityListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CharacteristicListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifierListType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractMetadataList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class AbstractMetadataListType : AbstractSWEIdentifiableType
    {

        private string definitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SpatialFrame", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class SpatialFrameType : AbstractSWEIdentifiableType
    {

        private string originField;

        private SpatialFrameTypeAxis[] axisField;

        /// <remarks/>
        public string origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("axis")]
        public SpatialFrameTypeAxis[] axis
        {
            get
            {
                return this.axisField;
            }
            set
            {
                this.axisField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class SpatialFrameTypeAxis
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("TemporalFrame", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class TemporalFrameType : AbstractSWEIdentifiableType
    {

        private string originField;

        /// <remarks/>
        public string origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ObservableProperty", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ObservablePropertyType : AbstractSWEIdentifiableType
    {

        private string definitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataInterface", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class DataInterfaceType : AbstractSWEIdentifiableType
    {

        private DataStreamPropertyType dataField;

        private DataRecordPropertyType interfaceParametersField;

        /// <remarks/>
        public DataStreamPropertyType data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        public DataRecordPropertyType interfaceParameters
        {
            get
            {
                return this.interfaceParametersField;
            }
            set
            {
                this.interfaceParametersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Event", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class EventType : AbstractSWEIdentifiableType
    {

        private MD_Keywords_PropertyType[] keywordsField;

        private IdentifierListPropertyType[] identificationField;

        private ClassifierListPropertyType[] classificationField;

        private ContactListPropertyType[] contactsField;

        private DocumentListPropertyType[] documentationField;

        private EventTypeTime timeField;

        private AbstractDataComponentPropertyType[] propertyField;

        private EventTypeConfiguration configurationField;

        private string definitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywords")]
        public MD_Keywords_PropertyType[] keywords
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
        public EventTypeTime time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public AbstractDataComponentPropertyType[] property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        public EventTypeConfiguration configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class IdentifierListPropertyType
    {

        private IdentifierListType identifierListField;

        /// <remarks/>
        public IdentifierListType IdentifierList
        {
            get
            {
                return this.identifierListField;
            }
            set
            {
                this.identifierListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("IdentifierList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class IdentifierListType : AbstractMetadataListType
    {

        private IdentifierListTypeIdentifier[] identifier1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("identifier")]
        public IdentifierListTypeIdentifier[] identifier1
        {
            get
            {
                return this.identifier1Field;
            }
            set
            {
                this.identifier1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class IdentifierListTypeIdentifier
    {

        private TermType termField;

        /// <remarks/>
        public TermType Term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Term", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class TermType : AbstractSWEType
    {

        private string labelField;

        private Reference codeSpaceField;

        private string valueField;

        private string definitionField;

        /// <remarks/>
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public Reference codeSpace
        {
            get
            {
                return this.codeSpaceField;
            }
            set
            {
                this.codeSpaceField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ClassifierListPropertyType
    {

        private ClassifierListType classifierListField;

        /// <remarks/>
        public ClassifierListType ClassifierList
        {
            get
            {
                return this.classifierListField;
            }
            set
            {
                this.classifierListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ClassifierList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ClassifierListType : AbstractMetadataListType
    {

        private ClassifierListTypeClassifier[] classifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("classifier")]
        public ClassifierListTypeClassifier[] classifier
        {
            get
            {
                return this.classifierField;
            }
            set
            {
                this.classifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ClassifierListTypeClassifier
    {

        private TermType termField;

        /// <remarks/>
        public TermType Term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ContactListPropertyType
    {

        private ContactListType contactListField;

        /// <remarks/>
        public ContactListType ContactList
        {
            get
            {
                return this.contactListField;
            }
            set
            {
                this.contactListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ContactList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ContactListType : AbstractMetadataListType
    {

        private CI_ResponsibleParty_PropertyType[] contactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public CI_ResponsibleParty_PropertyType[] contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DocumentListPropertyType
    {

        private DocumentListType documentListField;

        /// <remarks/>
        public DocumentListType DocumentList
        {
            get
            {
                return this.documentListField;
            }
            set
            {
                this.documentListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class DocumentListType : AbstractMetadataListType
    {

        private CI_OnlineResource_PropertyType[] documentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("document")]
        public CI_OnlineResource_PropertyType[] document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class EventTypeTime
    {

        private TimePeriodType timePeriodField;

        private TimeInstantType timeInstantField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
        public TimePeriodType TimePeriod
        {
            get
            {
                return this.timePeriodField;
            }
            set
            {
                this.timePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
        public TimeInstantType TimeInstant
        {
            get
            {
                return this.timeInstantField;
            }
            set
            {
                this.timeInstantField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class EventTypeConfiguration
    {

        private AbstractSettingsType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractSettings", typeof(AbstractSettingsType))]
        [System.Xml.Serialization.XmlElementAttribute("Settings", typeof(SettingsType))]
        public AbstractSettingsType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("EventList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class EventListType : AbstractMetadataListType
    {

        private EventPropertyType[] eventField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("event")]
        public EventPropertyType[] @event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class EventPropertyType
    {

        private EventType eventField;

        /// <remarks/>
        public EventType Event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CapabilityList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class CapabilityListType : AbstractMetadataListType
    {

        private CapabilityListTypeCapability[] capabilityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("capability")]
        public CapabilityListTypeCapability[] capability
        {
            get
            {
                return this.capabilityField;
            }
            set
            {
                this.capabilityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class CapabilityListTypeCapability : AbstractDataComponentPropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class FeatureListType : AbstractMetadataListType
    {

        private FeaturePropertyType[] featureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("feature")]
        public FeaturePropertyType[] feature
        {
            get
            {
                return this.featureField;
            }
            set
            {
                this.featureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CharacteristicList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class CharacteristicListType : AbstractMetadataListType
    {

        private CharacteristicListTypeCharacteristic[] characteristicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("characteristic")]
        public CharacteristicListTypeCharacteristic[] characteristic
        {
            get
            {
                return this.characteristicField;
            }
            set
            {
                this.characteristicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class CharacteristicListTypeCharacteristic : AbstractDataComponentPropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DescribedObjectTypeValidTime
    {

        private TimePeriodType timePeriodField;

        private TimeInstantType timeInstantField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
        public TimePeriodType TimePeriod
        {
            get
            {
                return this.timePeriodField;
            }
            set
            {
                this.timePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
        public TimeInstantType TimeInstant
        {
            get
            {
                return this.timeInstantField;
            }
            set
            {
                this.timeInstantField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DescribedObjectTypeCharacteristics : CharacteristicListPropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class CharacteristicListPropertyType
    {

        private CharacteristicListType characteristicListField;

        /// <remarks/>
        public CharacteristicListType CharacteristicList
        {
            get
            {
                return this.characteristicListField;
            }
            set
            {
                this.characteristicListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DescribedObjectTypeCapabilities : CapabilityListPropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class CapabilityListPropertyType
    {

        private CapabilityListType capabilityListField;

        /// <remarks/>
        public CapabilityListType CapabilityList
        {
            get
            {
                return this.capabilityListField;
            }
            set
            {
                this.capabilityListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class EventListPropertyType
    {

        private EventListType eventListField;

        /// <remarks/>
        public EventListType EventList
        {
            get
            {
                return this.eventListField;
            }
            set
            {
                this.eventListField = value;
            }
        }
    }

    

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractProcessTypeConfiguration
    {

        private AbstractSettingsType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractSettings", typeof(AbstractSettingsType))]
        [System.Xml.Serialization.XmlElementAttribute("Settings", typeof(SettingsType))]
        public AbstractSettingsType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractProcessTypeFeaturesOfInterest
    {

        private FeatureListType featureListField;

        /// <remarks/>
        public FeatureListType FeatureList
        {
            get
            {
                return this.featureListField;
            }
            set
            {
                this.featureListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractProcessTypeInputs
    {

        private InputListType inputListField;

        /// <remarks/>
        public InputListType InputList
        {
            get
            {
                return this.inputListField;
            }
            set
            {
                this.inputListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("InputList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class InputListType : AbstractSWEType
    {

        private InputListTypeInput[] inputField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public InputListTypeInput[] input
        {
            get
            {
                return this.inputField;
            }
            set
            {
                this.inputField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class InputListTypeInput : DataComponentOrObservablePropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DataComponentOrObservablePropertyType
    {

        private AbstractDataComponentType itemField;

        private ObservablePropertyType observablePropertyField;

        private DataInterfaceType dataInterfaceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataArray", typeof(DataArrayType), Namespace = "http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DataChoice", typeof(DataChoiceType), Namespace = "http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DataRecord", typeof(DataRecordType), Namespace = "http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Vector", typeof(Swe20.VectorType), Namespace = "http://www.opengis.net/swe/2.0")]
        public AbstractDataComponentType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public ObservablePropertyType ObservableProperty
        {
            get
            {
                return this.observablePropertyField;
            }
            set
            {
                this.observablePropertyField = value;
            }
        }

        /// <remarks/>
        public DataInterfaceType DataInterface
        {
            get
            {
                return this.dataInterfaceField;
            }
            set
            {
                this.dataInterfaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractProcessTypeOutputs
    {

        private OutputListType outputListField;

        /// <remarks/>
        public OutputListType OutputList
        {
            get
            {
                return this.outputListField;
            }
            set
            {
                this.outputListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("OutputList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class OutputListType : AbstractSWEType
    {

        private OutputListTypeOutput[] outputField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("output")]
        public OutputListTypeOutput[] output
        {
            get
            {
                return this.outputField;
            }
            set
            {
                this.outputField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class OutputListTypeOutput : DataComponentOrObservablePropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractProcessTypeParameters
    {

        private ParameterListType parameterListField;

        /// <remarks/>
        public ParameterListType ParameterList
        {
            get
            {
                return this.parameterListField;
            }
            set
            {
                this.parameterListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ParameterList", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class ParameterListType : AbstractSWEType
    {

        private ParameterListTypeParameter[] parameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public ParameterListTypeParameter[] parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ParameterListTypeParameter : DataComponentOrObservablePropertyType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractProcessTypeModes
    {

        private AbstractModesType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractModes", typeof(AbstractModesType))]
        [System.Xml.Serialization.XmlElementAttribute("ModeChoice", typeof(ModeChoiceType))]
        public AbstractModesType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalSystemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractPhysicalProcess", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public abstract partial class AbstractPhysicalProcessType : AbstractProcessType
    {

        private ReferenceType attachedToField;

        private AbstractPhysicalProcessTypeLocalReferenceFrame[] localReferenceFrameField;

        private AbstractPhysicalProcessTypeLocalTimeFrame[] localTimeFrameField;

        private PositionUnionPropertyType[] positionField;

        private TimePropertyType[] timePositionField;

        /// <remarks/>
        public ReferenceType attachedTo
        {
            get
            {
                return this.attachedToField;
            }
            set
            {
                this.attachedToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("localReferenceFrame")]
        public AbstractPhysicalProcessTypeLocalReferenceFrame[] localReferenceFrame
        {
            get
            {
                return this.localReferenceFrameField;
            }
            set
            {
                this.localReferenceFrameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("localTimeFrame")]
        public AbstractPhysicalProcessTypeLocalTimeFrame[] localTimeFrame
        {
            get
            {
                return this.localTimeFrameField;
            }
            set
            {
                this.localTimeFrameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("position")]
        public PositionUnionPropertyType[] position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timePosition")]
        public TimePropertyType[] timePosition
        {
            get
            {
                return this.timePositionField;
            }
            set
            {
                this.timePositionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractPhysicalProcessTypeLocalReferenceFrame
    {

        private SpatialFrameType spatialFrameField;

        /// <remarks/>
        public SpatialFrameType SpatialFrame
        {
            get
            {
                return this.spatialFrameField;
            }
            set
            {
                this.spatialFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractPhysicalProcessTypeLocalTimeFrame
    {

        private TemporalFrameType temporalFrameField;

        /// <remarks/>
        public TemporalFrameType TemporalFrame
        {
            get
            {
                return this.temporalFrameField;
            }
            set
            {
                this.temporalFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class PositionUnionPropertyType
    {

        private TextType textField;

        private PointType pointField;

        private Swe20.VectorType vectorField;

        private DataRecordType dataRecordField;

        private DataArrayType itemField;

        private AbstractProcessType item1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public TextType Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
        public PointType Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public Swe20.VectorType Vector
        {
            get
            {
                return this.vectorField;
            }
            set
            {
                this.vectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public DataRecordType DataRecord
        {
            get
            {
                return this.dataRecordField;
            }
            set
            {
                this.dataRecordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataArray", typeof(DataArrayType), Namespace = "http://www.opengis.net/swe/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Matrix", typeof(MatrixType), Namespace = "http://www.opengis.net/swe/2.0")]
        public DataArrayType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AggregateProcess", typeof(AggregateProcessType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleProcess", typeof(SimpleProcessType))]
        public AbstractProcessType Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PhysicalComponent", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class PhysicalComponentType : AbstractPhysicalProcessType
    {

        private ProcessMethodPropertyType methodField;

        /// <remarks/>
        public ProcessMethodPropertyType method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PhysicalSystem", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class PhysicalSystemType : AbstractPhysicalProcessType
    {

        private ComponentListPropertyType componentsField;

        private ConnectionListPropertyType connectionsField;

        /// <remarks/>
        public ComponentListPropertyType components
        {
            get
            {
                return this.componentsField;
            }
            set
            {
                this.componentsField = value;
            }
        }

        /// <remarks/>
        public ConnectionListPropertyType connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ConnectionListPropertyType
    {

        private ConnectionListType connectionListField;

        /// <remarks/>
        public ConnectionListType ConnectionList
        {
            get
            {
                return this.connectionListField;
            }
            set
            {
                this.connectionListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class SpatialFramePropertyType
    {

        private SpatialFrameType spatialFrameField;

        /// <remarks/>
        public SpatialFrameType SpatialFrame
        {
            get
            {
                return this.spatialFrameField;
            }
            set
            {
                this.spatialFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class TemporalFramePropertyType
    {

        private TemporalFrameType temporalFrameField;

        /// <remarks/>
        public TemporalFrameType TemporalFrame
        {
            get
            {
                return this.temporalFrameField;
            }
            set
            {
                this.temporalFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractPhysicalProcessPropertyType
    {

        private AbstractPhysicalProcessType itemField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public AbstractPhysicalProcessPropertyType()
        {
            this.ownsField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalComponent", typeof(PhysicalComponentType))]
        [System.Xml.Serialization.XmlElementAttribute("PhysicalSystem", typeof(PhysicalSystemType))]
        public AbstractPhysicalProcessType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class PhysicalComponentPropertyType
    {

        private PhysicalComponentType physicalComponentField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public PhysicalComponentPropertyType()
        {
            this.ownsField = false;
        }

        /// <remarks/>
        public PhysicalComponentType PhysicalComponent
        {
            get
            {
                return this.physicalComponentField;
            }
            set
            {
                this.physicalComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class PhysicalSystemPropertyType
    {

        private PhysicalSystemType physicalSystemField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public PhysicalSystemPropertyType()
        {
            this.ownsField = false;
        }

        /// <remarks/>
        public PhysicalSystemType PhysicalSystem
        {
            get
            {
                return this.physicalSystemField;
            }
            set
            {
                this.physicalSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ConstraintPropertyType
    {

        private AllowedTimesType allowedTimesField;

        private AllowedTokensType allowedTokensField;

        private AllowedValuesType allowedValuesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public AllowedTimesType AllowedTimes
        {
            get
            {
                return this.allowedTimesField;
            }
            set
            {
                this.allowedTimesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public AllowedTokensType AllowedTokens
        {
            get
            {
                return this.allowedTokensField;
            }
            set
            {
                this.allowedTokensField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/swe/2.0")]
        public AllowedValuesType AllowedValues
        {
            get
            {
                return this.allowedValuesField;
            }
            set
            {
                this.allowedValuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ModeChoicePropertyType
    {

        private ModeChoiceType modeChoiceField;

        /// <remarks/>
        public ModeChoiceType ModeChoice
        {
            get
            {
                return this.modeChoiceField;
            }
            set
            {
                this.modeChoiceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class TimeInstantOrPeriodPropertyType
    {

        private TimePeriodType timePeriodField;

        private TimeInstantType timeInstantField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
        public TimePeriodType TimePeriod
        {
            get
            {
                return this.timePeriodField;
            }
            set
            {
                this.timePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
        public TimeInstantType TimeInstant
        {
            get
            {
                return this.timeInstantField;
            }
            set
            {
                this.timeInstantField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ObservablePropertyPropertyType
    {

        private ObservablePropertyType observablePropertyField;

        /// <remarks/>
        public ObservablePropertyType ObservableProperty
        {
            get
            {
                return this.observablePropertyField;
            }
            set
            {
                this.observablePropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DataInterfacePropertyType
    {

        private DataInterfaceType dataInterfaceField;

        /// <remarks/>
        public DataInterfaceType DataInterface
        {
            get
            {
                return this.dataInterfaceField;
            }
            set
            {
                this.dataInterfaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractModesPropertyType
    {

        private AbstractModesType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractModes", typeof(AbstractModesType))]
        [System.Xml.Serialization.XmlElementAttribute("ModeChoice", typeof(ModeChoiceType))]
        public AbstractModesType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class ParameterListPropertyType
    {

        private ParameterListType parameterListField;

        /// <remarks/>
        public ParameterListType ParameterList
        {
            get
            {
                return this.parameterListField;
            }
            set
            {
                this.parameterListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class TermPropertyType
    {

        private TermType termField;

        /// <remarks/>
        public TermType Term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractMetadataListPropertyType
    {

        private AbstractMetadataListType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractMetadataList", typeof(AbstractMetadataListType))]
        [System.Xml.Serialization.XmlElementAttribute("CapabilityList", typeof(CapabilityListType))]
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicList", typeof(CharacteristicListType))]
        [System.Xml.Serialization.XmlElementAttribute("ClassifierList", typeof(ClassifierListType))]
        [System.Xml.Serialization.XmlElementAttribute("ContactList", typeof(ContactListType))]
        [System.Xml.Serialization.XmlElementAttribute("DocumentList", typeof(DocumentListType))]
        [System.Xml.Serialization.XmlElementAttribute("EventList", typeof(EventListType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureList", typeof(FeatureListType))]
        [System.Xml.Serialization.XmlElementAttribute("IdentifierList", typeof(IdentifierListType))]
        [System.Xml.Serialization.XmlElementAttribute("KeywordList", typeof(KeywordListType))]
        public AbstractMetadataListType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class FeatureListPropertyType
    {

        private FeatureListType featureListField;

        /// <remarks/>
        public FeatureListType FeatureList
        {
            get
            {
                return this.featureListField;
            }
            set
            {
                this.featureListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class InputListPropertyType
    {

        private InputListType inputListField;

        /// <remarks/>
        public InputListType InputList
        {
            get
            {
                return this.inputListField;
            }
            set
            {
                this.inputListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class OutputListPropertyType
    {

        private OutputListType outputListField;

        /// <remarks/>
        public OutputListType OutputList
        {
            get
            {
                return this.outputListField;
            }
            set
            {
                this.outputListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractSettingsPropertyType
    {

        private AbstractSettingsType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractSettings", typeof(AbstractSettingsType))]
        [System.Xml.Serialization.XmlElementAttribute("Settings", typeof(SettingsType))]
        public AbstractSettingsType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class DescribedObjectPropertyType
    {

        private ModeType itemField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public DescribedObjectPropertyType()
        {
            this.ownsField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mode")]
        public ModeType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class AbstractAlgorithmPropertyType
    {

        private AbstractAlgorithmType abstractAlgorithmField;

        /// <remarks/>
        public AbstractAlgorithmType AbstractAlgorithm
        {
            get
            {
                return this.abstractAlgorithmField;
            }
            set
            {
                this.abstractAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    public partial class SimpleProcessPropertyType
    {

        private SimpleProcessType simpleProcessField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public SimpleProcessPropertyType()
        {
            this.ownsField = false;
        }

        /// <remarks/>
        public SimpleProcessType SimpleProcess
        {
            get
            {
                return this.simpleProcessField;
            }
            set
            {
                this.simpleProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }
}
