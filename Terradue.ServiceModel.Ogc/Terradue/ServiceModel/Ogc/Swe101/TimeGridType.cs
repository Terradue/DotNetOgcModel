using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeIntervalGridType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantGridType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class TimeGridType : AbstractTimeComplexType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extent")]
        public TimeGridEnvelopePropertyType Extent { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("origin", Type = typeof(TimeInstantPropertyType))]
        [System.Xml.Serialization.XmlElementAttribute("originPos", Type = typeof(TimePositionType))]
        public object TimeOrigin { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offsetDuration", Type = typeof(string), DataType = "duration")]
        [System.Xml.Serialization.XmlElementAttribute("offsetInterval", Type = typeof(TimeIntervalLengthType))]
        public object TimeOffset { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("duration", DataType = "duration")]
        public string Duration { get; set; }
    }
}
