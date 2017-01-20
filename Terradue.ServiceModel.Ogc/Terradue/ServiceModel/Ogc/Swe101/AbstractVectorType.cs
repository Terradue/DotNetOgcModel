namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnvelopeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public abstract class AbstractVectorType : AbstractDataRecordType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("referenceFrame", DataType = "anyURI")]
        public string ReferenceFrame { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("localFrame", DataType = "anyURI")]
        public string LocalFrame { get; set; }
    }
}
