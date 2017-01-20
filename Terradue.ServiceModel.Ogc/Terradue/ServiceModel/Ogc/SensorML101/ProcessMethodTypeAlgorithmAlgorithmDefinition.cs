using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class ProcessMethodTypeAlgorithmAlgorithmDefinition
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description", Namespace = "http://www.opengis.net/gml")]
        public StringOrRefType Description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mathML")]
        public ProcessMethodTypeAlgorithmAlgorithmDefinitionMathML MathML { get; set; }
    }
}
