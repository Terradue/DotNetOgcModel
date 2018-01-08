// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>ClassLibrary9</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>True</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Terradue.ServiceModel.Ogc.Wps10
{
	using System;
	using System.Diagnostics;
	using System.Xml.Serialization;
	using System.Collections;
	using System.Xml.Schema;
	using System.ComponentModel;
	using System.IO;
	using System.Text;
	using System.Xml;
	using System.Collections.Generic;
	using Terradue.ServiceModel.Ogc.Ows11;
	using System.Text.RegularExpressions;

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wps/1.0.0")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wps/1.0.0", IsNullable = false)]
	public partial class Execute : RequestBaseType
	{

		private CodeType identifierField;

		private List<InputType> dataInputsField;

		private ResponseFormType responseFormField;

		/// <summary>
		/// Regular expression to validate agains suported output format parameter
		/// </summary>
		private Regex _validOutputFormat = new Regex(@"text/xml");

		/// <summary>
		/// Creates a default instance of <see cref="Execute"/>.
		/// </summary>
		public Execute()
		{
			Init();
		}

		/// <summary>
		/// Creates an instance of <see cref="DescribeSensor"/>.
		/// </summary>
		/// <param name="queryParameters">Object initial parameters.</param>
		public Execute(System.Collections.Specialized.NameValueCollection queryParameters)
			: base()
		{
			Init();
			this.Identifier = new CodeType() { Value = queryParameters["identifier"] };
			if (!string.IsNullOrEmpty(queryParameters["DataInputs"]) && queryParameters["DataInputs"].StartsWith("[") && queryParameters["DataInputs"].EndsWith("]"))
			    this.DataInputs = KVPDecode(queryParameters["DataInputs"].TrimStart('[').TrimEnd(']'));
		}

		List<InputType> KVPDecode(string v)
		{
			List<InputType> inputs = new List<InputType>();

			foreach (var param in v.Split(';'))
			{
				var parama = param.Split('@');
				if (parama.Length == 1)
				{
					inputs.Add(new InputType()
					{
						Identifier = new CodeType() { Value = parama[0].Split('=')[0] },
						Data = new DataType()
						{
							Item = new LiteralDataType()
							{
								Value = parama[0].Split('=')[1]
							}
						}
					});
					continue;
				}
			}

			return inputs;
		}

		/// <summary>
		/// Gets or sets prefix association with namespaces that are used object serializer.
		/// </summary>
		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Xmlns { get; set; }

		/// <summary>
		/// Perfoms object initialization tasks
		/// </summary>
		private void Init()
		{
			this.Xmlns = new XmlSerializerNamespaces();
			this.Xmlns.Add(string.Empty, "http://www.opengis.net/wps/1.0.0");
			this.Xmlns.Add("gml", "http://www.opengis.net/gml");
			this.Xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
			this.Xmlns.Add("ows", "http://www.opengis.net/ows/1.1");
			this.Xmlns.Add("ogc", "http://www.opengis.net/ogc");
			this.Xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
		}

		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/ows/1.1")]
		public CodeType Identifier
		{
			get
			{
				return this.identifierField;
			}
			set
			{
				this.identifierField = value;
			}
		}

		[System.Xml.Serialization.XmlArrayAttribute()]
		[System.Xml.Serialization.XmlArrayItemAttribute("Input", IsNullable = false)]
		public List<InputType> DataInputs
		{
			get
			{
				return this.dataInputsField;
			}
			set
			{
				this.dataInputsField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute()]
		public ResponseFormType ResponseForm
		{
			get
			{
				return this.responseFormField;
			}
			set
			{
				this.responseFormField = value;
			}
		}


	}

}
