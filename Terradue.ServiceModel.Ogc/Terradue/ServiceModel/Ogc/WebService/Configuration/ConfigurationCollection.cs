using System;
using System.Collections.Generic;
using System.Configuration;

namespace Terradue.ServiceModel.Ogc.WebService.Configuration
{
    /// <summary>
    /// Represents a configuration element containing a collection of SweServiceRequest elements.
    /// </summary>
    public sealed class ConfigurationCollection<T> : ConfigurationElementCollection, ICollection<T>, IEnumerator<T>
        where T : ConfigurationElement, IConfigurationElement, new()
    {
        private int _index = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ConfigurationCollection"/> class.
        /// </summary>
        public ConfigurationCollection()
        {
            this._index = -1;
        }

        private ServiceConfiguration _serviceConfiguration;
        /// <summary>
        /// Gets or sets the service configuration.
        /// </summary>
        /// <value>The service configuration.</value>
        public ServiceConfiguration ServiceConfiguration
        {
            get
            {
                return this._serviceConfiguration;
            }
            set
            {
                this._serviceConfiguration = value;
                foreach (IConfigurationElement element in this)
                {
                    element.ServiceConfiguration = value;
                }
            }
        }

        #region ICollection<T> Members

        /// <summary>
        /// Adds a configuration element to the <see cref="T:ConfigurationCollection"/>.
        /// </summary>
        /// <param name="item">An item to add</param>
        public void Add(T item)
        {
            this.BaseAdd(item);
        }

        /// <summary>
        /// Removes all configuration element objects from the collection.
        /// </summary>
        /// <exception cref="System.Configuration.ConfigurationErrorsException">The configuration is read-only.  - or - A collection item has been locked in a higher-level configuration.</exception>
        public void Clear()
        {
            this.BaseClear();
        }

        /// <summary>
        /// Determines whether an element is in the <see cref="T:ConfigurationCollection"/>.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:ConfigurationCollection"/>. The value can be null for reference types.</param>
        /// <returns>true if item is found in the <see cref="T:ConfigurationCollection"/>; otherwise, false.</returns>
        public bool Contains(T item)
        {
            return (!(this.BaseGet(item) == null));
        }

        /// <summary>
        /// Copies the contents of the <see cref="T:ConfigurationCollection"/> to an array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            base.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:ConfigurationCollection"/> object is read only.
        /// </summary>
        public new bool IsReadOnly
        {
            get { return base.IsReadOnly(); }
        }

        /// <summary>
        /// Removes a <see cref="T:ConfigurationCollection"/> from the collection.
        /// </summary>
        /// <param name="item">An item to remove</param>
        /// <returns>true if the object has been removed; otherwise, false. The default is false.</returns>
        public bool Remove(T item)
        {
            this.BaseRemove(item);

            return this.BaseIsRemoved(item);
        }

        #endregion

        #region IEnumerable<T> Members

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="T:ConfigurationCollection"/>.
        /// </summary>
        /// <returns></returns>
        public new IEnumerator<T> GetEnumerator()
        {
            this._index = -1;
            return this;
        }

        #endregion

        #region IEnumerator<T> Members

        /// <summary>
        /// Gets the element in the collection at the current position of the enumerator.
        /// </summary>
        public T Current
        {
            get
            {
                if ((this._index < 0) || (this._index == this.Count))
                {
                    throw new InvalidOperationException();
                }

                return this.BaseGet(this._index) as T;
            }
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }

        #endregion

        #region IEnumerator Members

        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        /// <exception cref="InvalidOperationException">The enumerator is positioned before the first element of the collection or after the last element.</exception>
        object System.Collections.IEnumerator.Current
        {
            get
            {
                if ((this._index < 0) || (this._index == this.Count))
                {
                    throw new InvalidOperationException();
                }

                return this.BaseGet(this._index);
            }
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.</returns>
        public bool MoveNext()
        {
            if (this._index < this.Count)
            {
                this._index++;
            }

            return (!(this._index == this.Count));
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection.
        /// </summary>
        public void Reset()
        {
            this._index = -1;
        }

        #endregion

        /// <summary>
        /// Creates a new <see cref="ConfigurationElement"/>.
        /// </summary>
        /// <returns></returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new T();
        }

        /// <summary>
        /// Gets the element key for a specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns></returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((T)element).Name;
        }
    }
}
