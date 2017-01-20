namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Rights", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Rights
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public Documentation Documentation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml", DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("privacyAct")]
        public bool PrivacyAct { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrivacyActSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("intellectualPropertyRights")]
        public bool IntellectualPropertyRights { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntellectualPropertyRightsSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("copyRights")]
        public bool Copyrights { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CopyrightsSpecified { get; set; }
    }
}
