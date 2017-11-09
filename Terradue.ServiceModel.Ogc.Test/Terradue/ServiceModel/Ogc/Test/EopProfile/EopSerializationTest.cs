using NUnit.Framework;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Microsoft.XmlDiffPatch;
using Terradue.ServiceModel.Ogc.Swe;
using System.Linq;

namespace Terradue.ServiceModel.Ogc.Test {
    
    [TestFixture()]
    public class EopSerializationTest {


        [Test()]
        public void EopExampleTestCase() {

            FileStream fs = new FileStream("../Samples/eop20_example.xml", FileMode.Open);

            var eop = (Eop20.EarthObservationType)OgcHelpers.Eop20Serializer.Deserialize(XmlReader.Create(fs));

            fs.Close();

            Assert.AreEqual("2001-08-22T11:02:47.000", eop.phenomenonTime.GmlTimePeriod.beginPosition.Value);
            Assert.AreEqual("2001-08-22T11:02:47.999", eop.phenomenonTime.GmlTimePeriod.endPosition.Value);
            Assert.AreEqual("archivingdate_1", eop.resultTime.TimeInstant.id);
            Assert.AreEqual("2001-08-22T11:02:47.999", eop.resultTime.TimeInstant.timePosition.Value);
            Assert.AreEqual("eoe_1", eop.procedure.Eop20EarthObservationEquipment.id);
            Assert.AreEqual("PHR", eop.procedure.Eop20EarthObservationEquipment.platform[0].Platform.shortName);
            Assert.AreEqual("1A", eop.procedure.Eop20EarthObservationEquipment.platform[0].Platform.serialIdentifier);
            Assert.AreEqual("PHR", eop.procedure.Eop20EarthObservationEquipment.instrument[0].Instrument.shortName);
            Assert.AreEqual("OPTICAL", eop.procedure.Eop20EarthObservationEquipment.sensor.Sensor.sensorType);
            Assert.AreEqual("urn:eop:PHR:sensorMode", eop.procedure.Eop20EarthObservationEquipment.sensor.Sensor.operationalMode.codeSpace);
            Assert.AreEqual("PX", eop.procedure.Eop20EarthObservationEquipment.sensor.Sensor.operationalMode.Text);
            Assert.AreEqual("m", eop.procedure.Eop20EarthObservationEquipment.sensor.Sensor.resolution.uom);
            Assert.AreEqual(0.7, eop.procedure.Eop20EarthObservationEquipment.sensor.Sensor.resolution.Value);
            Assert.AreEqual(Eop20.OrbitDirectionValueType.ASCENDING, eop.procedure.Eop20EarthObservationEquipment.acquisitionParameters.Acquisition.orbitDirection);
            Assert.AreEqual("2.1025 43.516667 2.861667 43.381667 2.65 42.862778 1.896944 42.996389 2.1025 43.516667", ((Terradue.ServiceModel.Ogc.Gml321.DirectPositionListType)((Terradue.ServiceModel.Ogc.Gml321.LinearRingType)((Terradue.ServiceModel.Ogc.Gml321.PolygonType)eop.featureOfInterest.Eop20Footprint.multiExtentOf.MultiSurface.surfaceMembers.Items[0]).exterior.Item).Items[0]).Text);
            Assert.AreEqual("2.374167 43.190833", ((Terradue.ServiceModel.Ogc.Gml321.DirectPositionType)eop.featureOfInterest.Eop20Footprint.centerOf.Point.Item).Text);

            Assert.AreEqual("QUICKLOOK", eop.result.Eop20EarthObservationResult.browse[0].BrowseInformation.type);
            Assert.AreEqual("http://eop.cnes.fr/catalog/DS_PHR1A_20010822110247_TLS_PX_E123N45_0101_01234.gml", eop.result.Eop20EarthObservationResult.browse[0].BrowseInformation.fileName.ServiceReference.href);

            Assert.AreEqual("DS_PHR1A_20010822110247_TLS_PX_E123N45_0101_01234", eop.EopMetaDataProperty.EarthObservationMetaData.identifier);

            Assert.AreEqual("xyzdef", (((Swe10.PhenomenonType)eop.result.Eop20EarthObservationResult.parameter.ParameterInformation.phenomenon.Item).Items[0]).Value);

            Assert.AreEqual(-14.0, eop.procedure.Eop20EarthObservationEquipment.acquisitionParameters.Acquisition.acrossTrackIncidenceAngle.Value);

            XmlReader xr = eop.CreateReader();

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            fs = new FileStream("../Samples/eop20_example.xml", FileMode.Open);

            //Assert.True(Util.IsXmlEqual(XmlReader.Create(fs),xr, xw, true, true, true, true, true, true, true, true), "Xml differences {0}", sw);

            fs.Close();

        }

		[Test()]
		public void EopWithTypeTestCase()
		{

			FileStream fs = new FileStream("../Samples/EopwithType.xml", FileMode.Open);

			var eop = (Eop21.EarthObservationType)OgcHelpers.Eop21Serializer.Deserialize(XmlReader.Create(fs));

			Assert.AreEqual("ID-2242", eop.result.Eop21EarthObservationResult.id);

			fs.Close();
		}

    }
}

