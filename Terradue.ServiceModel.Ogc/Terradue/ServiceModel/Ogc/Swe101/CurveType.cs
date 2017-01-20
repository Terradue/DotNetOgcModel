namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CurveType", Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Curve", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class CurveType : AbstractDataArrayType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("elementType")]
        public SimpleDataRecordPropertyType ElementType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("encoding")]
        public BlockEncodingPropertyType Encoding { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("values")]
        public DataValuePropertyType Values { get; set; }
    }
}
