using System;
using System.Globalization;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Ogc;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/sos/1.0")]
    public class GetObservationFeatureOfInterest
    {
        /// <remarks/>
        public GetObservationFeatureOfInterest()
        {
            this.Xmlns = new XmlSerializerNamespaces();
            this.Xmlns.Add("gml", "http://www.opengis.net/gml");
            this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            this.Xmlns.Add("swe", "http://www.opengis.net/swe/1.0.1");
            this.Xmlns.Add("om", "http://www.opengis.net/om/1.0");
            this.Xmlns.Add("sos", "http://www.opengis.net/sos/1.0");
            this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
            this.Xmlns.Add("ogc", "http://www.opengis.net/ogc");
            this.Xmlns.Add("tml", "http://www.opengis.net/tml");
            this.Xmlns.Add("sml", "http://www.opengis.net/sensorML/1.0.1");
            this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        /// <summary>
        /// Gets or sets prefix association with namespaces that are used object serializer.
        /// </summary>
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns { get; set; }

        /// <summary>
        /// Acts a choice element
        /// </summary>
        private object _choice;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DWithin", Type = typeof(DistanceBufferType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("BBOX", Type = typeof(BBOXType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("Equals", Type = typeof(BinarySpatialOpType), Namespace = "http://www.opengis.net/ogc")]
        [System.Xml.Serialization.XmlElementAttribute("spatialOps", Type = typeof(SpatialOpsType), Namespace = "http://www.opengis.net/ogc")]
        public SpatialOpsType SpatialOperators
        {
            get
            {
                return this._choice as SpatialOpsType;
            }
            set
            {
                if (this._choice != null && !(_choice is SpatialOpsType))
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Property other then 'SpatialOperators' has been used. Internal type is :{0}", this._choice.GetType().Name));
                this._choice = value;
            }
        }

        /// <summary>
        /// >Unordered list of zero or more object identifiers. These identifiers are usually listed in the Contents section of the service metadata (Capabilities) document. If no ObjectID value is included, and if only one category of objects is allowed for this operation, the server shall return all objects of that category. NOTE: Although retention of this ability is allowed by a specific OWS that uses this operation, such retention is discouraged due to possible problems. Making this ability optional implementation by servers reduces interoperability. Requiring implementation of this ability can require a server to return a huge response, when there are a large number of items in that category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ObjectID", DataType = "anyURI")]
        public string ObjectId
        {
            get
            {
                return this._choice as string;
            }
            set
            {
                if (this._choice != null && !(_choice is string))
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Property other then 'SpatialOperators' has been used. Internal type is :{0}", this._choice.GetType().Name));
                this._choice = value;
            }
        }
    }
}
