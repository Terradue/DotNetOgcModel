using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Renci.Ogc.WebService.Common
{
    /// <summary>
    /// Specifies URN string which follows OGC specified standards.
    /// </summary>
    public class UrnString
    {
        /// <summary>
        /// Identifies branh type of UrnString
        /// </summary>
        private string _branchType;

        /// <summary>
        /// Regular expresion to parse and validate urn string
        /// </summary>
        private static Regex _regex = new Regex(@"^(urn:ogc:(?<branch>def):(?<objectType>property|axis|axisDirection|coordinateOperation|crs|cs|datum|dataType|derivedCRSType|documentType|ellipsoid|featureType|feature|group|meaning|meridian|method|nil|parameter|phenomenon|pixelInCell|rangeMeaning|referenceSystem|uom|verticalDatumType):(?<authority>EDCS|EPSG|OGC|SI|UCUM)(:(?<version>\d{1,2}[.]\d\d?([.]\d)?))?:(?<code>[^:]+))|(urn:ogc:(?<branch>serviceType):(?<name>[^:]+):(?<version>\d{1,2}[.]\d\d?([.]\d)?):(?<binding>[^:]+)?(:(?<profile>[^:]+))?)|(urn:ogc:(?<branch>specification):(?<name>[^:]+):(?<version>\d{1,2}[.]\d\d?([.]\d)?):(?<type>(is|isc|ap|rp|bp|dp|wp|rfc|cr))?(:(?<status>(active|draft|deprecated|retired|corrigendum)))?)$", RegexOptions.Compiled);

        /// <summary>
        /// Gets OGC UrnString for a property.
        /// </summary>
        /// <param name="name">Property name</param>
        /// <returns>OGC compliant property urn string</returns>
        public static UrnString GetPropertyUrn(string name)
        {
            return GetUrnString("property", name.ToOgcId());
        }

        /// <summary>
        /// Gets the name of the property from OGC urn string.
        /// </summary>
        /// <param name="urn">The urn.</param>
        /// <returns></returns>
        public static string GetPropertyName(string urn)
        {
            return GetUrnValue(urn);
        }

        /// <summary>
        /// Gets OGC UrnString for a sensor.
        /// </summary>
        /// <param name="name">Sensor name</param>
        /// <returns>OGC compliant sensor urn string</returns>
        public static UrnString GetSensorUrn(string name)
        {
            return GetUrnString("featureType", name.ToOgcId());
        }

        /// <summary>
        /// Gets the name of the sensor from OGC urn string.
        /// </summary>
        /// <param name="urn">The urn.</param>
        /// <returns></returns>
        public static string GetSensorName(string urn)
        {
            return GetUrnValue(urn.ToOgcId());
        }

        /// <summary>
        /// Gets OGC UrnString for a feature of interest.
        /// </summary>
        /// <param name="name">Feature of interest name</param>
        /// <returns>OGC compliant feature of interest urn string</returns>
        public static UrnString GetFeatureOfInterestUrn(string name)
        {
            return GetUrnString("feature", name.ToOgcId());
        }

        /// <summary>
        /// Gets the name of the feature of interest from OGC urn string.
        /// </summary>
        /// <param name="urn">The urn.</param>
        /// <returns></returns>
        public static string GetFeatureOfInterestName(string urn)
        {
            return GetUrnValue(urn);
        }

        /// <summary>
        /// Gets the value from OGC urn string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string GetUrnValue(string name)
        {
            return new UrnString(name).Value;
        }

        /// <summary>
        /// Gets OGC compliant urn string for specific defintion and name
        /// </summary>
        /// <param name="definition">Definition</param>
        /// <param name="name">Name</param>
        /// <returns>OGC compliant urn string</returns>
        private static UrnString GetUrnString(string definition, string name)
        {
            return new UrnString(string.Format(CultureInfo.InvariantCulture, "urn:ogc:def:{0}:OGC:{1}", definition, name));
        }

        /// <summary>
        /// Creates instance of <see cref="UrnString"/> from provided urn string.
        /// </summary>
        /// <param name="urn">Urn string representation</param>
        public UrnString(string urn)
        {
            Match match = _regex.Match(urn);

            if (!match.Success)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "'{0}' is not a valid urn ogc string.", urn));
            }

            this._branchType = match.Result("${branch}");

            switch (this._branchType)
            {
                case "def":
                    this.DefinitionObjectType = match.Result("${objectType}");
                    this.DefinitionAuthority = match.Result("${authority}");
                    this.Version = match.Result("${version}");
                    this.Value = match.Result("${code}");
                    break;
                case "serviceType":
                    this.ServiceBinding = match.Result("${binding}");
                    this.ServiceProfile = match.Result("${profile}");
                    this.Version = match.Result("${version}");
                    this.Value = match.Result("${code}");
                    break;
                case "specification":
                    this.SpecificationType = match.Result("${type}");
                    this.SpecificationStatus = match.Result("${status}");
                    this.Version = match.Result("${version}");
                    this.Value = match.Result("${code}");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Gets or sets version used by URN string.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the name of specification, name of service type or code name in definition branch.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets binding when service type branch is used.
        /// </summary>
        public string ServiceBinding { get; set; }

        /// <summary>
        /// Gets or sets profile when service type branch is used.
        /// </summary>
        public string ServiceProfile { get; set; }

        /// <summary>
        /// Gets or sets a type when specification branch is used.
        /// </summary>
        public string SpecificationType { get; set; }

        /// <summary>
        /// Gets or sets a status when specification branch is used.
        /// </summary>
        public string SpecificationStatus { get; set; }

        /// <summary>
        /// Gets or sets object type when definition branch is used
        /// </summary>
        public string DefinitionObjectType { get; set; }

        /// <summary>
        /// Gets or sets authority when definition branch is used
        /// </summary>
        public string DefinitionAuthority { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="UrnString"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (this._branchType)
            {
                case "def":
                    string version = string.IsNullOrEmpty(this.Version) ? string.Empty : string.Format(CultureInfo.InvariantCulture, ":{0}", this.Version);
                    return string.Format(CultureInfo.InvariantCulture, "urn:ogc:def:{0}:{1}{2}:{3}", this.DefinitionObjectType, this.DefinitionAuthority, version, this.Value);

                case "serviceType":
                    string profile = string.IsNullOrEmpty(this.ServiceProfile) ? string.Empty : string.Format(CultureInfo.InvariantCulture, ":{0}", this.ServiceProfile);
                    return string.Format(CultureInfo.InvariantCulture, "urn:ogc:serviceType:{0}:{1}:{2}{3}", this.Value, this.Version, this.ServiceBinding, profile);

                case "specification":
                    return string.Format(CultureInfo.InvariantCulture, "urn:ogc:specification:{0}:{1}:{2}:{3}", this.Value, this.Version, this.SpecificationType, this.SpecificationStatus);
                default:
                    break;
            }

            return base.ToString();
        }

        /// <summary>
        /// Implicitly converts <see cref="System.String"/> into <see cref="UrnString"/>
        /// </summary>
        /// <param name="urnText"></param>
        /// <returns></returns>
        public static implicit operator UrnString(string urnText)
        {
            return new UrnString(urnText);
        }

        /// <summary>
        /// Implicitly converts <see cref="UrnString"/> into <see cref="System.String"/>
        /// </summary>
        /// <param name="urnString"></param>
        /// <returns></returns>
        public static implicit operator string(UrnString urnString)
        {
            return urnString.ToString();
        }
    }
}
