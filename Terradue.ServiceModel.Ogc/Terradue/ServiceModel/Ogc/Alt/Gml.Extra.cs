using System;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Gml321
{

    public partial class FeaturePropertyType
    {

        [XmlIgnore]
        public Alt20.AltFootprintType Alt20Footprint
        {
            get
            {
                if (eop20footprintField is Alt20.AltFootprintType)
                    return (Alt20.AltFootprintType)eop20footprintField;
                return null;
            }
            set
            {
                eop20footprintField = value;
            }
        }

        [XmlIgnore]
        public Alt21.AltFootprintType Alt21Footprint
        {
            get
            {
                if (eop21footprintField is Alt21.AltFootprintType)
                    return (Alt21.AltFootprintType)eop21footprintField;
                return null;
            }
            set
            {
                eop21footprintField = value;
            }
        }

    }



}