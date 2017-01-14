using System;
using System.Runtime.Serialization;

namespace Terradue.ServiceModel.Ogc.Exceptions
{
    /// <summary>
    /// Represents OGC OperationNotSupported exception.
    /// </summary>
    [Serializable]
    public class OperationNotSupportedException : OgcException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationNotSupportedException"/> class.
        /// </summary>
        public OperationNotSupportedException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationNotSupportedException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public OperationNotSupportedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationNotSupportedException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public OperationNotSupportedException(string message, System.Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationNotSupportedException"/> class with a specified error message and not supported operation name.
        /// </summary>
        /// <param name="operationName">Invalid parameter name</param>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public OperationNotSupportedException(string operationName, string message)
            : this(message)
        {
            this.Locator = operationName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationNotSupportedException"/> class with a specified error message, not supported operation name and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="operationName">Invalid parameter name</param>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public OperationNotSupportedException(string operationName, string message, System.Exception inner)
            : this(message, inner)
        {
            this.Locator = operationName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationNotSupportedException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected OperationNotSupportedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets OGC compliant error code.
        /// </summary>
        public override Terradue.ServiceModel.Ogc.Ows11.ExceptionCode ExceptionCode
        {
            get { return Terradue.ServiceModel.Ogc.Ows11.ExceptionCode.OperationNotSupported; }
        }
    }
}
