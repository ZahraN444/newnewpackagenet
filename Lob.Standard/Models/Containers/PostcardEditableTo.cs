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
        typeof(UnionTypeConverter<PostcardEditableTo>),
        new Type[] {
            typeof(MStringCase),
            typeof(Case1)
        },
        true
    )]
    public abstract class PostcardEditableTo
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The PostcardEditableTo instance, wrapping the provided string value.
        /// </returns>
        public static PostcardEditableTo FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is inline_address case.
        /// </summary>
        /// <returns>
        /// The PostcardEditableTo instance, wrapping the provided InlineAddress value.
        /// </returns>
        public static PostcardEditableTo FromInlineAddress(InlineAddress inlineAddress)
        {
            return new Case1().Set(inlineAddress);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString, Func<InlineAddress, T> inlineAddress);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : PostcardEditableTo, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<string, T> mString, Func<InlineAddress, T> inlineAddress)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<Case1, InlineAddress>))]
        private sealed class Case1 : PostcardEditableTo, ICaseValue<Case1, InlineAddress>
        {
            public InlineAddress _value;

            public override T Match<T>(Func<string, T> mString, Func<InlineAddress, T> inlineAddress)
            {
                return inlineAddress(_value);
            }

            public Case1 Set(InlineAddress value)
            {
                _value = value;
                return this;
            }

            public InlineAddress Get()
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