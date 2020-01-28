using System;
using Terradue.ServiceModel.Syndication;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using Terradue.ServiceModel.Ogc.GeoRss.GeoRss;
using System.Xml;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding
{
    public class OwsContextAtomEntry : SyndicationItem
    {


        public OwsContextAtomEntry()
        {
        }

        public OwsContextAtomEntry(SyndicationItem it) : base(it)
        {
        }

        public List<OwcOffering> Offerings
        {
            get
            {
                return ElementExtensions.ReadElementExtensions<OwcOffering>("offering", OwcNamespaces.Owc, OwcContextHelper.OwcOfferingSerializer).ToList();
            }
            set
            {
                foreach (var offering in value)
                {
                    ElementExtensions.Add(offering.CreateReader());
                }
            }
        }

        public string Publisher
        {
            get
            {
                var publishers = ElementExtensions.ReadElementExtensions<string>("publisher", OwcNamespaces.Dc);
                if (publishers.Count() > 0)
                {
                    return publishers.First();
                }
                else {
                    return null;
                }
            }
            set
            {
                var publishers = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("publisher", OwcNamespaces.Dc);
                foreach (var publisher in publishers)
                {
                    ElementExtensions.Remove(publisher);
                }
                ElementExtensions.Add("publisher", OwcNamespaces.Dc, value);
            }
        }

        public DateTimeInterval Date
        {
            get
            {
                var dates = ElementExtensions.ReadElementExtensions<string>("date", OwcNamespaces.Dc);
                if (dates.Count() > 0)
                {
                    return DateTimeInterval.Parse(dates.First());
                }
                else {
                    return null;
                }
            }
            set
            {
                var dates = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("date", OwcNamespaces.Dc);
                foreach (var date in dates)
                {
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

        public double MinScaleDenominator
        {
            get
            {
                var minScaleDenominators = ElementExtensions.ReadElementExtensions<double>("minScaleDenominator", OwcNamespaces.Dc);
                if (minScaleDenominators.Count() > 0)
                {
                    return minScaleDenominators.First();
                }
                else {
                    return 0;
                }
            }
            set
            {
                var minScaleDenominators = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("minScaleDenominator", OwcNamespaces.Dc);
                foreach (var minScaleDenominator in minScaleDenominators)
                {
                    ElementExtensions.Remove(minScaleDenominator);
                }
                ElementExtensions.Add("minScaleDenominator", OwcNamespaces.Dc, value);
            }
        }

        public double MaxScaleDenominator
        {
            get
            {
                var maxScaleDenominators = ElementExtensions.ReadElementExtensions<double>("maxScaleDenominator", OwcNamespaces.Dc);
                if (maxScaleDenominators.Count() > 0)
                {
                    return maxScaleDenominators.First();
                }
                else {
                    return 0;
                }
            }
            set
            {
                var maxScaleDenominators = ElementExtensions.ReadElementExtensions<SyndicationElementExtension>("maxScaleDenominator", OwcNamespaces.Dc);
                foreach (var maxScaleDenominator in maxScaleDenominators)
                {
                    ElementExtensions.Remove(maxScaleDenominator);
                }
                ElementExtensions.Add("maxScaleDenominator", OwcNamespaces.Dc, value);
            }
        }
    }
}

