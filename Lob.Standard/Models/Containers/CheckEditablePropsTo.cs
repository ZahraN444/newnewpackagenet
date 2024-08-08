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
        typeof(UnionTypeConverter<CheckEditablePropsTo>),
        new Type[] {
            typeof(MStringCase),
            typeof(Case1)
        },
        true
    )]
    public abstract class CheckEditablePropsTo
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The CheckEditablePropsTo instance, wrapping the provided string value.
        /// </returns>
        public static CheckEditablePropsTo FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is inline_address_us_chk11 case.
        /// </summary>
        /// <returns>
        /// The CheckEditablePropsTo instance, wrapping the provided InlineAddressUsChk11 value.
        /// </returns>
        public static CheckEditablePropsTo FromInlineAddressUsChk11(InlineAddressUsChk11 inlineAddressUsChk11)
        {
            return new Case1().Set(inlineAddressUsChk11);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<string, T> mString, Func<InlineAddressUsChk11, T> inlineAddressUsChk11);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : CheckEditablePropsTo, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<string, T> mString, Func<InlineAddressUsChk11, T> inlineAddressUsChk11)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<Case1, InlineAddressUsChk11>))]
        private sealed class Case1 : CheckEditablePropsTo, ICaseValue<Case1, InlineAddressUsChk11>
        {
            public InlineAddressUsChk11 _value;

            public override T Match<T>(Func<string, T> mString, Func<InlineAddressUsChk11, T> inlineAddressUsChk11)
            {
                return inlineAddressUsChk11(_value);
            }

            public Case1 Set(InlineAddressUsChk11 value)
            {
                _value = value;
                return this;
            }

            public InlineAddressUsChk11 Get()
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