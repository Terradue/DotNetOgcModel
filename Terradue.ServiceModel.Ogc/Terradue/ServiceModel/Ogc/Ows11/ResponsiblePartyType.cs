namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <summary>
    /// Identification of, and means of communication with, person responsible for the server. 
    /// At least one of IndividualName, OrganisationName, or PositionName shall be included. 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("PointOfContact", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ResponsiblePartyType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndividualName")]
        public string IndividualName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganisationName")]
        public string OrganisationName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PositionName")]
        public string PositionName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactInfo")]
        public ContactType ContactInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Role")]
        public CodeType Role { get; set; }
    }
}
