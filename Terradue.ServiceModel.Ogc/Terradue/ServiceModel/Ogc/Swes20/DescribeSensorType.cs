using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Oasis;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.W3c;

namespace Terradue.ServiceModel.Ogc.Swes20 {
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeSensor", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class DescribeSensorType : ExtensibleRequestType {
        
        private string procedureField;
        
        private string procedureDescriptionFormatField;
        
        private DescribeSensorTypeValidTime validTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string procedureDescriptionFormat {
            get {
                return this.procedureDescriptionFormatField;
            }
            set {
                this.procedureDescriptionFormatField = value;
            }
        }
        
        /// <remarks/>
        public DescribeSensorTypeValidTime validTime {
            get {
                return this.validTimeField;
            }
            set {
                this.validTimeField = value;
            }
        }
    }
    
}
