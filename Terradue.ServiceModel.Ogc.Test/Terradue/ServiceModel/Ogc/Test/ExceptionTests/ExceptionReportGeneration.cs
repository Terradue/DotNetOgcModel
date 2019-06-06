using NUnit.Framework;
using System;
using System.IO;
using System.Threading.Tasks;
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

            XmlSerializer ser = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Ows11.ExceptionReport));

            using (var fs = new FileStream(Util.TestBaseDir + "/out/simpleExceptionReport.xml", FileMode.Create))
                ser.Serialize(fs, exception.ExceptionReport);

        }

        [Test()]
        public void AggregateExceptionReport()
        {

            var task1 = Task.Run(() => FirstLevelFunction());
            var task2 = Task.Run(() => FirstLevelFunction());

            try {
            Task.WaitAll(new Task[] { task1, task2 });
            }
            catch(Exception e){
                XmlSerializer ser = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Ows11.ExceptionReport));

                var exception = new NoApplicableCodeException("An error occured during the execution", e);

                using (var fs = new FileStream(Util.TestBaseDir + "/out/aggregateExceptionsReport.xml", FileMode.Create))
                    ser.Serialize(fs, exception.ExceptionReport);
            }


        }

        private void FirstLevelFunction()
        {
            SecondLevelFunction();
        }

        private void SecondLevelFunction()
        {
            throw new BadImageFormatException("This is a second level exception");
        }
    }
}