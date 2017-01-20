namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ResponsibleParty", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class ResponsibleParty
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("individualName")]
        public string IndividualName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organizationName")]
        public string OrganizationName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("positionName")]
        public string PositionName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contactInfo")]
        public ContactInfo ContactInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml", DataType = "ID")]
        public string Id { get; set; }
    }
}
