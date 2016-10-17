using System;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Gml321
{

    public partial class FeaturePropertyType
    {

        [XmlIgnore]
        public Ssp20.SspFootprintType Ssp20Footprint
        {
            get
            {
                if (eop20footprintField is Ssp20.SspFootprintType)
                    return (Ssp20.SspFootprintType)eop20footprintField;
                return null;
            }
            set
            {
                eop20footprintField = value;
            }
        }

        [XmlIgnore]
        public Ssp21.SspFootprintType Ssp21Footprint
        {
            get
            {
                if (eop21footprintField is Ssp21.SspFootprintType)
                    return (Ssp21.SspFootprintType)eop21footprintField;
                return null;
            }
            set
            {
                eop21footprintField = value;
            }
        }

    }



}