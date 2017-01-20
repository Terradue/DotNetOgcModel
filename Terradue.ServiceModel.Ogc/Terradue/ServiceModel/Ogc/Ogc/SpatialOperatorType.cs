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
    public class SpatialOperatorType
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public SpatialOperatorNameType Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameSpecified { get; set; }
    }
}
