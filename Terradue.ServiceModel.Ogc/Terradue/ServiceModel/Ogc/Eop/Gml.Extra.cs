
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

namespace Terradue.ServiceModel.Ogc.Gml321 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;

    public partial class FeaturePropertyType {

        private Terradue.ServiceModel.Ogc.Eop20.FootprintType eop20footprintField;

        private Terradue.ServiceModel.Ogc.Eop21.FootprintType eop21footprintField;

        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/eop/2.0", Type = typeof(Terradue.ServiceModel.Ogc.Eop20.FootprintType))]
        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/alt/2.0", Type = typeof(Terradue.ServiceModel.Ogc.Alt20.AltFootprintType))]
        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/ssp/2.0", Type = typeof(Terradue.ServiceModel.Ogc.Ssp20.SspFootprintType))]
        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/lmb/2.0", Type = typeof(Terradue.ServiceModel.Ogc.Lmb20.LmbFootprintType))]
        public Terradue.ServiceModel.Ogc.Eop20.FootprintType Eop20Footprint {
            get {
                return this.eop20footprintField;
            }
            set {
                this.eop20footprintField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/eop/2.1", Type = typeof(Terradue.ServiceModel.Ogc.Eop21.FootprintType))]
        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/alt/2.1", Type = typeof(Terradue.ServiceModel.Ogc.Alt21.AltFootprintType))]
        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/ssp/2.1", Type = typeof(Terradue.ServiceModel.Ogc.Ssp21.SspFootprintType))]
        [System.Xml.Serialization.XmlElementAttribute("Footprint", Namespace = "http://www.opengis.net/lmb/2.1", Type = typeof(Terradue.ServiceModel.Ogc.Lmb21.LmbFootprintType))]
        public Terradue.ServiceModel.Ogc.Eop21.FootprintType Eop21Footprint {
            get {
                return this.eop21footprintField;
            }
            set {
                this.eop21footprintField = value;
            }
        }

    }
}
