using System;
using System.Globalization;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Exceptions;
using Terradue.ServiceModel.Ogc.Ows11;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies request to a SOS to perform the GetCapabilities operation. 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace = "http://www.opengis.net/sos/2.0", IsNullable = false)]
    public class GetCapabilities : GetCapabilitiesType
    {
        /// <summary>
        /// Holds service name support by the object
        /// </summary>
        private readonly string _service = "SOS";

        /// <summary>
        /// Creates a default instance of <see cref="GetCapabilities"/>.
        /// </summary>
        public GetCapabilities()
        {
            Init();
        }

        /// <summary>
        /// Creates an instance of <see cref="GetCapabilities"/>.
        /// </summary>
        /// <param name="queryParameters">Object initial parameters.</param>
        public GetCapabilities(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            Init();

            this.UpdateSequence = queryParameters["updateSequence"];
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <summary>
        /// Perfoms object initialization tasks
        /// </summary>
        private void Init()
        {
            this.Service = this._service;

            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add("fes", "http://www.opengis.net/fes/2.0");
            this.Xmlns.Add("gml", "http://www.opengis.net/gml/3.2");
            this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            this.Xmlns.Add("swe", "http://www.opengis.net/swe/2.0");
            this.Xmlns.Add("swe", "http://www.opengis.net/swes/2.0");
            this.Xmlns.Add("om", "http://www.opengis.net/om/2.0");
            this.Xmlns.Add("sos", "http://www.opengis.net/sos/2.0");
            this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("wsa", "http://www.w3.org/2005/08/addressing");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (!this.Service.Equals(this._service, StringComparison.OrdinalIgnoreCase))
                throw new OptionNotSupportedException(string.Format(CultureInfo.CurrentCulture, "Service '{0}' is not supported.", this.Service));
        }
    }
}
