using System;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Om;
using Terradue.ServiceModel.Ogc.Sos10;
using Terradue.ServiceModel.Ogc.Swe;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Specifies operations required to format observation
    /// </summary>
    public abstract class BaseObservationFormatter
    {
        /// <summary>
        /// Gets the operation.
        /// </summary>
        /// <value>The operation.</value>
        public BaseSosOperation Operation { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseObservationFormatter"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        protected BaseObservationFormatter(BaseSosOperation operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Gets the observation feature of interest.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <returns></returns>
        public abstract FeaturePropertyType GetObservationFeatureOfInterest(Om.ObservationType observation);

        /// <summary>
        /// Gets the observation property.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <returns></returns>
        public abstract PhenomenonPropertyType GetObservationProperty(Om.ObservationType observation);

        /// <summary>
        /// Gets the observation procedure.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <returns></returns>
        public abstract ProcessPropertyType GetObservationProcedure(Om.ObservationType observation);

        /// <summary>
        /// Gets the observation result.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <param name="responseMode">The response mode.</param>
        /// <param name="samplingBeginDate">The sampling begin date.</param>
        /// <param name="samplingEndDate">The sampling end date.</param>
        /// <returns></returns>
        public abstract object GetObservationResult(Om.ObservationType observation, ResponseModeType responseMode, DateTime samplingBeginDate, DateTime samplingEndDate);

        /// <summary>
        /// Gets the output format supported by this formatter
        /// </summary>
        /// <value>The output format.</value>
        public abstract OutputFormat OutputFormat { get;  }
    }
}
