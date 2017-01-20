using System;
using Terradue.ServiceModel.Ogc.Xlink;

namespace Terradue.ServiceModel.Ogc.Gml321
{
    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xlink")]
    interface IAssociationAttributeGroup : ISimpleLink
    {
        /// <remarks/>
        string NilReason { get; set; }

        /// <remarks/>
        string RemoteSchema { get; set; }
    }
}
