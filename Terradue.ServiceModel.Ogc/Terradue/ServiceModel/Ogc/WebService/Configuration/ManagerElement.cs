using System.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Configuration
{
    /// <summary>
    /// Defines configuration of service managers
    /// </summary>
    public class ManagerElement : ConfigurationElement, IConfigurationElement
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
        /// Gets or sets operation handler type
        /// </summary>
        [ConfigurationProperty("type", IsRequired = true)]
        public string ManagerType
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
