using System.Text.RegularExpressions;
using Terradue.ServiceModel.Ogc.Exceptions;

namespace Terradue.ServiceModel.Ogc
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public abstract class OwsRequestBase
    {
        private Regex _validVersion = new Regex(@"^(\d+[.]\d{1,2}[.]\d{1,2})?$");

        /// <summary>
        /// Gets service type identifier
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("service")]
        public string Service { get; set; }

        /// <summary>
        /// Gets specification version for operation
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("version")]
        public string Version { get; set; }
        public object Name { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected OwsRequestBase()
        {
        }

        /// <summary>
        /// Creates an object based on parameters if provided
        /// </summary>
        /// <param name="queryParameters">Name value collection of parameters passed in query string</param>
        protected OwsRequestBase(System.Collections.Specialized.NameValueCollection queryParameters)
            : this()
        {
            //  If no parameters are specified then do nothing
            if (queryParameters == null)
                return;

            this.Service = queryParameters["service"] ?? this.Service;
            this.Version = queryParameters["version"] ?? this.Version ?? string.Empty;
        }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public virtual void Validate()
        {
            if (string.IsNullOrEmpty(this.Service))
                throw new MissingParameterValueException("service");

            if (!string.IsNullOrEmpty(this.Version))
                if (!_validVersion.Match(this.Version).Success)
                {
                    throw new InvalidParameterValueException("version", this.Version);
                }
        }
    }
}
