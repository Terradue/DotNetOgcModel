namespace Renci.Ogc.WebService.Common
{
    public enum UrnSpecificationStatus
    {
        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("active")]
        Active,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("draft")]
        Draft,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("deprecated")]
        Deprecated,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("retired")]
        Retired,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("corrigendum")]
        Corrigendum,
    }
}
