using System;
using Terradue.ServiceModel.Syndication;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding
{

    [System.Xml.Serialization.XmlTypeAttribute("display", Namespace = OwcNamespaces.Owc)]
    [System.Xml.Serialization.XmlRootAttribute("display", Namespace = OwcNamespaces.Owc, IsNullable = false)]
    public class OwcDisplay
    {

        int pixelWidth;
        int pixelHeight;
        int mmPerPixel;
        private System.Xml.XmlElement[] itemsField;

        public OwcDisplay()
        {
        }

        public OwcDisplay(Terradue.ServiceModel.Ogc.Owc.Model.OwcDisplay display) : this()
        {
            this.MmPerPixel = display.MmPerPixel;
            this.PixelHeight = display.PixelHeight;
            this.PixelWidth = display.PixelWidth;
        }

        public static XmlSerializer GetSerializer()
        {

            XmlSerializer ser = new XmlSerializer(typeof(OwcDisplay));
            return ser;

        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pixelWidth")]
        public int PixelWidth
        {
            get
            {
                return pixelWidth;
            }
            set
            {
                pixelWidth = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "pixelHeight")]
        public int PixelHeight
        {
            get
            {
                return pixelHeight;
            }
            set
            {
                pixelHeight = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mmPerPixel")]
        public int MmPerPixel
        {
            get
            {
                return mmPerPixel;
            }
            set
            {
                mmPerPixel = value;
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
    }
}

