namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataArrayType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public abstract class AbstractDataArrayType : AbstractDataComponentType
    {
        private DataArrayTypeElementCount _elementCount = new DataArrayTypeElementCount();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("elementCount")]
        public DataArrayTypeElementCount ElementCount
        {
            get { return this._elementCount; }
            set { this._elementCount = value; }
        }
    }
}
