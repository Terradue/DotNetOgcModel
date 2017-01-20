namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class BinaryBlockMemberBlock
    {
        /// <remarks/>
        public BinaryBlockMemberBlock()
        {
            this.PaddingBytesbefore = "0";
            this.PaddingBytesafter = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType = "token")]
        public string Ref
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("byteLength", DataType = "positiveInteger")]
        public string ByteLength
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBytes-before", DataType = "nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PaddingBytesbefore
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBytes-after", DataType = "nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PaddingBytesafter
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("encryption", DataType = "anyURI")]
        public string Encryption
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("compression", DataType = "anyURI")]
        public string Compression
        {
            get;
            set;
        }
    }
}
