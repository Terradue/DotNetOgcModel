using System;
using System.Xml;
using Microsoft.XmlDiffPatch;

namespace Terradue.ServiceModel.Ogc.Test {
    public static class Util {
        
        static public bool IsXmlEqual( XmlReader x1, XmlReader x2, XmlWriter xw,
                                      bool IgnoreChildOrder, bool IgnoreComments, bool IgnorePI, bool IgnoreWhitespace,
                                      bool IgnoreNamespaces, bool IgnorePrefixes, bool IgnoreXmlDecl, bool IgnoreDtd
                                     )
        {
            XmlDiffOptions options = XmlDiffOptions.None;
            if (IgnoreChildOrder) options |= XmlDiffOptions.IgnoreChildOrder;
            if (IgnoreComments) options |= XmlDiffOptions.IgnoreComments;
            if (IgnorePI) options |= XmlDiffOptions.IgnorePI;
            if (IgnoreWhitespace) options |= XmlDiffOptions.IgnoreWhitespace;
            if (IgnoreNamespaces) options |= XmlDiffOptions.IgnoreNamespaces;
            if (IgnorePrefixes) options |= XmlDiffOptions.IgnorePrefixes;
            if (IgnoreXmlDecl) options |= XmlDiffOptions.IgnoreXmlDecl;
            if (IgnoreDtd) options |= XmlDiffOptions.IgnoreDtd;

            XmlDiff xmlDiff = new XmlDiff(options);
            bool bequal = xmlDiff.Compare(x1, x2, xw);
            return bequal;
        }
    }
}

