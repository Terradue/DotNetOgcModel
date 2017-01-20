using System.Collections.ObjectModel;
using System.Xml;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.ServiceModel.Ogc.Swe10;

namespace Terradue.ServiceModel.Ogc.Sos10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sos/1.0")]
    public class ObservationOfferingType : ObservationOfferingBaseType
    {
        private Collection<string> _intendedApplications = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("intendedApplication", DataType = "token")]
        public Collection<string> IntendedApplications
        {
            get
            {
                return this._intendedApplications;
            }
        }

        private Gml311.TimeGeometricPrimitivePropertyType _time = new Gml311.TimeGeometricPrimitivePropertyType();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time")]
        public Gml311.TimeGeometricPrimitivePropertyType Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        private Collection<ReferenceType> _procedures = new Collection<ReferenceType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procedure")]
        public Collection<ReferenceType> Procedures
        {
            get
            {
                return this._procedures;
            }
        }

        private Collection<PhenomenonPropertyType> _observedProperties = new Collection<PhenomenonPropertyType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("observedProperty")]
        public Collection<PhenomenonPropertyType> ObservedProperties
        {
            get
            {
                return this._observedProperties;
            }
        }

        private Collection<ReferenceType> _featuresOfInterest = new Collection<ReferenceType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("featureOfInterest")]
        public Collection<ReferenceType> FeaturesOfInterest
        {
            get
            {
                return this._featuresOfInterest;
            }
        }

        private Collection<string> _responseFormats = new Collection<string>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseFormat")]
        public Collection<string> ResponseFormats
        {
            get
            {
                return this._responseFormats;
            }
        }

        private Collection<XmlQualifiedName> _resultModels = new Collection<XmlQualifiedName>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resultModel")]
        public Collection<XmlQualifiedName> ResultModels
        {
            get
            {
                return this._resultModels;
            }
        }

        private Collection<ResponseModeType> _responseModes = new Collection<ResponseModeType>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responseMode")]
        public Collection<ResponseModeType> ResponseModes
        {
            get
            {
                return this._responseModes;
            }
        }
    }
}
