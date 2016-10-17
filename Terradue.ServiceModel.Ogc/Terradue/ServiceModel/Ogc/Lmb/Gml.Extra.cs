using System;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Gml321
{

    public partial class FeaturePropertyType
    {

        [XmlIgnore]
        public Lmb20.LmbFootprintType Lmb20Footprint
        {
            get
            {
                if (eop20footprintField is Lmb20.LmbFootprintType)
                    return (Lmb20.LmbFootprintType)eop20footprintField;
                return null;
            }
            set
            {
                eop20footprintField = value;
            }
        }

        [XmlIgnore]
        public Lmb21.LmbFootprintType Lmb21Footprint
        {
            get
            {
                if (eop21footprintField is Lmb21.LmbFootprintType)
                    return (Lmb21.LmbFootprintType)eop21footprintField;
                return null;
            }
            set
            {
                eop21footprintField = value;
            }
        }

    }



}