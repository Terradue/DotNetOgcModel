using System;
using System.Collections.ObjectModel;
using System.Globalization;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.WebService.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService
{
    /// <summary>
    /// Base class for all RequestHandler implementions.
    /// </summary>
    public abstract class BaseOperation
    {
        /// <summary>
        /// Gets an operation configuration information
        /// </summary>
        public ServiceOperationElement Configuration { get; private set; }

        /// <summary>
        /// Gets an operation service name
        /// </summary>
        public string ServiceName { get; private set; }

        /// <summary>
        /// Gets an operation request name
        /// </summary>
        public string RequestName { get; private set; }

        /// <summary>
        /// Gets an operation version
        /// </summary>
        public string Version { get; private set; }

        /// <summary>
        /// Gets an operation connection string
        /// </summary>
        protected string ConnectionString { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOperation"/> class.
        /// </summary>
        /// <param name="configuration">Operation configuration.</param>
        protected BaseOperation(ServiceOperationElement configuration)
        {
            this.Configuration = configuration;

            this.ServiceName = this.Configuration.Service;
            this.RequestName = this.Configuration.Operation;
            this.Version = this.Configuration.Version;

            this.ConnectionString = string.Format(CultureInfo.InvariantCulture, "name={0}", this.Configuration.ConnectionString);

            //  Set service base uri
            this.ServiceBaseUri = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.BaseUri;
        }

        /// <summary>
        /// Gets service base uri
        /// </summary>
        /// <remarks>
        /// Since this property usses current context to initlize its value it must be done before any thread calls this property get method
        /// </remarks>
        public Uri ServiceBaseUri
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets list of configured services
        /// </summary>
        public ConfigurationCollection<ServiceOperationElement> Services
        {
            get
            {
                return ServiceConfiguration.Settings.Services;
            }
        }

        /// <summary>
        /// Gets operation parameters list for GetObservation operation
        /// </summary>
        public abstract Collection<DomainType> OperationParameters { get; }

        /// <summary>
        /// Gets operation dcp list for GetObservation operation
        /// </summary>
        public abstract Collection<Dcp> OperationDcps { get; }

        /// <summary>
        /// Gets operation constraints list for GetObservation operation
        /// </summary>
        public abstract Collection<DomainType> OperationConstraints { get; }

        /// <summary>
        /// Gets operation metadata list for GetObservation operation
        /// </summary>
        public abstract Collection<MetadataType> OperationMetadata { get; }

        /// <summary>
        /// Gets a type of request object to be used for current operation
        /// </summary>
        public abstract Type RequestType { get; }

        /// <summary>
        /// Process request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Resposne object to be sent back to the client</returns>
        public abstract OperationResult ProcessRequest(object request);
    }
}
