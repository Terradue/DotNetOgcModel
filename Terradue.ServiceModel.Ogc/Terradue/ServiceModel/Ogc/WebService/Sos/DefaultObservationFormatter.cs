using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Terradue.ServiceModel.Ogc.WebService.Common;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Default implementation to format an observation.
    /// </summary>
    public class DefaultObservationFormatter : BaseObservationFormatter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultObservationFormatter"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        public DefaultObservationFormatter(BaseSosOperation operation)
            : base(operation)
        {
        }

        /// <summary>
        /// Gets the observation feature of interest.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <returns></returns>
        public override FeaturePropertyType GetObservationFeatureOfInterest(Observation observation)
        {
            return new Renci.Data.Interop.OpenGIS.Gml.FeaturePropertyType
            {
                Href = this.Operation.UriManager.GetFeatureOfInterestUri(observation.FeatureOfInterest.Code).ToString(),
            };
        }

        /// <summary>
        /// Gets the observation property.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <returns></returns>
        public override PhenomenonPropertyType GetObservationProperty(Observation observation)
        {
            return new PhenomenonPropertyType
            {
                Href = this.Operation.UriManager.GetPropertyUri(observation.ObservedProperty.Code).ToString(),
            };
        }

        /// <summary>
        /// Gets the observation procedure.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <returns></returns>
        public override ProcessPropertyType GetObservationProcedure(Observation observation)
        {
            return new ProcessPropertyType
            {
                Href = this.Operation.UriManager.GetSensorUri(observation.Sensor.Code).ToString(),
            };
        }

        /// <summary>
        /// Gets the observation result.
        /// </summary>
        /// <param name="observation">The observation.</param>
        /// <param name="responseMode">The response mode.</param>
        /// <param name="samplingBeginDate">The sampling begin date.</param>
        /// <param name="samplingEndDate">The sampling end date.</param>
        /// <returns></returns>
        public override object GetObservationResult(Observation observation, Terradue.ServiceModel.Ogc.Sos10.ResponseModeType responseMode, DateTime samplingBeginDate, DateTime samplingEndDate)
        {
            switch (responseMode)
            {
                case ResponseModeType.Inline:
                    return this.GetInlineResult(observation, samplingBeginDate, samplingEndDate);
                case ResponseModeType.Attached:
                    throw new OptionNotSupportedException(responseMode.ToStringValue());
                case ResponseModeType.OutOfBand:
                    return this.GetOutOfBandResult(observation, samplingBeginDate, samplingEndDate);
                case ResponseModeType.ResultTemplate:
                    throw new OptionNotSupportedException(responseMode.ToStringValue());
                default:
                    return null;
            }
        }

        /// <summary>
        /// Get observation inline data values
        /// </summary>
        /// <param name="observation"></param>
        /// <param name="samplingBeginDate"></param>
        /// <param name="samplingEndDate"></param>
        /// <returns></returns>
        protected virtual DataArrayType GetInlineResult(Observation observation, DateTime samplingBeginDate, DateTime samplingEndDate)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            string blockSeparator = "@@";

            using (SosEntities data = this.Operation.GetSosEntities())
            {
                var dataValues = this.GetObservationValuesQuery(data, observation.Code, samplingBeginDate, samplingEndDate);

                DataArrayType da = new DataArrayType()
                {
                    //   Set ElementType Name
                    ElementType = new DataComponentPropertyType()
                    {
                        Name = "SimpleType",
                        Item = new DataRecordType(),
                    },

                    //   Set Encoding
                    Encoding = new BlockEncodingPropertyType()
                    {
                        Item = new TextBlock()
                        {
                            BlockSeparator = blockSeparator,
                            DecimalSeparator = ci.NumberFormat.NumberDecimalSeparator,
                            TokenSeparator = ",",
                        },
                    },

                    //  Set ElementCount
                    ElementCount =
                    {
                        Count = new Count()
                        {
                            Value = dataValues.Count().ToString(CultureInfo.CurrentCulture),
                        }
                    }
                };

                //  Add ElementType, list of all fields
                da.ElementType.GetItem<DataRecordType>().Fields.Add(new DataComponentPropertyType
                {
                    Name = "Time",
                    Item = new Time
                    {
                        Definition = this.Operation.UrnManager.GetPropertyUrn("time").ToString(),
                    }
                });

                da.ElementType.GetItem<DataRecordType>().Fields.Add(new DataComponentPropertyType
                {
                    Name = observation.ObservedProperty.Name,
                    Item = new Quantity
                    {
                        Definition = this.Operation.UriManager.GetPropertyUri(observation.ObservedProperty.Code).ToString(),
                    }
                });

                StringBuilder valuesText = new StringBuilder();

                foreach (ObservationValue value in dataValues)
                {
                    valuesText.AppendFormat(ci, "{0},{1}{2}", value.Time.ToUnicodeStringValue(), value.Value, blockSeparator);
                }

                da.Values = new DataValuePropertyType()
                {
                    Value = valuesText.ToString(),
                };

                return da;
            }
        }

        /// <summary>
        /// Get observation out-of-band data values
        /// </summary>
        /// <param name="observation"></param>
        /// <param name="samplingBeginDate"></param>
        /// <param name="samplingEndDate"></param>
        /// <returns></returns>
        protected virtual Renci.Data.Interop.OpenGIS.Gml.ReferenceType GetOutOfBandResult(Observation observation, DateTime samplingBeginDate, DateTime samplingEndDate)
        {
            Renci.Data.Interop.OpenGIS.Gml.ReferenceType result = new Renci.Data.Interop.OpenGIS.Gml.ReferenceType();

            result.Href = string.Format(CultureInfo.InvariantCulture, "{0}/?service={1}&request={2}&version={3}&observationId={4}&beginDate={5}&endDate={6}", this.Operation.ServiceBaseUri, this.Operation.ServiceName, this.Operation.RequestName, this.Operation.Version, observation.Code, samplingBeginDate.ToUnicodeStringValue(), samplingEndDate.ToUnicodeStringValue());
            result.Role = "text/csv";

            return result;
        }

        /// <summary>
        /// Gets observation values query
        /// </summary>
        /// <param name="data"></param>
        /// <param name="observationCode"></param>
        /// <param name="samplingBeginDate"></param>
        /// <param name="samplingEndDate"></param>
        /// <returns></returns>
        private IQueryable<ObservationValue> GetObservationValuesQuery(SosEntities data, string observationCode, DateTime samplingBeginDate, DateTime samplingEndDate)
        {
            //  This parameter used internally and therefor no transformation is required.
            var code = observationCode;

            var result = from ov in data.ObservationValues.Include("Observation")
                         where
                            ov.Observation.Code == code &&
                            ov.Time >= samplingBeginDate &&
                            ov.Time <= samplingEndDate
                         select ov;

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result;
        }

        /// <summary>
        /// Gets the output format used by this formatter.
        /// </summary>
        /// <value>The output format.</value>
        public override OutputFormat OutputFormat
        {
            get { return OutputFormat.TextXml; }
        }
    }
}
