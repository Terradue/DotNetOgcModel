using NUnit.Framework;
using System;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Terradue.ServiceModel.Syndication;
using Terradue.ServiceModel.Ogc.Owc.AtomEncoding;
using System.Xml.Serialization;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using Terradue.ServiceModel.Ogc.Wps10;
using Terradue.ServiceModel.Ogc.Ows11;
using Terradue.ServiceModel.Ogc.GeoRss.GeoRss;

namespace Terradue.ServiceModel.Ogc.Test.OwsContext {

    [TestFixture()]
    public class SerializationTest {

        [Test()]
        public void Serialize() {

            OwsContextAtomFeed feed = new OwsContextAtomFeed();

            // display
            OwcDisplay display = new OwcDisplay() { PixelWidth = 800, PixelHeight = 600, MmPerPixel = 100 };
            var displayAny = new System.Collections.Generic.List<XmlElement>();
            display.Any = displayAny.ToArray();
            feed.Display = display;

            // date
            DateTimeInterval interval = new DateTimeInterval();
            interval.StartDate = DateTime.Parse("2010-05-30T05:54:34+02");
            interval.EndDate = DateTime.Parse("2010-05-31T20:20:20.000Z");
            feed.Date = interval;

            // georss
            GeoRssWhere georss = (GeoRssWhere)GeoRssHelper.Deserialize(XmlReader.Create(new StringReader("<georss:where xmlns:georss=\"http://www.georss.org/georss\">\n<gml:Polygon xmlns:gml=\"http://www.opengis.net/gml\">\n<gml:exterior>\n<gml:LinearRing>\n<gml:posList>45 -2 45 8 55 8 55 -2 45 -2</gml:posList>\n</gml:LinearRing>\n</gml:exterior>\n</gml:Polygon>\n</georss:where>")));
            feed.Where = georss;

            /// entries
            List<OwsContextAtomEntry> items = new List<OwsContextAtomEntry>();
            OwsContextAtomEntry item = new OwsContextAtomEntry();
            List<OwcOffering> offerings = new List<OwcOffering>();
            OwcOffering offering = new OwcOffering();
            List<XmlElement> offeringAny = new List<XmlElement>();
            offering.Any = offeringAny.ToArray();
            List<OwcOperation> ops = new List<OwcOperation>();
            ops.Add(new OwcOperation("GetCapabilities", new Uri("http://ows.genesi-dec.eu/geoserver/385d7d71-650a-414b-b8c7-739e2c0b5e76/wms?SERVICE=WMS&SERVICE=WMS&VERSION=1.1.1&REQUEST=GetCapabilitiesVERSION=1.3.0&REQUEST=GetCapabilities")));
            ops.Add(new OwcOperation("GetCapabilities2", new Uri("http://ows.genesi-dec.eu/geoserver/385d7d71-650a-414b-b8c7-739e2c0b5e76/wms?SERVICE=WMS&SERVICE=WMS&VERSION=1.1.1&REQUEST=GetCapabilitiesVERSION=1.3.0&REQUEST=GetCapabilities")));
            offering.Operations = ops.ToArray();
            offerings.Add(offering);
            item.Offerings = offerings;
            items.Add(item);

            feed.Items = items;

            MemoryStream stream = new MemoryStream();

            SerializeToStream(feed, stream);

            stream.Seek(0, SeekOrigin.Begin);

            SerializeToStream(feed, Console.Out);

            XDocument doc = XDocument.Load(stream);
            Assert.NotNull(doc.Element(XName.Get("feed", OwcNamespaces.Atom)));

            Assert.NotNull(doc.Element(XName.Get("feed", OwcNamespaces.Atom)).Element(XName.Get("display", OwcNamespaces.Owc)));

            Assert.AreEqual("2010-05-30T03:54:34.0000000Z/2010-05-31T20:20:20.0000000Z", doc.Element(XName.Get("feed", OwcNamespaces.Atom)).Element(XName.Get("date", OwcNamespaces.Dc)).Value);
        }

