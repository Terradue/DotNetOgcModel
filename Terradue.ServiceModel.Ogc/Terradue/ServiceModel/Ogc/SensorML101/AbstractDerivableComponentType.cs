namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentArrayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractComponentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComponentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public abstract class AbstractDerivableComponentType : AbstractProcessType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spatialReferenceFrame")]
        public SpatialReferenceFrame SpatialReferenceFrame { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("temporalReferenceFrame")]
        public TemporalReferenceFrame TemporalReferenceFrame { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location", Type = typeof(Location))]
        [System.Xml.Serialization.XmlElementAttribute("position", Type = typeof(Position))]
        public object Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timePosition")]
        public TimePosition TimePosition { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interfaces")]
        public Interfaces Interfaces { get; set; }
    }
}
