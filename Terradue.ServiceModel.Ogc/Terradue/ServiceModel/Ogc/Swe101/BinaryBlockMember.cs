namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class BinaryBlockMember
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Block", Type = typeof(BinaryBlockMemberBlock))]
        [System.Xml.Serialization.XmlElementAttribute("Component", Type = typeof(BinaryBlockMemberComponent))]
        public object Item { get; set; }
    }
}
