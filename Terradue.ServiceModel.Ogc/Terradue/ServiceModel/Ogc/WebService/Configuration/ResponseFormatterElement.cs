using System.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Configuration
{
    /// <summary>
    /// Specifies configuration for response formatter
    /// </summary>
    public class ResponseFormatterElement : ConfigurationElement, IConfigurationElement
    {
        #region IConfigurationElement Members

        /// <summary>
        /// Gets or sets service configuration name
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        /// <summary>
        /// Gets or sets service configuration settings
        /// </summary>
        /// <value>The service configuration settings.</value>
        public ServiceConfiguration ServiceConfiguration { get; set; }

        #endregion

        /// <summary>
        /// Gets or sets service name. Must be three character service name.
        /// </summary>
        /// <example>SOS, SAS etc'</example>
        [ConfigurationProperty("contentType", IsRequired = true)]
        public string ContentType
        {
            get
            {
                return (string)this["contentType"];
            }
            set
            {
                this["contentType"] = value;
            }
        }

        /// <summary>
        /// Gets or sets service name. Must be three character service name.
        /// </summary>
        /// <example>SOS, SAS etc'</example>
        [ConfigurationProperty("type", IsRequired = true)]
        public string HandlerType
        {
            get
            {
                return (string)this["type"];
            }
            set
            {
                this["type"] = value;
            }
        }
    }
}
