namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EnvelopeType", Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Envelope", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class EnvelopeType : AbstractVectorType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time")]
        public TimeRangePropertyType time { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lowerCorner")]
        public VectorPropertyType LowerCorner { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("upperCorner")]
        public VectorPropertyType UpperCorner { get; set; }
    }
}
