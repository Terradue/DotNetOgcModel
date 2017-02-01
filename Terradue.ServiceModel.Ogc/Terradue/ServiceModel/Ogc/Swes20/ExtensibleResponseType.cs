using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Oasis;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.W3c;

namespace Terradue.ServiceModel.Ogc.Swes20 {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteSensorResponseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DescribeSensorResponseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsertSensorResponseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateSensorDescriptionResponseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.20346")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ExtensibleResponse", Namespace="http://www.opengis.net/swes/2.0", IsNullable=false)]
    public abstract partial class ExtensibleResponseType {
        
        private object[] extensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public object[] extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
    }
    
}
