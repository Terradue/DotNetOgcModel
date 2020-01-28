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
    public class SerializationTests {

        [Test]
        public void DateExtensions() {

            Terradue.ServiceModel.Syndication.Atom10FeedFormatter feed = new Syndication.Atom10FeedFormatter();

            feed.ReadFrom(XmlReader.Create(File.OpenRead(Util.TestBaseDir + "/Samples/offeringdateext.xml")));

			OwsContextAtomFeed ows = new OwsContextAtomFeed(feed.Feed, true);

			SerializationTest.SerializeToStream(ows, Console.OpenStandardOutput());

        }
    }
}

