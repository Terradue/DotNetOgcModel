namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class XmlDataPropertyType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Array", Type = typeof(ArrayType))]
        [System.Xml.Serialization.XmlElementAttribute("Item", Type = typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("Record", Type = typeof(RecordType))]
        public object Item { get; set; }
    }
}
