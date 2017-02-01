using Terradue.ServiceModel.Ogc.Gmd;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Swe20;

namespace Terradue.ServiceModel.Ogc.SensorMl20
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6233.30931")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sensorml/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("SimpleProcess", Namespace = "http://www.opengis.net/sensorml/2.0", IsNullable = false)]
    public partial class SimpleProcessType : AbstractProcessType
    {

        private ProcessMethodPropertyType methodField;

        /// <remarks/>
        public ProcessMethodPropertyType method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }
    }
    
}
