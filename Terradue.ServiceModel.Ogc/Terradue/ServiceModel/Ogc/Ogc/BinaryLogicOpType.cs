using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public abstract class BinaryLogicOpType : LogicOpsType
    {
        private Collection<object> _items = new Collection<object>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("And", typeof(AndBinaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("BBOX", typeof(BBOXType))]
        [System.Xml.Serialization.XmlElementAttribute("Beyond", typeof(BeyondDistanceBufferType))]
        [System.Xml.Serialization.XmlElementAttribute("Contains", typeof(ContainsBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Crosses", typeof(CrossesBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("DWithin", typeof(DWithinDistanceBufferType))]
        [System.Xml.Serialization.XmlElementAttribute("Disjoint", typeof(DisjointBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Equals", typeof(EqualsBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersects", typeof(IntersectsBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Not", typeof(NotUnaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Or", typeof(OrBinaryLogicOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Overlaps", typeof(OverlapsBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsBetween", typeof(PropertyIsBetweenType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsEqualTo", typeof(PropertyIsEqualToType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsGreaterThan", typeof(PropertyIsGreaterThanType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsGreaterThanOrEqualTo", typeof(PropertyIsGreaterThanOrEqualToType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLessThan", typeof(PropertyIsLessThanType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLessThanOrEqualTo", typeof(PropertyIsLessThanOrEqualToType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsLike", typeof(PropertyIsLikeType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsNotEqualTo", typeof(PropertyIsNotEqualToType))]
        [System.Xml.Serialization.XmlElementAttribute("PropertyIsNull", typeof(PropertyIsNullType))]
        [System.Xml.Serialization.XmlElementAttribute("Touches", typeof(TouchesBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("Within", typeof(WithinBinarySpatialOpType))]
        [System.Xml.Serialization.XmlElementAttribute("comparisonOps", typeof(ComparisonOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("logicOps", typeof(LogicOpsType))]
        [System.Xml.Serialization.XmlElementAttribute("spatialOps", typeof(SpatialOpsType))]
        public Collection<object> Items
        {
            get
            {
                return this._items;
            }
        }
    }
}
