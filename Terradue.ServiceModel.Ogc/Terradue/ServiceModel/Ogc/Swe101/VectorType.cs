using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VectorType", Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Vector", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class VectorType : AbstractVectorType
    {
        private Collection<VectorTypeCoordinate> _coordinates = new Collection<VectorTypeCoordinate>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("coordinate")]
        public Collection<VectorTypeCoordinate> Coordinates
        {
            get
            {
                return this._coordinates;
            }
        }
    }
}
