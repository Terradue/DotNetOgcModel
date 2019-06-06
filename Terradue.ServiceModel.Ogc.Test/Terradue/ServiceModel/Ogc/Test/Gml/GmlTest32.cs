using NUnit.Framework;
using System;
using System.Xml;
using System.Linq;
using Terradue.ServiceModel.Ogc.Gml321;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace Terradue.ServiceModel.Ogc.Test
{

    [TestFixture()]
    public class Gml32Test
    {

        [Test()]
        public void Gml32MultiCurveWithLinearStringTestCase()
        {

            var fs = new FileStream("../Samples/MultiCurveWithLinearString32.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            Assert.That(gml is MultiCurveType);

            var sw = new StringWriter();

            var xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            xw.Close();

            var xml1 = sw.ToString();

        }

        [Test()]
        public void Gml32MultiSurfaceTestCase()
        {

            var fs = new FileStream(Util.TestBaseDir + "/Samples/Multisurface32.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            Assert.That(gml is MultiSurfaceType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

        }

        [Test()]
        public void FromGMLMultiPoint()
        {


            var fs = new FileStream("Samples/multipoint32.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            Assert.That(gml is MultiPointType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

        }

    }
}

