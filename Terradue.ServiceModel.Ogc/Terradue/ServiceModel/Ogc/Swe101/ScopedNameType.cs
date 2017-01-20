namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <summary>
    /// Generalized type to be used for a term, keyword or name.
    /// </summary>
    /// <remarks>It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ScopedNameType", Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("name", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class ScopedNameType
    {
        /// <remarks/>
        public ScopedNameType()
        {
        }

        /// <remarks/>
        public ScopedNameType(string value)
            : this()
        {
            this.Value = value;
        }

        /// <remarks/>
        public ScopedNameType(string value, string codeSpace)
            : this(value)
        {
            this.CodeSpace = codeSpace;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
        public string CodeSpace
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get;
            set;
        }

        /// <remarks/>
        public static implicit operator ScopedNameType(string d)
        {
            return new ScopedNameType() { Value = d };
        }

        /// <remarks/>
        public static implicit operator string(ScopedNameType c)
        {
            return c.Value;
        }

        /// <summary>
        /// Converts to <see cref="CodeType"/> type.
        /// </summary>
        /// <param name="d">Value to convert.</param>
        /// <returns></returns>
        public static ScopedNameType ToScopedNameType(string d)
        {
            return (ScopedNameType)d;
        }

        /// <summary>
        /// Converts from <see cref="CodeType"/> type.
        /// </summary>
        /// <param name="c">Value to convert.</param>
        /// <returns></returns>
        public static string FromScopedNameType(ScopedNameType c)
        {
            return (string)c;
        }
    }
}
