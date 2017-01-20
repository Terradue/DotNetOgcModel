using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.Ogc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("DWithin", Namespace = "http://www.opengis.net/ogc", IsNullable = false)]
    public class DistanceBufferType : SpatialOpsType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyName")]
        public PropertyNameType PropertyName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Grid", Type = typeof(GridType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("RectifiedGrid", Type = typeof(RectifiedGridType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("MultiPolygon", Type = typeof(MultiPolygonType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("MultiLineString", Type = typeof(MultiLineStringType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("MultiSolid", Type = typeof(MultiSolidType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("MultiSurface", Type = typeof(MultiSurfaceType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("MultiCurve", Type = typeof(MultiCurveType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("MultiPoint", Type = typeof(MultiPointType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("MultiGeometry", Type = typeof(MultiGeometryType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("Ring", Type = typeof(RingType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("LinearRing", Type = typeof(LinearRingType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("CompositeSolid", Type = typeof(CompositeSolidType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("Solid", Type = typeof(SolidType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("CompositeSurface", Type = typeof(CompositeSurfaceType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("OrientableSurface", Type = typeof(OrientableSurfaceType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("TriangulatedSurface", Type = typeof(TriangulatedSurfaceType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("Tin", Type = typeof(TinType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("PolyhedralSurface", Type = typeof(PolyhedralSurfaceType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("Polygon", Type = typeof(PolygonType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("CompositeCurve", Type = typeof(CompositeCurveType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("OrientableCurve", Type = typeof(OrientableCurveType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("Curve", Type = typeof(CurveType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("LineString", Type = typeof(LineStringType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("Point", Type = typeof(PointType), Namespace = "http://www.opengis.net/gml")]
        [System.Xml.Serialization.XmlElementAttribute("Surface", Type = typeof(SurfaceType), Namespace = "http://www.opengis.net/gml")]
        public AbstractGeometryType Geometry { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distance")]
        public DistanceType Distance { get; set; }
    }

}
