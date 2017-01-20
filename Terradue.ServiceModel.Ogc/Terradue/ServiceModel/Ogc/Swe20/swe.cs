namespace Terradue.ServiceModel.Ogc.Swe20 {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataRecord", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataRecordType : AbstractDataComponentType {
        
        private DataRecordTypeField[] fieldField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("field")]
        public DataRecordTypeField[] field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataRecordTypeField : AbstractDataComponentPropertyType {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AbstractDataComponentPropertyType {
        
        private AbstractDataComponentType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataArray", typeof(DataArrayType))]
        [System.Xml.Serialization.XmlElementAttribute("DataChoice", typeof(DataChoiceType))]
        [System.Xml.Serialization.XmlElementAttribute("DataRecord", typeof(DataRecordType))]
        [System.Xml.Serialization.XmlElementAttribute("Vector", typeof(VectorType))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatrixType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataArray", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataArrayType : AbstractDataComponentType {
        
        private CountPropertyType elementCountField;
        
        private DataArrayTypeElementType elementTypeField;
        
        private DataArrayTypeEncoding encodingField;
        
        private EncodedValuesPropertyType valuesField;
        
        /// <remarks/>
        public CountPropertyType elementCount {
            get {
                return this.elementCountField;
            }
            set {
                this.elementCountField = value;
            }
        }
        
        /// <remarks/>
        public DataArrayTypeElementType elementType {
            get {
                return this.elementTypeField;
            }
            set {
                this.elementTypeField = value;
            }
        }
        
        /// <remarks/>
        public DataArrayTypeEncoding encoding {
            get {
                return this.encodingField;
            }
            set {
                this.encodingField = value;
            }
        }
        
        /// <remarks/>
        public EncodedValuesPropertyType values {
            get {
                return this.valuesField;
            }
            set {
                this.valuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class CountPropertyType {
        
        private CountType countField;
        
        /// <remarks/>
        public CountType Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Count", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class CountType : AbstractSimpleComponentType {
        
        private AllowedValuesPropertyType constraintField;
        
        private string valueField;
        
        /// <remarks/>
        public AllowedValuesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedValuesPropertyType {
        
        private AllowedValuesType allowedValuesField;
        
        /// <remarks/>
        public AllowedValuesType AllowedValues {
            get {
                return this.allowedValuesField;
            }
            set {
                this.allowedValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedValues", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class AllowedValuesType : AbstractSWEType {
        
        private double[] valueField;
        
        private string[] intervalField;
        
        private string significantFiguresField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public double[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interval")]
        public string[] interval {
            get {
                return this.intervalField;
            }
            set {
                this.intervalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string significantFigures {
            get {
                return this.significantFiguresField;
            }
            set {
                this.significantFiguresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BlockType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractEncodingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryEncodingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextEncodingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XMLEncodingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllowedTimesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NilValuesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllowedTokensType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AllowedValuesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSWEIdentifiableType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataStreamType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDataComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataChoiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatrixType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSimpleComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataRecordType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractSWE", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class AbstractSWEType {
        
        private object[] extensionField;
        
        private string idField;
        
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataChoicePropertyByValueType {
        
        private DataChoiceType dataChoiceField;
        
        /// <remarks/>
        public DataChoiceType DataChoice {
            get {
                return this.dataChoiceField;
            }
            set {
                this.dataChoiceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataChoice", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataChoiceType : AbstractDataComponentType {
        
        private DataChoiceTypeChoiceValue choiceValueField;
        
        private DataChoiceTypeItem[] itemField;
        
        /// <remarks/>
        public DataChoiceTypeChoiceValue choiceValue {
            get {
                return this.choiceValueField;
            }
            set {
                this.choiceValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public DataChoiceTypeItem[] item {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataChoiceTypeChoiceValue {
        
        private CategoryType categoryField;
        
        /// <remarks/>
        public CategoryType Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Category", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class CategoryType : AbstractSimpleComponentType {
        
        private Reference codeSpaceField;
        
        private AllowedTokensPropertyType constraintField;
        
        private string valueField;
        
        /// <remarks/>
        public Reference codeSpace {
            get {
                return this.codeSpaceField;
            }
            set {
                this.codeSpaceField = value;
            }
        }
        
        /// <remarks/>
        public AllowedTokensPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class Reference {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedTokensPropertyType {
        
        private AllowedTokensType allowedTokensField;
        
        /// <remarks/>
        public AllowedTokensType AllowedTokens {
            get {
                return this.allowedTokensField;
            }
            set {
                this.allowedTokensField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedTokens", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class AllowedTokensType : AbstractSWEType {
        
        private string[] valueField;
        
        private string patternField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public string[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public string pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractSimpleComponent", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public abstract partial class AbstractSimpleComponentType : AbstractDataComponentType {
        
        private QualityPropertyType[] qualityField;
        
        private NilValuesPropertyType nilValuesField;
        
        private string referenceFrameField;
        
        private string axisIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quality")]
        public QualityPropertyType[] quality {
            get {
                return this.qualityField;
            }
            set {
                this.qualityField = value;
            }
        }
        
        /// <remarks/>
        public NilValuesPropertyType nilValues {
            get {
                return this.nilValuesField;
            }
            set {
                this.nilValuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string referenceFrame {
            get {
                return this.referenceFrameField;
            }
            set {
                this.referenceFrameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string axisID {
            get {
                return this.axisIDField;
            }
            set {
                this.axisIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class QualityPropertyType {
        
        private QuantityType quantityField;
        
        private QuantityRangeType quantityRangeField;
        
        private CategoryType categoryField;
        
        private TextType textField;
        
        /// <remarks/>
        public QuantityType Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public QuantityRangeType QuantityRange {
            get {
                return this.quantityRangeField;
            }
            set {
                this.quantityRangeField = value;
            }
        }
        
        /// <remarks/>
        public CategoryType Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public TextType Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Quantity", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class QuantityType : AbstractSimpleComponentType {
        
        private UnitReference uomField;
        
        private AllowedValuesPropertyType constraintField;
        
        private double valueField;
        
        private bool valueFieldSpecified;
        
        /// <remarks/>
        public UnitReference uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        /// <remarks/>
        public AllowedValuesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public double value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class UnitReference {
        
        private string codeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("QuantityRange", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class QuantityRangeType : AbstractSimpleComponentType {
        
        private UnitReference uomField;
        
        private AllowedValuesPropertyType constraintField;
        
        private string valueField;
        
        /// <remarks/>
        public UnitReference uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        /// <remarks/>
        public AllowedValuesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Text", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class TextType : AbstractSimpleComponentType {
        
        private AllowedTokensPropertyType constraintField;
        
        private string valueField;
        
        /// <remarks/>
        public AllowedTokensPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class NilValuesPropertyType {
        
        private NilValuesType nilValuesField;
        
        /// <remarks/>
        public NilValuesType NilValues {
            get {
                return this.nilValuesField;
            }
            set {
                this.nilValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("NilValues", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class NilValuesType : AbstractSWEType {
        
        private NilValue[] nilValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nilValue")]
        public NilValue[] nilValue {
            get {
                return this.nilValueField;
            }
            set {
                this.nilValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class NilValue {
        
        private string reasonField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="token")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataChoiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatrixType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSimpleComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataRecordType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDataComponent", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public abstract partial class AbstractDataComponentType : AbstractSWEIdentifiableType {
        
        private bool updatableField;
        
        private bool updatableFieldSpecified;
        
        private bool optionalField;
        
        private string definitionField;
        
        public AbstractDataComponentType() {
            this.optionalField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool updatable {
            get {
                return this.updatableField;
            }
            set {
                this.updatableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool updatableSpecified {
            get {
                return this.updatableFieldSpecified;
            }
            set {
                this.updatableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool optional {
            get {
                return this.optionalField;
            }
            set {
                this.optionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string definition {
            get {
                return this.definitionField;
            }
            set {
                this.definitionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataStreamType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDataComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataChoiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatrixType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSimpleComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataRecordType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractSWEIdentifiable", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class AbstractSWEIdentifiableType : AbstractSWEType {
        
        private string identifierField;
        
        private string labelField;
        
        private string descriptionField;
        
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
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DataStream", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class DataStreamType : AbstractSWEIdentifiableType {
        
        private DataStreamTypeElementCount elementCountField;
        
        private DataStreamTypeElementType elementTypeField;
        
        private DataStreamTypeEncoding encodingField;
        
        private EncodedValuesPropertyType valuesField;
        
        /// <remarks/>
        public DataStreamTypeElementCount elementCount {
            get {
                return this.elementCountField;
            }
            set {
                this.elementCountField = value;
            }
        }
        
        /// <remarks/>
        public DataStreamTypeElementType elementType {
            get {
                return this.elementTypeField;
            }
            set {
                this.elementTypeField = value;
            }
        }
        
        /// <remarks/>
        public DataStreamTypeEncoding encoding {
            get {
                return this.encodingField;
            }
            set {
                this.encodingField = value;
            }
        }
        
        /// <remarks/>
        public EncodedValuesPropertyType values {
            get {
                return this.valuesField;
            }
            set {
                this.valuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataStreamTypeElementCount {
        
        private CountType countField;
        
        /// <remarks/>
        public CountType Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataStreamTypeElementType : AbstractDataComponentPropertyType {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataStreamTypeEncoding {
        
        private AbstractEncodingType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryEncoding", typeof(BinaryEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("TextEncoding", typeof(TextEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLEncoding", typeof(XMLEncodingType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("BinaryEncoding", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class BinaryEncodingType : AbstractEncodingType {
        
        private BinaryEncodingTypeMember[] memberField;
        
        private ByteOrderType byteOrderField;
        
        private ByteEncodingType byteEncodingField;
        
        private string byteLengthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public BinaryEncodingTypeMember[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ByteOrderType byteOrder {
            get {
                return this.byteOrderField;
            }
            set {
                this.byteOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ByteEncodingType byteEncoding {
            get {
                return this.byteEncodingField;
            }
            set {
                this.byteEncodingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string byteLength {
            get {
                return this.byteLengthField;
            }
            set {
                this.byteLengthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class BinaryEncodingTypeMember {
        
        private ComponentType componentField;
        
        private BlockType blockField;
        
        /// <remarks/>
        public ComponentType Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        
        /// <remarks/>
        public BlockType Block {
            get {
                return this.blockField;
            }
            set {
                this.blockField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Component", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class ComponentType : AbstractSWEType {
        
        private string encryptionField;
        
        private string significantBitsField;
        
        private string bitLengthField;
        
        private string byteLengthField;
        
        private string dataTypeField;
        
        private string refField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string encryption {
            get {
                return this.encryptionField;
            }
            set {
                this.encryptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string significantBits {
            get {
                return this.significantBitsField;
            }
            set {
                this.significantBitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string bitLength {
            get {
                return this.bitLengthField;
            }
            set {
                this.bitLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string byteLength {
            get {
                return this.byteLengthField;
            }
            set {
                this.byteLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string dataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Block", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class BlockType : AbstractSWEType {
        
        private string compressionField;
        
        private string encryptionField;
        
        private string paddingBytesafterField;
        
        private string paddingBytesbeforeField;
        
        private string byteLengthField;
        
        private string refField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string compression {
            get {
                return this.compressionField;
            }
            set {
                this.compressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string encryption {
            get {
                return this.encryptionField;
            }
            set {
                this.encryptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBytes-after", DataType="integer")]
        public string paddingBytesafter {
            get {
                return this.paddingBytesafterField;
            }
            set {
                this.paddingBytesafterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBytes-before", DataType="integer")]
        public string paddingBytesbefore {
            get {
                return this.paddingBytesbeforeField;
            }
            set {
                this.paddingBytesbeforeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string byteLength {
            get {
                return this.byteLengthField;
            }
            set {
                this.byteLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public enum ByteOrderType {
        
        /// <remarks/>
        bigEndian,
        
        /// <remarks/>
        littleEndian,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public enum ByteEncodingType {
        
        /// <remarks/>
        base64,
        
        /// <remarks/>
        raw,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryEncodingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextEncodingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XMLEncodingType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractEncoding", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public abstract partial class AbstractEncodingType : AbstractSWEType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("TextEncoding", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class TextEncodingType : AbstractEncodingType {
        
        private bool collapseWhiteSpacesField;
        
        private string decimalSeparatorField;
        
        private string tokenSeparatorField;
        
        private string blockSeparatorField;
        
        public TextEncodingType() {
            this.collapseWhiteSpacesField = true;
            this.decimalSeparatorField = ".";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool collapseWhiteSpaces {
            get {
                return this.collapseWhiteSpacesField;
            }
            set {
                this.collapseWhiteSpacesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(".")]
        public string decimalSeparator {
            get {
                return this.decimalSeparatorField;
            }
            set {
                this.decimalSeparatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tokenSeparator {
            get {
                return this.tokenSeparatorField;
            }
            set {
                this.tokenSeparatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string blockSeparator {
            get {
                return this.blockSeparatorField;
            }
            set {
                this.blockSeparatorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("XMLEncoding", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class XMLEncodingType : AbstractEncodingType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class EncodedValuesPropertyType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Vector", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class VectorType : AbstractDataComponentType {
        
        private VectorTypeCoordinate[] coordinateField;
        
        private string referenceFrameField;
        
        private string localFrameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinate")]
        public VectorTypeCoordinate[] coordinate {
            get {
                return this.coordinateField;
            }
            set {
                this.coordinateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string referenceFrame {
            get {
                return this.referenceFrameField;
            }
            set {
                this.referenceFrameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string localFrame {
            get {
                return this.localFrameField;
            }
            set {
                this.localFrameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class VectorTypeCoordinate : AnyNumericalPropertyType {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AnyNumericalPropertyType {
        
        private CountType countField;
        
        private QuantityType quantityField;
        
        private TimeType timeField;
        
        /// <remarks/>
        public CountType Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public QuantityType Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public TimeType Time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Time", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class TimeType : AbstractSimpleComponentType {
        
        private UnitReference uomField;
        
        private AllowedTimesPropertyType constraintField;
        
        private string valueField;
        
        private System.DateTime referenceTimeField;
        
        private bool referenceTimeFieldSpecified;
        
        private string localFrameField;
        
        /// <remarks/>
        public UnitReference uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        /// <remarks/>
        public AllowedTimesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceTimeSpecified {
            get {
                return this.referenceTimeFieldSpecified;
            }
            set {
                this.referenceTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string localFrame {
            get {
                return this.localFrameField;
            }
            set {
                this.localFrameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedTimesPropertyType {
        
        private AllowedTimesType allowedTimesField;
        
        /// <remarks/>
        public AllowedTimesType AllowedTimes {
            get {
                return this.allowedTimesField;
            }
            set {
                this.allowedTimesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AllowedTimes", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class AllowedTimesType : AbstractSWEType {
        
        private string[] valueField;
        
        private string[] intervalField;
        
        private string significantFiguresField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public string[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interval")]
        public string[] interval {
            get {
                return this.intervalField;
            }
            set {
                this.intervalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string significantFigures {
            get {
                return this.significantFiguresField;
            }
            set {
                this.significantFiguresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CountRange", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class CountRangeType : AbstractSimpleComponentType {
        
        private AllowedValuesPropertyType constraintField;
        
        private string valueField;
        
        /// <remarks/>
        public AllowedValuesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Boolean", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class BooleanType : AbstractSimpleComponentType {
        
        private bool valueField;
        
        private bool valueFieldSpecified;
        
        /// <remarks/>
        public bool value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueSpecified {
            get {
                return this.valueFieldSpecified;
            }
            set {
                this.valueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("TimeRange", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class TimeRangeType : AbstractSimpleComponentType {
        
        private UnitReference uomField;
        
        private AllowedTimesPropertyType constraintField;
        
        private string valueField;
        
        private System.DateTime referenceTimeField;
        
        private bool referenceTimeFieldSpecified;
        
        private string localFrameField;
        
        /// <remarks/>
        public UnitReference uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        /// <remarks/>
        public AllowedTimesPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime referenceTime {
            get {
                return this.referenceTimeField;
            }
            set {
                this.referenceTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referenceTimeSpecified {
            get {
                return this.referenceTimeFieldSpecified;
            }
            set {
                this.referenceTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string localFrame {
            get {
                return this.localFrameField;
            }
            set {
                this.localFrameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("CategoryRange", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class CategoryRangeType : AbstractSimpleComponentType {
        
        private Reference codeSpaceField;
        
        private AllowedTokensPropertyType constraintField;
        
        private string valueField;
        
        /// <remarks/>
        public Reference codeSpace {
            get {
                return this.codeSpaceField;
            }
            set {
                this.codeSpaceField = value;
            }
        }
        
        /// <remarks/>
        public AllowedTokensPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataChoiceTypeItem : AbstractDataComponentPropertyType {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataChoicePropertyType {
        
        private DataChoiceType dataChoiceField;
        
        /// <remarks/>
        public DataChoiceType DataChoice {
            get {
                return this.dataChoiceField;
            }
            set {
                this.dataChoiceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class ComponentOrBlockPropertyType {
        
        private ComponentType componentField;
        
        private BlockType blockField;
        
        /// <remarks/>
        public ComponentType Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        
        /// <remarks/>
        public BlockType Block {
            get {
                return this.blockField;
            }
            set {
                this.blockField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class ComponentPropertyByValueType {
        
        private ComponentType componentField;
        
        /// <remarks/>
        public ComponentType Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class ComponentPropertyType {
        
        private ComponentType componentField;
        
        /// <remarks/>
        public ComponentType Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class BinaryEncodingPropertyByValueType {
        
        private BinaryEncodingType binaryEncodingField;
        
        /// <remarks/>
        public BinaryEncodingType BinaryEncoding {
            get {
                return this.binaryEncodingField;
            }
            set {
                this.binaryEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class BinaryEncodingPropertyType {
        
        private BinaryEncodingType binaryEncodingField;
        
        /// <remarks/>
        public BinaryEncodingType BinaryEncoding {
            get {
                return this.binaryEncodingField;
            }
            set {
                this.binaryEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class BlockPropertyByValueType {
        
        private BlockType blockField;
        
        /// <remarks/>
        public BlockType Block {
            get {
                return this.blockField;
            }
            set {
                this.blockField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class BlockPropertyType {
        
        private BlockType blockField;
        
        /// <remarks/>
        public BlockType Block {
            get {
                return this.blockField;
            }
            set {
                this.blockField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class TextEncodingPropertyByValueType {
        
        private TextEncodingType textEncodingField;
        
        /// <remarks/>
        public TextEncodingType TextEncoding {
            get {
                return this.textEncodingField;
            }
            set {
                this.textEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class TextEncodingPropertyType {
        
        private TextEncodingType textEncodingField;
        
        /// <remarks/>
        public TextEncodingType TextEncoding {
            get {
                return this.textEncodingField;
            }
            set {
                this.textEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class XMLEncodingPropertyByValueType {
        
        private XMLEncodingType xMLEncodingField;
        
        /// <remarks/>
        public XMLEncodingType XMLEncoding {
            get {
                return this.xMLEncodingField;
            }
            set {
                this.xMLEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class XMLEncodingPropertyType {
        
        private XMLEncodingType xMLEncodingField;
        
        /// <remarks/>
        public XMLEncodingType XMLEncoding {
            get {
                return this.xMLEncodingField;
            }
            set {
                this.xMLEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public abstract partial class AbstractEncodingPropertyByValueType {
        
        private AbstractEncodingType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryEncoding", typeof(BinaryEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("TextEncoding", typeof(TextEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLEncoding", typeof(XMLEncodingType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AbstractEncodingPropertyType {
        
        private AbstractEncodingType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryEncoding", typeof(BinaryEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("TextEncoding", typeof(TextEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLEncoding", typeof(XMLEncodingType))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataStreamPropertyByValueType {
        
        private DataStreamType dataStreamField;
        
        /// <remarks/>
        public DataStreamType DataStream {
            get {
                return this.dataStreamField;
            }
            set {
                this.dataStreamField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataStreamPropertyType {
        
        private DataStreamType dataStreamField;
        
        /// <remarks/>
        public DataStreamType DataStream {
            get {
                return this.dataStreamField;
            }
            set {
                this.dataStreamField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class MatrixPropertyByValueType {
        
        private MatrixType matrixField;
        
        /// <remarks/>
        public MatrixType Matrix {
            get {
                return this.matrixField;
            }
            set {
                this.matrixField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Matrix", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class MatrixType : DataArrayType {
        
        private string referenceFrameField;
        
        private string localFrameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string referenceFrame {
            get {
                return this.referenceFrameField;
            }
            set {
                this.referenceFrameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string localFrame {
            get {
                return this.localFrameField;
            }
            set {
                this.localFrameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class MatrixPropertyType {
        
        private MatrixType matrixField;
        
        /// <remarks/>
        public MatrixType Matrix {
            get {
                return this.matrixField;
            }
            set {
                this.matrixField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataArrayPropertyByValueType {
        
        private DataArrayType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataArray", typeof(DataArrayType))]
        [System.Xml.Serialization.XmlElementAttribute("Matrix", typeof(MatrixType))]
        public DataArrayType Item {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataArrayPropertyType {
        
        private DataArrayType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataArray", typeof(DataArrayType))]
        [System.Xml.Serialization.XmlElementAttribute("Matrix", typeof(MatrixType))]
        public DataArrayType Item {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AnyScalarPropertyType {
        
        private BooleanType booleanField;
        
        private CountType countField;
        
        private QuantityType quantityField;
        
        private TimeType timeField;
        
        private CategoryType categoryField;
        
        private TextType textField;
        
        /// <remarks/>
        public BooleanType Boolean {
            get {
                return this.booleanField;
            }
            set {
                this.booleanField = value;
            }
        }
        
        /// <remarks/>
        public CountType Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public QuantityType Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public TimeType Time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
        
        /// <remarks/>
        public CategoryType Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        public TextType Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AnyRangePropertyType {
        
        private QuantityRangeType quantityRangeField;
        
        private TimeRangeType timeRangeField;
        
        private CountRangeType countRangeField;
        
        private CategoryRangeType categoryRangeField;
        
        /// <remarks/>
        public QuantityRangeType QuantityRange {
            get {
                return this.quantityRangeField;
            }
            set {
                this.quantityRangeField = value;
            }
        }
        
        /// <remarks/>
        public TimeRangeType TimeRange {
            get {
                return this.timeRangeField;
            }
            set {
                this.timeRangeField = value;
            }
        }
        
        /// <remarks/>
        public CountRangeType CountRange {
            get {
                return this.countRangeField;
            }
            set {
                this.countRangeField = value;
            }
        }
        
        /// <remarks/>
        public CategoryRangeType CategoryRange {
            get {
                return this.categoryRangeField;
            }
            set {
                this.categoryRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedTimesPropertyByValueType {
        
        private AllowedTimesType allowedTimesField;
        
        /// <remarks/>
        public AllowedTimesType AllowedTimes {
            get {
                return this.allowedTimesField;
            }
            set {
                this.allowedTimesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedValuesPropertyByValueType {
        
        private AllowedValuesType allowedValuesField;
        
        /// <remarks/>
        public AllowedValuesType AllowedValues {
            get {
                return this.allowedValuesField;
            }
            set {
                this.allowedValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AllowedTokensPropertyByValueType {
        
        private AllowedTokensType allowedTokensField;
        
        /// <remarks/>
        public AllowedTokensType AllowedTokens {
            get {
                return this.allowedTokensField;
            }
            set {
                this.allowedTokensField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class CountRangePropertyType {
        
        private CountRangeType countRangeField;
        
        /// <remarks/>
        public CountRangeType CountRange {
            get {
                return this.countRangeField;
            }
            set {
                this.countRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class QuantityPropertyType {
        
        private QuantityType quantityField;
        
        /// <remarks/>
        public QuantityType Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class CategoryPropertyType {
        
        private CategoryType categoryField;
        
        /// <remarks/>
        public CategoryType Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class TextPropertyType {
        
        private TextType textField;
        
        /// <remarks/>
        public TextType Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class BooleanPropertyType {
        
        private BooleanType booleanField;
        
        /// <remarks/>
        public BooleanType Boolean {
            get {
                return this.booleanField;
            }
            set {
                this.booleanField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class TimeRangePropertyType {
        
        private TimeRangeType timeRangeField;
        
        /// <remarks/>
        public TimeRangeType TimeRange {
            get {
                return this.timeRangeField;
            }
            set {
                this.timeRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class TimePropertyType {
        
        private TimeType timeField;
        
        /// <remarks/>
        public TimeType Time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class QuantityRangePropertyType {
        
        private QuantityRangeType quantityRangeField;
        
        /// <remarks/>
        public QuantityRangeType QuantityRange {
            get {
                return this.quantityRangeField;
            }
            set {
                this.quantityRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class AbstractSimpleComponentPropertyType {
        
        private AbstractSimpleComponentType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Boolean", typeof(BooleanType))]
        [System.Xml.Serialization.XmlElementAttribute("Category", typeof(CategoryType))]
        [System.Xml.Serialization.XmlElementAttribute("CategoryRange", typeof(CategoryRangeType))]
        [System.Xml.Serialization.XmlElementAttribute("Count", typeof(CountType))]
        [System.Xml.Serialization.XmlElementAttribute("CountRange", typeof(CountRangeType))]
        [System.Xml.Serialization.XmlElementAttribute("Quantity", typeof(QuantityType))]
        [System.Xml.Serialization.XmlElementAttribute("QuantityRange", typeof(QuantityRangeType))]
        [System.Xml.Serialization.XmlElementAttribute("Text", typeof(TextType))]
        [System.Xml.Serialization.XmlElementAttribute("Time", typeof(TimeType))]
        [System.Xml.Serialization.XmlElementAttribute("TimeRange", typeof(TimeRangeType))]
        public AbstractSimpleComponentType Item {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class CategoryRangePropertyType {
        
        private CategoryRangeType categoryRangeField;
        
        /// <remarks/>
        public CategoryRangeType CategoryRange {
            get {
                return this.categoryRangeField;
            }
            set {
                this.categoryRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class VectorPropertyByValueType {
        
        private VectorType vectorField;
        
        /// <remarks/>
        public VectorType Vector {
            get {
                return this.vectorField;
            }
            set {
                this.vectorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class VectorPropertyType {
        
        private VectorType vectorField;
        
        /// <remarks/>
        public VectorType Vector {
            get {
                return this.vectorField;
            }
            set {
                this.vectorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataRecordPropertyByValueType {
        
        private DataRecordType dataRecordField;
        
        /// <remarks/>
        public DataRecordType DataRecord {
            get {
                return this.dataRecordField;
            }
            set {
                this.dataRecordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataRecordPropertyType {
        
        private DataRecordType dataRecordField;
        
        /// <remarks/>
        public DataRecordType DataRecord {
            get {
                return this.dataRecordField;
            }
            set {
                this.dataRecordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataArrayTypeElementType : AbstractDataComponentPropertyType {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/swe/2.0")]
    public partial class DataArrayTypeEncoding {
        
        private AbstractEncodingType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryEncoding", typeof(BinaryEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("TextEncoding", typeof(TextEncodingType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLEncoding", typeof(XMLEncodingType))]
        public AbstractEncodingType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
