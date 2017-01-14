namespace Renci.Ogc.WebService.Common
{
    public enum UrnBranchType
    {
        [System.Xml.Serialization.XmlEnumAttribute("def")]
        Definition,

        [System.Xml.Serialization.XmlEnumAttribute("serviceType")]
        ServiceType,

        [System.Xml.Serialization.XmlEnumAttribute("specification")]
        Specification,
    }
}
