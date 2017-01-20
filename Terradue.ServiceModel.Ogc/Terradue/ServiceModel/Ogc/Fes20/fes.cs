using Terradue.ServiceModel.Ogc.Ows11;

namespace Terradue.ServiceModel.Ogc.Fes20
{


    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractAdhocQueryExpressionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractQueryExpression", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class AbstractQueryExpressionType
    {

        private string handleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handle
        {
            get
            {
                return this.handleField;
            }
            set
            {
                this.handleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SortBy", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class SortByType
    {

        private SortPropertyType[] sortPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SortProperty")]
        public SortPropertyType[] SortProperty
        {
            get
            {
                return this.sortPropertyField;
            }
            set
            {
                this.sortPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class SortPropertyType
    {

        private string valueReferenceField;

        private SortOrderType sortOrderField;

        private bool sortOrderFieldSpecified;

        /// <remarks/>
        public string ValueReference
        {
            get
            {
                return this.valueReferenceField;
            }
            set
            {
                this.valueReferenceField = value;
            }
        }

        /// <remarks/>
        public SortOrderType SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified
        {
            get
            {
                return this.sortOrderFieldSpecified;
            }
            set
            {
                this.sortOrderFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public enum SortOrderType
    {

        /// <remarks/>
        DESC,

        /// <remarks/>
        ASC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ExtensionOperatorType
    {

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Extended_CapabilitiesType
    {

        private ExtensionOperatorType[] additionalOperatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Operator", IsNullable = false)]
        public ExtensionOperatorType[] AdditionalOperators
        {
            get
            {
                return this.additionalOperatorsField;
            }
            set
            {
                this.additionalOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class TemporalOperatorType
    {

        private TemporalOperandsTypeTemporalOperand[] temporalOperandsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperand", IsNullable = false)]
        public TemporalOperandsTypeTemporalOperand[] TemporalOperands
        {
            get
            {
                return this.temporalOperandsField;
            }
            set
            {
                this.temporalOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class TemporalOperandsTypeTemporalOperand
    {

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Temporal_CapabilitiesType
    {

        private TemporalOperandsTypeTemporalOperand[] temporalOperandsField;

        private TemporalOperatorType[] temporalOperatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperand", IsNullable = false)]
        public TemporalOperandsTypeTemporalOperand[] TemporalOperands
        {
            get
            {
                return this.temporalOperandsField;
            }
            set
            {
                this.temporalOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TemporalOperator", IsNullable = false)]
        public TemporalOperatorType[] TemporalOperators
        {
            get
            {
                return this.temporalOperatorsField;
            }
            set
            {
                this.temporalOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class SpatialOperatorType
    {

        private GeometryOperandsTypeGeometryOperand[] geometryOperandsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable = false)]
        public GeometryOperandsTypeGeometryOperand[] GeometryOperands
        {
            get
            {
                return this.geometryOperandsField;
            }
            set
            {
                this.geometryOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class GeometryOperandsTypeGeometryOperand
    {

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Spatial_CapabilitiesType
    {

        private GeometryOperandsTypeGeometryOperand[] geometryOperandsField;

        private SpatialOperatorType[] spatialOperatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable = false)]
        public GeometryOperandsTypeGeometryOperand[] GeometryOperands
        {
            get
            {
                return this.geometryOperandsField;
            }
            set
            {
                this.geometryOperandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SpatialOperator", IsNullable = false)]
        public SpatialOperatorType[] SpatialOperators
        {
            get
            {
                return this.spatialOperatorsField;
            }
            set
            {
                this.spatialOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ArgumentType
    {

        private MetadataType metadataField;

        private System.Xml.XmlQualifiedName typeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlQualifiedName Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class AvailableFunctionType
    {

        private MetadataType metadataField;

        private System.Xml.XmlQualifiedName returnsField;

        private ArgumentType[] argumentsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlQualifiedName Returns
        {
            get
            {
                return this.returnsField;
            }
            set
            {
                this.returnsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable = false)]
        public ArgumentType[] Arguments
        {
            get
            {
                return this.argumentsField;
            }
            set
            {
                this.argumentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ComparisonOperatorType
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ComparisonOperatorsType
    {

        private ComparisonOperatorType[] comparisonOperatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComparisonOperator")]
        public ComparisonOperatorType[] ComparisonOperator
        {
            get
            {
                return this.comparisonOperatorField;
            }
            set
            {
                this.comparisonOperatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class Scalar_CapabilitiesType
    {

        private LogicalOperators logicalOperatorsField;

        private ComparisonOperatorsType comparisonOperatorsField;

        /// <remarks/>
        public LogicalOperators LogicalOperators
        {
            get
            {
                return this.logicalOperatorsField;
            }
            set
            {
                this.logicalOperatorsField = value;
            }
        }

        /// <remarks/>
        public ComparisonOperatorsType ComparisonOperators
        {
            get
            {
                return this.comparisonOperatorsField;
            }
            set
            {
                this.comparisonOperatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class LogicalOperators
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class ResourceIdentifierType
    {

        private MetadataType metadataField;

        private System.Xml.XmlQualifiedName nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
        public MetadataType Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractSortingClauseType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResourceIdType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("_Id", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class AbstractIdType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ResourceId", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class ResourceIdType : AbstractIdType
    {

        private string ridField;

        private string previousRidField;

        private string versionField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rid
        {
            get
            {
                return this.ridField;
            }
            set
            {
                this.ridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string previousRid
        {
            get
            {
                return this.previousRidField;
            }
            set
            {
                this.previousRidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("extensionOps", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class ExtensionOpsType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnaryLogicOpType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryLogicOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("logicOps", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class LogicOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Not", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class UnaryLogicOpType : LogicOpsType
    {

        private object itemField;

        /// <remarks/>
        public object Item
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("And", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinaryLogicOpType : LogicOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryTemporalOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("temporalOps", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class TemporalOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("After", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinaryTemporalOpType : TemporalOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Function", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class FunctionType
    {

        private object[] itemsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Literal", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class LiteralType
    {

        private System.Xml.XmlNode[] anyField;

        private System.Xml.XmlQualifiedName typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class MeasureType
    {

        private string uomField;

        private double valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uom
        {
            get
            {
                return this.uomField;
            }
            set
            {
                this.uomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBufferType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BBOXType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinarySpatialOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("spatialOps", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class SpatialOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DWithin", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class DistanceBufferType : SpatialOpsType
    {

        private object[] itemsField;

        private MeasureType distanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public MeasureType Distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("BBOX", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BBOXType : SpatialOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Equals", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinarySpatialOpType : SpatialOpsType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class UpperBoundaryType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public partial class LowerBoundaryType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(object))]
        public object Item
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsBetweenType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsNilType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsNullType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyIsLikeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryComparisonOpType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("comparisonOps", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class ComparisonOpsType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsBetween", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsBetweenType : ComparisonOpsType
    {

        private object itemField;

        private LowerBoundaryType lowerBoundaryField;

        private UpperBoundaryType upperBoundaryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
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
        public LowerBoundaryType LowerBoundary
        {
            get
            {
                return this.lowerBoundaryField;
            }
            set
            {
                this.lowerBoundaryField = value;
            }
        }

        /// <remarks/>
        public UpperBoundaryType UpperBoundary
        {
            get
            {
                return this.upperBoundaryField;
            }
            set
            {
                this.upperBoundaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNil", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsNilType : ComparisonOpsType
    {

        private object itemField;

        private string nilReasonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsNull", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsNullType : ComparisonOpsType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object Item
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsLike", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class PropertyIsLikeType : ComparisonOpsType
    {

        private object[] itemsField;

        private string wildCardField;

        private string singleCharField;

        private string escapeCharField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wildCard
        {
            get
            {
                return this.wildCardField;
            }
            set
            {
                this.wildCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string singleChar
        {
            get
            {
                return this.singleCharField;
            }
            set
            {
                this.singleCharField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string escapeChar
        {
            get
            {
                return this.escapeCharField;
            }
            set
            {
                this.escapeCharField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsEqualTo", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class BinaryComparisonOpType : ComparisonOpsType
    {

        private object[] itemsField;

        private bool matchCaseField;

        private MatchActionType matchActionField;

        public BinaryComparisonOpType()
        {
            this.matchCaseField = true;
            this.matchActionField = MatchActionType.Any;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("Literal", typeof(LiteralType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueReference", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool matchCase
        {
            get
            {
                return this.matchCaseField;
            }
            set
            {
                this.matchCaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MatchActionType.Any)]
        public MatchActionType matchAction
        {
            get
            {
                return this.matchActionField;
            }
            set
            {
                this.matchActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public enum MatchActionType
    {

        /// <remarks/>
        All,

        /// <remarks/>
        Any,

        /// <remarks/>
        One,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilterType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractSelectionClauseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Filter", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class FilterType : AbstractSelectionClauseType
    {

        private ComparisonOpsType itemField;

        private ItemChoiceType itemElementNameField;

        private SpatialOpsType item1Field;

        private Item1ChoiceType item1ElementNameField;

        private BinaryTemporalOpType item2Field;

        private Item2ChoiceType item2ElementNameField;

        private LogicOpsType item3Field;

        private Item3ChoiceType item3ElementNameField;

        private ExtensionOpsType extensionOpsField;

        private FunctionType functionField;

        private ResourceIdType[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsBetween", typeof(PropertyIsBetweenType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsGreaterThan", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsGreaterThanOrEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLessThan", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLessThanOrEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLike", typeof(PropertyIsLikeType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsNil", typeof(PropertyIsNilType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsNotEqualTo", typeof(BinaryComparisonOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsNull", typeof(PropertyIsNullType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ComparisonOpsType Item
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BBOX", typeof(BBOXType))]
        [System.Xml.Serialization.XmlElementAttribute("Beyond", typeof(DistanceBufferType))]
        [System.Xml.Serialization.XmlElementAttribute("Contains", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Crosses", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("DWithin", typeof(DistanceBufferType))]
        [System.Xml.Serialization.XmlElementAttribute("Disjoint", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Equals", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersects", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Overlaps", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Touches", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Within", typeof(BinarySpatialOpType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public SpatialOpsType Item1
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName
        {
            get
            {
                return this.item1ElementNameField;
            }
            set
            {
                this.item1ElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("After", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("AnyInteracts", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Before", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Begins", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("BegunBy", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("During", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("EndedBy", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Ends", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Meets", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("MetBy", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("OverlappedBy", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("TContains", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("TEquals", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlElementAttribute("TOverlaps", typeof(BinaryTemporalOpType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item2ElementName")]
        public BinaryTemporalOpType Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item2ChoiceType Item2ElementName
        {
            get
            {
                return this.item2ElementNameField;
            }
            set
            {
                this.item2ElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("And", typeof(BinaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Not", typeof(UnaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Or", typeof(BinaryLogicOpType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item3ElementName")]
        public LogicOpsType Item3
        {
            get
            {
                return this.item3Field;
            }
            set
            {
                this.item3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item3ChoiceType Item3ElementName
        {
            get
            {
                return this.item3ElementNameField;
            }
            set
            {
                this.item3ElementNameField = value;
            }
        }

        /// <remarks/>
        public ExtensionOpsType extensionOps
        {
            get
            {
                return this.extensionOpsField;
            }
            set
            {
                this.extensionOpsField = value;
            }
        }

        /// <remarks/>
        public FunctionType Function
        {
            get
            {
                return this.functionField;
            }
            set
            {
                this.functionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceId")]
        public ResourceIdType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        PropertyIsBetween,

        /// <remarks/>
        PropertyIsEqualTo,

        /// <remarks/>
        PropertyIsGreaterThan,

        /// <remarks/>
        PropertyIsGreaterThanOrEqualTo,

        /// <remarks/>
        PropertyIsLessThan,

        /// <remarks/>
        PropertyIsLessThanOrEqualTo,

        /// <remarks/>
        PropertyIsLike,

        /// <remarks/>
        PropertyIsNil,

        /// <remarks/>
        PropertyIsNotEqualTo,

        /// <remarks/>
        PropertyIsNull,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0", IncludeInSchema = false)]
    public enum Item1ChoiceType
    {

        /// <remarks/>
        BBOX,

        /// <remarks/>
        Beyond,

        /// <remarks/>
        Contains,

        /// <remarks/>
        Crosses,

        /// <remarks/>
        DWithin,

        /// <remarks/>
        Disjoint,

        /// <remarks/>
        Equals,

        /// <remarks/>
        Intersects,

        /// <remarks/>
        Overlaps,

        /// <remarks/>
        Touches,

        /// <remarks/>
        Within,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0", IncludeInSchema = false)]
    public enum Item2ChoiceType
    {

        /// <remarks/>
        After,

        /// <remarks/>
        AnyInteracts,

        /// <remarks/>
        Before,

        /// <remarks/>
        Begins,

        /// <remarks/>
        BegunBy,

        /// <remarks/>
        During,

        /// <remarks/>
        EndedBy,

        /// <remarks/>
        Ends,

        /// <remarks/>
        Meets,

        /// <remarks/>
        MetBy,

        /// <remarks/>
        OverlappedBy,

        /// <remarks/>
        TContains,

        /// <remarks/>
        TEquals,

        /// <remarks/>
        TOverlaps,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0", IncludeInSchema = false)]
    public enum Item3ChoiceType
    {

        /// <remarks/>
        And,

        /// <remarks/>
        Not,

        /// <remarks/>
        Or,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    public abstract partial class AbstractProjectionClauseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractAdhocQueryExpression", Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public abstract partial class AbstractAdhocQueryExpressionType : AbstractQueryExpressionType
    {

        private object[] abstractProjectionClauseField;

        private FilterType itemField;

        private SortByType item1Field;

        private string[] typeNamesField;

        private string[] aliasesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbstractProjectionClause")]
        public object[] AbstractProjectionClause
        {
            get
            {
                return this.abstractProjectionClauseField;
            }
            set
            {
                this.abstractProjectionClauseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Filter")]
        public FilterType Item
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
        [System.Xml.Serialization.XmlElementAttribute("SortBy")]
        public SortByType Item1
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] typeNames
        {
            get
            {
                return this.typeNamesField;
            }
            set
            {
                this.typeNamesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
        public string[] aliases
        {
            get
            {
                return this.aliasesField;
            }
            set
            {
                this.aliasesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21329")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/fes/2.0", IsNullable = false)]
    public partial class Filter_Capabilities
    {

        private DomainType[] conformanceField;

        private ResourceIdentifierType[] id_CapabilitiesField;

        private Scalar_CapabilitiesType scalar_CapabilitiesField;

        private Spatial_CapabilitiesType spatial_CapabilitiesField;

        private Temporal_CapabilitiesType temporal_CapabilitiesField;

        private AvailableFunctionType[] functionsField;

        private Extended_CapabilitiesType extended_CapabilitiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Constraint", IsNullable = false)]
        public DomainType[] Conformance
        {
            get
            {
                return this.conformanceField;
            }
            set
            {
                this.conformanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResourceIdentifier", IsNullable = false)]
        public ResourceIdentifierType[] Id_Capabilities
        {
            get
            {
                return this.id_CapabilitiesField;
            }
            set
            {
                this.id_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        public Scalar_CapabilitiesType Scalar_Capabilities
        {
            get
            {
                return this.scalar_CapabilitiesField;
            }
            set
            {
                this.scalar_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        public Spatial_CapabilitiesType Spatial_Capabilities
        {
            get
            {
                return this.spatial_CapabilitiesField;
            }
            set
            {
                this.spatial_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        public Temporal_CapabilitiesType Temporal_Capabilities
        {
            get
            {
                return this.temporal_CapabilitiesField;
            }
            set
            {
                this.temporal_CapabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Function", IsNullable = false)]
        public AvailableFunctionType[] Functions
        {
            get
            {
                return this.functionsField;
            }
            set
            {
                this.functionsField = value;
            }
        }

        /// <remarks/>
        public Extended_CapabilitiesType Extended_Capabilities
        {
            get
            {
                return this.extended_CapabilitiesField;
            }
            set
            {
                this.extended_CapabilitiesField = value;
            }
        }
    }
}
