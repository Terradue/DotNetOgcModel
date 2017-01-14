using System.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Configuration
{
    /// <summary>
    /// Represents a ServiceConfiguration section within a configuration file.
    /// </summary>
    public class ServiceConfiguration : ConfigurationSection
    {
        private static ServiceConfiguration _settings;
        /// <summary>
        /// Gets instance of ServiceConfiguration.
        /// </summary>
        public static ServiceConfiguration Settings
        {
            get
            {
                if (_settings == null)
                {
                    _settings = ConfigurationManager.GetSection("ServiceConfiguration") as ServiceConfiguration;
                }

                return _settings;
            }
        }

        /// <summary>
        /// Gets collection of services.
        /// </summary>
        [ConfigurationProperty("services", IsDefaultCollection = true)]
        public ConfigurationCollection<ServiceOperationElement> Services
        {
            get
            {
                var services = (ConfigurationCollection<ServiceOperationElement>)base["services"];
                services.ServiceConfiguration = this;
                return services;
            }
        }

        /// <summary>
        /// Gets collection of response formatters
        /// </summary>
        [ConfigurationProperty("responseFormatters", IsDefaultCollection = true)]
        public ConfigurationCollection<ResponseFormatterElement> ResponseFormatters
        {
            get
            {
                var services = (ConfigurationCollection<ResponseFormatterElement>)base["responseFormatters"];
                services.ServiceConfiguration = this;
                return services;
            }
        }

        /// <summary>
        /// Gets collection of response formatters
        /// </summary>
        [ConfigurationProperty("managers", IsDefaultCollection = true)]
        public ConfigurationCollection<ManagerElement> ServiceManagers
        {
            get
            {
                var services = (ConfigurationCollection<ManagerElement>)base["managers"];
                services.ServiceConfiguration = this;
                return services;
            }
        }

        /// <summary>
        /// Gets or sets default service name. Must be three character service name.
        /// </summary>
        /// <example>SOS, SAS etc'</example>
        [ConfigurationProperty("defaultService", IsRequired = true)]
        [RegexStringValidator(@"^(\w{3})?$")]
        public string DefaultService
        {
            get
            {
                return (string)this["defaultService"];
            }

            set
            {
                this["defaultService"] = value;
            }
        }

        /// <summary>
        /// Gets or sets default version
        /// </summary>
        [ConfigurationProperty("defaultVersion", IsRequired = false, DefaultValue = "")]
        [RegexStringValidator(@"^(\d+[.]\d{1,2}[.]\d{1,2})?$")]
        public string DefaultVersion
        {
            get
            {
                return (string)this["defaultVersion"];
            }
            set
            {
                this["defaultVersion"] = value;
            }
        }

        /// <summary>
        /// Gets or sets connection string to be used by this operation handler
        /// </summary>
        [ConfigurationProperty("defaultConnection", IsRequired = true)]
        [RegexStringValidator(@"^(\w+)?$")]
        public string DefaultConnectionString
        {
            get
            {
                return (string)this["defaultConnection"];
            }
            set
            {
                this["defaultConnection"] = value;
            }
        }

        /// <summary>
        /// Gets or sets connection string to be used by this operation handler
        /// </summary>
        [ConfigurationProperty("cacheTimeout", IsRequired = false, DefaultValue = 20)]
        public int CacheTimeout
        {
            get
            {
                return (int)this["cacheTimeout"];
            }
            set
            {
                this["cacheTimeout"] = value;
            }
        }
    }
}

