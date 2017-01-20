namespace Terradue.ServiceModel.Ogc.Swe101
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/swe/1.0.1")]
    public class BinaryBlockMemberComponent
    {
        /// <remarks/>
        public BinaryBlockMemberComponent()
        {
            this.PaddingBitsbefore = "0";
            this.PaddingBitsafter = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ref", DataType = "token")]
        public string Ref
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("dataType", DataType = "anyURI")]
        public string DataType
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("significantBits", DataType = "positiveInteger")]
        public string SignificantBits
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("bitLength", DataType = "positiveInteger")]
        public string BitLength
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBits-before", DataType = "nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PaddingBitsbefore
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("paddingBits-after", DataType = "nonNegativeInteger")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PaddingBitsafter
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("encryption", DataType = "anyURI")]
        public string encryption
        {
            get;
            set;
        }
    }
}
