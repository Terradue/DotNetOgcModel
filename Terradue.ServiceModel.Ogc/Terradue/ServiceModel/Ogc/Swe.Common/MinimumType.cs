using System;

namespace Terradue.ServiceModel.Ogc.Swe.Common
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class MinimumType<T>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

        /// <remarks/>
        public static implicit operator MinimumType<T>(T d)
        {
            return new MinimumType<T>() { Value = d.ToString() };
        }

        /// <remarks/>
        public static implicit operator T(MinimumType<T> c)
        {
            return (T)Convert.ChangeType(c.Value, typeof(T), System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts to <see cref="T:MinimumType"/> type.
        /// </summary>
        /// <param name="d">Value to convert.</param>
        /// <returns></returns>
        public MinimumType<T> ToMinimumType(T d)
        {
            return (MinimumType<T>)d;
        }

        /// <summary>
        /// Converts from <see cref="T:MinimumType"/> type.
        /// </summary>
        /// <param name="c">Value to convert.</param>
        /// <returns></returns>
        public T FromMinimumType(MinimumType<T> c)
        {
            return (T)c;
        }
    }
}
