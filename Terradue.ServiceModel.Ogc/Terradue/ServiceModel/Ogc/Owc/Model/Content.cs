using System;
using Terradue.ServiceModel.Syndication;

namespace Terradue.ServiceModel.Ogc.Owc.Model {

    /// <summary>
    /// OWC Content
    /// </summary>
    /// <description>
    /// This object is a generic container for any content in a \OWSContext Document.
    /// </description>
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    /// \ingroup OWSContext
    public class Content {

        /// <summary>
        /// Type of the inline content
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }

        /// <summary>
        /// Referenced Content
        /// </summary>
        /// <value>The URL.</value>
        public Uri Url { get; set; }

        /// <summary>
        /// Actual content in the content element 
        /// </summary>
        /// <value>The content.</value>
        public string Value { get; set; }

        /// <summary>
        /// Application specific content 
        /// </summary>
        /// <value>The extension.</value>
        public SyndicationElementExtension Extension { get; set; }

        public Content() {
        }
    }
}

