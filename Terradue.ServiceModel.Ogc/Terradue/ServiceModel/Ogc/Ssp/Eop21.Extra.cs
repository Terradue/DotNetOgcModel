using System;
using Terradue.ServiceModel.Ogc.Ssp21;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Eop21 {

    public partial class EarthObservationMetaDataPropertyType {

        [XmlIgnore]
        public SspEarthObservationMetaDataType SspEarthObservationMetaData {
            get {
                if (EarthObservationMetaData is SspEarthObservationMetaDataType)
                    return (SspEarthObservationMetaDataType)EarthObservationMetaData;
                return null;
            }
            set {
                EarthObservationMetaData = value;
            }
        }

    }
}

