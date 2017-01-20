using System;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Collections.Specialized;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Om20;
using Terradue.ServiceModel.Ogc.Gml321;
using System.IO;
using System.Text;

namespace Terradue.ServiceModel.Ogc {
    
    public static class OgcHelpers {


        public const string EOP20 = "http://www.opengis.net/eop/2.0";
        public const string OPT20 = "http://www.opengis.net/opt/2.0";
        public const string SAR20 = "http://www.opengis.net/sar/2.0";
        public const string ATM20 = "http://www.opengis.net/atm/2.0";
        public const string ALT20 = "http://www.opengis.net/alt/2.0";
        public const string LMB20 = "http://www.opengis.net/lmb/2.0";
        public const string SSP20 = "http://www.opengis.net/ssp/2.0";

        public const string EOP21 = "http://www.opengis.net/eop/2.1";
        public const string OPT21 = "http://www.opengis.net/opt/2.1";
        public const string SAR21 = "http://www.opengis.net/sar/2.1";
        public const string ATM21 = "http://www.opengis.net/atm/2.1";
        public const string ALT21 = "http://www.opengis.net/alt/2.1";
        public const string LMB21 = "http://www.opengis.net/lmb/2.1";
        public const string SSP21 = "http://www.opengis.net/ssp/2.1";

        public const string OM = "http://www.opengis.net/om";
        public const string DC = "http://purl.org/dc/elements/1.1/";
        public const string GML = "http://www.opengis.net/gml";
        public const string GML321 = "http://www.opengis.net/gml/3.2";

        public static XNamespace Eop {
            get {
                return EOP21;
            }
        }

        public static XNamespace Opt {
            get {
                return OPT21;
            }
        }

        public static XNamespace Sar {
            get {
                return SAR21;
            }
        }

        public static XNamespace Atm {
            get {
                return ATM21;
            }
        }

        public static XNamespace Alt {
            get {
                return ALT21;
            }
        }

        public static XNamespace Lmb {
            get {
                return LMB21;
            }
        }

        public static XNamespace Ssp {
            get {
                return SSP21;
            }
        }

        static XmlSerializer eopSerializer;
        static XmlSerializer eopSerializer20;
        static XmlSerializer sarSerializer;
        static XmlSerializer sarSerializer20;
        static XmlSerializer optSerializer;
        static XmlSerializer optSerializer20;
        static XmlSerializer altSerializer;
        static XmlSerializer altSerializer20;
        static XmlSerializer atmSerializer;
        static XmlSerializer atmSerializer20;
        static XmlSerializer sspSerializer;
        static XmlSerializer sspSerializer20;
        static XmlSerializer lmbSerializer;
        static XmlSerializer lmbSerializer20;


