﻿using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Om10;
using Terradue.ServiceModel.Ogc.Xlink;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class ComponentsComponent : IAssociationAttributeGroup
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessModel", Type = typeof(ProcessModelType), Namespace = "http://www.opengis.net/sensorML/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ProcessChain", Type = typeof(ProcessChainType), Namespace = "http://www.opengis.net/sensorML/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("DataSource", Type = typeof(DataSourceType), Namespace = "http://www.opengis.net/sensorML/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("Component", Type = typeof(ComponentType), Namespace = "http://www.opengis.net/sensorML/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("System", Type = typeof(SystemType), Namespace = "http://www.opengis.net/sensorML/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ComponentArray", Type = typeof(ComponentArrayType), Namespace = "http://www.opengis.net/sensorML/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("ObservationProcess", Type = typeof(ObservationProcessType), Namespace = "http://www.opengis.net/om/1.0")]
        [System.Xml.Serialization.XmlElementAttribute("Instrument", Type = typeof(InstrumentType), Namespace = "http://www.opengis.net/om/1.0")]
        [System.Xml.Serialization.XmlElementAttribute("CalculationProcess", Type = typeof(CalculationProcessType), Namespace = "http://www.opengis.net/om/1.0")]
        public AbstractProcessType Process { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType = "token")]
        public string Name { get; set; }

        #region IAssociationAttributeGroup Members

        /// <summary>
        /// Gets or sets a reference to an XML Schema fragment that specifies the content model of the propertys value. This is in conformance with the XML Schema Section 4.14 Referencing Schemas from Elsewhere.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("remoteSchema", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
        public string RemoteSchema { get; set; }

        #endregion

        #region ISimpleLink Members

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public XlinkType Type { get; set; }

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
