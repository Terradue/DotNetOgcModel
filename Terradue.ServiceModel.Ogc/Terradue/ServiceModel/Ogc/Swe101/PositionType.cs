namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Position", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class PositionType : AbstractVectorType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time")]
        public TimePropertyType Time { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public VectorPropertyType Location { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("orientation")]
        public VectorOrSquareMatrixPropertyType Orientation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("velocity")]
        public VectorPropertyType Velocity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("angularVelocity")]
        public VectorOrSquareMatrixPropertyType AngularVelocity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("acceleration")]
        public VectorPropertyType Acceleration { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("angularAcceleration")]
        public VectorOrSquareMatrixPropertyType AngularAcceleration { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public VectorOrSquareMatrixPropertyType State { get; set; }
    }
}
