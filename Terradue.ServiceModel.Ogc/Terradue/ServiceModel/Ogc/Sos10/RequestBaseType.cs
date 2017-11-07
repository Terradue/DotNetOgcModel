using System.Globalization;
using Terradue.ServiceModel.Ogc.Exceptions;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sos/1.0")]
    public class RequestBaseType : OwsRequestBase
    {
        //  Sets service name
        private readonly string _service = "SOS";

        //  Sets version number
        private readonly string _version = "1.0.0";

        /// <summary>
        /// Default constructor
        /// </summary>
        public RequestBaseType()
            : base()
        {
            this.Service = this._service;
        }

        /// <summary>
        /// Creates an object based on parameters if provided
        /// </summary>
        /// <param name="queryParameters">Name value collection of parameters passed in query string</param>
        public RequestBaseType(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
        }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (this.Version != this._version)
                throw new VersionNegotiationException(string.Format(CultureInfo.InvariantCulture, "Version '{0}' is not supported.", this.Version));
        }
    }
}
