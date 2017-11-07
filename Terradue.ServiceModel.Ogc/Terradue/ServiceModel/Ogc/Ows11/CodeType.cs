namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <summary>
    /// Name or code with an (optional) authority. 
    /// </summary>
    /// <remarks>If the codeSpace attribute is present, its value shall reference a dictionary, thesaurus, or authority for the name or code, such as the organisation who assigned the value, or the dictionary from which it is taken.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CodeType", Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Role", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class CodeType
    {
        /// <remarks/>
        public CodeType()
        {

        }

        /// <remarks/>
        public CodeType(string value)
            : this()
        {
            this.Value = value;

        }

        /// <remarks/>
        public CodeType(string value, string codeSpace)
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
        public static implicit operator CodeType(string d)
        {
            return new CodeType() { Value = d };
        }

        /// <remarks/>
        public static implicit operator string(CodeType c)
        {
            return c.Value;
        }

        /// <summary>
        /// Converts to <see cref="CodeType"/> type.
        /// </summary>
        /// <param name="d">Value to convert.</param>
        /// <returns></returns>
        public static CodeType ToCodeType(string d)
        {
            return (CodeType)d;
        }

        /// <summary>
        /// Converts from <see cref="CodeType"/> type.
        /// </summary>
        /// <param name="c">Value to convert.</param>
        /// <returns></returns>
        public static string FromCodeType(CodeType c)
        {
            return (string)c;
        }
    }
}
