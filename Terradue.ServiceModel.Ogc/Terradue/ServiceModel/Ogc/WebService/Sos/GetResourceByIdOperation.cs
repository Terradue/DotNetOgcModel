using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using Terradue.ServiceModel.Ogc.WebService.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Provides functionlity for OGC Web Service GetResourceById operation
    /// </summary>
    public class GetResourceByIdOperation : BaseSosOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetResourceByIdOperation"/> class.
        /// </summary>
        /// <param name="configuration">Operation configuration.</param>
        public GetResourceByIdOperation(ServiceOperationElement configuration)
            : base(configuration)
        {
        }

        #region BaseOperation abstract methods

        /// <summary>
        /// Gets operation parameters list for GetObservation operation
        /// </summary>
        public override Collection<DomainType> OperationParameters
        {
            get
            {
                Collection<DomainType> parameters = new Collection<DomainType>();

                parameters.Add(new DomainType()
                    {
                        Name = "ResourceID",
                        AnyValue = new AnyValue(),
                        Meaning = new DomainMetadataType
                        {
                            Value = "Valid resource id",
                        }
                    });

                return parameters;
            }
        }

        /// <summary>
        /// Gets operation dcp list for GetObservation operation
        /// </summary>
        public override Collection<Dcp> OperationDcps
        {
            get
            {
                Collection<Dcp> dcps = new Collection<Dcp>();
                Dcp dcp = new Dcp();
                dcp.Http.PostMethods.Add(new RequestMethodType()
                {
                    Href = string.Format(CultureInfo.InvariantCulture, "{0}/", this.ServiceBaseUri)
                });
                dcp.Http.GetMethods.Add(new RequestMethodType()
                {
                    Href = string.Format(CultureInfo.InvariantCulture, "{0}/", this.ServiceBaseUri)
                });

                dcps.Add(dcp);

                return dcps;
            }
        }

        /// <summary>
        /// Gets operation constraints list for GetObservation operation
        /// </summary>
        public override Collection<DomainType> OperationConstraints
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets operation metadata list for GetObservation operation
        /// </summary>
        public override Collection<MetadataType> OperationMetadata
        {
            get { return null; }
        }

        /// <summary>
        /// Gets a type of request object to be used for current operation
        /// </summary>
        public override Type RequestType
        {
            get { return typeof(GetResourceByIdType); }
        }

        /// <summary>
        /// Process operation request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Resposne object to be sent back to the client</returns>
        public override OperationResult ProcessRequest(object request)
        {
            GetResourceByIdType grg = request as GetResourceByIdType;

            //  Make sure there is valid request parameter
            if (grg == null)
            {
                throw new NoApplicableCodeException(string.Format(CultureInfo.CurrentCulture, "Type '{0}' is not supported by DescribeRequest operation.", request.GetType().FullName));
            }

            var result = new Renci.Data.Interop.OpenGIS.Gml.DictionaryType();

            //foreach (var resourceId in grg.ResourceID)
            //{
            //    var nameValue = this.UrnManager.GetUrnNameValue(resourceId);

            //    if (nameValue == null)
            //    {
            //        throw new InvalidParameterValueException("ResourceID", resourceId);
            //    }
            //    else
            //    {
            //        if (nameValue.Name.Equals("property", StringComparison.OrdinalIgnoreCase))
            //        {
            //            //<swe:Phenomenon gml:id="WaterTemperature">
            //            //<gml:description>Temperature of the water.</gml:description>
            //            //<gml:identifier codeSpace="urn:x-noaa:ioos:def:phenomenonNames">WaterTemperature</gml:identifier>
            //            //</swe:Phenomenon>

            //            using (var data = this.GetSosEntities())
            //            {
            //                var property = (from p in data.ObservedProperties
            //                                where p.Code == nameValue.Value
            //                                select p).FirstOrDefault();

            //                if (property == null)
            //                    throw new InvalidParameterValueException("ResourceID", resourceId);

            //                var phenomen = new PhenomenonType
            //                {
            //                    Id = property.Name,
            //                    Description = new StringOrRefType
            //                    {
            //                        Value = property.Description,
            //                    },
            //                };

            //                result.Items.Add(new DefinitionMember
            //                {
            //                    Definition = phenomen,
            //                });
            //            }

            //        }
            //    }
            //}

            return new OperationResult()
            {
                ResultObject = result,
            };
        }

        #endregion
    }
}
