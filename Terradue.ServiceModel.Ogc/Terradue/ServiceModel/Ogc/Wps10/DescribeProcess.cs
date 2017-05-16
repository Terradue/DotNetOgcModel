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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/wps/1.0.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/wps/1.0.0", IsNullable = false)]
    public partial class DescribeProcess : RequestBaseType
    {

        private List<CodeType> identifierField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("Identifier", Namespace = "http://www.opengis.net/ows/1.1")]
        public List<CodeType> Identifier
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

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(DescribeProcess));
                }
                return serializer;
            }
        }

    }
    
}
