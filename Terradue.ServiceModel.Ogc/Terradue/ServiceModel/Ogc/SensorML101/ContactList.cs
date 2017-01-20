using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ContactList", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class ContactList
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description", Namespace = "http://www.opengis.net/gml")]
        public StringOrRefType Description { get; set; }

        private Collection<ContactListMember> _members = new Collection<ContactListMember>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public Collection<ContactListMember> Members
        {
            get
            {
                return this._members;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml", DataType = "ID")]
        public string Id { get; set; }
    }
}
