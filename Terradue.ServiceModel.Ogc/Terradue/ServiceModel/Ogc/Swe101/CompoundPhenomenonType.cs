namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <summary>
    /// Description of a set of Phenomena.
    /// CompoundPhenomenon is the abstract head of a substitution group of specialized compound phenomena
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhenomenonSeriesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositePhenomenonType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class CompoundPhenomenonType : PhenomenonType
    {
        /// <summary>
        /// The number of components in the tuple
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("dimension", DataType = "positiveInteger")]
        public string Dimension { get; set; }
    }
}
