namespace Terradue.ServiceModel.Ogc.Wcs10
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wcs")]
    [System.Xml.Serialization.XmlRootAttribute("domainSubset", Namespace = "http://www.opengis.net/wcs", IsNullable = false)]
    public class DomainSubsetType
    {
        [System.Xml.Serialization.XmlElementAttribute("spatialSubset")]
        public SpatialSubsetType SpatialSubset { get; set; }



    }
}