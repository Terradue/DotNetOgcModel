using System;
using Terradue.ServiceModel.Syndication;
using System.Xml;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("content", Namespace = OwcNamespaces.Owc)]
    [System.Xml.Serialization.XmlRootAttribute("content", Namespace = OwcNamespaces.Owc, IsNullable = false)]
	public class OwcContent
	{
        private string type;
        private Uri url;
        private string text;
        private XmlElement itemsField;

        public OwcContent(){
        }

        public OwcContent(string type, Uri url){
            Url = url;
            this.type = type;
        }

        public OwcContent(string type, string text){
            Text = text;
            this.type = type;
        }

        public OwcContent(string type, XmlElement any){
            Any = any;
            this.type = type;
        }

        public OwcContent(Model.Content content)
        {
            this.Type = content.Type;
            this.Url = content.Url;
            this.Text = content.Value;
            this.Any = content.Extension == null ? null : content.Extension.GetObject<XmlElement>();
        }

        [System.Xml.Serialization.XmlAttributeAttribute("href")]
        public string Href {
            get {
                if (Url == null)
                    return null;
                return Url.ToString();
            }
            set {
                Url = new Uri(value);
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public Uri Url {
            get {
                return url;
            }
            set {
                url = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }
            
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text {
            get {
                return text;
            }
            set {
                text = value;
            }
        }

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
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
	}


}

