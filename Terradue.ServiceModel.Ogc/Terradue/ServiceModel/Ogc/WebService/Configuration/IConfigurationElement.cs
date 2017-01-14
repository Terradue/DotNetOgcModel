namespace Terradue.ServiceModel.Ogc.WebService.Configuration
{
    /// <summary>
    /// Specifies an interface for configuration element
    /// </summary>
    public interface IConfigurationElement
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets service configuration settings
        /// </summary>
        /// <value>The service configuration settings.</value>
        ServiceConfiguration ServiceConfiguration { get; set; }
    }
}