        public static XmlSerializer Eop21Serializer {
            get {

                if (eopSerializer == null) eopSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Eop21.EarthObservationType));
                return eopSerializer;

            }
        }

        public static XmlSerializer Sar21Serializer {
            get {

                if (sarSerializer == null) sarSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Sar21.SarEarthObservationType));
                return sarSerializer;

            }
        }

        public static XmlSerializer Opt21Serializer {
            get {

                if (optSerializer == null) optSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Opt21.OptEarthObservationType));
                return optSerializer;

            }
        }

        public static XmlSerializer Alt21Serializer {
            get {

                if (altSerializer == null) altSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Alt21.AltEarthObservationType));
                return altSerializer;

            }
        }

        public static XmlSerializer Atm21Serializer {
            get {

                if (atmSerializer == null) atmSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Atm21.AtmEarthObservationType));
                return atmSerializer;

            }
        }

        public static XmlSerializer Ssp21Serializer {
            get {

                if (sspSerializer == null) sspSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Ssp21.SspEarthObservationType));
                return sspSerializer;

            }
        }

        public static XmlSerializer Lmb21Serializer {
            get {

                if (lmbSerializer == null) lmbSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Lmb21.LmbEarthObservationType));
                return lmbSerializer;

            }
        }

        public static XmlSerializer Eop20Serializer {
            get {

                if (eopSerializer20 == null) eopSerializer20 = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Eop20.EarthObservationType));
                return eopSerializer20;

            }
        }

        public static XmlSerializer Sar20Serializer {
            get {

                if (sarSerializer20 == null) sarSerializer20 = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Sar20.SarEarthObservationType));
                return sarSerializer20;

            }
        }

        public static XmlSerializer Opt20Serializer {
            get {

                if (optSerializer20 == null) optSerializer20 = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Opt20.OptEarthObservationType));
                return optSerializer20;

            }
        }

        public static XmlSerializer Alt20Serializer {
            get {

                if (altSerializer20 == null) altSerializer20 = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Alt20.AltEarthObservationType));
                return altSerializer20;

            }
        }

        public static XmlSerializer Atm20Serializer {
            get {

                if (atmSerializer20 == null) atmSerializer20 = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Atm20.AtmEarthObservationType));
                return atmSerializer20;

            }
        }

        public static XmlSerializer Ssp20Serializer {
            get {

                if (sspSerializer == null) sspSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Ssp20.SspEarthObservationType));
                return sspSerializer;

            }
        }

        public static XmlSerializer Lmb20Serializer {
            get {

                if (lmbSerializer == null) lmbSerializer = new XmlSerializer(typeof(Terradue.ServiceModel.Ogc.Lmb20.LmbEarthObservationType));
                return lmbSerializer;

            }
        }

        public static XmlElement SerializeToXmlElement(object obj) {
            XmlDocument xdoc = new XmlDocument();

            Type type = obj.GetType();

            using (XmlWriter writer = xdoc.CreateNavigator().AppendChild()) {

                XmlSerializer ser = GetXmlSerializerFromType(type);

                ser.Serialize(writer, obj);
            }

            return xdoc.DocumentElement;
        }

        public static XmlSerializer GetXmlSerializerFromType(Type type) {
            if (type == typeof(Terradue.ServiceModel.Ogc.Eop21.EarthObservationType)) return OgcHelpers.Eop21Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Eop20.EarthObservationType)) return OgcHelpers.Eop20Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Sar21.SarEarthObservationType)) return OgcHelpers.Sar21Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Sar20.SarEarthObservationType)) return OgcHelpers.Sar20Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Opt21.OptEarthObservationType)) return OgcHelpers.Opt21Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Opt20.OptEarthObservationType)) return OgcHelpers.Opt20Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Alt21.AltEarthObservationType)) return OgcHelpers.Alt21Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Alt20.AltEarthObservationType)) return OgcHelpers.Alt20Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Atm21.AtmEarthObservationType)) return OgcHelpers.Atm21Serializer;

            if (type == typeof(Terradue.ServiceModel.Ogc.Atm20.AtmEarthObservationType)) return OgcHelpers.Atm20Serializer;

            return new XmlSerializer(type);
        }

        public static XmlSerializerNamespaces GetXmlSerializerNamespacesFromType(Type type) {


            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();


            if (type == typeof(Terradue.ServiceModel.Ogc.Eop21.EarthObservationType)) {
                ns.Add("eop", EOP21);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Eop20.EarthObservationType)) {
                ns.Add("eop", EOP20);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Sar21.SarEarthObservationType)) {
                ns.Add("eop", EOP21);
                ns.Add("sar", SAR21);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Sar20.SarEarthObservationType)) {
                ns.Add("eop", EOP20);
                ns.Add("sar", SAR20);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Opt21.OptEarthObservationType)) {
                ns.Add("eop", EOP21);
                ns.Add("opt", OPT21);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Opt20.OptEarthObservationType)) {
                ns.Add("eop", EOP20);
                ns.Add("opt", OPT20);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Alt21.AltEarthObservationType)) {
                ns.Add("eop", EOP21);
                ns.Add("alt", ALT21);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Alt20.AltEarthObservationType)) {
                ns.Add("eop", EOP20);
                ns.Add("alt", ALT20);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Atm21.AtmEarthObservationType)) {
                ns.Add("eop", EOP21);
                ns.Add("atm", ATM21);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            if (type == typeof(Terradue.ServiceModel.Ogc.Atm20.AtmEarthObservationType)) {
                ns.Add("eop", EOP20);
                ns.Add("atm", ATM20);
                ns.Add("om", OM);
                ns.Add("gml", GML321);
            }

            return ns;
        }

        public static object DeserializeEarthObservation(XmlReader reader) {

            XmlSerializer ser = null;
            string nspace = reader.NamespaceURI;

            while (string.IsNullOrEmpty(nspace) && reader.Read()) {
                nspace = reader.NamespaceURI;
            }

            switch (nspace) {

                case SSP20:
                    ser = Ssp20Serializer;
                    break;
                case LMB20:
                    ser = Lmb20Serializer;
                    break;
                case EOP20:
                    ser = Eop20Serializer;
                    break;
                case SAR20:
                    ser = Sar20Serializer;
                    break;
                case OPT20:
                    ser = Opt20Serializer;
                    break;
                case ALT20:
                    ser = Alt20Serializer;
                    break;
                case ATM20:
                    ser = Atm20Serializer;
                    break;
                case EOP21:
                    ser = Eop21Serializer;
                    break;
                case LMB21:
                    ser = Lmb21Serializer;
                    break;
                case SSP21:
                    ser = Ssp21Serializer;
                    break;
                case SAR21:
                    ser = Sar21Serializer;
                    break;
                case OPT21:
                    ser = Opt21Serializer;
                    break;
                case ALT21:
                    ser = Alt21Serializer;
                    break;
                case ATM21:
                    ser = Atm21Serializer;
                    break;
                default:
                    throw new NotImplementedException("The namespace URI " + nspace + " is not implemented");
            }

            object eo = null;

            try {
                eo = ser.Deserialize(reader);
            } catch (Exception e){
                throw e;
            }

            return eo;
        }


        public static XmlReader CreaterReader(this Terradue.ServiceModel.Ogc.Eop20.EarthObservationType eop){
            XmlSerializer ser = GetXmlSerializerFromType(eop.GetType());
            XmlSerializerNamespaces ns = GetXmlSerializerNamespacesFromType(eop.GetType());

            MemoryStream ms = new MemoryStream();

            XmlWriter xw = XmlWriter.Create(ms);

            ser.Serialize(xw, eop, ns);

            ms.Seek(0, SeekOrigin.Begin);

            return XmlReader.Create(ms);
        }

        public static XmlReader CreaterReader(this Terradue.ServiceModel.Ogc.Eop21.EarthObservationType eop){
            XmlSerializer ser = GetXmlSerializerFromType(eop.GetType());
            XmlSerializerNamespaces ns = GetXmlSerializerNamespacesFromType(eop.GetType());

            MemoryStream ms = new MemoryStream();

            XmlWriter xw = XmlWriter.Create(ms);

            ser.Serialize(xw, eop, ns);

            ms.Seek(0, SeekOrigin.Begin);

            return XmlReader.Create(ms);
        }

    }
}

