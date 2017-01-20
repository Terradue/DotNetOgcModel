namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public abstract class AbstractComponentType : AbstractDerivableComponentType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inputs")]
        public Inputs Inputs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outputs")]
        public Outputs Outputs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameters")]
        public Parameters Parameters { get; set; }
    }
}
