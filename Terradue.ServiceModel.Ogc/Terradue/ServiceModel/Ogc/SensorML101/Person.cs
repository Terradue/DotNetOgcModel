namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Person", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Person
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("surname", DataType = "token")]
        public string Surname { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name", DataType = "token")]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("userID", DataType = "token")]
        public string UserID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("affiliation", DataType = "token")]
        public string Affiliation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phoneNumber", DataType = "token")]
        public string PhoneNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email", DataType = "token")]
        public string Email { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml", DataType = "ID")]
        public string Id { get; set; }
    }
}
