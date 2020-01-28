using System;
using Terradue.ServiceModel.Syndication;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using Terradue.ServiceModel.Ogc.Owc.Model;
using Terradue.ServiceModel.Ogc.GeoRss.GeoRss;


/*!
\defgroup OWSContextAtomFeed OWS Context Document
@{
This components provides with the representation of entities in the system into \ref OWSContext compliant
entry in a \ref Syndication feed (typically \ref Atom)

\xrefitem cptype_document "Document" "Documents" represents \ref OWSContext

\xrefitem cpgroup_model "Model" "Models"

\ingroup Model

@}
*/

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding {
    public class OwsContextAtomFeed : SyndicationFeed {

        public OwsContextAtomFeed() : base() {
            AttributeExtensions.Add(new System.Xml.XmlQualifiedName("owc", XNamespace.Xmlns.NamespaceName), OwcNamespaces.Owc);
        }

        public OwsContextAtomFeed(SyndicationFeed feed, bool cloneItems) : base(feed, cloneItems) {
            AttributeExtensions.Add(new System.Xml.XmlQualifiedName("owc", XNamespace.Xmlns.NamespaceName), OwcNamespaces.Owc);
        }

        public OwcDisplay Display {
            get {
                var displays = ElementExtensions.ReadElementExtensions<OwcDisplay>("display", OwcNamespaces.Owc, new XmlSerializer(typeof(OwcDisplay)));
                if (displays.Count() > 0) {
                    return displays.First();
                } else {
                    return null;
                }
            }
            set {
                var displays = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("display", OwcNamespaces.Owc);
                foreach (var display in displays) {
                    ElementExtensions.Remove(display);
                }
                ElementExtensions.Add(value, new XmlSerializer(typeof(OwcDisplay)));
            }
        }

        public string Publisher {
            get {
                var publishers = ElementExtensions.ReadElementExtensions<string>("publisher", OwcNamespaces.Dc);
                if (publishers.Count() > 0) {
                    return publishers.First();
                } else {
                    return null;
                }
            }
            set {
                var publishers = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("publisher", OwcNamespaces.Dc);
                foreach (var publisher in publishers) {
                    ElementExtensions.Remove(publisher);
                }
                ElementExtensions.Add("publisher", OwcNamespaces.Dc, value);
            }
        }

        public DateTimeInterval Date {
            get {
                var dates = ElementExtensions.ReadElementExtensions<string>("date", OwcNamespaces.Dc);
                if (dates.Count() > 0) {
                    return DateTimeInterval.Parse(dates.First());
                } else {
                    return null;
                }
            }
            set {
                var dates = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("date", OwcNamespaces.Dc);
                foreach (var date in dates) {
                    ElementExtensions.Remove(date);
                }
                ElementExtensions.Add("date", OwcNamespaces.Dc, value.ToString());
            }
        }

        public GeoRssWhere Where
        {
            get
            {
                var whereExts = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("where", OwcNamespaces.GeoRss);
                if (whereExts.Count > 0)
                {
                    GeoRssWhere where = (GeoRssWhere)GeoRssHelper.Deserialize(whereExts.First().GetReader());
                    if (where != null)
                    {
                        return where;
                    }
                }
                return null;
            }
            set
            {
                var whereExts = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("where", OwcNamespaces.GeoRss);
                foreach (var date in whereExts)
                {
                    ElementExtensions.Remove(date);
                }
                ElementExtensions.Add(value.CreateReader());
            }
        }

        public new IEnumerable<OwsContextAtomEntry> Items {
            get {
                List<OwsContextAtomEntry> items = new List<OwsContextAtomEntry>();
                foreach (var it in base.Items) {
                    items.Add(new OwsContextAtomEntry(it));
                }
                return items;
            }
            set {
                base.Items = new List<OwsContextAtomEntry>(value);
            }
        }
    }
}

