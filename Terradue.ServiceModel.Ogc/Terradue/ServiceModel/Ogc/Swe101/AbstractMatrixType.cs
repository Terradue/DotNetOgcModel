namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareMatrixType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public abstract class AbstractMatrixType : AbstractDataArrayType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("referenceFrame", DataType = "anyURI")]
        public string ReferenceFrame { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("localFrame", DataType = "anyURI")]
        public string LocalFrame { get; set; }
    }
}
