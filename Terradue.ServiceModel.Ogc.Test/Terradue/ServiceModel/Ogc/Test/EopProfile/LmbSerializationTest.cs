using NUnit.Framework;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Terradue.ServiceModel.Ogc.Eop21;
using System.Xml.Linq;
using Microsoft.XmlDiffPatch;
using Terradue.ServiceModel.Ogc.Swe;
using Terradue.ServiceModel.Ogc.Lmb21;

namespace Terradue.ServiceModel.Ogc.Test {

    [TestFixture()]
    public class LmbSerializationTest {


        [Test()]
        public void LmbExampleTestCase() {

            FileInfo s1 = new FileInfo("../Samples/LBY_S1A_OPER_REP_METARC_PDMC_20150718T045726_I9847_point.xml");

            LmbEarthObservationType eop = (LmbEarthObservationType)OgcHelpers.DeserializeEarthObservation(XmlReader.Create(s1.OpenRead()));


            Assert.AreEqual("2015-07-18T02:44:58.47Z", eop.phenomenonTime.GmlTimePeriod.beginPosition.Value);
            Assert.AreEqual("2015-07-18T02:45:50.18Z", eop.phenomenonTime.GmlTimePeriod.endPosition.Value);
            Assert.AreEqual("TimeInstant.S1A_EW_GRDM_1SDV_20150718T024458_20150718T024550_006859_009400_2D59.SAFE", eop.resultTime.TimeInstant.id);
            Assert.AreEqual("2015-07-18T04:47:43.54Z", eop.resultTime.TimeInstant.timePosition.Value);
            Assert.AreEqual("ALTIMETRIC", eop.procedure.Eop21EarthObservationEquipment.sensor.LmbSensor.sensorType);

            XmlReader xr = eop.CreaterReader();

            string xml1 = XElement.Load(xr).ToString();

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            xr = eop.CreaterReader();

           

        }

    }
}

