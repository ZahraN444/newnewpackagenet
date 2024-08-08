using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InlineAddress>),
        new Type[] {
            typeof(InlineAddressUsCase),
            typeof(InlineAddressIntlCase)
        },
        true
    )]
    public abstract class InlineAddress
    {
        /// <summary>
        /// This is inline_address_us case.
        /// </summary>
        /// <returns>
        /// The InlineAddress instance, wrapping the provided InlineAddressUs value.
        /// </returns>
        public static InlineAddress FromInlineAddressUs(InlineAddressUs inlineAddressUs)
        {
            return new InlineAddressUsCase().Set(inlineAddressUs);
        }

        /// <summary>
        /// This is inline_address_intl case.
        /// </summary>
        /// <returns>
        /// The InlineAddress instance, wrapping the provided InlineAddressIntl value.
        /// </returns>
        public static InlineAddress FromInlineAddressIntl(InlineAddressIntl inlineAddressIntl)
        {
            return new InlineAddressIntlCase().Set(inlineAddressIntl);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<InlineAddressUs, T> inlineAddressUs, Func<InlineAddressIntl, T> inlineAddressIntl);

        [JsonConverter(typeof(UnionTypeCaseConverter<InlineAddressUsCase, InlineAddressUs>))]
        private sealed class InlineAddressUsCase : InlineAddress, ICaseValue<InlineAddressUsCase, InlineAddressUs>
        {
            public InlineAddressUs _value;

            public override T Match<T>(Func<InlineAddressUs, T> inlineAddressUs, Func<InlineAddressIntl, T> inlineAddressIntl)
            {
                return inlineAddressUs(_value);
            }

            public InlineAddressUsCase Set(InlineAddressUs value)
            {
                _value = value;
                return this;
            }

            public InlineAddressUs Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<InlineAddressIntlCase, InlineAddressIntl>))]
        private sealed class InlineAddressIntlCase : InlineAddress, ICaseValue<InlineAddressIntlCase, InlineAddressIntl>
        {
            public InlineAddressIntl _value;

            public override T Match<T>(Func<InlineAddressUs, T> inlineAddressUs, Func<InlineAddressIntl, T> inlineAddressIntl)
            {
                return inlineAddressIntl(_value);
            }

            public InlineAddressIntlCase Set(InlineAddressIntl value)
            {
                _value = value;
                return this;
            }

            public InlineAddressIntl Get()
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