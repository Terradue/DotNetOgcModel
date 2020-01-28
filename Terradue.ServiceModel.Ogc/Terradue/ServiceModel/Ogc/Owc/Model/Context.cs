using System;
using System.Collections.Generic;
using Terradue.ServiceModel.Ogc.GeoRss.GeoRss;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Owc.AtomEncoding;
using Terradue.ServiceModel.Syndication;


/*!
\defgroup OWSContext OWS Context
@{

A ‘context document’ specifies a fully configured service set which can be exchanged (with a consistent interpretation) among clients supporting the standard. 
The OGC Web Services Context Document (OWS Context) was created to allow a set of configured information resources (service set)
to be passed between applications primarily as a collection of services. OWS Context is developed to support in-line content as well. 
The goal is to support use cases such as the distribution of search results, the exchange of a set of resources such as 
OGC Web Feature Service (WFS), Web Map Service (WMS), Web Map Tile Service (WMTS), Web Coverage Service (WCS) and others in a 
‘common operating picture’. Additionally OWS Context can deliver a set of configured processing services (Web Processing Service (WPS))
parameters to allow the processing to be reproduced on different nodes. 

\xrefitem norm "Normative References" "Normative References" [OGC OWS Context Conceptual Model](https://portal.opengeospatial.org/files/?artifact_id=55182)

\xrefitem norm "Normative References" "Normative References" [OGC OWS Context Atom Encoding Standard](https://portal.opengeospatial.org/files/?artifact_id=55183)

\xrefitem cptype_sm "ServiceModel" "Service Models"

\ingroup Model

@}
*/

namespace Terradue.ServiceModel.Ogc.Owc.Model {
    /// <summary>OWS Context</summary>
    /// <description>
    /// This class is the overall container class for the OWS context document.
    /// </description>
    /// \ingroup OWSContext
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    public class Context {

        /// <summary>
        /// Specification Reference identifying that this is an owc Context document 
        /// </summary>
        /// <value>The spec reference.</value>
        public Uri SpecReference { get; set; }

        /// <summary>
        /// Language used in the owc Context document 
        /// </summary>
        /// <value>The language.</value>
        public string Language { get; set; }

        /// <summary>
        /// Unique Identifier assigned to the OWS Context Document
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// A Human Readable Title for the OWS Context Document
        /// </summary>
        /// <value>The title.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public string Title { get; set; }

        /// <summary>
        /// Description of the Context Document Purpose/Content 
        /// </summary>
        /// <value>The abstract.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public string Abstract { get; set; }

        /// <summary>
        /// Date when the Context Document was updated
        /// </summary>
        /// <value>The update date.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public DateTimeOffset UpdateDate { get; set; }

        /// <summary>
        /// Identifier for the author of the document
        /// </summary>
        /// <value>The author.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public List<string> Authors { get; set; }

        /// <summary>
        /// Identifier for the publisher of the document
        /// </summary>
        /// <value>The publisher.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public string Publisher { get; set; }

        /// <summary>
        /// The tool/application used to create the context document and its properties
        /// </summary>
        /// \return references \ref OwcCreator as the the tool or application used to create the context document and its properties.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public Creator Creator { get; set; }

        /// <summary>
        /// Rights which apply to the context document.
        /// </summary>
        /// <value>The rights.</value>
        public string Rights { get; set; }

        /// <summary>
        /// Geographic area of interest of the users of the context document 
        /// </summary>
        /// <value>The area of interest.</value>
        public GeoRssWhere AreaOfInterest { get; set; }

        /// <summary>
        /// A date/time interval relevant to the context document
        /// </summary>
        /// <value>The time interval of interest.</value>
        public DateTimeInterval TimeIntervalOfInterest { get; set; }

        /// <summary>
        /// Keyword related to this context document. Shall support an optional codelist parameter. 
        /// </summary>
        /// <value>The keyword.</value>
        public List<string> Keywords { get; set; }

        /// <summary>
        /// The description of a resource and its access parameters and configuration
        /// </summary>
        /// \return contains \ref OwcResource that describe resources and their access parameters and configuration</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public List<Resource> Resources { get; set; }

        /// <summary>
        /// Additional metadata describing the context document itself. The format recommendation is ISO19115 complaint metadata. The metadata standard used should be specified
        /// </summary>
        /// <value>The context metadata.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public SyndicationLink ContextMetadata { get; set; }

        /// <summary>
        /// Any encoding should allow the user to extend the context content to include custom items 
        /// </summary>
        /// <value>The extension.</value>
        public ServiceModel.Syndication.SyndicationElementExtensionCollection Extension { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terradue.ServiceModel.Ogc.Owc.Model.Context"/> class.
        /// </summary>
        public Context() {
        }

        /// <summary>
        /// Transform the current object to OwsContextAtomFeed.
        /// </summary>
        /// <returns>The ows context atom feed.</returns>
        public OwsContextAtomFeed ToOwsContextAtomFeed(){

            OwsContextAtomFeed feed = new OwsContextAtomFeed();

            feed.Title = new TextSyndicationContent(this.Title);
            feed.Description = new TextSyndicationContent(this.Abstract);
            feed.Id = this.Id;
            feed.LastUpdatedTime = this.UpdateDate;
            feed.Language = this.Language;
            feed.Publisher = this.Publisher;
            feed.Copyright = new TextSyndicationContent(this.Rights);
            feed.Where = this.AreaOfInterest;
            feed.Date = this.TimeIntervalOfInterest;

            if(this.SpecReference != null) feed.Links.Add(new Terradue.ServiceModel.Syndication.SyndicationLink(this.SpecReference,"profile","OWC Context document specification reference",null,this.SpecReference.AbsoluteUri.Length));

            //TODO: validate type of ContextMetadata
            if(this.ContextMetadata != null) feed.Links.Add(this.ContextMetadata);

            if (this.Authors != null) {
                foreach (string author in this.Authors) feed.Authors.Add(new SyndicationPerson(null, author, null));
            }

            if (this.Creator != null) {
                if(this.Creator.CreatorApplication != null) feed.Generator = this.Creator.CreatorApplication.Title;
                feed.Display = new Terradue.ServiceModel.Ogc.Owc.AtomEncoding.OwcDisplay(this.Creator.CreatorDisplay);
            }

            if (this.Keywords != null) {
                foreach (string kw in this.Keywords) feed.Categories.Add(new SyndicationCategory(kw));
            }

            if (this.Resources != null) {
                System.Collections.ObjectModel.Collection<OwsContextAtomEntry> items = new System.Collections.ObjectModel.Collection<OwsContextAtomEntry>();
                foreach (Resource resource in this.Resources) items.Add(resource.ToContextAtomEntry());
                feed.Items = items;
            }

//            feed.ElementExtensions = Extension.ToAtom(); //TODO: implement

            return feed;
        }
    }


}

