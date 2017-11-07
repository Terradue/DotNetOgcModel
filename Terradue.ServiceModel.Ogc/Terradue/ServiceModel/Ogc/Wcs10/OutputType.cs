namespace Terradue.ServiceModel.Ogc.Wcs10
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wcs")]
    [System.Xml.Serialization.XmlRootAttribute("output", Namespace = "http://www.opengis.net/wcs", IsNullable = false)]
    public class OutputType
    {

        [System.Xml.Serialization.XmlElementAttribute("crs")]
        public string Crs { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("format")]
        public string Format { get; set; }
    }
}