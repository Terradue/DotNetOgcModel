using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using Terradue.ServiceModel.Ogc.WebService.Common;
using Terradue.ServiceModel.Ogc.WebService.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Represents a sample DescribeSensor request handler
    /// </summary>
    public class DescribeSensorOperation : BaseSosOperation
    {
        /// <summary>
        /// Gets sensor query
        /// </summary>
        /// <param name="data"></param>
        /// <param name="procedure"></param>
        /// <returns></returns>
        private IQueryable<Sensor> GetSensorQuery(SosEntities data, string procedure)
        {
            var code = this.UrnManager.GetUrnValue(new Uri(procedure));

            var result = from s in data.Sensors.Include("ObservedProperties").Include("Keywords").Include("Identifications")
                         where s.Code == code
                         select s;

            ObjectQuery query = result as ObjectQuery;

            query.MergeOption = MergeOption.NoTracking;
            query.EnablePlanCaching = true;

            return result;
        }

        private IDictionary<string, Func<Sensor, object>> _outputFormatters;
        /// <summary>
        /// Gets output formatters list
        /// </summary>
        public virtual IDictionary<string, Func<Sensor, object>> OutputFormatters
        {
            get
            {
                if (this._outputFormatters == null)
                {
                    this._outputFormatters = new Dictionary<string, Func<Sensor, object>>();
                    this._outputFormatters.Add("text/xml;subtype=\"sensorML/1.0.0\"", this.GetSensorML);
                }

                return this._outputFormatters;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeSensorOperation"/> class.
        /// </summary>
        /// <param name="configuration">Operation configuration.</param>
        public DescribeSensorOperation(ServiceOperationElement configuration)
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
                    Name = "SensorId",
                    AllowedValues = new Collection<object>(),
                });

                DomainType parameter = parameters[parameters.Count - 1];

                foreach (var sensorName in this.UrnManager.SensorNames)
                {
                    parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(this.UrnManager.GetSensorUrn(sensorName).ToString()));
                }

                parameters.Add(new DomainType()
                {
                    Name = "outputFormat",
                    AllowedValues = new Collection<object>(),
                });

                if (this.OutputFormatters.Count > 0)
                {
                    parameter = parameters[parameters.Count - 1];

                    foreach (var format in this.OutputFormatters.Keys)
                    {
                        parameter.AllowedValues.Add(new Renci.Data.Interop.OpenGIS.Ows_11.ValueType(format));
                    }
                }

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
                dcp.Http.PostMethods.Add(new RequestMethodType
                {
                    Href = string.Format(CultureInfo.InvariantCulture, "{0}/", this.ServiceBaseUri)
                });
                dcp.Http.GetMethods.Add(new RequestMethodType
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
                Collection<DomainType> constraints = new Collection<DomainType>();

                constraints.Add(new DomainType()
                    {
                        Name = "SupportedSensorDescription",
                        AllowedValues = new Collection<object>()
                        {
                            new Renci.Data.Interop.OpenGIS.Ows_11.ValueType("sml:SensorML"),
                        },
                        Meaning = new DomainMetadataType()
                        {
                            Reference = this.UrnManager.GetPropertyUrn("SupportedSensorDescription").ToString(),
                            Value = "The service will only accept sensor descriptions that comply with the listed ones.",
                        }
                    });

                return constraints;
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
            get { return typeof(Terradue.ServiceModel.Ogc.Sos10.DescribeSensor); }
        }

        /// <summary>
        /// Process operation request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Resposne object to be sent back to the client</returns>
        public override OperationResult ProcessRequest(object request)
        {
            Terradue.ServiceModel.Ogc.Sos10.DescribeSensor dsr = request as Terradue.ServiceModel.Ogc.Sos10.DescribeSensor;

            //  Make sure there is valid request parameter
            if (dsr == null)
            {
                throw new NoApplicableCodeException(string.Format(CultureInfo.CurrentCulture, "Type '{0}' is not supported by DescribeRequest operation.", request.GetType().FullName));
            }

            OperationResult result = new OperationResult();

            using (SosEntities data = this.GetSosEntities())
            {
                var sensorInfo = this.GetSensorQuery(data, dsr.Procedure).FirstOrDefault();

                if (sensorInfo == null)
                {
                    throw new InvalidParameterValueException("procedure", dsr.Procedure);
                }

                //  Get appropriate output formatter and execute it if available
                if (this.OutputFormatters.ContainsKey(dsr.OutputFormat))
                {
                    result.ResultObject = this.OutputFormatters[dsr.OutputFormat](sensorInfo);
                }
                else
                {
                    throw new InvalidParameterValueException("outputFormat", dsr.OutputFormat);
                }
            }

            return result;
        }

        #endregion

        #region SensorML methods

        /// <summary>
        /// Gets SensorML object for provided sensor information
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Renci.Data.Interop.OpenGIS.SensorML_101.Sensor GetSensorML(Sensor sensorInfo)
        {
            Renci.Data.Interop.OpenGIS.SensorML_101.Sensor sensor = new Renci.Data.Interop.OpenGIS.SensorML_101.Sensor();
            Renci.Data.Interop.OpenGIS.SensorML_101.SensorMember sm = new Renci.Data.Interop.OpenGIS.SensorML_101.SensorMember();
            sensor.Members.Add(sm);
            Renci.Data.Interop.OpenGIS.SensorML_101.SystemType system = new Renci.Data.Interop.OpenGIS.SensorML_101.SystemType();
            system.Id = sensorInfo.Code;
            sm.Item = system;

            //  Add sensor name(s)
            system.Names.Add(this.GetSensorNames(sensorInfo));

            //  Add sensor description
            system.Description = this.GetSensorDescription(sensorInfo);

            //  Add sensor keyword(s)
            system.Keywords.Add(this.GetSensorKeywords(sensorInfo));

            //  Add sensor identification            
            system.Identifications.Add(this.GetSensorIdentification(sensorInfo));

            //  Add sensor classification
            system.Classifications.Add(this.GetSensorClassification(sensorInfo));

            //  Add sensor validTime
            system.ValidTime = this.GetSensorValidTime(sensorInfo);

            //  Add sensor characteristics
            system.Characteristics.Add(this.GetSensorCharacteristics(sensorInfo));

            //  Add sensor capabilities
            system.Capabilities.Add(this.GetSensorCapabilities(sensorInfo));

            //  Add sensor contact
            system.Contacts.Add(this.GetSensorContact(sensorInfo));

            //  Add sensor documentation
            system.Documentation.Add(this.GetSensorDocumentation(sensorInfo));

            //  Add sensor history
            system.History.Add(this.GetSensorHistory(sensorInfo));

            //  Add sensor spatialReferenceFrame
            system.SpatialReferenceFrame = this.GetSensorSpatialReferenceFrame(sensorInfo);

            //  Add sensor inputs
            system.Inputs = this.GetSensorInputs(sensorInfo);

            //  Add sensor outputs
            system.Outputs = this.GetSensorOutputs(sensorInfo);

            //  Add sensor components
            system.Components = this.GetSensorComponents(sensorInfo);

            //  Add sensor positions
            system.Positions = this.GetSensorPositions(sensorInfo);

            //  Add sensor location
            system.Location = this.GetSensorLocation(sensorInfo);

            return sensor;
        }

        /// <summary>
        /// Gets sensor name(s)
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Renci.Data.Interop.OpenGIS.Gml.CodeType> GetSensorNames(Sensor sensorInfo)
        {
            Collection<Renci.Data.Interop.OpenGIS.Gml.CodeType> names = new Collection<Renci.Data.Interop.OpenGIS.Gml.CodeType>()
            {
                { sensorInfo.Name },
            };

            return names;
        }

        /// <summary>
        /// Gets sensor description
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Renci.Data.Interop.OpenGIS.Gml.StringOrRefType GetSensorDescription(Sensor sensorInfo)
        {
            return new Renci.Data.Interop.OpenGIS.Gml.StringOrRefType()
            {
                Value = sensorInfo.Description,
            };
        }

        /// <summary>
        /// Gets sensor keywords if any
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Keywords> GetSensorKeywords(Sensor sensorInfo)
        {
            if (sensorInfo.Keywords.Count > 0)
            {
                var keywords = new Collection<Keywords>();

                foreach (var keyword in from sk in sensorInfo.Keywords group sk by sk.CodeSpace into g select new { CodeSpace = g.Key, Words = g })
                {
                    keywords.Add(new Keywords
                    {
                        KeywordList = new KeywordsKeywordList
                        {
                            CodeSpace = keyword.CodeSpace,
                            //Id = "",
                        }
                    });

                    keywords[keywords.Count - 1].KeywordList.Keywords.Add(from kw in keyword.Words select kw.Word);
                }

                return keywords;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get sensor identifications
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Renci.Data.Interop.OpenGIS.SensorML_101.Identification> GetSensorIdentification(Sensor sensorInfo)
        {
            Collection<Renci.Data.Interop.OpenGIS.SensorML_101.Identification> identifications = new Collection<Renci.Data.Interop.OpenGIS.SensorML_101.Identification>()
            {
                new Renci.Data.Interop.OpenGIS.SensorML_101.Identification()
                {
                    IdentifierList = new IdentificationIdentifierList()
                    {
                        Identifiers = 
                        {
                            new IdentificationIdentifierListIdentifier()
                            {
                                Name = "Name",
                                Term = new Term()
                                {
                                    Definition = this.UrnManager.GetPropertyUrn("Name").ToString(),
                                    Value = sensorInfo.Name,
                                },
                            },
                            new IdentificationIdentifierListIdentifier()
                            {
                                Name = "Description",
                                Term = new Term()
                                {
                                    Definition = this.UrnManager.GetPropertyUrn("Description").ToString(),
                                    Value = sensorInfo.Description,
                                },
                            },
                        },
                    },
                }
            };

            return identifications;
        }

        /// <summary>
        /// Gets sensor classifications
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Classification> GetSensorClassification(Sensor sensorInfo)
        {
            //  TODO:   Implement sensor classification
            return null;
        }

        /// <summary>
        /// Gets sensor valid time
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual ValidTime GetSensorValidTime(Sensor sensorInfo)
        {
            return new ValidTime()
            {
                Item = new Renci.Data.Interop.OpenGIS.Gml.TimePeriodType()
                {
                    BeginTime = new Renci.Data.Interop.OpenGIS.Gml.TimePositionType() { Value = (sensorInfo.BeginTime == null) ? null : sensorInfo.BeginTime.Value.ToUnicodeStringValue() },
                    EndTime = new Renci.Data.Interop.OpenGIS.Gml.TimePositionType() { Value = (sensorInfo.EndTime == null) ? null : sensorInfo.EndTime.Value.ToUnicodeStringValue() },
                },
            };
        }

        /// <summary>
        /// Gets sensor characteristics
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Characteristics> GetSensorCharacteristics(Sensor sensorInfo)
        {
            //  TODO:   Implement sensor characteristics
            return null;
        }

        /// <summary>
        /// Gets sensor capabilities
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Capabilities> GetSensorCapabilities(Sensor sensorInfo)
        {
            //  TODO:   Implement sensor capabilities
            return null;
        }

        /// <summary>
        /// Gets sensor contacts
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Contact> GetSensorContact(Sensor sensorInfo)
        {
            //  TODO:   Implement sensor contacts
            return null;
        }

        /// <summary>
        /// Gets sensor documentation
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<Documentation> GetSensorDocumentation(Sensor sensorInfo)
        {
            //  TODO:   Implement sensor documentation
            return null;
        }

        /// <summary>
        /// Gets sensor history
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Collection<History> GetSensorHistory(Sensor sensorInfo)
        {
            //  TODO:   Implement sensor history
            return null;
        }

        /// <summary>
        /// Gets sensor spatial reference
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual SpatialReferenceFrame GetSensorSpatialReferenceFrame(Sensor sensorInfo)
        {
            //  TODO:   Implement sensor spatial refernce
            return null;
        }

        /// <summary>
        /// Gets sensor inputs
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Inputs GetSensorInputs(Sensor sensorInfo)
        {
            Inputs inputs = new Inputs();
            inputs.InputList = new InputsInputList();

            foreach (var property in sensorInfo.ObservedProperties)
            {
                inputs.InputList.Inputs.Add(new IoComponentPropertyType()
                                                       {
                                                           Name = property.Name,
                                                           Item = new ObservableProperty
                                                               {
                                                                   Definition = this.UriManager.GetPropertyUri(property.Code).ToString(),
                                                               },
                                                       });
            }

            return inputs;
        }

        /// <summary>
        /// Gets sensor outputs
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Outputs GetSensorOutputs(Sensor sensorInfo)
        {
            Outputs outputs = new Outputs();
            outputs.OutputList = new OutputsOutputList();
            outputs.OutputList.Outputs.Add(new IoComponentPropertyType
            {
                Name = string.Format(CultureInfo.CurrentCulture, "{0}_outputs", sensorInfo.Name),
                Item = new DataRecordType(),
            });

            foreach (var property in sensorInfo.ObservedProperties)
            {
                (outputs.OutputList.Outputs[0].GetItem<DataRecordType>()).Fields.Add(new DataComponentPropertyType()
                {
                    Name = property.Name,
                    Item = new Quantity
                    {
                        Definition = this.UriManager.GetPropertyUri(property.Code).ToString(),
                        Uom = new UomPropertyType()
                        {
                            //  Repalce all spaces with dash since spaces are not allowed by the schema
                            Code = property.UnitAbbreviation.Replace(" ", "-"),
                        }
                    },
                });
            }

            return outputs;
        }

        /// <summary>
        /// Gets sensor components
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Components GetSensorComponents(Sensor sensorInfo)
        {
            return null;
        }

        /// <summary>
        /// Gets sensor positions
        /// </summary>
        /// <param name="sensorInfo"></param>
        /// <returns></returns>
        protected virtual Positions GetSensorPositions(Sensor sensorInfo)
        {
            SqlGeometry location = SqlGeometry.STGeomFromText(new System.Data.SqlTypes.SqlChars(new System.Data.SqlTypes.SqlString(sensorInfo.GeoLocation)), 4326);

            Positions positions = new Positions();

            positions.PositionList = new PositionsPositionList();
            Position pos = new Position
            {
                Name = "sensor position",
            };

            positions.PositionList.Items.Add(pos);
            PositionType post = new PositionType()
            {
                LocalFrame = "",
                ReferenceFrame = sensorInfo.SrsName,
            };
            pos.Item = post;
            post.Location = new VectorPropertyType();
            post.Location.Vector = new VectorType()
            {
                Definition = this.UrnManager.GetPropertyUrn("location").ToString(),
            };

            post.Location.Vector.Coordinates.Add(new VectorTypeCoordinate()
            {
                Name = "latitude",
                Item = new Quantity()
                {
                    Definition = this.UrnManager.GetPropertyUrn("latitude").ToString(),
                    Uom = new UomPropertyType()
                    {
                        Code = "deg",
                    },
                    Value = location.STX.Value,
                },
            });

            post.Location.Vector.Coordinates.Add(new VectorTypeCoordinate()
            {
                Name = "longitude",
                Item = new Quantity()
                {
                    Definition = this.UrnManager.GetPropertyUrn("longitude").ToString(),
                    Uom = new UomPropertyType()
                    {
                        Code = "deg",
                    },
                    Value = location.STY.Value,
                },
            });

            if (sensorInfo.Elevation.HasValue)
            {
                post.Location.Vector.Coordinates.Add(new VectorTypeCoordinate()
                {
                    Name = "heightAboveSeafloor",
                    Item = new Quantity()
                    {
                        Definition = this.UrnManager.GetPropertyUrn("height").ToString(),
                        Uom = new UomPropertyType()
                        {
                            Code = sensorInfo.ElevationUnitAbbreviation,
                        },
                        Value = sensorInfo.Elevation.Value,
                    },
                });
            }

            return positions;
        }

        /// <summary>
        /// Gets the sensor location.
        /// </summary>
        /// <param name="sensorInfo">The sensor info.</param>
        /// <returns></returns>
        protected virtual Renci.Data.Interop.OpenGIS.Gml.LocationPropertyType GetSensorLocation(Sensor sensorInfo)
        {
            SqlGeometry location = SqlGeometry.STGeomFromText(new System.Data.SqlTypes.SqlChars(new System.Data.SqlTypes.SqlString(sensorInfo.GeoLocation)), 4326);

            return new Renci.Data.Interop.OpenGIS.Gml.LocationPropertyType
            {
                DataItem = new Renci.Data.Interop.OpenGIS.Gml.PointType
                {
                    Id = "SYSTEM_LOCATION",
                    SrsName = sensorInfo.SrsName,
                    Item = new Renci.Data.Interop.OpenGIS.Gml.DirectPositionType(location.STX.Value, location.STY.Value),
                }
            };
        }

        #endregion
    }
}
