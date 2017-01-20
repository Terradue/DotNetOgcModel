using System;
namespace Terradue.ServiceModel.Ogc.Xlink
{
    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    interface ISimpleLink
    {
        /// <remarks/>
        string Type { get; set; }

        /// <remarks/>
        string Href { get; set; }

        /// <remarks/>
        string Role { get; set; }

        /// <remarks/>
        string ArcRole { get; set; }

        /// <remarks/>
        string Title { get; set; }

        /// <remarks/>
        MetadataTypeShow Show { get; set; }

        /// <remarks/>
        bool ShowSpecified { get; }

        /// <remarks/>
        MetadataTypeActuate Actuate { get; set; }

        /// <remarks/>
        bool ActuateSpecified { get; }
    }
}
