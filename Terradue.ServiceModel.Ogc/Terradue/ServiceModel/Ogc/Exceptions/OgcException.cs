using System;
using System.Linq;
using System.Runtime.Serialization;
using Terradue.ServiceModel.Ogc.Ows11;

namespace Terradue.ServiceModel.Ogc.Exceptions
{
    /// <summary>
    /// Specifies a base class for all OGC errors that occur during application execution.
    /// </summary>
    [Serializable]
    public abstract class OgcException : System.Exception
    {
        /// <summary>
        /// Gets or sets excetion locator.
        /// </summary>
        public string Locator { get; protected set; }

        /// <remarks/>
        protected OgcException()
        {
        }

        /// <remarks/>
        protected OgcException(string message)
            : base(message)
        {
        }

        /// <remarks/>
        protected OgcException(string message, System.Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OgcException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected OgcException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets OGC compliant error code.
        /// </summary>
        public abstract ExceptionCode ExceptionCode { get; }

        /// <summary>
        /// Gets ExceptionReport object that represents current exception
        /// </summary>
        public ExceptionReport ExceptionReport
        {
            get
            {
                ExceptionReport exceptionReports = new ExceptionReport();
                exceptionReports.Exceptions.Add(new Terradue.ServiceModel.Ogc.Ows11.ExceptionType()
                {
                    ExceptionCode = this.ExceptionCode,
                    ExceptionText = (!string.IsNullOrEmpty(this.Message)) ? this.Message : this.ToString(),
                    Locator = this.Locator,
                });
                FillStackTrace(this.InnerException, ref exceptionReports);

                return exceptionReports;
            }
        }
        private void FillStackTrace(Exception exception, ref ExceptionReport exceptionReports)
        {
            if (exception is null) return;
            if (exception is AggregateException)
            {
                exceptionReports.Exceptions.Last().ExceptionText += " (All details in next exceptions)";
                foreach (var innerException in ((AggregateException)this.InnerException).InnerExceptions)
                {
                    FillStackTrace(innerException, ref exceptionReports);
                }
            }
            else if (exception is OgcException)
            {
                var ogcException = exception as OgcException;
                exceptionReports.Exceptions.Add(new Terradue.ServiceModel.Ogc.Ows11.ExceptionType()
                {
                    ExceptionCode = ogcException.ExceptionCode,
                    ExceptionText = (!string.IsNullOrEmpty(ogcException.Message)) ? ogcException.Message : ogcException.ToString(),
                    Locator = ogcException.Locator,
                });
                FillStackTrace(exception.InnerException, ref exceptionReports);
            }
            else
            {
                exceptionReports.Exceptions.Add(new Terradue.ServiceModel.Ogc.Ows11.ExceptionType()
                {
                    ExceptionCode = ExceptionCode.NoApplicableCode,
                    ExceptionText = exception.Message,
                    Locator = exception.StackTrace,
                });
                FillStackTrace(exception.InnerException, ref exceptionReports);
            }
        }
    }
}
