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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sos/2.0")]
    public partial class FilterCapabilities {
        
        private Filter_Capabilities filter_CapabilitiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/fes/2.0")]
        public Filter_Capabilities Filter_Capabilities {
            get {
                return this.filter_CapabilitiesField;
            }
            set {
                this.filter_CapabilitiesField = value;
            }
        }
    }
    
}
