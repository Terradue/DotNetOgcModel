using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("TimeIntervalGrid", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class TimeIntervalGridType : TimeGridType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("windowDuration", Type = typeof(string), DataType = "duration")]
        [System.Xml.Serialization.XmlElementAttribute("windowInterval", Type = typeof(TimeIntervalLengthType))]
        public object TimeWindow { get; set; }
    }
}
