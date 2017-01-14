using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.WebService.Common
{
    /// <summary>
    /// This class contains different extention methods
    /// </summary>
    internal static class Extenstions
    {
        /// <summary>
        /// Collection of serializers to be used for result serialization
        /// </summary>
        private static Dictionary<Type, XmlSerializer> _serializers = new Dictionary<Type, XmlSerializer>();

        /// <summary>
        /// Gets unicode text represention of date.
        /// </summary>
        /// <param name="d">Date value</param>
        /// <returns>Unicode text representaion of the date.</returns>
        public static string ToUnicodeStringValue(this DateTime d)
        {
            return d.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets <see cref="XmlQualifiedName"/> for specific type.
        /// </summary>
        /// <param name="t">Type to get <see cref="XmlQualifiedName"/> for.</param>
        /// <returns>Instance of <see cref="XmlQualifiedName"/>.</returns>
        public static XmlQualifiedName GetXmlQualifiedName(this Type t)
        {
            object[] attributes = t.GetCustomAttributes(typeof(XmlRootAttribute), true);
            if (attributes.Length > 0)
            {
                XmlRootAttribute attribute = attributes[0] as XmlRootAttribute;
                XmlQualifiedName xqn = new XmlQualifiedName(attribute.ElementName, attribute.Namespace);
                return xqn;
            }

            return null;
        }

        /// <summary>
        /// Adds an collection of objects to the end of the <see cref="System.Collections.ObjectModel.Collection&lt;T&gt;"/>. If collection is null then do nothing.
        /// </summary>
        /// <typeparam name="T">Type of the object in the collection</typeparam>
        /// <param name="source">An existing collection where objects need to be added to</param>
        /// <param name="newItems">Collection of object to be added.</param>
        /// <returns>Collection that includes added objects</returns>
        public static Collection<T> Add<T>(this Collection<T> source, IEnumerable<T> newItems)
        {
            if (newItems != null)
            {
                foreach (var newItem in newItems)
                {
                    source.Add(newItem);
                }
            }

            return source;
        }

        /// <summary>
        /// Gets XmlSerializer for specified type.
        /// </summary>
        /// <param name="resultType">Type to get serializer for</param>
        /// <returns>Type specific XmlSerializer</returns>
        public static XmlSerializer GetSerializer(this Type resultType)
        {
            XmlSerializer serializer = null;

            if (_serializers.ContainsKey(resultType))
            {
                serializer = _serializers[resultType];
            }

            if (serializer == null)
            {
                serializer = new XmlSerializer(resultType);
                _serializers.Add(resultType, serializer);
            }

            return serializer;
        }

        /// <summary>
        /// Converts to read only dictionary.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static IDictionary<K,V> ToReadOnly<K,V>(this IDictionary<K, V> source)
        {
            //  TODO:   Finish this method
            return new ReadOnlyDictionary<K,V>(source);
        }
    }
}
