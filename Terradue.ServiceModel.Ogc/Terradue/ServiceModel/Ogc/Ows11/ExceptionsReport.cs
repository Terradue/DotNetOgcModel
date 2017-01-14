using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ExceptionReport
    {
        /// <remarks/>
        public ExceptionReport()
        {
            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add(string.Empty, "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            this.Language = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <summary>
        /// Specification version, in this case the version to which this Exception Report conforms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("version")]
        public string Version { get; set; }

        /// <summary>
        /// Language used by all included exception text values
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lang", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        [System.ComponentModel.DefaultValueAttribute("en")]
        public string Language { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }

        private Collection<ExceptionType> _exceptions = new Collection<ExceptionType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Exception")]
        public Collection<ExceptionType> Exceptions
        {
            get
            {
                return this._exceptions;
            }
        }
    }
}
