using System;
namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Specifies operations for URI Manager
    /// </summary>
    public abstract class BaseUriManager
    {
        /// <summary>
        /// Gets the operation.
        /// </summary>
        /// <value>The operation.</value>
        public BaseSosOperation Operation { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUriManager"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        protected BaseUriManager(BaseSosOperation operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Gets property URI.
        /// </summary>
        /// <param name="value">Property name</param>
        /// <returns>Property uri string</returns>
        public virtual Uri GetPropertyUri(string value)
        {
            return this.Operation.UrnManager.GetPropertyUrn(value);
        }

        /// <summary>
        /// Gets sensor URI.
        /// </summary>
        /// <param name="value">Sensor name</param>
        /// <returns>Sensor uri string</returns>
        public virtual Uri GetSensorUri(string value)
        {
            return this.Operation.UrnManager.GetSensorUrn(value);
        }

        /// <summary>
        /// Gets feature of interest URI.
        /// </summary>
        /// <param name="value">Feature of interest name</param>
        /// <returns>Feature of interest uri string</returns>
        public virtual Uri GetFeatureOfInterestUri(string value)
        {
            return this.Operation.UrnManager.GetFeatureOfInterestUrn(value);
        }
    }
}
