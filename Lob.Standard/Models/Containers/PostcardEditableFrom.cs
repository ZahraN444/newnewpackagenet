using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<PostcardEditableFrom>),
        new Type[] {
            typeof(MStringCase),
            typeof(InlineAddressUsCase)
        },
        true
    )]
    public abstract class PostcardEditableFrom
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The PostcardEditableFrom instance, wrapping the provided string value.
        /// </returns>
        public static PostcardEditableFrom FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is inline_address_us case.
        /// </summary>
        /// <returns>
        /// The PostcardEditableFrom instance, wrapping the provided InlineAddressUs value.
        /// </returns>
        public static PostcardEditableFrom FromInlineAddressUs(InlineAddressUs inlineAddressUs)
        {
            return new InlineAddressUsCase().Set(inlineAddressUs);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString, Func<InlineAddressUs, T> inlineAddressUs);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : PostcardEditableFrom, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<string, T> mString, Func<InlineAddressUs, T> inlineAddressUs)
            {
                return mString(_value);
            }

            public MStringCase Set(string value)
            {
                _value = value;
                return this;
            }

            public string Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<InlineAddressUsCase, InlineAddressUs>))]
        private sealed class InlineAddressUsCase : PostcardEditableFrom, ICaseValue<InlineAddressUsCase, InlineAddressUs>
        {
            public InlineAddressUs _value;

            public override T Match<T>(Func<string, T> mString, Func<InlineAddressUs, T> inlineAddressUs)
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
    }
}