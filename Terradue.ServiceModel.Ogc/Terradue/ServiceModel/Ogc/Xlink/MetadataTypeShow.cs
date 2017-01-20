namespace Terradue.ServiceModel.Ogc.Xlink
{
    /// <summary>
    /// Specifies desired presentation of the ending resource on traversal from the starting resource.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")]
    public enum MetadataTypeShow
    {
        /// <summary>
        /// Load the resource in a new window, frame, pane, or other presentation context
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("new")]
        New,

        /// <summary>
        /// Load the resource in the same window, frame, pane, or other presentation context
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("replace")]
        Replace,

        /// <summary>
        /// Load the resource in place of the presentation of the starting resource
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("embed")]
        Embed,

        /// <summary>
        /// Behavior is unconstrained; examine other markup in the  link for hints 
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("other")]
        Other,

        /// <summary>
        /// Behavior is unconstrained
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("none")]
        None,
    }
}
