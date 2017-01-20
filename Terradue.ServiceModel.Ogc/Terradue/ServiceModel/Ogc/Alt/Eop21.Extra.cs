using System;
using Terradue.ServiceModel.Ogc.Alt21;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Eop21
{
    
    public partial class ProcessingInformationPropertyType
    {
        [XmlIgnore]
        public AltProcessingInformationType AltProcessingInformation
        {
            get
            {
                if (ProcessingInformation is AltProcessingInformationType)
                    return (AltProcessingInformationType)ProcessingInformation;
                return null;
            }
            set
            {
                ProcessingInformation = value;
            }
        }

    }

    public partial class AcquisitionPropertyType
    {
        [XmlIgnore]
        public AltAcquisitionType AltAcquisition
        {
            get
            {
                if (Acquisition is AltAcquisitionType)
                    return (AltAcquisitionType)Acquisition;
                return null;
            }
            set
            {
                Acquisition = value;
            }
        }

    }
}


