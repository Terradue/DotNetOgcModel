using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("EventList", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class EventList
    {
        private Collection<EventListMember> _members = new Collection<EventListMember>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public Collection<EventListMember> Members
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
