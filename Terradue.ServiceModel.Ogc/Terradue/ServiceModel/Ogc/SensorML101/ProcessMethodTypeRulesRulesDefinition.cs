using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class ProcessMethodTypeRulesRulesDefinition
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description", Namespace = "http://www.opengis.net/gml")]
        public StringOrRefType Description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("schematron", Type = typeof(Schematron))]
        [System.Xml.Serialization.XmlElementAttribute("relaxNG", Type = typeof(RelaxNg))]
        [System.Xml.Serialization.XmlElementAttribute("ruleLanguage")]
        public RuleLanguageType RuleLanguage { get; set; }
    }
}
