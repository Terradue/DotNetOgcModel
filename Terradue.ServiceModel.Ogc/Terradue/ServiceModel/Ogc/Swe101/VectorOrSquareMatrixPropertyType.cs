namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class VectorOrSquareMatrixPropertyType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SquareMatrix", Type = typeof(SquareMatrixType))]
        [System.Xml.Serialization.XmlElementAttribute("Vector", Type = typeof(VectorType))]
        public AbstractDataComponentType Item { get; set; }
    }
}
