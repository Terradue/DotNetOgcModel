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
    public partial class GetFeatureOfInterestTypeSpatialFilter {
        
        private SpatialOpsType itemField;
        
        private ItemChoiceType24 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BBOX", typeof(BBOXType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Beyond", typeof(DistanceBufferType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Contains", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Crosses", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("DWithin", typeof(DistanceBufferType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Disjoint", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Equals", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Intersects", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Overlaps", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Touches", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlElementAttribute("Within", typeof(BinarySpatialOpType), Namespace="http://www.opengis.net/fes/2.0")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public SpatialOpsType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType24 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
}
