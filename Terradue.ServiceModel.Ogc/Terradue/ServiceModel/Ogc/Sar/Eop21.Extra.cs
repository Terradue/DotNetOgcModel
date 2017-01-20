using System;
using Terradue.ServiceModel.Ogc.Sar21;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Eop21 {
    
    public partial class AcquisitionPropertyType {

        [XmlIgnore]
        public SarAcquisitionType SarAcquisition {
            get {
                if (Acquisition is SarAcquisitionType)
                    return (SarAcquisitionType)Acquisition;
                return null;
            }
            set {
                Acquisition = value;
            }
        }

    }

   
}

