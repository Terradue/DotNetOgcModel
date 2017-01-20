using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Count", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class Count : AbstractDataComponentType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("constraint")]
        public AllowedValuesPropertyType constraint
        {
            get;
            set;
        }

        private Collection<QualityPropertyType> _qualities = new Collection<QualityPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quality")]
        public Collection<QualityPropertyType> Qualities
        {
            get
            {
                return this._qualities;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value", DataType = "integer")]
        public string Value
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("referenceFrame", DataType = "anyURI")]
        public string ReferenceFrame
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("axisID", DataType = "token")]
        public string AxisId
        {
            get;
            set;
        }
    }
}
