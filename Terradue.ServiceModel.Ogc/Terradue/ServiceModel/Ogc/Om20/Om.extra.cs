using System;
using Terradue.ServiceModel.Ogc.Gml321;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Om20 {
    public partial class TimeObjectPropertyType {

        [XmlIgnore]
        public TimePeriodType GmlTimePeriod {
            get {
                if (this.abstractTimeObjectField is TimePeriodType)
                    return (TimePeriodType)this.abstractTimeObjectField;
                return null;
            }
            set {
                this.abstractTimeObjectField = value;
            }
        }

    }
}

