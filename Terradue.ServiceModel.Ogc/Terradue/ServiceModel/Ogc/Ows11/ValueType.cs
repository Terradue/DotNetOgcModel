using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Terradue.ServiceModel.Ogc.Ows11
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class ValueType : IXmlSerializable
    {
        private string _value;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ValueType()
        {

        }

        /// <remarks/>
        public ValueType(string value)
            : this()
        {
            this._value = value;
        }

        #region IXmlSerializable Members

        /// <summary>
        /// This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute"/> to the class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Xml.Schema.XmlSchema"/> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)"/> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)"/> method.
        /// </returns>
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            string xsd = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<schema targetNamespace=""http://www.opengis.net/ows/1.1"" xmlns:ows=""http://www.opengis.net/ows/1.1"" xmlns:xlink=""http://www.w3.org/1999/xlink"" xmlns=""http://www.w3.org/2001/XMLSchema"" elementFormDefault=""qualified"" version=""1.1.0"" xml:lang=""en"">
	<complexType name=""ValueType"">
		<simpleContent>
			<extension base=""string""></extension>
		</simpleContent>
	</complexType>
</schema>";

            System.Xml.Schema.XmlSchema schema = System.Xml.Schema.XmlSchema.Read(new StringReader(xsd), null);
            return schema;
        }

        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"/> stream from which the object is deserialized.</param>
        public void ReadXml(System.Xml.XmlReader reader)
        {
            this._value = reader.ReadString();
            reader.Read();
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"/> stream to which the object is serialized.</param>
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteString(this._value);
        }

        #endregion

        /// <remarks/>
        public static implicit operator ValueType(string value)
        {
            return new ValueType() { _value = value };
        }

        /// <remarks/>
        public static implicit operator string(ValueType c)
        {
            return c._value;
        }

        /// <summary>
        /// Converts to <see cref="ValueType"/> type.
        /// </summary>
        /// <param name="d">Value to convert.</param>
        /// <returns></returns>
        public static ValueType ToValueType(string d)
        {
            return (ValueType)d;
        }

        /// <summary>
        /// Converts from <see cref="ValueType"/> type.
        /// </summary>
        /// <param name="c">Value to convert.</param>
        /// <returns></returns>
        public static string FromValueType(ValueType c)
        {
            return (string)c;
        }

    }
}
