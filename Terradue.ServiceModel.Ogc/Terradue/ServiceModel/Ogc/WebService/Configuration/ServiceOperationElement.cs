using System;
using System.Configuration;
using System.Globalization;

namespace Terradue.ServiceModel.Ogc.WebService.Configuration
{
    /// <summary>
    /// Represents a SweServiceRequest element within a configuration file.
    /// </summary>
    public class ServiceOperationElement : ConfigurationElement, IConfigurationElement
    {
        /// <summary>
        /// Holds cached reference to an operation handler
        /// </summary>
        private BaseOperation operation;

        /// <summary>
        /// Holds a reference to default handler type
        /// </summary>
        private Type _handlerType;

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
        [ConfigurationProperty("service", IsRequired = true)]
        [RegexStringValidator(@"^(\w{3})?$")]
        public string Service
        {
            get
            {
                return (string)this["service"];
            }

            set
            {
                this["service"] = value;
            }
        }

        /// <summary>
        /// Gets or sets service operation request name
        /// </summary>
        /// <example>GetCapabilities</example>
        [ConfigurationProperty("operation", IsRequired = true)]
        [RegexStringValidator(@"^([a-zA-Z]+)?$")]
        public string Operation
        {
            get
            {
                return (string)this["operation"];
            }

            set
            {
                this["operation"] = value;
            }
        }

        /// <summary>
        /// Gets or sets version
        /// </summary>
        [ConfigurationProperty("version", IsRequired = false, DefaultValue = "")]
        [RegexStringValidator(@"^(\d+[.]\d{1,2}[.]\d{1,2})?$")]
        public string Version
        {
            get
            {
                return (string)this["version"];
            }
            set
            {
                this["version"] = value;
            }
        }

        /// <summary>
        /// Gets or sets operation handler type
        /// </summary>
        [ConfigurationProperty("type", IsRequired = true)]
        public string DefaultHandlerType
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

        /// <summary>
        /// Gets or sets connection string to be used by this operation handler
        /// </summary>
        [ConfigurationProperty("connection", IsRequired = false)]
        [RegexStringValidator(@"^(\w+)?$")]
        public string ConnectionString
        {
            get
            {
                return string.IsNullOrEmpty(this["connection"] as string) ? this.ServiceConfiguration.DefaultConnectionString : this["connection"] as string;
            }
            set
            {
                this["connection"] = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether cache is enabled or not.
        /// </summary>
        [ConfigurationProperty("cacheEnabled", IsRequired = false, DefaultValue = true)]
        public bool CacheEnabled
        {
            get
            {
                return (bool)this["cacheEnabled"];
            }
            set
            {
                this["cacheEnabled"] = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating when cache timeout.
        /// </summary>
        /// <remarks>
        /// Specifies amount of minutes after which cahce is expired.
        /// </remarks>
        [ConfigurationProperty("cacheTimeout", IsRequired = false, DefaultValue = 20d)]
        public double CacheTimeout
        {
            get
            {
                return (double)this["cacheTimeout"];
            }
            set
            {
                this["cacheTimeout"] = value;
            }
        }

        /// <summary>
        /// Gets collection of services.
        /// </summary>
        [ConfigurationProperty("defaultValues", IsDefaultCollection = true)]
        public ConfigurationCollection<DefaultValueElement> DefaultValues
        {
            get
            {
                return (ConfigurationCollection<DefaultValueElement>)base["defaultValues"];
            }
        }

        /// <summary>
        /// Creates an instance of an operation handler
        /// </summary>
        /// <returns>An operation handler instance</returns>
        public BaseOperation CreateHandlerInstance()
        {
            if (this.operation == null)
            {
                if (this._handlerType == null)
                {
                    this._handlerType = Type.GetType(this.DefaultHandlerType);
                }
                if (this._handlerType == null)
                {
                    throw new ConfigurationErrorsException(string.Format(CultureInfo.InvariantCulture, "Type '{0}' is not found.", this.DefaultHandlerType));
                }

                this.operation = Activator.CreateInstance(this._handlerType, new object[] { this }) as BaseOperation;
            }

            return this.operation;
        }
    }
}
