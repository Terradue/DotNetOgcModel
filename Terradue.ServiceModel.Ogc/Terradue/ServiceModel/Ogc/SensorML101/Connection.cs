namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("connection", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Connection
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrayLink", Type = typeof(ArrayLink))]
        [System.Xml.Serialization.XmlElementAttribute("Link", Type = typeof(Link))]
        public object Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType = "token")]
        public string Name { get; set; }
    }
}
