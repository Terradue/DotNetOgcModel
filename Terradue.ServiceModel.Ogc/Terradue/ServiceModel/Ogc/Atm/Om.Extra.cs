
// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Terradue.ServiceModel.Ogc.Eop</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
using Terradue.ServiceModel.Ogc.Om20;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Ogc.Ows20;
using Terradue.ServiceModel.Ogc.Swe10;


namespace Terradue.ServiceModel.Ogc.Om20 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;


    public partial class OM_ResultPropertyType {

        [XmlIgnore]
        public Terradue.ServiceModel.Ogc.Atm21.AtmEarthObservationResultType Atm21EarthObservationResult {
            get {
                if (Eop21EarthObservationResult is Terradue.ServiceModel.Ogc.Atm21.AtmEarthObservationResultType)
                    return (Terradue.ServiceModel.Ogc.Atm21.AtmEarthObservationResultType)Eop21EarthObservationResult;
                return null;
            }
            set {
                Eop21EarthObservationResult = value;
            }
        }

        [XmlIgnore]
        public Terradue.ServiceModel.Ogc.Atm20.AtmEarthObservationResultType Atm20EarthObservationResult {
            get {
                if (Eop20EarthObservationResult is Terradue.ServiceModel.Ogc.Atm20.AtmEarthObservationResultType)
                    return (Terradue.ServiceModel.Ogc.Atm20.AtmEarthObservationResultType)Eop20EarthObservationResult;
                return null;
            }
            set {
                Eop20EarthObservationResult = value;
            }
        }

    }

   

}
