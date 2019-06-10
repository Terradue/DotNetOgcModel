using System;
using System.IO;
using System.Reflection;
using System.Xml;
using Microsoft.XmlDiffPatch;
using NUnit.Framework;

namespace Terradue.ServiceModel.Ogc.Test
{

    [SetUpFixture()]
    public static class Util
    {
        public static string TestBaseDir;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            var baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            TestBaseDir = Path.Combine(baseDir, "../../..");
        }

    }
}

