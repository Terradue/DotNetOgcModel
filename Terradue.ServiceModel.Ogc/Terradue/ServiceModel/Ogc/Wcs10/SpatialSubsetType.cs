using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.Wcs10
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wcs")]
    [System.Xml.Serialization.XmlRootAttribute("spatialSubset", Namespace = "http://www.opengis.net/wcs", IsNullable = false)]
    public class SpatialSubsetType
    {

        [System.Xml.Serialization.XmlElementAttribute("Envelope", Namespace = "http://www.opengis.net/gml")]
        public EnvelopeType Envelope { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Grid", Namespace = "http://www.opengis.net/gml")]
        public GridType Grid { get; set; }

    }
}