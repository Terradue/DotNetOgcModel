using System;
using System.Collections.Generic;
using System.Linq;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = OwcNamespaces.Owc)]
    [System.Xml.Serialization.XmlRootAttribute("offering", Namespace = OwcNamespaces.Owc, IsNullable = false)]
    public class OwcOffering
    {


        private System.Xml.XmlElement[] itemsField;
        Uri code;
        OwcOperation[] operations;
        OwcContent[] contents;
        OwcStyleSet[] styleSets;

        public OwcOffering()
        {
        }

        public OwcOffering(Terradue.ServiceModel.Ogc.Owc.Model.Offering offering)
        {

            this.code = offering.Code;

            if (offering.Content != null)
            {
                this.Contents = offering.Content.Select(c => new OwcContent(c)).ToArray();
            }

            if (offering.Operation != null)
            {
                this.Operations = offering.Operation.Select(c => new OwcOperation(c)).ToArray();
            }

            if (offering.StyleSet != null)
            {
                this.StyleSets = offering.StyleSet.Select(c => new OwcStyleSet(c)).ToArray();
            }

            if (offering.Extensions != null)
                this.Any = offering.Extensions.ToXmlElementArray();
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

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "code")]
        public string Code
        {
            get
            {
                if (code != null)
                    return code.ToString();
                return null;
            }
            set
            {
                code = new Uri(value);
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "operation")]
        public OwcOperation[] Operations
        {
            get
            {
                return operations;
            }
            set
            {
                operations = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "content")]
        public OwcContent[] Contents
        {
            get
            {
                return contents;
            }
            set
            {
                contents = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "styleSet")]
        public OwcStyleSet[] StyleSets
        {
            get
            {
                return styleSets;
            }
            set
            {
                styleSets = value;
            }
        }
    }
}

