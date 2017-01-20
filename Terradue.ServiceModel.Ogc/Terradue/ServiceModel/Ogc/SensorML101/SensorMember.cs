using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Om10;
using Terradue.ServiceModel.Ogc.Xlink;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("SensorMLMember", AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class SensorMember : IAssociationAttributeGroup
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactList", typeof(ContactList))]
        [System.Xml.Serialization.XmlElementAttribute("DocumentList", typeof(DocumentList))]
        [System.Xml.Serialization.XmlElementAttribute("ProcessModel", typeof(ProcessModelType))]
        [System.Xml.Serialization.XmlElementAttribute("ProcessChain", typeof(ProcessChainType))]
        [System.Xml.Serialization.XmlElementAttribute("DataSource", typeof(DataSourceType))]
        [System.Xml.Serialization.XmlElementAttribute("Component", typeof(ComponentType))]
        [System.Xml.Serialization.XmlElementAttribute("System", typeof(SystemType))]
        [System.Xml.Serialization.XmlElementAttribute("ComponentArray", typeof(ComponentArrayType))]
        [System.Xml.Serialization.XmlElementAttribute("ObservationProcess", Type = typeof(ObservationProcessType), Namespace = "http://www.opengis.net/om/1.0")]
        [System.Xml.Serialization.XmlElementAttribute("Instrument", Type = typeof(InstrumentType), Namespace = "http://www.opengis.net/om/1.0")]
        [System.Xml.Serialization.XmlElementAttribute("CalculationProcess", Type = typeof(CalculationProcessType), Namespace = "http://www.opengis.net/om/1.0")]
        public object Item { get; set; }

        #region IAssociationAttributeGroup Members

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("remoteSchema", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string RemoteSchema { get; set; }

        #endregion

        #region ISimpleLink Members

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("href", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string Href { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("role", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string Role { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("arcrole", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string ArcRole { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("title", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string Title { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("show", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public MetadataTypeShow Show { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShowSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("actuate", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public MetadataTypeActuate Actuate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActuateSpecified { get; set; }

        #endregion
    }
}
