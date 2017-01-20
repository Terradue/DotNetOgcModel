using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("TimeGeometricComplex", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class TimeGeometricComplexType : AbstractTimeComplexType
    {
        private Collection<TimeGeometricPrimitivePropertyType> _primitives = new Collection<TimeGeometricPrimitivePropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primitive")]
        public Collection<TimeGeometricPrimitivePropertyType> Primitives
        {
            get
            {
                return this._primitives;
            }
        }
    }
}
