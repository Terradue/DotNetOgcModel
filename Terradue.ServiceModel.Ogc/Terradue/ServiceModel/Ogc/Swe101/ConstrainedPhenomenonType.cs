using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <summary>
    /// A scalar Phenomenon is defined by adding constraints to an existing property.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("ConstrainedPhenomenon", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class ConstrainedPhenomenonType : PhenomenonType
    {
        /// <summary>
        /// Property that forms the basis for generating a set of more refined Phenomena; e.g. Chemical Composition, Radiance
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("base")]
        public PhenomenonPropertyType Base
        {
            get;
            set;
        }

        private Collection<string> _otherConstraints = new Collection<string>();
        /// <summary>
        /// Constraints that cannot be expressed as values of an orthogonal/helper phenomenon
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("otherConstraint")]
        public Collection<string> OtherConstraints
        {
            get
            {
                return this._otherConstraints;
            }
        }

        private Collection<AnyDataPropertyType> _singleConstraints = new Collection<AnyDataPropertyType>();
        /// <summary>
        /// Constraint expressed as a value or range of an orthogonal/helper phenomenon
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("singleConstraint")]
        public Collection<AnyDataPropertyType> SingleConstraints
        {
            get
            {
                return this._singleConstraints;
            }
        }
    }
}
