using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.WebService.Common;
using Terradue.ServiceModel.Ogc.WebService.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseSosOperation : Terradue.ServiceModel.Ogc.WebService.BaseOperation
    {
        /// <summary>
        /// Used for thread locking
        /// </summary>
        private static object _lock = new object();

        private BaseUrnManager _urnManager;
        /// <summary>
        /// Gets the urn manager.
        /// </summary>
        /// <value>The urn manager.</value>
        public BaseUrnManager UrnManager
        {
            get
            {
                if (_urnManager == null)
                {
                    this._urnManager = this.CreateManager("UrnManager", new DefaultUrnManager(this)) as BaseUrnManager;
                }
                return this._urnManager;
            }
        }

        private BaseUriManager _uriManager;
        /// <summary>
        /// Gets the URI manager.
        /// </summary>
        /// <value>The URI manager.</value>
        public BaseUriManager UriManager
        {
            get
            {
                if (_uriManager == null)
                {
                    this._uriManager = this.CreateManager("UriManager", new DefaultUriManager(this)) as BaseUriManager;
                }
                return this._uriManager;
            }
        }

        private static IDictionary<string, string> _offeringNames;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        public IDictionary<string, string> OfferingNames
        {
            get
            {
                if (_offeringNames == null)
                {
                    using (SosEntities data = this.GetSosEntities())
                    {
                        var result = from s in data.Offerings
                                     select s;

                        ObjectQuery query = result as ObjectQuery;

                        query.MergeOption = MergeOption.NoTracking;
                        query.EnablePlanCaching = true;

                        lock (_lock)
                        {
                            if (_offeringNames == null)
                            {
                                _offeringNames = (from s in result
                                                  select s).ToDictionary(x => x.Code, x => string.Format(CultureInfo.InvariantCulture, "offering_{0}", x.Code));
                            }
                        }
                    }
                }
                return _offeringNames.ToReadOnly();
            }
        }

        private static IDictionary<string, string> _observationNames;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        public IDictionary<string, string> ObservationNames
        {
            get
            {
                if (_observationNames == null)
                {
                    using (SosEntities data = this.GetSosEntities())
                    {
                        var result = from s in data.Observations
                                     select s;

                        ObjectQuery query = result as ObjectQuery;

                        query.MergeOption = MergeOption.NoTracking;
                        query.EnablePlanCaching = true;

                        lock (_lock)
                        {
                            if (_observationNames == null)
                            {
                                _observationNames = (from s in result
                                                     select s).ToDictionary(x => x.Code, x => string.Format(CultureInfo.InvariantCulture, "observation_{0}", x.Code));
                            }
                        }
                    }
                }
                return _observationNames.ToReadOnly();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSosOperation"/> class.
        /// </summary>
        /// <param name="configuration">Operation configuration.</param>
        protected BaseSosOperation(ServiceOperationElement configuration)
            : base(configuration)
        {
        }

        /// <summary>
        /// Creates and gets a new instance of <see cref="SosEntities"/>.
        /// </summary>
        /// <returns></returns>
        public SosEntities GetSosEntities()
        {
            return new SosEntities(this.ConnectionString);
        }

        #region BaseOperation abstract methods

        /// <summary>
        /// Gets operation parameters list for GetObservation operation
        /// </summary>
        public override abstract Collection<DomainType> OperationParameters { get; }

        /// <summary>
        /// Gets operation dcp list for GetObservation operation
        /// </summary>
        public override abstract Collection<Dcp> OperationDcps { get; }

        /// <summary>
        /// Gets operation constraints list for GetObservation operation
        /// </summary>
        public override abstract Collection<DomainType> OperationConstraints { get; }

        /// <summary>
        /// Gets operation metadata list for GetObservation operation
        /// </summary>
        public override abstract Collection<MetadataType> OperationMetadata { get; }

        /// <summary>
        /// Gets a type of request object to be used for current operation
        /// </summary>
        public override abstract Type RequestType { get; }

        /// <summary>
        /// Process request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Resposne object to be sent back to the client</returns>
        public override abstract OperationResult ProcessRequest(object request);

        #endregion

        /// <summary>
        /// Creates an instance of the specified manager.
        /// </summary>
        /// <param name="managerName">Name of the manager.</param>
        /// <param name="defaultManager">The default manager.</param>
        /// <returns></returns>
        private object CreateManager(string managerName, object defaultManager)
        {
            object manager = null;

            var managerTypeName = (from c in this.Configuration.ServiceConfiguration.ServiceManagers
                                   where c.Name.Equals(managerName, StringComparison.OrdinalIgnoreCase)
                                   select c.ManagerType).SingleOrDefault();

            if (string.IsNullOrEmpty(managerTypeName))
            {
                //  Create default manager
                manager = defaultManager;
            }
            else
            {
                var managerType = Type.GetType(managerTypeName);

                if (managerType == null)
                {
                    throw new ConfigurationErrorsException(string.Format(CultureInfo.InvariantCulture, "Manager '{0}' is not valid. Cannot create type '{1}'.", managerName, managerTypeName));
                }
                manager = Activator.CreateInstance(managerType, new object[] { this });
            }
            return manager;
        }
    }
}
