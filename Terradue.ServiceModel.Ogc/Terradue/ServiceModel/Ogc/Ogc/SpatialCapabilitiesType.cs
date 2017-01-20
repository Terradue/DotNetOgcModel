using System.Collections.ObjectModel;
using System.Xml;
namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Spatial_Capabilities", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class SpatialCapabilitiesType
    {
        private Collection<XmlQualifiedName> _geometryOperands = new Collection<XmlQualifiedName>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable = false)]
        [System.Xml.Serialization.XmlArray("GeometryOperands")]
        public Collection<XmlQualifiedName> GeometryOperands 
        {
            get
            {
                return this._geometryOperands;
            }
        }

        private Collection<SpatialOperatorType> _spatialOperators = new Collection<SpatialOperatorType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SpatialOperator", IsNullable = false)]
        [System.Xml.Serialization.XmlArray("SpatialOperators")]
        public Collection<SpatialOperatorType> SpatialOperators 
        {
            get
            {
                return this._spatialOperators;
            }
        }
    }
}
