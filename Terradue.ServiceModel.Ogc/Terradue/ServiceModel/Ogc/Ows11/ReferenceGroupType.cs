using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ReferenceGroup", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ReferenceGroupType : BasicIdentificationType
    {
        private Collection<AbstractReferenceBaseType> _reference = new Collection<AbstractReferenceBaseType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceReference", Type = typeof(ServiceReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("Reference", Type = typeof(ReferenceType))]
        public Collection<AbstractReferenceBaseType> Reference
        {
            get
            {
                return this._reference;
            }
        }
    }
}
