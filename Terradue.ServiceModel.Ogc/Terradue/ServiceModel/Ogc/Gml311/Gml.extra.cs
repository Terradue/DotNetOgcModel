using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Gml311{

    public partial class TimePeriodType {

        [XmlIgnore]
        public TimePositionType beginPosition {
            get {
                if (this.itemField is TimePositionType)
                    return (TimePositionType)this.itemField;
                return null;
            }
            set {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public TimePositionType endPosition {
            get {
                if (this.item1Field is TimePositionType)
                    return (TimePositionType)this.item1Field;
                return null;
            }
            set {
                this.item1Field = value;
            }
        }

    }
}