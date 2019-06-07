using NUnit.Framework;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Terradue.ServiceModel.Ogc.Eop21;
using System.Xml.Linq;
using Terradue.ServiceModel.Ogc.Swe;
using Terradue.ServiceModel.Ogc.Alt21;
using System.Linq;

namespace Terradue.ServiceModel.Ogc.Test {

    [TestFixture()]
    public class AltSerializationTest {


        [Test()]
        public void AltExampleTestCase() {

            FileInfo s1 = new FileInfo(Util.TestBaseDir + "/Samples/alt21ngeo.atom");

            AltEarthObservationType eop = (AltEarthObservationType)OgcHelpers.DeserializeEarthObservation(XmlReader.Create(s1.OpenRead()));


            Assert.AreEqual("2018-07-18T02:44:58.47Z", eop.phenomenonTime.GmlTimePeriod.beginPosition.Value);
            Assert.AreEqual("2018-07-18T02:45:50.18Z", eop.phenomenonTime.GmlTimePeriod.endPosition.Value);
            Assert.AreEqual("2018-07-18T04:47:43.54Z", eop.resultTime.TimeInstant.timePosition.Value);
            Assert.AreEqual("ALTIMETRIC", eop.procedure.Eop21EarthObservationEquipment.sensor.Sensor.sensorType);

            Assert.AreEqual("79.89 178.16 80.75 -172.11 81.48 -149.51 81.49 -149.51 81.44 -141.83 80.36 -119.94 78.26 -104.04 75.58 -93.33 72.58 -85.99 69.4 -80.73 66.12 -76.77 62.76 -73.67 59.36 -71.15 55.93 -69.05 52.46 -67.25 48.98 -65.68 45.49 -64.28 41.98 -63.01 38.46 -61.85 34.93 -60.77 31.4 -59.76 27.85 -58.81 24.31 -57.9 20.76 -57.03 17.2 -56.18 13.65 -55.36 10.09 -54.55 6.53 -53.76 2.97 -52.97 -0.59 -52.19 -4.15 -51.41 -7.71 -50.62 -11.27 -49.82 -14.82 -49.01 -18.38 -48.18 -21.92 -47.33 -25.47 -46.44 -29 -45.52 -32.53 -44.55 -36.06 -43.53 -39.57 -42.43 -43.08 -41.24 -46.57 -39.94 -50.05 -38.49 -53.51 -36.86 -56.95 -34.99 -60.37 -32.79 -63.74 -30.13 -67.07 -26.83 -70.31 -22.58 -73.43 -16.85 -76.35 -8.78 -78.89 3.09 -80.76 20.56 -81.48 43.06 -81.49 43.08 -81.44 50.72 -80.37 72.53 -78.28 88.41 -75.62 99.12 -72.64 106.47 -69.48 111.75 -66.21 115.72 -62.87 118.83 -59.49 121.35 -56.07 123.46 -52.62 125.26 -49.15 126.84 -45.67 128.25 -42.17 129.52 -38.66 130.68 -35.15 131.76 -31.62 132.77 -28.09 133.72 -24.55 134.64 -21 135.51 -17.46 136.36 -13.9 137.18 -10.35 137.99 -6.79 138.78 -3.23 139.57 0.33 140.35 3.89 141.13 7.45 141.92 11.01 142.72 14.57 143.53 18.12 144.36 21.68 145.21 25.23 146.09 28.77 147.01 32.31 147.98 35.84 149 39.37 150.1 42.89 151.29 46.39 152.58 49.89 154.03 53.36 155.65 56.82 157.52 60.25 159.72 63.64 162.36 66.98 165.66 70.24 169.9 73.38 175.61 76.31 -176.33 78.87 -164.46 80.75 -146.96 81.48 -124.36 81.49 -124.36 81.22 -108.84 80.01 -91.27",
                            ((Gml321.LineStringType)eop.featureOfInterest.Alt21Footprint.nominalTrack.MultiCurve.curveMember.First().Item).Items.Cast<Gml321.DirectPositionListType>().First().Text);

            XmlReader xr = eop.CreateReader();

            string xml1 = XElement.Load(xr).ToString();

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            xr = eop.CreateReader();

           

        }

    }
}

