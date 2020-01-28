using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Terradue.ServiceModel.Syndication;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding
{
    public static class OwcContextHelper
    {
        public static XmlSerializer OwcOfferingSerializer = new XmlSerializer(typeof(OwcOffering));

        public static XmlReader CreateReader(this OwcOffering offering)
        {
            XmlSerializerNamespaces ns = GetXmlSerializerNamespacesFromType(offering.GetType());

            MemoryStream memoryStream = new MemoryStream();
            XmlWriter xmlWriter = XmlWriter.Create(memoryStream);
            OwcOfferingSerializer.Serialize(xmlWriter, offering, ns);
            memoryStream.Seek(0L, SeekOrigin.Begin);
            return XmlReader.Create(memoryStream);
        }

        public static XmlSerializerNamespaces GetXmlSerializerNamespacesFromType(Type type)
        {

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

            ns.Add("owc", OwcNamespaces.Owc);

            return ns;
        }

        public static Model.Offering ToOffering(this OwcOffering offering)
        {

            var of = new Model.Offering()
            {
                Code = new Uri(offering.Code),

                Extensions = offering.Any == null ? null : offering.Any.ToSyndicationElementExtensionCollection()
            };

            if (offering.Operations != null)
                of.Operation = new System.Collections.ObjectModel.Collection<Model.Operation>(offering.Operations.Select(o => o.ToOperation()).ToList());
            if (offering.Contents != null)
                of.Content = new System.Collections.ObjectModel.Collection<Model.Content>(offering.Contents.Select(o => o.ToContent()).ToList());
            if (offering.StyleSets != null)
                of.StyleSet = new System.Collections.ObjectModel.Collection<Model.StyleSet>(offering.StyleSets.Select(o => o.ToStyleSet()).ToList());

            return of;

        }

        public static Model.Operation ToOperation(this OwcOperation operation)
        {

            var o = new Model.Operation()
            {
                Code = operation.Code,
                RequestURL = operation.RequestUrl,
                Method = operation.Method,
                Type = operation.Type
               
            };

            if (operation.Request != null)
                o.Request = operation.Request.ToContent();
            if (operation.Result != null)
                o.Result = operation.Result.ToContent();
            if (operation.Any != null)
                o.Extensions = operation.Any.ToSyndicationElementExtensionCollection();

            return o;

        }

        public static Model.StyleSet ToStyleSet(this OwcStyleSet styleSet)
        {

            return new Model.StyleSet()
            {
                Name = styleSet.Name,
                Title = styleSet.Title,
                Abstract = styleSet.Abstract,
                Default = styleSet.Default,
                LegendURL = styleSet.LegendUrl == null ? null : styleSet.LegendUrl.Href,
                Content = styleSet.Content == null ? null : styleSet.Content.ToContent(),
                Extensions = styleSet.Any == null ? null : styleSet.Any.ToSyndicationElementExtensionCollection()
            };

        }

        public static Model.Content ToContent(this OwcContent content)
        {

            return new Model.Content()
            {
                Type = content.Type,
                Url = content.Url,
                Value = content.Text,
                Extension = content.Any == null ? null : content.Any.ToSyndicationElementExtension()
            };

        }

        public static SyndicationElementExtension ToSyndicationElementExtension(this XmlElement element)
        {
            return new SyndicationElementExtension(new XmlNodeReader(element));
        }

        public static SyndicationElementExtensionCollection ToSyndicationElementExtensionCollection(this XmlElement[] elements)
        {
            SyndicationElementExtensionCollection extensions = new SyndicationElementExtensionCollection();

            foreach (var element in elements)
            {
                extensions.Add(element.ToSyndicationElementExtension());
            }

            return extensions;
        }

        public static XmlElement[] ToXmlElementArray(this SyndicationElementExtensionCollection exts)
        {
            if (exts == null) return null;
            XmlDocument doc = new XmlDocument();
            doc.Load(exts.GetReaderAtExtensionWrapper());
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("//extensionWrapper/*");
            return nodes.Cast<XmlElement>().ToArray();
        }

        public static XmlElement ToXmlElement(this SyndicationElementExtension ext)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(ext.GetReader());
            return doc.DocumentElement;
        }
    }


}
