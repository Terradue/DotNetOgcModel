using NUnit.Framework;
using System;
using System.Xml;
using System.Linq;
using Terradue.ServiceModel.Ogc.Gml311;
using System.IO;
using System.Xml.Linq;

namespace Terradue.GeoJson.Tests { 

    [TestFixture()]
    public class GmlTest {

        [Test()]
        public void GmlMultiPolygonTestCase() {

            var fs = new FileStream("../Samples/MultiPolygon.xml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            Assert.That(gml is MultiPolygonType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            xw.Close();

            sw = new StringWriter();

            xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            //Assert.IsTrue(XNode.DeepEquals(XDocument.Load("../Samples/MultiPolygon.xml").Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GmlMultiCurveWithLinearStringTestCase() {

            var fs = new FileStream("../Samples/MultiCurveWithLinearString.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            Assert.That(gml is MultiCurveType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

            sw = new StringWriter();

            xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            xw.Close();

            xml1 = sw.ToString();

        }

        [Test()]
        public void GmlMultiSurfaceTestCase() {

            var fs = new FileStream("../Samples/MultiSurface311.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            Assert.That(gml is MultiSurfaceType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

        }


    }
}

