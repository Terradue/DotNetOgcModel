using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    public class TelephoneType
    {
        private Collection<string> _phoneNumbers = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Voice")]
        public Collection<string> PhoneNumbers
        {
            get
            {
                return this._phoneNumbers;
            }
        }

        private Collection<string> _faxNumbers = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Facsimile")]
        public Collection<string> FaxNumbers
        {
            get
            {
                return this._faxNumbers;
            }
        }
    }
}
