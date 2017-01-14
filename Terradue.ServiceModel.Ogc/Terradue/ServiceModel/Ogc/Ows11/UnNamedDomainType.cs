using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class UnNamedDomainType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Range", Type = typeof(RangeType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Value", Type = typeof(ValueType), IsNullable = false)]
        [System.Xml.Serialization.XmlArray("AllowedValues")]
        public Collection<object> AllowedValues { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnyValue")]
        public AnyValue AnyValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NoValues")]
        public NoValues NoValues { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValuesReference")]
        public ValuesReference ValuesReference { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DefaultValue")]
        public ValueType DefaultValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Meaning")]
        public DomainMetadataType Meaning { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataType")]
        public DomainMetadataType DataType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UOM")]
        public DomainMetadataType Uom { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceSystem")]
        public DomainMetadataType ReferenceSystem { get; set; }

        private Collection<MetadataType> _metadata = new Collection<MetadataType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public Collection<MetadataType> Metadata
        {
            get
            {
                return this._metadata;
            }
        }
    }
}
