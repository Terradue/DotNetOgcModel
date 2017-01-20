using System.Collections.ObjectModel;
namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public class FunctionNamesType
    {
        private Collection<FunctionNameType> _functionName = new Collection<FunctionNameType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionName")]
        public Collection<FunctionNameType> FunctionName 
        {
            get
            {
                return this._functionName;
            }
        }
    }
}
