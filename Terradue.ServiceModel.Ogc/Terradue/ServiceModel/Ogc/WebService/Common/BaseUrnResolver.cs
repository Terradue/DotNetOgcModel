using System.Collections.Generic;
using System.Linq;
using Terradue.ServiceModel.Ogc.WebService;

namespace Terradue.ServiceModel.Ogc.WebService.Common
{
    public abstract class BaseUrnResolver
    {
        /// <summary>
        /// Specifies name/value pair class
        /// </summary>
        public class NameValue
        {
            public string Name { get; set; }

            public string Value { get; set; }
        }

        /// <summary>
        /// Used for thread locking
        /// </summary>
        private static object _lock = new object();

        private static IDictionary<string, string> _urnSensorNames = null;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        public IDictionary<string, string> UrnSensorNames
        {
            get
            {
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
                                                   select s).ToDictionary(x => x.Code, x => this.GetSensorUrn(x.Code).ToString());
                            }
                        }
                    }

                }
                return _urnSensorNames.ToReadOnly();
            }
        }

        private static IDictionary<string, string> _urnObservedPropertyNames = null;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        public IDictionary<string, string> UrnObservedPropertyNames
        {
            get
            {
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
                                                             select s).ToDictionary(x => x.Code, x => this.GetPropertyUrn(x.Code).ToString());
                            }
                        }
                    }

                }
                return _urnObservedPropertyNames.ToReadOnly();
            }
        }

        private static IDictionary<string, string> _urnFeatureOfInterestNames = null;
        /// <summary>
        /// Gets dictionary which maps sensor names to urn names
        /// </summary>
        /// <value>The urn sensor names.</value>
        public IDictionary<string, string> UrnFeatureOfInterestNames
        {
            get
            {
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
                                                              select s).ToDictionary(x => x.Code, x => this.GetFeatureOfInterestUrn(x.Code).ToString());
                            }
                        }
                    }

                }
                return _urnFeatureOfInterestNames.ToReadOnly();
            }
        }

        /// <summary>
        /// Gets or sets the operation.
        /// </summary>
        /// <value>The operation.</value>
        public BaseOperation Operation { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUrnResolver"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        public BaseUrnResolver(BaseOperation operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Gets urn property name
        /// </summary>
        /// <param name="name">Property name</param>
        /// <returns>Property urn string</returns>
        public virtual string GetPropertyUrn(string value)
        {

            return GetUrnString("property", System.Uri.EscapeUriString(value));
        }

        /// <summary>
        /// Gets the name of the property from OGC urn string.
        /// </summary>
        /// <param name="urn">The urn.</param>
        /// <returns></returns>
        public virtual string GetPropertyName(string urn)
        {
            var nameValue = GetUrnNameValue(urn);

            if (nameValue.Name.Equals("property", System.StringComparison.OrdinalIgnoreCase))
            {
                return nameValue.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets property URI.
        /// </summary>
        /// <param name="name">Property name</param>
        /// <returns>Property uri string</returns>
        public virtual string GetPropertyUri(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets urn sensor name
        /// </summary>
        /// <param name="name">Sensor name</param>
        /// <returns>Sensor urn string</returns>
        public virtual string GetSensorUrn(string value)
        {
            return GetUrnString("sensor", System.Uri.EscapeUriString(value));
        }

        /// <summary>
        /// Gets the name of the sensor from OGC urn string.
        /// </summary>
        /// <param name="urn">The urn.</param>
        /// <returns></returns>
        public virtual string GetSensorName(string urn)
        {
            var nameValue = GetUrnNameValue(urn);
            if (nameValue.Name.Equals("sensor", System.StringComparison.OrdinalIgnoreCase))
            {
                return nameValue.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets sensor URI.
        /// </summary>
        /// <param name="name">Sensor name</param>
        /// <returns>Sensor uri string</returns>
        public virtual string GetSensorUri(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets urn feature of interest name
        /// </summary>
        /// <param name="name">Feature of interest name</param>
        /// <returns>Feature of interest urn string</returns>
        public virtual string GetFeatureOfInterestUrn(string value)
        {
            return GetUrnString("featureOfInterest", System.Uri.EscapeUriString(value));
        }

        /// <summary>
        /// Gets the name of the feature of interest from urn string.
        /// </summary>
        /// <param name="urn">The urn.</param>
        /// <returns></returns>
        public virtual string GetFeatureOfInterestName(string urn)
        {
            var nameValue = GetUrnNameValue(urn);
            if (nameValue.Name.Equals("featureOfInterest", System.StringComparison.OrdinalIgnoreCase))
            {
                return nameValue.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets feature of interest URI.
        /// </summary>
        /// <param name="name">Feature of interest name</param>
        /// <returns>Feature of interest uri string</returns>
        public virtual string GetFeatureOfInterestUri(string value)
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets the value from urn string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public abstract NameValue GetUrnNameValue(string urn);

        /// <summary>
        /// Gets urn string for specific defintion and name
        /// </summary>
        /// <param name="definition">Definition</param>
        /// <param name="name">Name</param>
        /// <returns>Urn string</returns>
        protected abstract string GetUrnString(string name, string value);
    }
}
