using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <summary>
    /// Contents of typical Contents section of an OWS service metadata (Capabilities) document. 
    /// This type shall be extended and/or restricted if needed for specific OWS use to include the specific metadata needed.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class ContentsBaseType
    {
        private Collection<DatasetDescriptionSummaryBaseType> _datasetDescriptionSummary = new Collection<DatasetDescriptionSummaryBaseType>();
        /// <summary>
        /// Unordered set of summary descriptions for the datasets available from this OWS server. 
        /// This set shall be included unless another source is referenced and all this metadata is available from that source.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DatasetDescriptionSummary")]
        public Collection<DatasetDescriptionSummaryBaseType> DatasetDescriptionSummary
        {
            get
            {
                return this._datasetDescriptionSummary;
            }
        }

        private Collection<MetadataType> _otherSource = new Collection<MetadataType>();
        /// <summary>
        /// Unordered set of references to other sources of metadata describing the coverage offerings available from this server.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OtherSource")]
        public Collection<MetadataType> OtherSource
        {
            get
            {
                return this._otherSource;
            }
        }
    }
}
