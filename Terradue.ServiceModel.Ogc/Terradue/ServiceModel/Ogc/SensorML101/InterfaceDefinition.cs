namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("InterfaceDefinition", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class InterfaceDefinition
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serviceLayer")]
        public LayerPropertyType ServiceLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applicationLayer")]
        public LayerPropertyType ApplicationLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("presentationLayer")]
        public PresentationLayerPropertyType PresentationLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sessionLayer")]
        public LayerPropertyType SessionLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transportLayer")]
        public LayerPropertyType TransportLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("networkLayer")]
        public LayerPropertyType NetworkLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dataLinkLayer")]
        public LayerPropertyType DataLinkLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("physicalLayer")]
        public LayerPropertyType PhysicalLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mechanicalLayer")]
        public LayerPropertyType MechanicalLayer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id { get; set; }
    }
}
