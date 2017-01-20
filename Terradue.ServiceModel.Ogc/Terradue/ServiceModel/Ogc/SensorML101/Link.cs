namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Link", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Link
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public LinkSource Source { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("destination")]
        public LinkDestination Destination { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type", DataType = "anyURI")]
        public string Type { get; set; }
    }
}
