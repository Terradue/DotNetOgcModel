namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
    [System.Xml.Serialization.XmlRootAttribute("Range", Namespace = "http://www.opengis.net/ows/1.1", IsNullable = false)]
    public class RangeType
    {
        /// <remarks/>
        public RangeType()
        {
            this.RangeClosure = RangeTypeRangeClosure.Closed;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MinimumValue")]
        public ValueType MinimumValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaximumValue")]
        public ValueType MaximumValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spacing")]
        public ValueType Spacing { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("rangeClosure", Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        [System.ComponentModel.DefaultValueAttribute(RangeTypeRangeClosure.Closed)]
        public RangeTypeRangeClosure RangeClosure { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RangeClosureSpecified { get; set; }
    }
}
