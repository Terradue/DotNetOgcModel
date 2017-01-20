namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class VectorTypeCoordinate
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Count", Type = typeof(Count))]
        [System.Xml.Serialization.XmlElementAttribute("Quantity", Type = typeof(Quantity))]
        [System.Xml.Serialization.XmlElementAttribute("Time", Type = typeof(Time))]
        public AbstractDataComponentType Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType = "token")]
        public string Name { get; set; }
    }
}
