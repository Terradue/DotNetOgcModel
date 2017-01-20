namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Component", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class ComponentType : AbstractComponentType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("method")]
        public MethodPropertyType Method { get; set; }
    }
}
