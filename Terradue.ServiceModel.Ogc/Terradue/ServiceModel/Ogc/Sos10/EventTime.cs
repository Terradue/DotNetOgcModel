
using Terradue.ServiceModel.Ogc.Ogc;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    public class EventTime
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TM_After", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_Before", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_Begins", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_BegunBy", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_Contains", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_During", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_EndedBy", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_Ends", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_Equals", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_Meets", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_MetBy", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_Overalps", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("TM_OverlappedBy", Type = typeof(BinaryTemporalOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TimeType")]
        public BinaryTemporalOpType Time { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public EventTimeType TimeType { get; set; }
    }
}
