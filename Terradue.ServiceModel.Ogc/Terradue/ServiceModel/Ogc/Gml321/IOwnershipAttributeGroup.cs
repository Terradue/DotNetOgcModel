using System;
namespace Terradue.ServiceModel.Ogc.Gml321
{
    /// <summary>
    /// Encoding a GML property inline vs. by-reference shall not imply anything about the “ownership” of the contained or referenced GML Object, i.e. the encoding style shall not imply any “deep-copy” or “deep-delete” semantics. To express ownership over the contained or referenced GML Object, the gml:OwnershipAttributeGroup attribute group may be added to object-valued property elements. If the attribute group is not part of the content model of such a property element, then the value may not be “owned”.
    /// When the value of the owns attribute is "true", the existence of inline or referenced object(s) depends upon the existence of the parent object.
    /// </summary>
    interface IOwnershipAttributeGroup
    {
        bool Owns { get; set; }
    }
}
