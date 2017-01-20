using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Caching;
using Terradue.ServiceModel.Ogc.WebService.Common;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Represnts base class for Urn managment
    /// </summary>
    public abstract class BaseUrnManager
    {
        /// <summary>
        /// Gets the cache timeout.
        /// </summary>
        /// <value>The cache timeout.</value>
        public int CacheTimeout
        {
            get
            {
                return this.Operation.Configuration.ServiceConfiguration.CacheTimeout;
            }
        }

        /// <summary>
        /// Gets the operation.
        /// </summary>
        /// <value>The operation.</value>
        public BaseSosOperation Operation { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUrnManager"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        protected BaseUrnManager(BaseSosOperation operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Used for thread locking
        /// </summary>
        private static object _lock = new object();

        /// <summary>
        /// Holds urn string to value reference
        /// </summary>
        private IDictionary<Uri, string> _urnLookup;
        /// <summary>
        /// Gets the urn lookup.
        /// </summary>
        /// <value>The urn lookup.</value>
        protected IDictionary<Uri, string> UrnLookup
        {
            get
            {
                if (this._urnLookup == null)
                {
                    this._urnLookup = System.Web.HttpContext.Current.Cache["__URN_LOOKUP"] as IDictionary<Uri, string>;

                    if (this._urnLookup == null)
                    {
                        this._urnLookup = new Dictionary<Uri, string>();

                        //  Add sensor values to lookup table
                        this._urnLookup = this._urnLookup.Union(UrnSensorNames.ToDictionary(a => a.Value, a => a.Key)).ToDictionary(x => x.Key, x => x.Value);

                        //  Add property values to lookup table
                        this._urnLookup = this._urnLookup.Union(UrnObservedPropertyNames.ToDictionary(a => a.Value, a => a.Key)).ToDictionary(x => x.Key, x => x.Value); ;

                        //  Add feature of interest values to lookup table
                        this._urnLookup = this._urnLookup.Union(UrnFeatureOfInterestNames.ToDictionary(a => a.Value, a => a.Key)).ToDictionary(x => x.Key, x => x.Value); ;

                        System.Web.HttpContext.Current.Cache.Add("__URN_LOOKUP", this._urnLookup, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(this.CacheTimeout), CacheItemPriority.Normal, null);
                    }
                }
                return this._urnLookup;
            }
        }

        private IDictionary<string, Uri> _urnSensorNames;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        protected IDictionary<string, Uri> UrnSensorNames
        {
            get
            {
                if (_urnSensorNames == null)
                {
                    this._urnSensorNames = System.Web.HttpContext.Current.Cache["__URN_SENSORNAMES"] as IDictionary<string, Uri>;

                    if (_urnSensorNames == null)
                    {
                        using (SosEntities data = this.Operation.GetSosEntities())
                        {
                            var result = from s in data.Sensors
                                         select s;

                            ObjectQuery query = result as ObjectQuery;

                            query.MergeOption = MergeOption.NoTracking;
                            query.EnablePlanCaching = true;

                            lock (_lock)
                            {
                                if (_urnSensorNames == null)
                                {
                                    _urnSensorNames = (from s in result
                                                       select s).ToDictionary(x => x.Code, x => this.GetSensorUrn(x.Code));
                                }
                            }

                            System.Web.HttpContext.Current.Cache.Add("__URN_SENSORNAMES", this._urnSensorNames, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(this.CacheTimeout), CacheItemPriority.Normal, null);
                        }
                    }
                }
                return _urnSensorNames.ToReadOnly();
            }
        }

        private IDictionary<string, Uri> _urnObservedPropertyNames;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        protected IDictionary<string, Uri> UrnObservedPropertyNames
        {
            get
            {
                if (_urnObservedPropertyNames == null)
                {
                    this._urnObservedPropertyNames = System.Web.HttpContext.Current.Cache["__URN_OBSERVEDPROPERTYNAMES"] as IDictionary<string, Uri>;

                    if (_urnObservedPropertyNames == null)
                    {
                        using (SosEntities data = this.Operation.GetSosEntities())
                        {
                            var result = from s in data.ObservedProperties
                                         select s;

                            ObjectQuery query = result as ObjectQuery;

                            query.MergeOption = MergeOption.NoTracking;
                            query.EnablePlanCaching = true;

                            lock (_lock)
                            {
                                if (_urnObservedPropertyNames == null)
                                {
                                    _urnObservedPropertyNames = (from s in result
                                                                 select s).ToDictionary(x => x.Code, x => this.GetPropertyUrn(x.Code));
                                }
                            }
                        }

                        System.Web.HttpContext.Current.Cache.Add("__URN_OBSERVEDPROPERTYNAMES", this._urnObservedPropertyNames, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(this.CacheTimeout), CacheItemPriority.Normal, null);
                    }
                }
                return _urnObservedPropertyNames.ToReadOnly();
            }
        }

        private IDictionary<string, Uri> _urnFeatureOfInterestNames;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        protected IDictionary<string, Uri> UrnFeatureOfInterestNames
        {
            get
            {
                if (_urnFeatureOfInterestNames == null)
                {
                    this._urnFeatureOfInterestNames = System.Web.HttpContext.Current.Cache["__URN_FEATUREOFINTERESTNAMES"] as IDictionary<string, Uri>;

                    if (_urnFeatureOfInterestNames == null)
                    {
                        using (SosEntities data = this.Operation.GetSosEntities())
                        {
                            var result = from s in data.FeaturesOfInterest
                                         select s;

                            ObjectQuery query = result as ObjectQuery;

                            query.MergeOption = MergeOption.NoTracking;
                            query.EnablePlanCaching = true;

                            lock (_lock)
                            {
                                if (_urnFeatureOfInterestNames == null)
                                {
                                    _urnFeatureOfInterestNames = (from s in result
                                                                  select s).ToDictionary(x => x.Code, x => this.GetFeatureOfInterestUrn(x.Code));
                                }
                            }
                        }

                        System.Web.HttpContext.Current.Cache.Add("__URN_FEATUREOFINTERESTNAMES", this._urnFeatureOfInterestNames, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(this.CacheTimeout), CacheItemPriority.Normal, null);
                    }
                }
                return _urnFeatureOfInterestNames.ToReadOnly();
            }
        }

        /// <summary>
        /// Gets list of the sensor names.
        /// </summary>
        /// <value>The sensor names.</value>
        public ICollection<string> SensorNames
        {
            get
            {
                return this.UrnSensorNames.Keys;
            }
        }

        /// <summary>
        /// Gets list of the observed properties.
        /// </summary>
        /// <value>The observed properties.</value>
        public ICollection<string> ObservedPropertyNames
        {
            get
            {
                return this.UrnObservedPropertyNames.Keys;
            }
        }

        /// <summary>
        /// Gets list of the features of interest.
        /// </summary>
        /// <value>The features of interest.</value>
        public ICollection<string> FeatureOfInterestNames
        {
            get
            {
                return this.UrnFeatureOfInterestNames.Keys;
            }
        }

        /// <summary>
        /// Gets urn property name
        /// </summary>
        /// <param name="value">Property name</param>
        /// <returns>Property urn string</returns>
        public virtual Uri GetPropertyUrn(string value)
        {
            return this.GetUrnName("property", value);
        }

        /// <summary>
        /// Gets urn sensor name
        /// </summary>
        /// <param name="value">Sensor name</param>
        /// <returns>Sensor urn string</returns>
        public virtual Uri GetSensorUrn(string value)
        {
            return this.GetUrnName("sensor", value);
        }

        /// <summary>
        /// Gets urn feature of interest name
        /// </summary>
        /// <param name="value">Feature of interest name</param>
        /// <returns>Feature of interest urn string</returns>
        public virtual Uri GetFeatureOfInterestUrn(string value)
        {
            return this.GetUrnName("featureOfInterest", value);
        }

        /// <summary>
        /// Gets urn string for specified name and value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public abstract Uri GetUrnName(string name, string value);

        /// <summary>
        /// Gets the urn string value.
        /// </summary>
        /// <param name="urn">The urn.</param>
        /// <returns></returns>
        public virtual string GetUrnValue(Uri urn)
        {
            if (this.UrnLookup.ContainsKey(urn))
                return this.UrnLookup[urn];
            else
                return null;
        }
    }
}
