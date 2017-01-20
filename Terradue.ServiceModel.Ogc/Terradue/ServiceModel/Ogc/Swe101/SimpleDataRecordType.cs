using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("SimpleDataRecord", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class SimpleDataRecordType : AbstractDataRecordType
    {
        private Collection<AnyScalarPropertyType> _fields = new Collection<AnyScalarPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("field")]
        public Collection<AnyScalarPropertyType> Fields
        {
            get
            {
                return this._fields;
            }
        }
    }
}