        [Test()]
        public void SerializeFromModel() {

            Terradue.ServiceModel.Ogc.Owc.Model.Context context = new Terradue.ServiceModel.Ogc.Owc.Model.Context();

            context.Abstract = "Test ows context";
            context.Publisher = "engue";
            context.Authors = new List<string>{ "author" };

            // display
            Terradue.ServiceModel.Ogc.Owc.Model.OwcDisplay display = new Terradue.ServiceModel.Ogc.Owc.Model.OwcDisplay() { PixelWidth = 800, PixelHeight = 600, MmPerPixel = 100 };
            context.Creator = new Terradue.ServiceModel.Ogc.Owc.Model.Creator();
            context.Creator.CreatorDisplay = display;

            // date
            DateTimeInterval interval = new DateTimeInterval();
            interval.StartDate = DateTime.Parse("2010-05-30T05:54:34+02");
            interval.EndDate = DateTime.Parse("2010-05-31T20:20:20.000Z");
            context.TimeIntervalOfInterest = interval;

            // georss
            GeoRssWhere georss =  (GeoRssWhere)GeoRssHelper.Deserialize(XmlReader.Create(new StringReader("<georss:where xmlns:georss=\"http://www.georss.org/georss\">\n<gml:Polygon xmlns:gml=\"http://www.opengis.net/gml\">\n<gml:exterior>\n<gml:LinearRing>\n<gml:posList>45 -2 45 8 55 8 55 -2 45 -2</gml:posList>\n</gml:LinearRing>\n</gml:exterior>\n</gml:Polygon>\n</georss:where>")));
            context.AreaOfInterest = georss;

            /// entries
            context.Resources = new List<Terradue.ServiceModel.Ogc.Owc.Model.Resource>();
            Terradue.ServiceModel.Ogc.Owc.Model.Resource resource = new Terradue.ServiceModel.Ogc.Owc.Model.Resource();
            resource.Publisher = "engue";
            List<Terradue.ServiceModel.Ogc.Owc.Model.Offering> offerings = new List<Terradue.ServiceModel.Ogc.Owc.Model.Offering>();
            Terradue.ServiceModel.Ogc.Owc.Model.Offering offering = new Terradue.ServiceModel.Ogc.Owc.Model.Offering();
            offering.Operation = new Collection<Terradue.ServiceModel.Ogc.Owc.Model.Operation>();
            Terradue.ServiceModel.Ogc.Owc.Model.Operation op = new Terradue.ServiceModel.Ogc.Owc.Model.Operation();
            op.Code = "GetCapabilities";
            op.RequestURL = new Uri("http://ows.genesi-dec.eu/geoserver/385d7d71-650a-414b-b8c7-739e2c0b5e76/wms?SERVICE=WMS&SERVICE=WMS&VERSION=1.1.1&REQUEST=GetCapabilitiesVERSION=1.3.0&REQUEST=GetCapabilities");
            offering.Operation.Add(op);
            offering.Code = new Uri("http://ows.genesi-dec.eu/geoserver");
            offerings.Add(offering);
            resource.Offerings = offerings;
            context.Resources.Add(resource);

            MemoryStream stream = new MemoryStream();

            OwsContextAtomFeed feed = context.ToOwsContextAtomFeed();

            SerializeToStream(feed, stream);

            stream.Seek(0, SeekOrigin.Begin);

            SerializeToStream(feed, Console.Out);

            XDocument doc = XDocument.Load(stream);

            Assert.NotNull(doc.Element(XName.Get("feed", OwcNamespaces.Atom)));

            Assert.NotNull(doc.Element(XName.Get("feed", OwcNamespaces.Atom)).Element(XName.Get("display", OwcNamespaces.Owc)));

            Assert.AreEqual("2010-05-30T03:54:34.0000000Z/2010-05-31T20:20:20.0000000Z", doc.Element(XName.Get("feed", OwcNamespaces.Atom)).Element(XName.Get("date", OwcNamespaces.Dc)).Value);
        }

