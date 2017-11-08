[![Build Status](https://build.terradue.com/buildStatus/icon?job=DotNetOgcModel/develop)](https://build.terradue.com/job/DotNetOgcModel/job/develop/)

# DotNetOgcModel - A complete .Net library for manipulating XML documents according to the OGC specifications

Terradue.ServiceModel.Ogc is a library targeting .NET 4.5 and above providing an easy
way to manipulate XML document following the [OGC standards](http://www.opengeospatial.org/standards).
It provides with an exhaustive set of classes generated from the [official XSD schemas' files](http://schemas.opengis.net/). 
Those classes can be used with System.XML.Serialization.XMLSerializer to read (deserialization) and write (serialization) XML code that follows the schemas.
Some helpers are also implemented for some usual specifications such as GML, Observation and Measurements, OWS...

## Usage examples


### GML - [Geography Markup Language](http://www.opengeospatial.org/standards/gml)

Serialize 

```c#
// Init Serializer
System.Xml.Serialization.XmlSerializer multiPolygonSerializer = new System.Xml.Serialization.XmlSerializer(typeof(MultiPolygonType));
// Read XML file and desrialize into object
FileStream fs = new FileStream("../Samples/MultiPolygon.xml", FileMode.Open);
MultiPolygonType multiPolygon = (MultiPolygonType)multiPolygonSerializer.Deserialize(fs);
// Manipulate object
PolygonType firstPolygon  = gml.polygonMember[0].Polygon;
// Serialize object
multiPolygonSerializer.Serialize(Console.OpenStandardOutput(), multiPolygon);
```

### EOP - Earth Observation Profile

```c#
// Use Ogc Helper
FileStream fs = new FileStream("../Samples/eop20_example.xml", FileMode.Open);
Eop20.EarthObservationType eop = (Eop20.EarthObservationType)OgcHelpers.Eop20Serializer.Deserialize(fs);
// read dataset's begin and end position
var begin = eop.phenomenonTime.GmlTimePeriod.beginPosition.Value;
var end = eop.phenomenonTime.GmlTimePeriod.endPosition.Value;
```


## Getting Started

Terradue.ServiceModel.Ogc is available as NuGet package in releases.

```
Install-Package Terradue.ServiceModel.Ogc
```

## Build

Terradue.ServiceModel.Ogc is a single assembly designed to be easily deployed anywhere. 

To compile it yourself, you’ll need:

* Visual Studio 2012 or later, or Xamarin Studio

To clone it locally, click the "Clone in Desktop" button above or run the 
following git commands.

```
git clone git@github.com:Terradue/DotNetOgcModel.git Terradue.ServiceModel.Ogc
```

## Copyright and License

Copyright (c) 2014 - 2017 Terradue

Licensed under the [AGPL v3 License](https://raw.githubusercontent.com/Terradue/DotNetOgcModel/develop/LICENSE)
