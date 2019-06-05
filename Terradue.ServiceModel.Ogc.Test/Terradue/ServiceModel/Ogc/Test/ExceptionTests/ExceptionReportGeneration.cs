using NUnit.Framework;
using System;
using System.IO;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Exceptions;

namespace Terradue.ServiceModel.Ogc.Test
{

    [TestFixture()]
    public class ExceptonReportGenerationTest
    {

        [Test()]
        public void SimpleReport()
        {

            Terradue.ServiceModel.Ogc.Exceptions.NoApplicableCodeException exception =
                new Exceptions.NoApplicableCodeException("This is a Test Exception", new InsufficientMemoryException("The Memory Reached Maximum"));

            XmlSerializer ser = new XmlSerializer(typeof(OgcException));

            using (var fs = new FileStream("../out/simpleExceptionReport.xml", FileMode.Create))
                ser.Serialize(fs, exception.ExceptionReport);

        }
    }
}