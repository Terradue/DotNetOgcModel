namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("System", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class SystemType : AbstractComponentType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("components")]
        public Components Components { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("positions")]
        public Positions Positions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connections")]
        public Connections Connections { get; set; }
    }
}
