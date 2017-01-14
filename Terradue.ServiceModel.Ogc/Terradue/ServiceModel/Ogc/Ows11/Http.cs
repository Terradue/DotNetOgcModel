using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("HTTP", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class Http
    {
        private Collection<RequestMethodType> _getMethods = new Collection<RequestMethodType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Get", Type = typeof(RequestMethodType))]
        public Collection<RequestMethodType> GetMethods
        {
            get
            {
                return this._getMethods;
            }
        }

        private Collection<RequestMethodType> _postMethods = new Collection<RequestMethodType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Post", Type = typeof(RequestMethodType))]
        public Collection<RequestMethodType> PostMethods
        {
            get
            {
                return this._postMethods;
            }
        }
    }
}
