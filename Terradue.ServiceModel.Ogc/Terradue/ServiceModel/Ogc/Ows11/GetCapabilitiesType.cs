using System.Collections.ObjectModel;
using System.Linq;

namespace Terradue.ServiceModel.Ogc.Ows11
{

    /// <remarks>
    /// No namespace specified fo rthis class since it will be specified by a concrete class
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract class GetCapabilitiesType : OwsRequestBase
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <remarks>Required for serialization.</remarks>
        public GetCapabilitiesType()
            : base()
        {

        }

        /// <summary>
        /// Creates an object based on parameters if provided
        /// </summary>
        /// <param name="queryParameters">Name value collection of parameters passed in query string</param>
        public GetCapabilitiesType(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            //  If no parameters are specified then do nothing
            if (queryParameters == null)
                return;

            this.UpdateSequence = queryParameters["updateSequence"] ?? string.Empty;
            string acceptFormats = queryParameters["AcceptFormats"] ?? string.Empty;
            string acceptVersions = queryParameters["AcceptVersions"] ?? string.Empty;
            string sections = queryParameters["Sections"] ?? string.Empty;

            var acceptVersionsList = acceptVersions.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries);
            if (acceptVersionsList.Length > 0)
            {
                this.AcceptVersions = acceptVersionsList;
            }

            var acceptFormatsList = acceptFormats.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries);
            if (acceptFormatsList.Length > 0)
            {
                this.AcceptFormats = acceptFormatsList;
            }

            var sectionsList = sections.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries);
            if (sectionsList.Length > 0)
            {
                this.Sections = sectionsList;
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Version", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayAttribute("AcceptVersions")]
        public string[] AcceptVersions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Section", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayAttribute("Sections")]
        public string[] Sections { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputFormat", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayAttribute("AcceptFormats")]
        public string[] AcceptFormats { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("updateSequence")]
        public string UpdateSequence { get; set; }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            //  TODO:   Validate version formats
            //  TODO:   Validate section
            //  TODO:   Validate AcceptFormats
            //  TODO:   Validate updateSequence
        }
    }
}
