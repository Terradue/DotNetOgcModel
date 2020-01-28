using System;
using System.Collections.Generic;
using Terradue.ServiceModel.Syndication;
using Terradue.ServiceModel.Ogc.Owc.AtomEncoding;
using Terradue.ServiceModel.Ogc.GeoRss.GeoRss;
using Terradue.ServiceModel.Ogc.Gml321;

namespace Terradue.ServiceModel.Ogc.Owc.Model
{
    /// <summary>OWS Resource</summary>
    /// <description>
    /// This class describes the resource elements which supply the information layers used in 
    /// the Context Document. Resource, while it can be used bare, is typically classified by 
    /// owc:MediaCode indicating the type of information encoded in the resource. The resource 
    /// offers multiple ways to pass a configured resource, in-line content, by absolute URI and 
    /// by service Content which needs to be interpreted by an intelligent client. While there may 
    /// be limitations in the individual encoding, each of these types shall be semantically 
    /// equivalent, i.e. alternative representations of the same information (they can for example 
    /// have different resolutions but should not show fundamentally different information).
    /// </description>
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    /// \ingroup OWSContext
    public class Resource
    {

        /// <summary>
        /// Unique Identifier assigned to the owc Resource. Used to reference a resource from other resources 
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>
        /// A Human Readable Title for the OWC Resource
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
        /// Date when the resource definition was updated
        /// </summary>
        /// <value>The update date.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public DateTimeOffset UpdateDate { get; set; }

        /// <summary>
        /// Identifier for the author of the resource definition
        /// </summary>
        /// <value>The author.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public List<string> Authors { get; set; }

        /// <summary>
        /// Identifier for the publisher of the resource definition
        /// </summary>
        /// <value>The publisher.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public string Publisher { get; set; }

        /// <summary>
        /// Rights which apply to the resource definition.
        /// </summary>
        /// <value>The rights.</value>
        public string Rights { get; set; }

        /// <summary>
        /// The geographic extent of the resource 
        /// </summary>
        /// <value>The geospatial extent.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public EnvelopeType GeospatialExtent { get; set; }

        /// <summary>
        /// The temporal extent of the content of the resource
        /// </summary>
        /// <value>The temporal extent.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public DateTimeInterval TemporalExtent { get; set; }

        /// <summary>
        /// A URI identifying a preview of the resource
        /// </summary>
        /// <value>The preview.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public List<Uri> Preview { get; set; }

        /// <summary>
        /// A URI identifying a service which will return an immediately exploitable result by simply requesting based on the URI. 
        /// The expectation is that the return type of this call will be a well-known format 
        /// </summary>
        /// <value>The content by reference.</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public List<Uri> ContentByRef { get; set; }

        /// <summary>
        /// Service or inline content offering for the resource targeted at OGC compliant clients
        /// </summary>
        ///\return exposes \ref OwcOffering as services or inline contents for the resource</value>
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public List<Offering> Offerings { get; set; }

        /// <summary>
        /// This flag indicates the state of the resource within the context document. 
        /// It can be interpreted by the caller as required (this may be defined in a profile or in the specific service extensions) 
        /// </summary>
        /// <value><c>true</c> if offering; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }

        /// <summary>
        /// Keyword related to this resource definition. Shall support an optional codelist parameter. 
        /// </summary>
        /// <value>The keyword.</value>
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Minimum scale for the display of the layer
        /// </summary>
        /// <value>The minimum scale denominator.</value>
        public double MinScaleDenominator { get; set; }

        /// <summary>
        /// Maximum scale for the display of the layer
        /// </summary>
        /// <value>The max scale denominator.</value>
        public double MaxScaleDenominator { get; set; }

        /// <summary>
        /// Metadata about the resource itself
        /// </summary>
        /// <value>The resource metadata.</value>
        public object ResourceMetadata { get; set; }

        /// <summary>
        /// Definition of the folder structure in which the resource is placed.
        /// </summary>
        /// <value>The folder.</value>
        public string Folder { get; set; }

        /// <summary>
        /// Any encoding should allow the user to extend the resource content to include custom items 
        /// </summary>
        /// <value>The extension.</value>
        public object Extension { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terradue.ServiceModel.Ogc.Owc.Model.Resource"/> class.
        /// </summary>
        public Resource()
        {
        }

        /// <summary>
        /// Transform the current object to OwsContextAtomEntry.
        /// </summary>
        /// <returns>The context atom entry.</returns>
        public OwsContextAtomEntry ToContextAtomEntry()
        {
            OwsContextAtomEntry item = new OwsContextAtomEntry();

            item.Title = new TextSyndicationContent(this.Title);
            item.Summary = new TextSyndicationContent(this.Abstract);
            item.Id = this.Id;
            item.LastUpdatedTime = this.UpdateDate;
            item.Publisher = this.Publisher;
            item.Copyright = new TextSyndicationContent(this.Rights);
            if (this.GeospatialExtent != null) item.Where = new GeoRssWhere() { Item = new object[] { this.GeospatialExtent } };
            if (this.TemporalExtent != null) item.Date = this.TemporalExtent;
            item.MinScaleDenominator = this.MinScaleDenominator;
            item.MaxScaleDenominator = this.MaxScaleDenominator;

            if (this.Authors != null)
            {
                foreach (string author in this.Authors) item.Authors.Add(new SyndicationPerson(null, author, null));
            }

            if (this.Preview != null)
            {
                foreach (Uri uri in this.Preview) item.Links.Add(new SyndicationLink(uri, "icon", "Preview image", null, uri.AbsoluteUri.Length));
            }

            if (this.ContentByRef != null)
            {
                foreach (Uri uri in this.ContentByRef) item.Links.Add(new SyndicationLink(uri, "enclosure", "Data resource location", null, uri.AbsoluteUri.Length));
            }

            if (this.ResourceMetadata != null)
            {
                Uri u = new Uri((string)this.ResourceMetadata);//TODO: validate type of ResourceMetadata
                item.Links.Add(new SyndicationLink(u, "via", "Reference to the resource from which the Context resource is derived", null, u.AbsoluteUri.Length));
            }

            if (this.Offerings != null)
            {
                List<Terradue.ServiceModel.Ogc.Owc.AtomEncoding.OwcOffering> offerings = new List<Terradue.ServiceModel.Ogc.Owc.AtomEncoding.OwcOffering>();
                foreach (Offering off in this.Offerings) offerings.Add(new Terradue.ServiceModel.Ogc.Owc.AtomEncoding.OwcOffering(off));
                item.Offerings = offerings;
            }

            item.Categories.Add(new SyndicationCategory(this.Active.ToString(), "http://www.opengis.net/spec/owc/active", null));

            if (this.Keywords != null)
            {
                foreach (string kw in this.Keywords) item.Categories.Add(new SyndicationCategory(kw));
            }
            if (this.Folder != null)
            {
                item.Categories.Add(new SyndicationCategory(this.Folder, "http://www.opengis.net/spec/owc/folder", null));
            }

            //            feed.ElementExtensions = Extension.ToAtom(); //TODO: implement

            return item;
        }
    }
}

