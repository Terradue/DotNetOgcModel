using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ConditionalData", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class ConditionalDataType : AbstractDataRecordType
    {
        private Collection<ConditionalDataTypeCase> _case = new Collection<ConditionalDataTypeCase>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("case")]
        public Collection<ConditionalDataTypeCase> Case
        {
            get
            {
                return this._case;
            }
        }
    }
}
