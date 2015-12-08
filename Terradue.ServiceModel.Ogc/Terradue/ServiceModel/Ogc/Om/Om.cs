﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Terradue.ServiceModel.Ogc.Observation</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
using Terradue.EarthObservation.EarthObservation.Ogc.Gmd;
using Terradue.ServiceModel.Ogc.Gml321;


namespace Terradue.ServiceModel.Ogc.Om
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("OM_Observation", Namespace = "http://www.opengis.net/om/2.0", IsNullable = false)]
    public partial class OM_ObservationType : AbstractFeatureType
    {

        private ReferenceType typeField;

        private Terradue.EarthObservation.EarthObservation.Ogc.Gmd.MD_Metadata_PropertyType metadataField;

        private ObservationContextPropertyType[] relatedObservationField;

        private TimeObjectPropertyType phenomenonTimeField;

        private TimeInstantPropertyType resultTimeField;

        private TimePeriodPropertyType validTimeField;

        private OM_ProcessPropertyType procedureField;

        private NamedValuePropertyType[] parameterField;

        private ReferenceType observedPropertyField;

        private FeaturePropertyType featureOfInterestField;

        private Terradue.EarthObservation.EarthObservation.Ogc.Gmd.DQ_Element_PropertyType[] resultQualityField;

        private object resultField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public ReferenceType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public Terradue.EarthObservation.EarthObservation.Ogc.Gmd.MD_Metadata_PropertyType metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("relatedObservation")]
        public ObservationContextPropertyType[] relatedObservation
        {
            get
            {
                return this.relatedObservationField;
            }
            set
            {
                this.relatedObservationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public TimeObjectPropertyType phenomenonTime
        {
            get
            {
                return this.phenomenonTimeField;
            }
            set
            {
                this.phenomenonTimeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public TimeInstantPropertyType resultTime
        {
            get
            {
                return this.resultTimeField;
            }
            set
            {
                this.resultTimeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public TimePeriodPropertyType validTime
        {
            get
            {
                return this.validTimeField;
            }
            set
            {
                this.validTimeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public virtual OM_ProcessPropertyType procedure
        {
            get
            {
                return this.procedureField;
            }
            set
            {
                this.procedureField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public NamedValuePropertyType[] parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ReferenceType observedProperty
        {
            get
            {
                return this.observedPropertyField;
            }
            set
            {
                this.observedPropertyField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
        public virtual FeaturePropertyType featureOfInterest
        {
            get
            {
                return this.featureOfInterestField;
            }
            set
            {
                this.featureOfInterestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("resultQuality")]
        public Terradue.EarthObservation.EarthObservation.Ogc.Gmd.DQ_Element_PropertyType[] resultQuality
        {
            get
            {
                return this.resultQualityField;
            }
            set
            {
                this.resultQualityField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public virtual object result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class ObservationContextPropertyType
    {

        private ObservationContextType observationContextField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public ObservationContextType ObservationContext
        {
            get
            {
                return this.observationContextField;
            }
            set
            {
                this.observationContextField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ObservationContext", Namespace = "http://www.opengis.net/om/2.0", IsNullable = false)]
    public partial class ObservationContextType
    {

        private ReferenceType roleField;

        private ReferenceType relatedObservationField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public ReferenceType role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public ReferenceType relatedObservation
        {
            get
            {
                return this.relatedObservationField;
            }
            set
            {
                this.relatedObservationField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class TimeObjectPropertyType
    {

        private AbstractTimeObjectType abstractTimeObjectField;

        private string nilReasonField;

        private string remoteSchemaField;

        [System.Xml.Serialization.XmlElementAttribute("TimePeriod", Type=typeof(TimePeriodType), Namespace = "http://www.opengis.net/gml/3.2")]
        public AbstractTimeObjectType AbstractTimeObject
        {
            get
            {
                return this.abstractTimeObjectField;
            }
            set
            {
                this.abstractTimeObjectField = value;
            }
        }

        [XmlIgnore]
        public TimePeriodType GmlTimePeriod
        {
            get
            {
                return (TimePeriodType)this.abstractTimeObjectField;
            }
            set
            {
                this.abstractTimeObjectField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class OM_ProcessPropertyType
    {

        private System.Xml.XmlElement anyField;

        private string nilReasonField;

        private string remoteSchemaField;

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class NamedValuePropertyType
    {

        private NamedValueType namedValueField;

        private string nilReasonField;

        private string remoteSchemaField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public NamedValueType NamedValue
        {
            get
            {
                return this.namedValueField;
            }
            set
            {
                this.namedValueField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("NamedValue", Namespace = "http://www.opengis.net/om/2.0", IsNullable = false)]
    public partial class NamedValueType
    {

        private ReferenceType nameField;

        private object valueField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public ReferenceType name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public object value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/om/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/om/2.0", IsNullable = true)]
    public partial class OM_ObservationPropertyType
    {

        private OM_ObservationType oM_ObservationField;

        private string nilReasonField;

        private string remoteSchemaField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public OM_ObservationType OM_Observation
        {
            get
            {
                return this.oM_ObservationField;
            }
            set
            {
                this.oM_ObservationField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
            }
        }
    }
}
