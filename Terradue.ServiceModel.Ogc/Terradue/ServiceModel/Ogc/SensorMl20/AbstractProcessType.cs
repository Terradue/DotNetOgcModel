using Terradue.ServiceModel.Ogc.Gmd;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Swe20;

namespace Terradue.ServiceModel.Ogc.SensorMl20
{

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AggregateProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractPhysicalProcessType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalSystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleProcessType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractProcess", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public abstract partial class AbstractProcessType : DescribedObjectType
    {

        private ReferenceType typeOfField;

        private AbstractProcessTypeConfiguration configurationField;

        private AbstractProcessTypeFeaturesOfInterest featuresOfInterestField;

        private AbstractProcessTypeInputs inputsField;

        private AbstractProcessTypeOutputs outputsField;

        private AbstractProcessTypeParameters parametersField;

        private AbstractProcessTypeModes[] modesField;

        private string definitionField;

        /// <remarks/>
        public ReferenceType typeOf
        {
            get
            {
                return this.typeOfField;
            }
            set
            {
                this.typeOfField = value;
            }
        }

        /// <remarks/>
        public AbstractProcessTypeConfiguration configuration
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
        public AbstractProcessTypeFeaturesOfInterest featuresOfInterest
        {
            get
            {
                return this.featuresOfInterestField;
            }
            set
            {
                this.featuresOfInterestField = value;
            }
        }

        /// <remarks/>
        public AbstractProcessTypeInputs inputs
        {
            get
            {
                return this.inputsField;
            }
            set
            {
                this.inputsField = value;
            }
        }

        /// <remarks/>
        public AbstractProcessTypeOutputs outputs
        {
            get
            {
                return this.outputsField;
            }
            set
            {
                this.outputsField = value;
            }
        }

        /// <remarks/>
        public AbstractProcessTypeParameters parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("modes")]
        public AbstractProcessTypeModes[] modes
        {
            get
            {
                return this.modesField;
            }
            set
            {
                this.modesField = value;
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
    
}
