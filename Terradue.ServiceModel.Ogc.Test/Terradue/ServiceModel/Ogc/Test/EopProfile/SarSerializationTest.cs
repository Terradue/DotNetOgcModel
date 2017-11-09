using NUnit.Framework;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Terradue.ServiceModel.Ogc.Eop21;
using System.Xml.Linq;
using Microsoft.XmlDiffPatch;
using Terradue.ServiceModel.Ogc.Swe;
using Terradue.ServiceModel.Ogc.Sar21;

namespace Terradue.ServiceModel.Ogc.Test {

    [TestFixture()]
    public class SarSerializationTest {


        [Test()]
        public void SarExampleTestCase() {

            FileStream fs = new FileStream("../Samples/sar21_example.xml", FileMode.Open);

            var eop = (EarthObservationType)OgcHelpers.Sar21Serializer.Deserialize(XmlReader.Create(fs));

            fs.Close();

            Assert.AreEqual("2002-11-26T22:17:55.778Z", eop.phenomenonTime.GmlTimePeriod.beginPosition.Value);
            Assert.AreEqual("2002-11-27T03:54:38.229Z", eop.phenomenonTime.GmlTimePeriod.endPosition.Value);
            Assert.AreEqual("archivingdate_40e1de65-8512-4c9a-8701-bf37dd9d88f9", eop.resultTime.TimeInstant.id);
            Assert.AreEqual("2012-12-06T10:20:41.960Z", eop.resultTime.TimeInstant.timePosition.Value);
            Assert.AreEqual("eoe_40e1de65-8512-4c9a-8701-bf37dd9d88f9", eop.procedure.Eop21EarthObservationEquipment.id);
            Assert.AreEqual("ENVISAT", eop.procedure.Eop21EarthObservationEquipment.platform.Platform.shortName);
            Assert.AreEqual("ASAR", eop.procedure.Eop21EarthObservationEquipment.instrument.Instrument.shortName);
            Assert.AreEqual("RADAR", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.sensorType);
            Assert.AreEqual("any:sensorMode", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.operationalMode.codeSpace);
            Assert.AreEqual("NA", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.operationalMode.Text);
            Assert.AreEqual("WS", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.swathIdentifier.Text);
            Assert.AreEqual(OrbitDirectionValueType.ASCENDING, eop.procedure.Eop21EarthObservationEquipment.acquisitionParameters.Acquisition.orbitDirection);
            Assert.AreEqual("S", eop.procedure.Eop21EarthObservationEquipment.acquisitionParameters.SarAcquisition.polarisationMode);

            Assert.AreEqual("EN-021126221755-53642-SV.ASA_WS__0P", eop.EopMetaDataProperty.EarthObservationMetaData.identifier);

            Assert.AreEqual("$urlRootEN-021126221755-53642-SV.ASA_WS__0P.zip", eop.result.Eop21EarthObservationResult.product[0].ProductInformation.fileName.ServiceReference.href);

            XmlReader xr = eop.CreateReader();

            string xml1 = XElement.Load(xr).ToString();

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            xr = eop.CreateReader();

            fs = new FileStream("../Samples/sar21_example.xml", FileMode.Open);

            //Assert.True(Util.IsXmlEqual(XmlReader.Create(fs),xr, xw, true, true, true, true, true, true, true, true), "Xml differences {0}", sw);

            fs.Close();

        }

        [TestCase]
        public void DeserializeSar(){

            FileInfo s1 = new FileInfo("../Samples/S1-20120407T205500910-20120407T211433040_A_T-XG0B.atom");

            SarEarthObservationType sarEo = (SarEarthObservationType)OgcHelpers.DeserializeEarthObservation(XmlReader.Create(s1.OpenRead()));

            Assert.AreEqual("S1A", sarEo.procedure.Eop21EarthObservationEquipment.platform.Platform.shortName);

        }


    }
}

