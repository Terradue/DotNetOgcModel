using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Xlink;

namespace Terradue.ServiceModel.Ogc.Om10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/1.0")]
    public class ObservationPropertyType : IAssociationAttributeGroup
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Observation", typeof(ObservationType))]
        [System.Xml.Serialization.XmlElementAttribute("DiscreteCoverageObservation", typeof(DiscreteCoverageObservationType))]
        [System.Xml.Serialization.XmlElementAttribute("ElementCoverageObservation", typeof(ElementCoverageObservationType))]
        [System.Xml.Serialization.XmlElementAttribute("PointCoverageObservation", typeof(PointCoverageObservationType))]
        [System.Xml.Serialization.XmlElementAttribute("TimeSeriesObservation", typeof(TimeSeriesObservationType))]
        [System.Xml.Serialization.XmlElementAttribute("DiscreteCoverageObs", typeof(DiscreteCoverageObsType))]
        [System.Xml.Serialization.XmlElementAttribute("PointCoverageObs", typeof(PointCoverageObsType))]
        [System.Xml.Serialization.XmlElementAttribute("TimeSeriesObs", typeof(TimeSeriesObsType))]
        [System.Xml.Serialization.XmlElementAttribute("CategoryObservation", typeof(CategoryObservation))]
        [System.Xml.Serialization.XmlElementAttribute("ComplexObservation", typeof(ComplexObservation))]
        [System.Xml.Serialization.XmlElementAttribute("CountObservation", typeof(CountObservation))]
        [System.Xml.Serialization.XmlElementAttribute("GeometryObservation", typeof(GeometryObservation))]
        [System.Xml.Serialization.XmlElementAttribute("Measurement", typeof(MeasurementObservation))]
        [System.Xml.Serialization.XmlElementAttribute("TemporalObservation", typeof(TemporalObservation))]
        [System.Xml.Serialization.XmlElementAttribute("TruthObservation", typeof(TruthObservation))]
        public ObservationType Observation { get; set; }

        #region IAssociationAttributeGroup Members

        /// <summary>
        /// Gets or sets a reference to an XML Schema fragment that specifies the content model of the propertys value. This is in conformance with the XML Schema Section 4.14 Referencing Schemas from Elsewhere.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("remoteSchema", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string RemoteSchema { get; set; }

        #endregion

        #region ISimpleLink Members

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("href", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string Href { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("role", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string Role { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("arcrole", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string ArcRole { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("title", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string Title { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("show", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public MetadataTypeShow Show { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShowSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("actuate", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public MetadataTypeActuate Actuate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActuateSpecified { get; set; }

        #endregion

    }
}
