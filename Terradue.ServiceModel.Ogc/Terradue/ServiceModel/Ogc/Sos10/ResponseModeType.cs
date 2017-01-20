namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies forms of the response.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sos/1.0")]
    public enum ResponseModeType
    {
        /// <summary>
        /// Results to appear inline in a resultTag.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("inline")]
        Inline,

        /// <summary>
        /// Results to appear as MIME attachment.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("attached")]
        Attached,

        /// <summary>
        /// Results to appear external to the observation element.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("out-of-band")]
        OutOfBand,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("resultTemplate")]
        ResultTemplate,
    }
}
