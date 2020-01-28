using System;
using System.Collections.ObjectModel;
using Terradue.ServiceModel.Syndication;

namespace Terradue.ServiceModel.Ogc.Owc.Model {
    /// <summary>OWS StyleSet</summary>
    /// <description>
    /// This datatype class defines a portrayal style for a resource content or serviceContent element. 
    /// It can be specified at a resource level or at a service offering level (when it only applies to the offering).
    /// </description>
    public class StyleSet {

        /// <summary>
        /// Unique name of the styleSet within a given offering
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// A Human Readable Title for the OWS Context Document
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Description of the Style
        /// </summary>
        /// <value>The abstract.</value>
        public string Abstract { get; set; }

        /// <summary>
        /// Whether this Styleset is the one to be used as default (initial display) 
        /// </summary>
        /// <value><c>true</c> if default; otherwise, <c>false</c>.</value>
        public bool Default { get; set; }

        /// <summary>
        /// URL of a legend image for the style
        /// </summary>
        /// <value>The legend UR.</value>
        public Uri LegendURL { get; set; }

        /// <summary>
        /// The in-line or an external reference to the style definition
        /// </summary>
        /// <value>The content.</value>
        public Content Content { get; set; }

        /// <summary>
        /// Application specific content 
        /// </summary>
        /// <value>The extension.</value>
        public SyndicationElementExtensionCollection Extensions { get; set; }

        public StyleSet() {
        }
    }
}

