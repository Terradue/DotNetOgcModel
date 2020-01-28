using System;
using Terradue.ServiceModel.Syndication;

namespace Terradue.ServiceModel.Ogc.Owc.Model {
    /// <summary>OWS Operation</summary>
    /// <description>
    /// Definition of the operation either to get the information or to get the capabilities. 
    /// Note that service specific extension requirements may mandate more than one owc:operation.
    /// </description>
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    /// \ingroup OWSContext
    public class Operation {

        /// <summary>
        /// Code identifying the type of Operation
        /// Typically the OGC Service request type, e.g. "GetCapabilities" or "GetMap".
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; set; }

        /// <summary>
        /// Name of operation method request
        /// </summary>
        /// <value>The method.</value>
        public string Method { get; set; }

        /// <summary>
        /// MIMEType of the return result
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }

        /// <summary>
        /// Service Request URL
        /// </summary>
        /// <value>The request URI.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public Uri RequestURL { get; set; }

        /// <summary>
        /// Optional request body content
        /// </summary>
        /// \return is invoked with \ref OwcContent that is the body of the requets to send along with service invokation</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public Content Request { get; set; }

        /// <summary>
        /// result of the operation (optional)
        /// </summary>
        /// <value>The result.</value>
        public Content Result { get; set; }

        /// <summary>
        /// Application specific content 
        /// </summary>
        /// <value>The extension.</value>
        public SyndicationElementExtensionCollection Extensions { get; set; }

        public Operation() {
        }
    }
}

