using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class IdentificationType : BasicIdentificationType
    {
        private Collection<BoundingBoxType> _boundingBox = new Collection<BoundingBoxType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WGS84BoundingBox", Type = typeof(WGS84BoundingBoxType))]
        [System.Xml.Serialization.XmlElementAttribute("BoundingBox", Type = typeof(BoundingBoxType))]
        public Collection<BoundingBoxType> BoundingBox
        {
            get
            {
                return this._boundingBox;
            }
        }

        private Collection<string> _outputFormat = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutputFormat")]
        public Collection<string> OutputFormat
        {
            get
            {
                return this._outputFormat;
            }
        }

        private Collection<string> _availableCRS = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AvailableCRS", DataType = "anyURI")]
        public Collection<string> AvailableCRS
        {
            get
            {
                return this._availableCRS;
            }
        }

        private Collection<string> _supportedCRS = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedCRS", DataType = "anyURI")]
        public Collection<string> SupportedCRS
        {
            get
            {
                return this._supportedCRS;
            }
        }
    }
}
