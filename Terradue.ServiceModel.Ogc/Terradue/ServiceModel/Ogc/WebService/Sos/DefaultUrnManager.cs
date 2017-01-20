using System;
using System.Globalization;
namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Specifies urn manager operations
    /// </summary>
    public class DefaultUrnManager : BaseUrnManager
    {
        /// <summary>
        /// Internal class which help to generate escaped URI strings
        /// </summary>
        private class UriHelper : Uri
        {
            public UriHelper(string urn)
                : base(urn)
            {

            }

            public override string ToString()
            {
                return System.Uri.EscapeUriString(base.ToString());
            }

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultUrnManager"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        public DefaultUrnManager(BaseSosOperation operation)
            : base(operation)
        {
        }

        /// <summary>
        /// Gets urn string for specified name and value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override Uri GetUrnName(string name, string value)
        {
            return new UriHelper(string.Format(CultureInfo.InvariantCulture, "urn:renci:sdb:{0}:1.0.0:{1}", System.Uri.EscapeUriString(name), System.Uri.EscapeUriString(value)));
        }
    }
}
