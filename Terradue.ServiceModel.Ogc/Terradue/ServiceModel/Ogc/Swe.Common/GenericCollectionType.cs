using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace Terradue.ServiceModel.Ogc.Swe.Common
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class GenericCollectionType<T>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }


        /// <remarks/>
        public static implicit operator GenericCollectionType<T>(Collection<T> d)
        {
            return new GenericCollectionType<T>()
            {
                Value = string.Join(" ",
                (from n in d select n.ToString()).ToArray()
                )
            };
        }

        /// <remarks/>
        public static implicit operator Collection<T>(GenericCollectionType<T> c)
        {
            return new Collection<T>((from s in c.Value.Split(new char[] { ' ' })
                                      select (T)Convert.ChangeType(s, typeof(T), System.Globalization.CultureInfo.InvariantCulture)).ToList());
        }

        /// <summary>
        /// Converts to <see cref="T:GenericCollectionType"/> type.
        /// </summary>
        /// <param name="d">Value to convert.</param>
        /// <returns></returns>
        public static GenericCollectionType<T> ToGenericCollectionType(Collection<T> d)
        {
            return (GenericCollectionType<T>)d;
        }

        /// <summary>
        /// Converts from <see cref="T:GenericCollectionType"/> type.
        /// </summary>
        /// <param name="c">Value to convert.</param>
        /// <returns></returns>
        public static Collection<T> FromGenericCollectionType(GenericCollectionType<T> c)
        {
            return (GenericCollectionType<T>)c;
        }

    }
}
