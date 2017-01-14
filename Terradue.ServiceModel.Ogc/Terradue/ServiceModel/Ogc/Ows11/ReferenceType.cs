using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReferenceType", Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Reference", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ReferenceType : AbstractReferenceBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Identifier")]
        public CodeType Identifier { get; set; }

        private Collection<LanguageStringType> _abstract = new Collection<LanguageStringType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Collection<LanguageStringType> Abstract
        {
            get
            {
                return this._abstract;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Format")]
        public string Format { get; set; }

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
