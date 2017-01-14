using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Terradue.ServiceModel.Ogc.Exceptions
{
    /// <summary>
    /// Represents OGC MissingParameterValue exception.
    /// </summary>
    [Serializable]
    public class MissingParameterValueException : OgcException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingParameterValueException"/> class.
        /// </summary>
        public MissingParameterValueException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingParameterValueException"/> class with a specified parameter name.
        /// </summary>
        /// <param name="parameterName">Missing parameter name</param>
        public MissingParameterValueException(string parameterName)
            : base(string.Format(CultureInfo.InvariantCulture, "\"{0}\" parameter is required.", parameterName))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingParameterValueException"/> class with a specified parameter name and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="parameterName">Missing parameter name</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public MissingParameterValueException(string parameterName, System.Exception inner)
            : base(string.Format(CultureInfo.InvariantCulture, "\"{0}\" parameter is required.", parameterName), inner)
        {
            this.Locator = parameterName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingParameterValueException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected MissingParameterValueException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets OGC compliant error code.
        /// </summary>
        public override Terradue.ServiceModel.Ogc.Ows11.ExceptionCode ExceptionCode
        {
            get { return Terradue.ServiceModel.Ogc.Ows11.ExceptionCode.MissingParameterValue; }
        }
    }
}
