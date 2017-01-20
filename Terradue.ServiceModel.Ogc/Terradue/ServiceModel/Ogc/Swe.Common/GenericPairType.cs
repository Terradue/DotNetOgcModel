using System;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Ogc.Swe.Common
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class GenericPairType<T>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} {1}", this.First, this.Second);
            }
            set
            {
                string[] pairArray = value.Split(new char[] { ' ' });

                if (pairArray.Length > 0)
                    this.First = (T)Convert.ChangeType(pairArray[0], typeof(T), System.Globalization.CultureInfo.InvariantCulture);

                if (pairArray.Length > 1)
                    this.Second = (T)Convert.ChangeType(pairArray[1], typeof(T), System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Gets or sets first pair value
        /// </summary>
        [XmlIgnore]
        public T First { get; set; }

        /// <summary>
        /// Gets or sets second pair value
        /// </summary>
        [XmlIgnore]
        public T Second { get; set; }
    }
}
