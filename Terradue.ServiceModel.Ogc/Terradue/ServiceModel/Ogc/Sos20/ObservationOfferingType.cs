using Terradue.ServiceModel.Ogc.Fes20;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Om20;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.Swe20;
using Terradue.ServiceModel.Ogc.Swes20;

namespace Terradue.ServiceModel.Ogc.Sos20 {
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6225.41916")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ObservationOffering", Namespace="http://www.opengis.net/sos/2.0", IsNullable=false)]
    public partial class ObservationOfferingType : AbstractOfferingType {
        
        private ObservationOfferingTypeObservedArea observedAreaField;
        
        private ObservationOfferingTypePhenomenonTime phenomenonTimeField;
        
        private ObservationOfferingTypeResultTime resultTimeField;
        
        private string[] responseFormatField;
        
        private string[] observationTypeField;
        
        private string[] featureOfInterestTypeField;
        
        /// <remarks/>
        public ObservationOfferingTypeObservedArea observedArea {
            get {
                return this.observedAreaField;
            }
            set {
                this.observedAreaField = value;
            }
        }
        
        /// <remarks/>
        public ObservationOfferingTypePhenomenonTime phenomenonTime {
            get {
                return this.phenomenonTimeField;
            }
            set {
                this.phenomenonTimeField = value;
            }
        }
        
        /// <remarks/>
        public ObservationOfferingTypeResultTime resultTime {
            get {
                return this.resultTimeField;
            }
            set {
                this.resultTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseFormat", DataType="anyURI")]
        public string[] responseFormat {
            get {
                return this.responseFormatField;
            }
            set {
                this.responseFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observationType", DataType="anyURI")]
        public string[] observationType {
            get {
                return this.observationTypeField;
            }
            set {
                this.observationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterestType", DataType="anyURI")]
        public string[] featureOfInterestType {
            get {
                return this.featureOfInterestTypeField;
            }
            set {
                this.featureOfInterestTypeField = value;
            }
        }
    }
    
}
