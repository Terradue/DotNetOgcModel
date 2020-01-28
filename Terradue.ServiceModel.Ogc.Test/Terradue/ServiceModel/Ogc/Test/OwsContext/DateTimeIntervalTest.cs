using System;
using NUnit.Framework;
using Terradue.ServiceModel.Ogc.Owc.AtomEncoding;

namespace Terradue.ServiceModel.Ogc.Test.OwsContext {

    [TestFixture()]
    public class DateTimeIntervalTest {

        [Test()]
        public void Parse() {

            string dateToParse = "2010-05-30T05:54:34/2010-05-31T20:20:20.000Z";

            var interval = DateTimeInterval.Parse(dateToParse);

            Assert.AreEqual(DateTime.Parse("2010-05-30T05:54:34"), interval.StartDate);
            Assert.AreEqual(DateTime.Parse("2010-05-31T20:20:20.000Z"), interval.EndDate);
        }

        [Test()]
        public void ToString() {

            var interval = new DateTimeInterval();

            interval.StartDate = DateTime.Parse("2010-05-30T05:54:34+02");
            interval.EndDate = DateTime.Parse("2010-05-31T20:20:20.000Z");

            Assert.AreEqual("2010-05-30T03:54:34.0000000Z/2010-05-31T20:20:20.0000000Z", interval.ToString());
        }
    }
}

