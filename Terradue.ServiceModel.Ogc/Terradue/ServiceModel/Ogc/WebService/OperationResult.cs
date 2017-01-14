using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.WebService
{
    /// <summary>
    /// Used to return result of an operation.
    /// </summary>
    /// <remarks>
    /// This class is responsible to create object of type <see cref="Message"/> that will be used to return results from the service.
    /// </remarks>
    public class OperationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResult"/> class.
        /// </summary>
        public OperationResult()
        {
            this.OutputFormat = OutputFormat.TextXml;
        }

        /// <summary>
        /// Gets or sets result of the operation
        /// </summary>
        public object ResultObject { get; set; }

        /// <summary>
        /// Gets or sets output MIME format to be used to return result
        /// </summary>
        public OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Gets message object to be returned by the service as the result of the operation
        /// </summary>
        /// <returns></returns>
        public Stream GetResultMessage()
        {

            switch (this.OutputFormat)
            {
                case OutputFormat.ApplicationXmlExternalParsedEntity:
                case OutputFormat.TextXmlExternalParsedEntity:
                case OutputFormat.ApplicationXml:
                case OutputFormat.TextXml:
                case OutputFormat.ApplicationXmlWaterMl2:
                    {
                        //  Serialize result object
                        XmlSerializer serializer = this.ResultObject.GetType().GetSerializer();

                        StringBuilder sb = new StringBuilder();
                        using (StringWriter sw = new StringWriter(sb, CultureInfo.InvariantCulture))
                        {
                            serializer.Serialize(sw, this.ResultObject);
                        }

                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(sb.ToString());

                        result = Message.CreateMessage(MessageVersion.None, null, xmlDoc.DocumentElement);
                        result.Properties[WebBodyFormatMessageProperty.Name] = new WebBodyFormatMessageProperty(WebContentFormat.Xml);
                        WebOperationContext.Current.OutgoingResponse.ContentType = this.OutputFormat.ToStringValue();
                        break;
                    }

                case OutputFormat.TextCsv:
                    {
                        string message = this.ResultObject as string;
                        if (string.IsNullOrEmpty(message) && this.ResultObject is ReadOnlyCollection<string>)
                        {
                            StringBuilder sb = new StringBuilder();
                            foreach (string text in this.ResultObject as ReadOnlyCollection<string>)
                            {
                                sb.AppendLine(text);
                            }

                            message = sb.ToString();
                        }

                        if (string.IsNullOrEmpty(message))
                        {
                            throw new NoApplicableCodeException("Message is empty or not set or result object is not supported.");
                        }

                        result = Message.CreateMessage(MessageVersion.None, null, new TextBodyWriter(message));
                        result.Properties[WebBodyFormatMessageProperty.Name] = new WebBodyFormatMessageProperty(WebContentFormat.Raw);
                        WebOperationContext.Current.OutgoingResponse.ContentType = "text/csv";
                        break;
                    }

                case OutputFormat.TextPlain:
                    {
                        string message = string.Format(CultureInfo.InvariantCulture, "{0}", this.ResultObject);

                        if (string.IsNullOrEmpty(message))
                        {
                            throw new NoApplicableCodeException("Message is empty or not set or result object is not supported.");
                        }

                        result = Message.CreateMessage(MessageVersion.None, null, new TextBodyWriter(message));
                        result.Properties[WebBodyFormatMessageProperty.Name] = new WebBodyFormatMessageProperty(WebContentFormat.Raw);
                        WebOperationContext.Current.OutgoingResponse.ContentType = "text/csv";
                        break;
                    }
                default:
                    break;
            }

            return result;
        }

       
    }
}
