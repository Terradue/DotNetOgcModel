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
    [System.Xml.Serialization.XmlRootAttribute("DescribeSensorResponse", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public partial class DescribeSensorResponseType : ExtensibleResponseType {
        
        private string procedureDescriptionFormatField;
        
        private DescribeSensorResponseTypeDescription[] descriptionField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public DescribeSensorResponseTypeDescription[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
}
