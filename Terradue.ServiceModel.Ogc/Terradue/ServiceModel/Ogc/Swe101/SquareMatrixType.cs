namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("SquareMatrix", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class SquareMatrixType : AbstractMatrixType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("elementType")]
        public QuantityPropertyType ElementType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("encoding")]
        public BlockEncodingPropertyType Encoding { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("values")]
        public DataValuePropertyType Values { get; set; }
    }
}
