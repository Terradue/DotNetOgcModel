using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Filter_Capabilities", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class FilterCapabilities
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spatial_Capabilities")]
        public SpatialCapabilitiesType SpatialCapabilities { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Scalar_Capabilities")]
        public ScalarCapabilitiesType ScalarCapabilities { get; set; }

        private Collection<object> _capabilityIds = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EID", typeof(EID), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FID", typeof(FID), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayAttribute("Id_Capabilities", IsNullable = false)]
        public Collection<object> CapabilityIds
        {
            get
            {
                return this._capabilityIds;
            }
        }
    }
}
