using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using Terradue.ServiceModel.Ogc.Owc.AtomEncoding;

namespace Terradue.ServiceModel.Ogc.Test.OwsContext {

    [TestFixture]
    public class RegressionTests {

        [Test]
        public void Issue1() {


            OwsContextAtomFeed feed = new OwsContextAtomFeed();

            /// entries
            List<OwsContextAtomEntry> items = new List<OwsContextAtomEntry>();
            OwsContextAtomEntry item = new OwsContextAtomEntry();

            feed.Publisher = "manu";
            item.Publisher = "manu";
            items.Add(item);

            feed.Items = items;

            MemoryStream stream = new MemoryStream();

            SerializationTest.SerializeToStream(feed, stream);

            stream.Seek(0, SeekOrigin.Begin);

            XDocument doc = XDocument.Load(stream);

            Assert.AreEqual("manu", doc.Element(XName.Get("feed", OwcNamespaces.Atom))
                            .Element(XName.Get("publisher", OwcNamespaces.Dc)).Value);

            Assert.AreEqual("manu", doc.Element(XName.Get("feed", OwcNamespaces.Atom))
                            .Elements(XName.Get("entry", OwcNamespaces.Atom)).First()
                            .Element(XName.Get("publisher", OwcNamespaces.Dc)).Value);

        }
    }
}

