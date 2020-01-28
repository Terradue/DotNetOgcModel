using System;
using System.Text.RegularExpressions;

namespace Terradue.ServiceModel.Ogc.Owc.AtomEncoding {
    public class DateTimeInterval {

        DateTime startDate;
        DateTime endDate;

        public DateTimeInterval() {

            startDate = DateTime.Now;
            endDate = DateTime.MaxValue;
           
        }

        public DateTime StartDate {
            get {
                return startDate;
            }
            set {
                startDate = value;
            }
        }

        public DateTime EndDate {
            get {
                return endDate;
            }
            set {
                endDate = value;
            }
        }

        public static DateTimeInterval Parse(string str) {

            string pattern = @"(\s*[0-9]{4}-[0-9]{2}-[0-9]{2}T[0-9]{2}:[0-9]{2}:[0-9]{2}(?:\.[0-9]+)?(?:Z|[\+\-][0-9]{2}:[0-9]{2})?)(?:/([0-9]{4}-[0-9]{2}-[0-9]{2}T[0-9]{2}:[0-9]{2}:[0-9]{2}(?:\.[0-9]+)?(?:Z|[\+\-][0-9]{2}:[0-9]{2})|))\s*";
            Match match = Regex.Match(str, pattern);

            if (!match.Success)
                return null;

            DateTimeInterval interval = new DateTimeInterval();

            interval.startDate = DateTime.Parse(match.Groups[1].Value);
            interval.endDate = DateTime.MaxValue;

            if (match.Groups.Count > 2) {
                interval.endDate = DateTime.Parse(match.Groups[2].Value);
            }


            return interval;
        }

        public new string ToString(){

            string date = StartDate.ToUniversalTime().ToString("O");
            if (endDate < DateTime.MaxValue) {
                date += "/" + EndDate.ToUniversalTime().ToString("O");
            }

            return date;

        }
    }
}

