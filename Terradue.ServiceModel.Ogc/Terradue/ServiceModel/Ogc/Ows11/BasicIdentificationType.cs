using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManifestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentificationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class BasicIdentificationType : DescriptionType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Identifier")]
        public CodeType Identifier { get; set; }

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
