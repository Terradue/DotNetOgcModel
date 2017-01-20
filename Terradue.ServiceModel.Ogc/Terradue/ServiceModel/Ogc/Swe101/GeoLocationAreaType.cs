using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class GeoLocationAreaType : AbstractVectorType
    {
        private Collection<EnvelopePropertyType> _member = new Collection<EnvelopePropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public Collection<EnvelopePropertyType> Member
        {
            get
            {
                return this._member;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name", DataType = "token")]
        public string Name { get; set; }
    }
}
