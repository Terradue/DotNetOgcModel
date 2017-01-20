using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Exceptions;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <summary>
    /// Specifies a request to perform an operation to request detailed sensor metadata.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeSensor", Namespace = "http://www.opengis.net/sos/1.0", IsNullable = false)]
    public class DescribeSensor : RequestBaseType
    {
        /// <summary>
        /// Regular expression to validate agains suported output format parameter
        /// </summary>
        private Regex _validOutputFormat = new Regex(@"text/xml");

        /// <summary>
        /// Creates a default instance of <see cref="DescribeSensor"/>.
        /// </summary>
        public DescribeSensor()
        {
            Init();
        }

        /// <summary>
        /// Creates an instance of <see cref="DescribeSensor"/>.
        /// </summary>
        /// <param name="queryParameters">Object initial parameters.</param>
        public DescribeSensor(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            Init();

            this.Procedure = queryParameters["procedure"] ?? queryParameters["SensorId"] ?? string.Empty;
            this.OutputFormat = queryParameters["outputFormat"];
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <summary>
        /// Gets or sets an identifier of the sensor, for which detailed metadata is requested.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("procedure", DataType = "anyURI")]
        public string Procedure { get; set; }

        /// <summary>
        /// Gets or sets an identifier of the output format to be used for the requested data. 
        /// </summary>
        /// <remarks>
        /// Default value is tex/xml;subtype="sensorML/1.0.0".
        /// </remarks>
        /// <exception cref="OptionNotSupportedException">Requested output format is not supported by the SOS server</exception>
        [System.Xml.Serialization.XmlAttributeAttribute("outputFormat")]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Perfoms object initialization tasks
        /// </summary>
        private void Init()
        {
            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add(string.Empty, "http://www.opengis.net/sos/1.0");
            this.Xmlns.Add("gml", "http://www.opengis.net/gml");
            this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            this.Xmlns.Add("swe", "http://www.opengis.net/swe/1.0.1");
            this.Xmlns.Add("om", "http://www.opengis.net/om/1.0");
            this.Xmlns.Add("sos", "http://www.opengis.net/sos/1.0");
            this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("ogc", "http://www.opengis.net/ogc");
            this.Xmlns.Add("tml", "http://www.opengis.net/tml");
            this.Xmlns.Add("sml", "http://www.opengis.net/sensorML/1.0.1");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (string.IsNullOrEmpty(this.Service))
                throw new MissingParameterValueException("Procedure");

            if (string.IsNullOrEmpty(this.OutputFormat))
                throw new MissingParameterValueException("OutputFormat");

            if (!string.IsNullOrEmpty(this.OutputFormat) && !_validOutputFormat.Match(this.OutputFormat).Success)
            {
                throw new InvalidParameterValueException("OutputFormat", this.OutputFormat);
            }
        }
    }
}
