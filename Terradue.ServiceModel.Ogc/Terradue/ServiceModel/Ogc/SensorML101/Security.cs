using System;
using Terradue.ServiceModel.Ogc.Ic.Ism;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Security", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class Security
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("classification", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2")]
        public ClassificationType Classification { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClassificationSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ownerProducer", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string OwnerProducer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("SCIcontrols", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string SciControls { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("SARIdentifier", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string SarIdentifier { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("disseminationControls", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string DisseminationControls { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("FGIsourceOpen", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string FgiSourceOpen { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("FGIsourceProtected", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string FgiSourceProtected { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("releasableTo", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string ReleasableTo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("nonICmarkings", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string NonICmarkings { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("classifiedBy", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2")]
        public string ClassifiedBy { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("classificationReason", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2")]
        public string ClassificationReason { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("derivedFrom", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2")]
        public string DerivedFrom { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("declassDate", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "date")]
        public DateTime DeclassDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclassDateSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("declassEvent", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2")]
        public string DeclassEvent { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("declassException", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string DeclassException { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("typeOfExemptedSource", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "NMTOKENS")]
        public string TypeOfExemptedSource { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dateOfExemptedSource", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2", DataType = "date")]
        public DateTime DateOfExemptedSource { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateOfExemptedSourceSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("declassManualReview", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:us:gov:ic:ism:v2")]
        public bool DeclassManualReview { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclassManualReviewSpecified { get; set; }
    }
}
