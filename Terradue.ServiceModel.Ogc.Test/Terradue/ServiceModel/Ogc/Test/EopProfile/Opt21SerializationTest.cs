using NUnit.Framework;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Terradue.ServiceModel.Ogc.Eop21;
using System.Xml.Linq;
using Microsoft.XmlDiffPatch;
using Terradue.ServiceModel.Ogc.Swe;
using Terradue.ServiceModel.Ogc.Opt21;

namespace Terradue.ServiceModel.Ogc.Test {

    [TestFixture()]
    public class Opt21SerializationTest {


        [Test()]
        public void OptExampleTestCase() {

            FileStream fs = new FileStream("../Samples/opt21_example.xml", FileMode.Open);

            var eop = (EarthObservationType)OgcHelpers.Opt21Serializer.Deserialize(XmlReader.Create(fs));

            fs.Close();

            Assert.AreEqual("2001-08-22T11:02:47.000", eop.phenomenonTime.GmlTimePeriod.beginPosition.Value);
            Assert.AreEqual("2001-08-22T11:02:47.999", eop.phenomenonTime.GmlTimePeriod.endPosition.Value);
            Assert.AreEqual("archivingdate_1", eop.resultTime.TimeInstant.id);
            Assert.AreEqual("2001-08-22T11:02:47.999", eop.resultTime.TimeInstant.timePosition.Value);
            Assert.AreEqual("eop_2", eop.procedure.Eop21EarthObservationEquipment.id);
            Assert.AreEqual("PHR", eop.procedure.Eop21EarthObservationEquipment.platform.Platform.shortName);
            Assert.AreEqual("1A", eop.procedure.Eop21EarthObservationEquipment.platform.Platform.serialIdentifier);
            Assert.AreEqual("PHR", eop.procedure.Eop21EarthObservationEquipment.instrument.Instrument.shortName);
            Assert.AreEqual("OPTICAL", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.sensorType);
            Assert.AreEqual("urn:eop:PHR:sensorMode", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.operationalMode.codeSpace);
            Assert.AreEqual("PX", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.operationalMode.Text);
            Assert.AreEqual("m", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.resolution.uom);
            Assert.AreEqual(0.7, eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.resolution.Value);
            Assert.AreEqual(OrbitDirectionValueType.ASCENDING, eop.procedure.Eop21EarthObservationEquipment.acquisitionParameters.Acquisition.orbitDirection);
            Assert.AreEqual("2.1025 43.516667 2.861667 43.381667 2.65 42.862778 1.896944 42.996389 2.1025 43.516667", ((Terradue.ServiceModel.Ogc.Gml321.DirectPositionListType)((Terradue.ServiceModel.Ogc.Gml321.LinearRingType)((Terradue.ServiceModel.Ogc.Gml321.PolygonType)eop.featureOfInterest.Eop21Footprint.multiExtentOf.MultiSurface.surfaceMembers.Items[0]).exterior.Item).Items[0]).Text);
            Assert.AreEqual("2.374167 43.190833", ((Terradue.ServiceModel.Ogc.Gml321.DirectPositionType)eop.featureOfInterest.Eop21Footprint.centerOf.Point.Item).Text);

            Assert.AreEqual("QUICKLOOK", eop.result.Eop21EarthObservationResult.browse[0].BrowseInformation.type);
            Assert.AreEqual("http://www.mybrowse.com/et", eop.result.Eop21EarthObservationResult.browse[0].BrowseInformation.fileName.ServiceReference.href);

            Assert.AreEqual("DS_PHR1A_20010822110247_TLS_PX_E123N45_0101_01234", eop.EopMetaDataProperty.EarthObservationMetaData.identifier);

            Assert.AreEqual("1514:56:4564:5646:6548:75648", eop.EopMetaDataProperty.EarthObservationMetaData.productGroupId);

            Assert.AreEqual(-14.0, eop.procedure.Eop21EarthObservationEquipment.acquisitionParameters.Acquisition.acrossTrackIncidenceAngle.Value);
            Assert.AreEqual(30, eop.result.Opt21EarthObservationResult.cloudCoverPercentage.Value);

            XmlReader xr = eop.CreaterReader();

            string xml1 = XElement.Load(xr).ToString();

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            xr = eop.CreaterReader();

            fs = new FileStream("../Samples/opt21_example.xml", FileMode.Open);

            //Assert.True(Util.IsXmlEqual(XmlReader.Create(fs),xr, xw, true, true, true, true, true, true, true, true), "Xml differences {0}", sw);

            fs.Close();

        }

        [Test()]
        public void OptWithTypeTestCase() {

            FileStream fs = new FileStream("../Samples/S2withType.xml", FileMode.Open);

            var eop = (EarthObservationType)OgcHelpers.Opt21Serializer.Deserialize(XmlReader.Create(fs));

            Assert.AreEqual(6.29, eop.result.Opt21EarthObservationResult.cloudCoverPercentage.Value);

            fs.Close();
        }


    }
}

