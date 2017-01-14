using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Terradue.ServiceModel.Ogc.Exceptions
{
    /// <summary>
    /// Represents OGC OptionNotSupported exception.
    /// </summary>
    [Serializable]
    public class OptionNotSupportedException : OgcException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionNotSupportedException"/> class.
        /// </summary>
        public OptionNotSupportedException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionNotSupportedException"/> class with a specified not supported option.
        /// </summary>
        /// <param name="optionName">Not supported option name</param>
        public OptionNotSupportedException(string optionName)
            : base(string.Format(CultureInfo.CurrentCulture, "Option '{0}' is not supported.", optionName))
        {
            this.Locator = optionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionNotSupportedException"/> class with a specified not supported option and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="optionName">Not supported option name</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public OptionNotSupportedException(string optionName, System.Exception inner)
            : base(string.Format(CultureInfo.CurrentCulture, "Option '{0}' is not supported.", optionName), inner)
        {
            this.Locator = optionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionNotSupportedException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected OptionNotSupportedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets OGC compliant error code.
        /// </summary>
        public override Terradue.ServiceModel.Ogc.Ows11.ExceptionCode ExceptionCode
        {
            get { return Terradue.ServiceModel.Ogc.Ows11.ExceptionCode.OptionNotSupported; }
        }
    }
}
