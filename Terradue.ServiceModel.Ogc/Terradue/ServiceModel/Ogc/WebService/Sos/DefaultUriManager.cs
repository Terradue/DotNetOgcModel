using System;
using System.Globalization;

namespace Terradue.ServiceModel.Ogc.WebService.Sos
{
    /// <summary>
    /// Specifies default implementation of URI manager
    /// </summary>
    public class DefaultUriManager : BaseUriManager
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
        /// Initializes a new instance of the <see cref="DefaultUriManager"/> class.
        /// </summary>
        /// <param name="operation">The operation.</param>
        public DefaultUriManager(BaseSosOperation operation)
            : base(operation)
        {
        }

        /// <summary>
        /// Gets property URI.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Escaped property uri string</returns>
        public override Uri GetPropertyUri(string value)
        {
            return new UriHelper(string.Format(CultureInfo.InvariantCulture, "{0}/?service={1}&request=GetResourceByID&ResourceID={2}", this.Operation.ServiceBaseUri, this.Operation.ServiceName, this.Operation.UrnManager.GetPropertyUrn(value)));
        }
    }
}
