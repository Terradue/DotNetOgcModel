
using Terradue.ServiceModel.Ogc.Om20;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("ObservationTemplate", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class ObservationTemplate
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Observation", Namespace = "http://www.opengis.net/om/1.0")]
        public OM_ObservationType Observation { get; set; }
    }
}
