
namespace Terradue.ServiceModel.Ogc.WebService
{
    /// <summary>
    /// Specifies list output format MIME types used by the application.
    /// </summary>
    public enum OutputFormat
    {
        /// <summary>
        /// text/xml MIME types
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("text/xml")]
        TextXml,

        /// <summary>
        /// text/csv MIME types
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("text/csv")]
        TextCsv,

        /// <summary>
        /// text/plain MIME types
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("text/plain")]
        TextPlain,

        /// <summary>
        /// application/xml MIME types
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("application/xml")]
        ApplicationXml,

        /// <summary>
        /// text/xml-external-parsed-entity MIME types
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("text/xml-external-parsed-entity")]
        TextXmlExternalParsedEntity,

        /// <summary>
        /// text/xml-external-parsed-entity MIME types
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("application/xml-external-parsed-entity")]
        ApplicationXmlExternalParsedEntity,

        /// <summary>
        /// application/vnd.ogc.waterml2+xml (Waterml2) MIME Type
        /// </summary>
        // fails in content [System.Xml.Serialization.XmlEnumAttribute("application/gml+xml; subtype=\"waterml2/1.0\"")]
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ogc.waterml2+xml")]
        ApplicationXmlWaterMl2,
    }
}
