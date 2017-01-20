namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ComponentArray", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class ComponentArrayType : AbstractDerivableComponentType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inputs")]
        public Inputs Inputs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outputs")]
        public Outputs outputs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameters")]
        public ComponentArrayTypeParameters parameters { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("components")]
        public Components Components { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("positions")]
        public Positions Positions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connections")]
        public Connections connections { get; set; }
    }
}
