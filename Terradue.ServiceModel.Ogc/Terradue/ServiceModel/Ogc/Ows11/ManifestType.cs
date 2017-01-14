using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Manifest", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ManifestType : BasicIdentificationType
    {
        private Collection<ReferenceGroupType> _referenceGroup = new Collection<ReferenceGroupType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceGroup")]
        public Collection<ReferenceGroupType> ReferenceGroup
        {
            get
            {
                return this._referenceGroup;
            }
        }
    }
}
