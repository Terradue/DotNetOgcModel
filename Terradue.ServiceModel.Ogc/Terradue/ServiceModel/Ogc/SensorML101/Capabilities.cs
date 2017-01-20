using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Swe101;
using Terradue.ServiceModel.Ogc.Xlink;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("capabilities", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Capabilities : IAssociationAttributeGroup
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataRecord", Type = typeof(DataRecordType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("SimpleDataRecord", Type = typeof(SimpleDataRecordType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ConditionalData", Type = typeof(ConditionalDataType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ConditionalValue", Type = typeof(ConditionalValueType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("NormalizedCurve", Type = typeof(NormalizedCurveType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Position", Type = typeof(PositionType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("GeoLocationArea", Type = typeof(GeoLocationAreaType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Envelope", Type = typeof(Swe101.EnvelopeType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Vector", Type = typeof(Swe101.VectorType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        public AbstractDataRecordType DataRecord { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType = "token")]
        public string Name { get; set; }

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
