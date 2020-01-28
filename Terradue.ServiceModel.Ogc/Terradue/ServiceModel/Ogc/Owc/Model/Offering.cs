using System;
using System.Collections.ObjectModel;
using Terradue.ServiceModel.Syndication;

namespace Terradue.ServiceModel.Ogc.Owc.Model {
    /// <summary>OWS Offering</summary>
    /// <description>
    /// This datatype class defines the properties of a specific service binding or inline content 
    /// for an offering. The service binding is primarily characterized by a series of parameters. 
    /// The parameters valid for a specific type of service binding, e.g. WFS are defined outside 
    /// of the OWS Context core specification. Each specific service binding is defined by a URI 
    /// which references a requirement class.
    /// </description>
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    /// \ingroup OWSContext
    public class Offering {

        /// <summary>
        /// Code identifying the type of service offering
        /// </summary>
        /// <value>The code.</value>
        public Uri Code { get; set; }

        /// <summary>
        /// Operations used to invoke the service
        /// </summary>
        /// \return offers \ref OwcOperation as a list of operations available to invoke the service</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public Collection<Operation> Operation { get; set; }

        /// <summary>
        /// inline content
        /// </summary>
        /// \return offers \ref OwcContent as a list of inline contents
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public Collection<Content> Content { get; set; }
        Collection<StyleSet> styleSet;

        /// <summary>
        /// Style sets to style the in-line content
        /// </summary>
        /// <value>The style set.</value>
        public Collection<StyleSet> StyleSet
        {
            get
            {
                return styleSet;
            }

            set
            {
                styleSet = value;
            }
        }

        /// <summary>
        /// Any specific content
        /// </summary>
        /// <value>The extension.</value>
        public SyndicationElementExtensionCollection Extensions { get; set; }

        public Offering() {
        }
    }
}

