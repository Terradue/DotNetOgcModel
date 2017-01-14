using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DatasetDescriptionSummaryBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BasicIdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManifestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceGroupType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentificationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class DescriptionType
    {
        private Collection<LanguageStringType> _titles = new Collection<LanguageStringType>();
        /// <summary>
        /// Gets or sets titles of this server, normally used for display to a human.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Title")]
        public Collection<LanguageStringType> Titles
        {
            get
            {
                return this._titles;
            }
        }

        private Collection<LanguageStringType> _abstracts = new Collection<LanguageStringType>();
        /// <summary>
        /// Gets or sets brief narrative descriptions of this server, normally available for display to a human.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Abstract")]
        public Collection<LanguageStringType> Abstracts
        {
            get
            {
                return this._abstracts;
            }
        }

        private Collection<KeywordsType> _keywords = new Collection<KeywordsType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keywords")]
        public Collection<KeywordsType> Keywords
        {
            get
            {
                return this._keywords;
            }
        }
    }
}
