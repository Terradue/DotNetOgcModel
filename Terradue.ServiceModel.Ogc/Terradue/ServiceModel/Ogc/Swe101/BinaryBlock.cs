using System.Collections.ObjectModel;

namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    [System.Xml.Serialization.XmlRootAttribute("BinaryBlock", Namespace = "http://www.opengis.net/swe/1.0.1", IsNullable = false)]
    public class BinaryBlock : AbstractEncodingType
    {
        private Collection<BinaryBlockMember> _members = new Collection<BinaryBlockMember>();
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public Collection<BinaryBlockMember> Members
        {
            get
            {
                return this._members;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("byteLength", DataType = "positiveInteger")]
        public string ByteLength
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("byteEncoding")]
        public ByteEncoding ByteEncoding
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("byteOrder")]
        public ByteOrder ByteOrder
        {
            get;
            set;
        }
    }
}
