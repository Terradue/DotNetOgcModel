using System;
using Terradue.ServiceModel.Syndication;

namespace Terradue.ServiceModel.Ogc.Owc.Model {
    /// <summary>
    /// OWC Creator
    /// </summary>
    /// <description>
    /// This object provides place to encode information related to the creator of the context document. 
    /// It includes the creator application and any relevant properties or settings for the application. 
    /// </description>
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    /// \ingroup OWSContext
    public class Creator {

        /// <summary>
        /// The name, reference and version of the creator application used to create the context document
        /// </summary>
        /// \return created on \ref OwcApplication at the moment the ows document was generated
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public OwcApplication CreatorApplication { get; set; }

        /// <summary>
        /// Properties of the display in use when the context document was created (for display based applications only).
        /// </summary>
        /// \return displayed on \ref OwcDisplay at the moment the ows document was generated
        /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
        public OwcDisplay CreatorDisplay { get; set; }

        /// <summary>
        /// Any encoding should allow the user to extend the Creator information to include custom items 
        /// </summary>
        /// <value>The extension.</value>
        public SyndicationElementExtensionCollection Extensions { get; set; }

        public Creator() {
        }
    }

    /************************************************************************************************************/

    /// <summary>OWC Application</summary>
    /// <description>
    /// This object provides place to encode information related to the creator context when the document was produced. It includes the creator application and relevant properties or settings for the application.
    /// </description>
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    public class OwcApplication {

        /// <summary>
        /// Title or name of the application (for display purposes)
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// URI describing the creator application
        /// </summary>
        /// <value>The URI.</value>
        public Uri Uri { get; set; }

        /// <summary>
        /// Version of the application.
        /// </summary>
        /// <value>The version.</value>
        public string Version { get; set; }

        public OwcApplication() {
        }
    }

    /************************************************************************************************************/

    /// <summary>
    /// OWC Display
    /// </summary>
    /// <description>
    /// This object provides place to encode information related to the display area used
    /// in the creator application when the OWS Context document was produced. This set of 
    /// properties only applies to creator applications which are using a geographic display and is 
    /// supporting information to the exploiter of the OWS Context document. Note the elements 
    /// within creator display are intended as supporting information (metadata) for clients and 
    /// not properties which should control the display size of the client opening the document.
    /// </description>
    /// \xrefitem rmodp "RM-ODP" "RM-ODP Doc"
    public class OwcDisplay {

        /// <summary>
        /// Pixel width of the display specified by Area of Interest.
        /// </summary>
        /// <value>The width of the pixel.</value>
        public int PixelWidth { get; set; }

        /// <summary>
        /// Pixel height of the display specified by Area of Interest
        /// </summary>
        /// <value>The height of the pixel.</value>
        public int PixelHeight { get; set; }

        /// <summary>
        /// The number of mm per pixel for the display. If no value is available the field should be set to NULL.
        /// </summary>
        /// <value>The mm per pixel.</value>
        public int MmPerPixel { get; set; }

        /// <summary>
        /// Any encoding should allow the user to extend the display information to include custom items 
        /// </summary>
        /// <value>The extension.</value>
        public SyndicationElementExtensionCollection Extensions { get; set; }

        public OwcDisplay() {
        }
    }
}

