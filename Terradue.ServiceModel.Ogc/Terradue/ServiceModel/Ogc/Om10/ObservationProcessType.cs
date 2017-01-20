using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.SensorML101;

namespace Terradue.ServiceModel.Ogc.Om10
{
    /// <summary>
    /// Head of substitution group of observation procedures. 
    /// Use gml:description element to describe the procedure or link to a definitive description.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstrumentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("ObservationProcess", Namespace = "http://www.opengis.net/om/1.0", IsNullable = false)]
    public class ObservationProcessType : AbstractProcessType
    {
        /// <summary>
        /// Code for the particular procedure type.  Usually an item from a list or register of procedures, methods, instrument-types, etc.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("method")]
        public CodeType Method { get; set; }

        /// <summary>
        /// Quality associated systematically with observations made using this procedure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("resultQuality")]
        public AnyOrReferenceType ResultQuality { get; set; }
    }
}