        [Test()]
        public void DeserializeGeotiff() {

            FileStream geotiff = new FileStream(Util.TestBaseDir + "/Samples/geotiff.xml", FileMode.Open);
            OwsContextAtomFeed feed = DeserializeFromStream(geotiff);

            Assert.AreEqual("GeoTIFF Example", feed.Title.Text);

            Assert.AreEqual(2, feed.Items.First().Offerings.Count());

            Assert.AreEqual("image/tiff", feed.Items.First().Offerings.First().Contents.First().Type);

            Assert.AreEqual("ftp://ftp.remotesensing.org/pub/geotiff/samples/gdal_eg/cea.tif", feed.Items.First().Offerings.First().Contents.First().Url.ToString());

            Assert.AreEqual("ftp://ftp.remotesensing.org/pub/geotiff/samples/pci_eg/acea.tif", feed.Items.First().Offerings.Last().Contents.First().Url.ToString());
           
        }

        [Test()]
        public void SerializeWithAny() {

            OwsContextAtomFeed feed = new OwsContextAtomFeed();
            OwsContextAtomEntry entry = new OwsContextAtomEntry();
            var items = new List<OwsContextAtomEntry>();

            items.Add(entry);

            var offering = new OwcOffering();

            List<OwcOperation> operations = new List<OwcOperation>();

            Uri executeUri = new Uri("http://localhost/wps?");

            Terradue.ServiceModel.Ogc.Owc.AtomEncoding.OwcOperation operation = new OwcOperation{ Method = "POST", Code = "Execute", RequestUrl = executeUri };

            List<KeyValuePair<string, string>> Parameters = new List<KeyValuePair<string, string>>();
            Parameters.Add(new KeyValuePair<string, string>("manu", "test"));

            Execute execute = new Execute();
            execute.Identifier = new CodeType{ Value = "id" };
            execute.DataInputs = new List<InputType>();
            foreach (var param in Parameters) {
                InputType input = new InputType();
                input.Identifier = new CodeType{ Value = param.Key };
                input.Data = new DataType{ Item = new LiteralDataType{ Value = param.Value } };
                execute.DataInputs.Add(input);
            }


            MemoryStream ms = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(ms);

            new System.Xml.Serialization.XmlSerializer(typeof(Execute)).Serialize(writer, execute);
            writer.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            XmlDocument doc = new XmlDocument();
            doc.Load(ms);

            XmlElement any = (XmlElement)doc.DocumentElement.CloneNode(true);

            operation.Request = new OwcContent();
            ((OwcContent)operation.Request).Any = any;
            operations.Add(operation);
            offering.Operations = operations.ToArray();
            entry.Offerings = new List<OwcOffering>{ offering };
            entry.Categories.Add(new SyndicationCategory("WpsOffering"));

            entry.Summary = new TextSyndicationContent("summary");
            entry.ElementExtensions.Add("identifier", "http://purl.org/dc/elements/1.1/", "id");

            feed.Items = items;

            SerializeToStream(feed, Console.Out);

        }

        public static void SerializeToStream(SyndicationFeed feed, System.IO.Stream stream) {
            var sw = XmlWriter.Create(stream, new XmlWriterSettings(){Indent = true});
            Atom10FeedFormatter atomFormatter = new Atom10FeedFormatter(feed);
            atomFormatter.WriteTo(sw);
            sw.Flush();
            sw.Close();
        }

        public static void SerializeToStream(SyndicationFeed feed, TextWriter writer) {
            var sw = XmlWriter.Create(writer,new XmlWriterSettings(){Indent = true});
            Atom10FeedFormatter atomFormatter = new Atom10FeedFormatter(feed);
            atomFormatter.WriteTo(sw);
            sw.Flush();
            sw.Close();
        }

        public OwsContextAtomFeed DeserializeFromStream(Stream stream) {
            var sr = XmlReader.Create(stream);
            Atom10FeedFormatter atomFormatter = new Atom10FeedFormatter();
            atomFormatter.ReadFrom(sr);
            sr.Close();
            return new OwsContextAtomFeed(atomFormatter.Feed, true);
        }
    }


}

