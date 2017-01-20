using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <summary>
    /// Basic Phenomenon definition, and head of substitution group of specialized phenomenon defs.
    /// gml:description may be used for a more extensive description of the semantics, with a link to a definitive version (if available).
    /// gml:name should be used for the name or label.
    /// Note: In GML 3.2 the gml:identifier element should be used for the identifier assigned by or preferred by the data provider.
    /// This identifier will typically be in the form of a URN, for example following the OGC URN scheme
    /// e.g. urn:x-ogc:def:phenomenon:OGC:Age
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompoundPhenomenonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhenomenonSeriesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositePhenomenonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstrainedPhenomenonType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("Phenomenon", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class PhenomenonType : DefinitionType
    {
    }
}
