using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Swe10;

namespace Terradue.ServiceModel.Ogc.Om10
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElementCoverageObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeriesObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointCoverageObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscreteCoverageObservationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeSeriesObsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointCoverageObsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscreteCoverageObsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryObservation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComplexObservation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountObservation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeometryObservation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasurementObservation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalObservation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TruthObservation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ObservationType", Namespace = "http://www.opengis.net/om/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("Observation", Namespace = "http://www.opengis.net/om/1.0", IsNullable = false)]
    public class ObservationType : AbstractFeatureType
    {
        /// <remarks/>
        public ObservationType()
        {
            this.Xmlns = new XmlSerializerNamespaces();
            //this.Xmlns.Add(string.Empty, "http://www.opengis.net/om/1.0");
            this.Xmlns.Add("om", "http://www.opengis.net/cv/0.2.1");
            this.Xmlns.Add("gml", "http://www.opengis.net/gml");
            this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            this.Xmlns.Add("swe", "http://www.opengis.net/swe/1.0.1");
            this.Xmlns.Add("om", "http://www.opengis.net/om/1.0");
            this.Xmlns.Add("sos", "http://www.opengis.net/sos/1.0");
            this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("ogc", "http://www.opengis.net/ogc");
            this.Xmlns.Add("tml", "http://www.opengis.net/tml");
            this.Xmlns.Add("sml", "http://www.opengis.net/sensorML/1.0.1");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metadata")]
        public AnyOrReferenceType Metadata { get; set; }

        private TimeObjectPropertyType _samplingTime = new TimeObjectPropertyType();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("samplingTime")]
        public TimeObjectPropertyType SamplingTime
        {
            get { return this._samplingTime; }
            set { this._samplingTime = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resultTime")]
        public TimeObjectPropertyType ResultTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procedure")]
        public ProcessPropertyType Procedure { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resultQuality")]
        public AnyOrReferenceType ResultQuality { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observedProperty")]
        public PhenomenonPropertyType ObservedProperty { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterest")]
        public FeaturePropertyType FeatureOfInterest { get; set; }

        private Collection<SimpleDataPropertyType> _parameters = new Collection<SimpleDataPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public Collection<SimpleDataPropertyType> Parameters
        {
            get
            {
                return this._parameters;
            }
        }

        /// <summary>
        /// The result contains the value generated by the procedure.
        /// The type of the observation result must be consistent with the observed property, and the scale or scope for the value must be consistent with the quantity or category type. 
        /// Application profiles may choose to constrain the type of the result.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("result")]
        public object Result { get; set; }
    }
}
