using System;
using System.Xml;
using System.Linq;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("styleSet", Namespace = OwcNamespaces.Owc)]
    [System.Xml.Serialization.XmlRootAttribute("styleSet", Namespace = OwcNamespaces.Owc, IsNullable = false)]
    public class OwcStyleSet
    {

        XmlElement[] itemsField;
        bool defaultAttr;
        string name;
        string title;
        string @abstract;
        OwcLegenUrl legendUrl;
        OwcContent content;

        public OwcStyleSet()
        {
        }

        public OwcStyleSet(ServiceModel.Ogc.Owc.Model.StyleSet styleSet)
        {
            this.Abstract = styleSet.Abstract;
            if (styleSet.Content != null)
                this.Content = new OwcContent(styleSet.Content);
            this.Default = styleSet.Default;
            if (styleSet.LegendURL != null)
                this.LegendUrl = new OwcLegenUrl(styleSet.LegendURL);
            this.name = styleSet.Name;
            this.Title = styleSet.Title;
            if (styleSet.Extensions != null)
                this.Any = styleSet.Extensions.ToXmlElementArray();

        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "default")]
        public bool Default
        {
            get
            {
                return defaultAttr;
            }
            set
            {
                defaultAttr = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "title")]
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "abstract")]
        public string Abstract
        {
            get
            {
                return @abstract;
            }
            set
            {
                @abstract = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "legendURL")]
        public OwcLegenUrl LegendUrl
        {
            get
            {
                return legendUrl;
            }
            set
            {
                legendUrl = value;
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

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "content")]
        public OwcContent Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = OwcNamespaces.Owc)]
        public class OwcLegenUrl
        {

            public OwcLegenUrl() { }

            public OwcLegenUrl(Uri legendURL)
            {
                this.Href = legendURL;
            }

            Uri href;

            [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "href")]
            public string Url
            {
                get
                {
                    if (href != null)
                        return href.ToString();
                    return null;
                }
                set
                {
                    href = new Uri(value);
                }
            }

            [System.Xml.Serialization.XmlIgnore]
            public Uri Href
            {
                get
                {
                    return href;
                }
                set
                {
                    href = value;
                }
            }


        }
    }
}

