using System;

namespace Terradue.ServiceModel.Ogc.Swe.Common
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class MaximumType<T>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

        /// <remarks/>
        public static implicit operator MaximumType<T>(T d)
        {
            return new MaximumType<T>() { Value = d.ToString() };
        }

        /// <remarks/>
        public static implicit operator T(MaximumType<T> c)
        {
            return (T)Convert.ChangeType(c.Value, typeof(T), System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts to <see cref="T:MaximumType"/> type.
        /// </summary>
        /// <param name="d">Value to convert.</param>
        /// <returns></returns>
        public static MaximumType<T> ToMMaximumType(T d)
        {
            return (MaximumType<T>)d;
        }

        /// <summary>
        /// Converts from <see cref="T:MaximumType"/> type.
        /// </summary>
        /// <param name="c">Value to convert.</param>
        /// <returns></returns>
        public static T FromMaximumType(MaximumType<T> c)
        {
            return (T)c;
        }

    }
}
