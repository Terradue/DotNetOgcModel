namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <summary>
    /// Specifies list of OGC exception types
    /// </summary>
    public enum ExceptionCode
    {
        /// <summary>
        /// Request is for an operation that is not supported by this server.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OperationNotSupported")]
        OperationNotSupported,

        /// <summary>
        /// Operation request does not include a parameter value.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("MissingParameterValue")]
        MissingParameterValue,

        /// <summary>
        /// Operation request contains an invalid parameter value.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("InvalidParameterValue")]
        InvalidParameterValue,

        /// <summary>
        /// List of versions in “AcceptVersions” parameter value, in GetCapabilities operation request, did not include any version supported by this server.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("VersionNegotiationFailed")]
        VersionNegotiationFailed,

        /// <summary>
        /// Value of (optional) updateSequence parameter, in GetCapabilities operation request, is greater than current value of service metadata updateSequence number.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("InvalidUpdateSequence")]
        InvalidUpdateSequence,

        /// <summary>
        /// Request is for an option that is not supported by this server.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("OptionNotSupported")]
        OptionNotSupported,

        /// <summary>
        /// No other exceptionCode specified by this service and server applies to this exception
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NoApplicableCode")]
        NoApplicableCode,
    }
}
