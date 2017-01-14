using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using Terradue.ServiceModel.Ogc.Exceptions;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("GetResourceByID", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class GetResourceByIdType : OwsRequestBase
    {
        private Regex _validOutputFormat = new Regex(@"text/xml");

        private Collection<string> _resourceIds = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceID", DataType = "anyURI")]
        public Collection<string> ResourceID
        {
            get
            {
                return this._resourceIds;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutputFormat")]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetResourceByIdType()
            : base()
        {
        }

        /// <summary>
        /// Creates an object based on parameters if provided
        /// </summary>
        /// <param name="queryParameters">Name value collection of parameters passed in query string</param>
        public GetResourceByIdType(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            //  If no parameters are specified then do nothing
            if (queryParameters == null)
                return;

            string resourceIds = queryParameters["ResourceID"] ?? string.Empty;
            this.OutputFormat = queryParameters["OutputFormat"];

            foreach (string resourceId in resourceIds.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries))
            {
                this.ResourceID.Add(resourceId);
            }
        }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (this.ResourceID.Count == 0)
            {
                throw new MissingParameterValueException("ResourceID");
            }

            if (!string.IsNullOrEmpty(this.OutputFormat) && !_validOutputFormat.Match(this.OutputFormat).Success)
            {
                throw new InvalidParameterValueException("OutputFormat", this.OutputFormat);
            }
        }
    }
}
