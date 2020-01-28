using System;
using Terradue.ServiceModel.Syndication;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = OwcNamespaces.Owc)]
    [System.Xml.Serialization.XmlRootAttribute("operation", Namespace = OwcNamespaces.Owc, IsNullable = false)]
    public class OwcOperation
    {

        string method;
        string code;
        Uri url;
        private System.Xml.XmlElement[] itemsField;
        string type;

        OwcContent result;
        OwcContent request;

        public OwcOperation()
        {
        }

        public OwcOperation(string code, Uri href)
        {
            this.url = href;
            this.code = code;
            this.method = null;
        }

        public OwcOperation(Terradue.ServiceModel.Ogc.Owc.Model.Operation operation) : this(operation.Code, operation.RequestURL)
        {
            this.Method = operation.Method;
            if (operation.Request != null)
                this.Request = new OwcContent(operation.Request);
            if (operation.Result != null)
                this.Result = new OwcContent(operation.Result);
            this.Type = operation.Type;
            if (operation.Extensions != null)
                this.Any = operation.Extensions.ToXmlElementArray();
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "code")]
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "href")]
        public string Href
        {
            get
            {
                return RequestUrl.ToString();
            }
            set
            {
                RequestUrl = new Uri(value);
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public Uri RequestUrl
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "method")]
        public string Method
        {
            get
            {
                return method;
            }
            set
            {
                method = value;
            }
        }

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "result")]
        public OwcContent Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "request")]
        public OwcContent Request
        {
            get
            {
                return request;
            }
            set
            {
                request = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }

}

