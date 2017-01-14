using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <summary>
    /// General metadata for this specific server.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceIdentification", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class ServiceIdentification : DescriptionType
    {
        /// <summary>
        /// A service type name from a registry of services.
        /// </summary>
        /// <example>For example, the values of the codeSpace URI and name and code string may be "OGC" and "catalogue." This type name is normally used for machine-to-machine communication.</example>
        [System.Xml.Serialization.XmlElementAttribute("ServiceType")]
        public CodeType ServiceType
        {
            get;
            set;
        }

        private Collection<string> _serviceTypeVersions = new Collection<string>();
        /// <summary>
        /// Unordered list of one or more versions of this service type implemented by this server.
        /// </summary>
        /// <remarks>This information is not adequate for version negotiation, and shall not be used for that purpose.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ServiceTypeVersion")]
        public Collection<string> ServiceTypeVersions
        {
            get { return _serviceTypeVersions; }
        }

        private Collection<string> _profiles = new Collection<string>();
        /// <summary>
        /// Unordered list of identifiers of Application Profiles that are implemented by this server.
        /// </summary>
        /// <remarks>This information is not adequate for version negotiation, and shall not be used for that purpose.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Profile", DataType = "anyURI")]
        public Collection<string> Profiles
        {
            get
            {
                return this._profiles;
            }
        }

        /// <summary>
        /// Fees and terms for using this server, including the monetary units as specified in ISO 4217
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Fees")]
        public string Fees
        {
            get;
            set;
        }
        private Collection<string> _accessConstraints = new Collection<string>();
        /// <summary>
        /// Unordered list of access constraints applied to assure the protection of privacy or intellectual property, and any other restrictions on retrieving or using data from or otherwise using this server.
        /// </summary>
        /// <remarks>The reserved value NONE (case insensitive) shall be used to mean no access constraints are imposed. When this element is omitted, no meaning is implied.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AccessConstraints")]
        public Collection<string> AccessConstraints
        {
            get
            {
                return this._accessConstraints;
            }
        }

    }
}
