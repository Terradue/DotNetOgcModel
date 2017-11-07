using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Exceptions;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Ogc;

namespace Terradue.ServiceModel.Ogc.Wcs10
{
    /// <summary>
    /// Specifies a request to perform an operation to request sensor data from live sensors as well as sensor data archives.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wcs")]
    [System.Xml.Serialization.XmlRootAttribute("GetCoverage", Namespace = "http://www.opengis.net/wcs", IsNullable = false)]
    public class GetCoverage : RequestBaseType
    {
        /// <summary>
        /// Creates a default instance of <see cref="GetCoverage"/>.
        /// </summary>
        public GetCoverage()
        {
            Init();
        }

        /// <summary>
        /// Creates an instance of <see cref="GetCoverage"/>.
        /// </summary>
        /// <param name="queryParameters">Object initial parameters.</param>
        public GetCoverage(System.Collections.Specialized.NameValueCollection queryParameters)
            : base(queryParameters)
        {
            Init();

        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("sourceCoverage")]
        public string SourceCoverage { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("domainSubset")]
        public DomainSubsetType DomainSubset { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("output")]
        public OutputType Output { get; set; }





        /// <summary>
        /// Perfoms object initialization tasks
        /// </summary>
        private void Init()
        {
            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add(string.Empty, "http://www.opengis.net/wcs");
            this.Xmlns.Add("gml", "http://www.opengis.net/gml");
            this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("ogc", "http://www.opengis.net/ogc");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        /// <summary>
        /// Validates current instance and makes sure that all required properties are set and has corect value
        /// </summary>
        public override void Validate()
        {
            base.Validate();

        }
    }
}
