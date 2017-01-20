using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Ogc;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("Filter_Capabilities", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class FilterCapabilities
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spatial_Capabilities", Namespace = "http://www.opengis.net/ogc")]
        public SpatialCapabilitiesType SpatialCapabilities
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Temporal_Capabilities", Namespace = "http://www.opengis.net/ogc")]
        public TemporalCapabilitiesType TemporalCapabilities
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Scalar_Capabilities", Namespace = "http://www.opengis.net/ogc")]
        public ScalarCapabilitiesType ScalarCapabilities
        {
            get;
            set;
        }

        private Collection<object> _idCapabilities = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("Id_Capabilities", Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlArrayItemAttribute("EID", Type = typeof(EID), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FID", Type = typeof(FID), IsNullable = false)]
        public Collection<object> IdCapabilities
        {
            get
            {
                return this._idCapabilities;
            }
        }
    }
}
