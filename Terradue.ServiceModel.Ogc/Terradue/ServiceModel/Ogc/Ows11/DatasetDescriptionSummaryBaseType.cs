using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("DatasetDescriptionSummary", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class DatasetDescriptionSummaryBaseType : DescriptionType
    {
        private Collection<WGS84BoundingBoxType> _wGS84BoundingBox = new Collection<WGS84BoundingBoxType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox")]
        public Collection<WGS84BoundingBoxType> WGS84BoundingBox
        {
            get
            {
                return this._wGS84BoundingBox;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Identifier")]
        public CodeType Identifier { get; set; }

        private Collection<BoundingBoxType> _boundingBox = new Collection<BoundingBoxType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox")]
        public Collection<BoundingBoxType> BoundingBox
        {
            get
            {
                return this._boundingBox;
            }
        }

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

        private Collection<DatasetDescriptionSummaryBaseType> _datasetDescriptionSummary = new Collection<DatasetDescriptionSummaryBaseType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DatasetDescriptionSummary")]
        public Collection<DatasetDescriptionSummaryBaseType> DatasetDescriptionSummary
        {
            get
            {
                return this._datasetDescriptionSummary;
            }
        }
    }
}
