using System.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Configuration
{
    /// <summary>
    /// Specifies default value setting
    /// </summary>
    public class DefaultValueElement : ConfigurationElement, IConfigurationElement
    {
        #region IConfigurationElement Members

        /// <summary>
        /// Gets or sets default settings name
        /// </summary>
        /// <value>The name.</value>
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
        /// Gets or sets the default value.
        /// </summary>
        /// <value>The default value.</value>
        [ConfigurationProperty("defaultValue", IsRequired = true, IsKey = true)]
        public string DefaultValue
        {
            get
            {
                return (string)this["defaultValue"];
            }
            set
            {
                this["defaultValue"] = value;
            }
        }
    }
}
