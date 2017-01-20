using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <summary>
    /// A Phenomenon defined as a set of explicitly enumerated components which may or may not be related to one another.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("CompositePhenomenon", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class CompositePhenomenonType : CompoundPhenomenonType
    {
        /// <summary>
        /// Optional phenomenon that forms the basis for generating more specialized composite Phenomenon by adding more components
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("base")]
        public PhenomenonPropertyType Base { get; set; }

        private Collection<PhenomenonPropertyType> _components = new Collection<PhenomenonPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("component")]
        public Collection<PhenomenonPropertyType> Components
        {
            get
            {
                return this._components;
            }
        }
    }
}
