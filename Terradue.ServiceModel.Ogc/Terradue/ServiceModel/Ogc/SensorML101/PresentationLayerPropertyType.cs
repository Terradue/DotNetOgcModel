using Terradue.ServiceModel.Ogc.Swe101;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class PresentationLayerPropertyType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataRecord", Type = typeof(DataRecordType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("SimpleDataRecord", Type = typeof(SimpleDataRecordType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ConditionalData", Type = typeof(ConditionalDataType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ConditionalValue", Type = typeof(ConditionalValueType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("NormalizedCurve", Type = typeof(NormalizedCurveType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Position", Type = typeof(PositionType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("GeoLocationArea", Type = typeof(GeoLocationAreaType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Envelope", Type = typeof(Terradue.ServiceModel.Ogc.Swe101.EnvelopeType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Vector", Type = typeof(Terradue.ServiceModel.Ogc.Swe101.VectorType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Category", Type = typeof(Category), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("DataBlockDefinition", Type = typeof(DataBlockDefinitionType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("DataStreamDefinition", Type = typeof(DataStreamDefinitionType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        public object Item { get; set; }
    }
}
