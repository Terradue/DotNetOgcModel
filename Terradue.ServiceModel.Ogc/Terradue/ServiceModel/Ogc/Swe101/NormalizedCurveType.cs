namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("NormalizedCurve", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class NormalizedCurveType : AbstractDataRecordType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inputGain")]
        public QuantityPropertyType InputGain { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inputBias")]
        public QuantityPropertyType InputBias { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outputGain")]
        public QuantityPropertyType OutputGain { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outputBias")]
        public QuantityPropertyType OutputBias { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interpolationMethod")]
        public CategoryPropertyType InterpolationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extrapolationMethod")]
        public CategoryPropertyType ExtrapolationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("function")]
        public CurvePropertyType Function { get; set; }
    }
}
