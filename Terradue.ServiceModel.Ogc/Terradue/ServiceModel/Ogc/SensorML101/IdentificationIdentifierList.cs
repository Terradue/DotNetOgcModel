using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class IdentificationIdentifierList
    {
        private Collection<IdentificationIdentifierListIdentifier> _identifiers = new Collection<IdentificationIdentifierListIdentifier>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("identifier")]
        public Collection<IdentificationIdentifierListIdentifier> Identifiers
        {
            get
            {
                return this._identifiers;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id", DataType = "ID")]
        public string Id { get; set; }
    }
}
