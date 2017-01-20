using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Swe10;

namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    public class BinaryTemporalOpType : TemporalOpsType
    {
        private Collection<PropertyNameType> _propertyNames = new Collection<PropertyNameType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyName")]
        public Collection<PropertyNameType> PropertyNames
        {
            get
            {
                return this._propertyNames;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeAggregate", Type = typeof(TimeAggregateType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("TimeIntervalGrid", Type = typeof(TimeIntervalGridType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("TimeInstantGrid", Type = typeof(TimeInstantGridType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("TimeGeometricComplex", Type = typeof(TimeGeometricComplexType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("TimeTopologyComplex", Type = typeof(TimeTopologyComplexType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("TimeGrid", Type = typeof(TimeGridType), Namespace = "http://www.opengis.net/swe/1.0.1")]
        [System.Xml.Serialization.XmlElementAttribute("TimeEdge", Type = typeof(TimeEdgeType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("TimeNode", Type = typeof(TimeNodeType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("TimePeriod", Type = typeof(TimePeriodType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("TimeInstant", Type = typeof(TimeInstantType), Namespace = "http://www.opengis.net/gml")]
        public AbstractTimeObjectType Time { get; set; }

        /// <summary>
        /// Helper method to get typed Time
        /// </summary>
        /// <typeparam name="T">Valid types as TimeAggregateType, TimeIntervalGridType, TimeInstantGridType, TimeGeometricComplexType, TimeTopologyComplexType, TimeGridType, TimeEdgeType, TimeNodeType, TimePeriodType and TimeInstantType</typeparam>
        /// <returns></returns>
        public T GetTime<T>()
            where T : class
        {
            return this.Time as T;
        }
    }
}
