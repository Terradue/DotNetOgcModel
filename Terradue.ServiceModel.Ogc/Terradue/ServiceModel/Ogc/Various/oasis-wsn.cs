namespace Terradue.ServiceModel.Ogc.Oasis {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21609")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1")]
    [System.Xml.Serialization.XmlRootAttribute("TopicNamespace", Namespace="http://docs.oasis-open.org/wsn/t-1", IsNullable=false)]
    public partial class TopicNamespaceType : ExtensibleDocumented {
        
        private TopicNamespaceTypeTopic[] topicField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string nameField;
        
        private string targetNamespaceField;
        
        private bool finalField;
        
        public TopicNamespaceType() {
            this.finalField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Topic")]
        public TopicNamespaceTypeTopic[] Topic {
            get {
                return this.topicField;
            }
            set {
                this.topicField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string targetNamespace {
            get {
                return this.targetNamespaceField;
            }
            set {
                this.targetNamespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool final {
            get {
                return this.finalField;
            }
            set {
                this.finalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21609")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.oasis-open.org/wsn/t-1")]
    public partial class TopicNamespaceTypeTopic : TopicType {
        
        private string parentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21609")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1")]
    public partial class TopicType : ExtensibleDocumented {
        
        private QueryExpressionType messagePatternField;
        
        private TopicType[] topicField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string nameField;
        
        private System.Xml.XmlQualifiedName[] messageTypesField;
        
        private bool finalField;
        
        public TopicType() {
            this.finalField = false;
        }
        
        /// <remarks/>
        public QueryExpressionType MessagePattern {
            get {
                return this.messagePatternField;
            }
            set {
                this.messagePatternField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Topic")]
        public TopicType[] Topic {
            get {
                return this.topicField;
            }
            set {
                this.topicField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName[] messageTypes {
            get {
                return this.messageTypesField;
            }
            set {
                this.messageTypesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool final {
            get {
                return this.finalField;
            }
            set {
                this.finalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21609")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1")]
    public partial class QueryExpressionType {
        
        private System.Xml.XmlNode[] anyField;
        
        private string dialectField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Dialect {
            get {
                return this.dialectField;
            }
            set {
                this.dialectField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21609")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1")]
    public partial class Documentation {
        
        private System.Xml.XmlNode[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopicSetType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopicType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopicNamespaceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21609")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1")]
    public abstract partial class ExtensibleDocumented {
        
        private Documentation documentationField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public Documentation documentation {
            get {
                return this.documentationField;
            }
            set {
                this.documentationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdGenerator", "1.0.6228.21609")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1")]
    [System.Xml.Serialization.XmlRootAttribute("TopicSet", Namespace="http://docs.oasis-open.org/wsn/t-1", IsNullable=false)]
    public partial class TopicSetType : ExtensibleDocumented {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
}
