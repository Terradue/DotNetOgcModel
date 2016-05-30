using System;
using Terradue.ServiceModel.Ogc.Opt21;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Eop21 {
    
    public partial class EarthObservationResultPropertyType {

        [XmlIgnore]
        public OptEarthObservationResultType OptEarthObservationResult {
            get {
                if (EarthObservationResult is OptEarthObservationResultType)
                    return (OptEarthObservationResultType)EarthObservationResult;
                return null;
            }
            set {
                EarthObservationResult = value;
            }
        }

    }
}

