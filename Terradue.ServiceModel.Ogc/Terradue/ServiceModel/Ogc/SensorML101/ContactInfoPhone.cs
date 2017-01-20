using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    public class ContactInfoPhone
    {
        private Collection<string> _voice = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("voice")]
        public Collection<string> Voice
        {
            get
            {
                return this._voice;
            }
        }

        private Collection<string> _facsimile = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("facsimile")]
        public Collection<string> Facsimile
        {
            get
            {
                return this._facsimile;
            }
        }
    }
}
