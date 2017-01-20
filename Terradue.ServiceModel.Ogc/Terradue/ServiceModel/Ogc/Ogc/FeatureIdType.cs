namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("FeatureId", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class FeatureIdType : AbstractIdType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("fid", DataType = "ID")]
        public string Id { get; set; }
    }
}
