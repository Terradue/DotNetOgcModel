using NUnit.Framework;
using System;
using System.Xml.Serialization;
using System.IO;

namespace Terradue.ServiceModel.Ogc.Test {
    
    [TestFixture()]
    public class SerializationTest {


        [Test()]
        public void TestCase() {

            XmlSerializer gmlTimePeriodSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Gml321.TimePeriodType));
            FileStream fs = new FileStream("../Samples/GmlTimePeriod.xml", FileMode.Open);
            Terradue.ServiceModel.Ogc.Gml321.TimePeriodType tp = (Terradue.ServiceModel.Ogc.Gml321.TimePeriodType)gmlTimePeriodSerializer.Deserialize(fs);

            Assert.That(tp.Item is Terradue.ServiceModel.Ogc.Gml321.TimeInstantPropertyType);
            Assert.That(tp.Item1 is Terradue.ServiceModel.Ogc.Gml321.TimeInstantPropertyType);

        }


    }
}

