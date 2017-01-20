using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <summary>
    /// A phenomenon defined as a base property convolved with a set of constraints
    /// The set of constraints may be either
    /// * an explicit set of soft-typed measures, intervals and categories
    /// * one or more lists of soft-typed measures, intervals and categories
    /// * one or more sequences of soft-typed measures and intervals
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("PhenomenonSeries", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class PhenomenonSeriesType : CompoundPhenomenonType
    {
        /// <summary>
        /// Phenomenon that forms the basis for generating a set of more refined Phenomena; e.g. Chemical Composition, Radiance
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("base")]
        public PhenomenonPropertyType Base { get; set; }

        private Collection<DataArrayPropertyType> _constraints = new Collection<DataArrayPropertyType>();
        /// <summary>
        /// A set of values of some secondary property that constraints the basePhenomenon to generate a Phenomenon set.
        /// If more than one set of constraints are possible, then these are applied simultaneously to generate
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("constraintList")]
        public Collection<DataArrayPropertyType> Constraints
        {
            get
            {
                return this._constraints;
            }
        }

        private Collection<string> _otherConstraints = new Collection<string>();
        /// <summary>
        /// Other constraints are described in text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("otherConstraint")]
        public Collection<string> OtherConstraints
        {
            get
            {
                return this._otherConstraints;
            }
        }
    }
}
