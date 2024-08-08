using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<Address>),
        new Type[] {
            typeof(AddressUsCase),
            typeof(AddressIntlCase)
        },
        true
    )]
    public abstract class Address
    {
        /// <summary>
        /// This is address_us case.
        /// </summary>
        /// <returns>
        /// The Address instance, wrapping the provided AddressUs value.
        /// </returns>
        public static Address FromAddressUs(AddressUs addressUs)
        {
            return new AddressUsCase().Set(addressUs);
        }

        /// <summary>
        /// This is address_intl case.
        /// </summary>
        /// <returns>
        /// The Address instance, wrapping the provided AddressIntl value.
        /// </returns>
        public static Address FromAddressIntl(AddressIntl addressIntl)
        {
            return new AddressIntlCase().Set(addressIntl);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<AddressUs, T> addressUs, Func<AddressIntl, T> addressIntl);

        [JsonConverter(typeof(UnionTypeCaseConverter<AddressUsCase, AddressUs>))]
        private sealed class AddressUsCase : Address, ICaseValue<AddressUsCase, AddressUs>
        {
            public AddressUs _value;

            public override T Match<T>(Func<AddressUs, T> addressUs, Func<AddressIntl, T> addressIntl)
            {
                return addressUs(_value);
            }

            public AddressUsCase Set(AddressUs value)
            {
                _value = value;
                return this;
            }

            public AddressUs Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AddressIntlCase, AddressIntl>))]
        private sealed class AddressIntlCase : Address, ICaseValue<AddressIntlCase, AddressIntl>
        {
            public AddressIntl _value;

            public override T Match<T>(Func<AddressUs, T> addressUs, Func<AddressIntl, T> addressIntl)
            {
                return addressIntl(_value);
            }

            public AddressIntlCase Set(AddressIntl value)
            {
                _value = value;
                return this;
            }

            public AddressIntl Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}