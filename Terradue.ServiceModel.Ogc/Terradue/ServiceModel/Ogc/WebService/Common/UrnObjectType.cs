namespace Renci.Ogc.WebService.Common
{
    public enum UrnObjectType
    {
        /// <summary>
        /// Full definition reference in 9.3 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("axis")]
        CoordinateSystemAxe,

        /// <summary>
        /// Full definition reference in 9.4 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("axisDirection")]
        AxisDirectionCode,

        /// <summary>
        /// Full definition reference in 11.1 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("coordinateOperation")]
        CoordinateOperation,

        /// <summary>
        /// Full definition reference in 8.2 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("crs")]
        CoordinateReferenceSystem,

        /// <summary>
        /// Full definition reference in 9.2 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("cs")]
        CoordinateSystem,

        /// <summary>
        /// Full definition reference in 10.1 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("datum")]
        GeodeticDatum,

        /// <summary>
        /// Full definition reference in D.1 in OGC 05-007r4
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("dataType")]
        DataType,

        /// <summary>
        /// Full definition reference in 8.3 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("derivedCRSType")]
        DerivedCRSType,

        /// <summary>
        /// Full definition reference in 4. in OGC 05-020r4
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("documentType")]
        DocumentType,

        /// <summary>
        /// Full definition reference in 10.2.2 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ellipsoid")]
        Ellipsoid,

        /// <summary>
        /// Full definition as specified in an application schema (ISO 19109)
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("featureType")]
        FeatureType,

        /// <summary>
        /// Full definition reference in 11.2 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("group")]
        OperationParameterGroup,

        /// <summary>
        /// Full definition reference in D.1 in OGC 05-007r4
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("meaning")]
        ParameterMeaning,

        /// <summary>
        /// Full definition reference in 10.2.1 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("meridian")]
        PrimeMeridian,

        /// <summary>
        /// Full definition reference in 11.2 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("method")]
        OperationMethod,

        /// <summary>
        /// Full definition reference in 8.2.3.1 in OGC 05-108r1
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("nil")]
        MissingInformation,

        /// <summary>
        /// Full definition reference in 11.2 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("parameter")]
        OperationParameter,

        /// <summary>
        /// Full definition reference in 6.2 in OGC 05-087r2
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("phenomenon")]
        ObservableProperty,

        /// <summary>
        /// Full definition reference in 10.3 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("pixelInCell")]
        PixelInCellCode,

        /// <summary>
        /// Full definition reference in 9.4 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("rangeMeaning")]
        RangeMeaningCode,

        /// <summary>
        /// Full definition reference in D.1 in OGC 05-007r4
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("referenceSystem")]
        ValueReferenceSystem,

        /// <summary>
        /// Full definition reference in  ....
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("uom")]
        UnitOfMeasure,

        /// <summary>
        /// Full definition reference in 10.3 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("verticalDatumType")]
        VerticalDatumTypeCode,

        /// <summary>
        /// Full definition reference in 10.3 in OGC 05-103
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("property")]
        Property,
    }
}
