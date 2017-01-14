namespace Renci.Ogc.WebService.Common
{
    public enum UrnSpecificationType
    {
        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("is")]
        ImplementationSpecification,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("isc")]
        ImplementationSpecificationCorrigendum,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("ap")]
        ApplicationProfile,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("rp")]
        RecommendationPaper,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("bp")]
        BestPracticesPaper,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("dp")]
        DiscussionPaper,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("wp")]
        WhitePaper,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("rfc")]
        RequestForComment,

        /// <remarks />
        [System.Xml.Serialization.XmlEnumAttribute("cr")]
        ChangeRequest,
    }
}
