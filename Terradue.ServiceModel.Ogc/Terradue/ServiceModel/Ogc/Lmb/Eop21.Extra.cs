using System;
using Terradue.ServiceModel.Ogc.Lmb21;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Eop21 {

    public partial class SensorPropertyType {

        [XmlIgnore]
        public LmbSensorType LmbSensor {
            get {
                if (Sensor is LmbSensorType)
                    return (LmbSensorType)Sensor;
                return null;
            }
            set {
                Sensor = value;
            }
        }

    }

    public partial class AcquisitionPropertyType {

        [XmlIgnore]
        public LmbAcquisitionType LmbAcquisition {
            get {
                if (Acquisition is LmbAcquisitionType)
                    return (LmbAcquisitionType)Acquisition;
                return null;
            }
            set {
                Acquisition = value;
            }
        }

    }
}

