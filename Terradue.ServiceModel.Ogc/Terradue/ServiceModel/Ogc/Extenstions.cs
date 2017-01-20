using System;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Exceptions;

namespace Terradue.ServiceModel.Ogc
{
    /// <remarks/>
    public static class Extensions
    {
        /// <summary>
        /// Gets text represention of enum type defined by a XmlEnumAttribute attribute.
        /// </summary>
        /// <param name="value">Enum value</param>
        /// <returns>Value defined by XmlEnumAttribute if exists; otherwise string represention of enum value.</returns>
        public static string ToStringValue(this Enum value)
        {
            // Get the Type of the enum
            Type t = value.GetType();

            // Get the FieldInfo for the member field with the enums name
            FieldInfo info = t.GetField(value.ToString("G"));

            // Check to see if the XmlEnumAttribute is defined on this field
            if (!info.IsDefined(typeof(XmlEnumAttribute), false))
            {
                // If no XmlEnumAttribute then return the string version of the enum.
                return value.ToString("G");
            }

            // Get the XmlEnumAttribute
            object[] o = info.GetCustomAttributes(typeof(XmlEnumAttribute), false);
            XmlEnumAttribute att = (XmlEnumAttribute)o[0];
            return att.Name;
        }

        /// <remarks/>
        public static T ParseEnum<T>(this string text)
        {
            Type t = typeof(T);

            FieldInfo[] fields = t.GetFields();

            foreach (var field in fields)
            {
                // Check to see if the XmlEnumAttribute is defined on this field
                if (field.IsDefined(typeof(XmlEnumAttribute), false))
                {
                    object[] o = field.GetCustomAttributes(typeof(XmlEnumAttribute), false);
                    XmlEnumAttribute att = (XmlEnumAttribute)o[0];

                    if (att.Name == text)
                    {
                        return (T)Enum.Parse(t, field.Name);
                    }
                }
            }

            //  return default value if not found
            return (T)Enum.Parse(t, Enum.GetNames(t)[0]);
        }

        /// <remarks/>
        public static bool TryParseEnum<T>(this string text, out T result)
        {
            result = default(T);

            Type t = typeof(T);

            FieldInfo[] fields = t.GetFields();

            foreach (var field in fields)
            {
                // Check to see if the XmlEnumAttribute is defined on this field
                if (field.IsDefined(typeof(XmlEnumAttribute), false))
                {
                    object[] o = field.GetCustomAttributes(typeof(XmlEnumAttribute), false);
                    XmlEnumAttribute att = (XmlEnumAttribute)o[0];

                    if (att.Name == text)
                    {
                        result = (T)Enum.Parse(t, field.Name);
                        return true;
                    }
                }
            }

            return false;
        }

        private static Regex _versionRe = new Regex(@"(?<major>\d+)[.](?<minor>\d{1,2})[.](?<build>\d{1,2})");

        /// <summary>
        /// Converts string to numeric representation of the version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns></returns>
        public static int ToVersionNumber(this string version)
        {
            if (string.IsNullOrEmpty(version))
            {
                return -1;
            }

            var match = _versionRe.Match(version);

            if (!match.Success)
                throw new NoApplicableCodeException(string.Format(CultureInfo.InvariantCulture, "Version '{0}' has invalid OGC format.", version));

            int major = int.Parse(match.Result("${major}"), CultureInfo.InvariantCulture);
            int minor = int.Parse(match.Result("${minor}"), CultureInfo.InvariantCulture);
            int build = int.Parse(match.Result("${build}"), CultureInfo.InvariantCulture);

            return major * 10000 + minor * 100 + build;

        }

        /// <summary>
        /// Converts integer to string representation of the version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns></returns>
        public static string ToVersionString(this int version)
        {
            if (version < 0)
                return string.Empty;

            int build = version - (version / 100) * 100;
            int minor = (version - (version / 10000) * 10000) / 100;
            int major = version / 10000;

            return string.Format(CultureInfo.InvariantCulture, "{0}.{1}.{2}", major, minor, build);
        }
    }
}
