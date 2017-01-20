using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.ServiceModel.Ogc.SensorML101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sensorML/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("spatialReferenceFrame", Namespace = "http://www.opengis.net/sensorML/1.0.1", IsNullable = false)]
    public class SpatialReferenceFrame
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EngineeringCRS", Namespace = "http://www.opengis.net/gml")]
        public EngineeringCRSType EngineeringCRS { get; set; }
    }
}
