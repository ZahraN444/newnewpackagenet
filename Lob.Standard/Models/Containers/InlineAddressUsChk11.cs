using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InlineAddressUsChk11>),
        new Type[] {
            typeof(AddressobjwithnamedefinedCase),
            typeof(AddressobjwithcompanydefinedCase)
        },
        false
    )]
    public abstract class InlineAddressUsChk11
    {
        /// <summary>
        /// This is addressobjwithnamedefined case.
        /// </summary>
        /// <returns>
        /// The InlineAddressUsChk11 instance, wrapping the provided Addressobjwithnamedefined value.
        /// </returns>
        public static InlineAddressUsChk11 FromAddressobjwithnamedefined(Addressobjwithnamedefined addressobjwithnamedefined)
        {
            return new AddressobjwithnamedefinedCase().Set(addressobjwithnamedefined);
        }

        /// <summary>
        /// This is addressobjwithcompanydefined case.
        /// </summary>
        /// <returns>
        /// The InlineAddressUsChk11 instance, wrapping the provided Addressobjwithcompanydefined value.
        /// </returns>
        public static InlineAddressUsChk11 FromAddressobjwithcompanydefined(Addressobjwithcompanydefined addressobjwithcompanydefined)
        {
            return new AddressobjwithcompanydefinedCase().Set(addressobjwithcompanydefined);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<Addressobjwithnamedefined, T> addressobjwithnamedefined, Func<Addressobjwithcompanydefined, T> addressobjwithcompanydefined);

        [JsonConverter(typeof(UnionTypeCaseConverter<AddressobjwithnamedefinedCase, Addressobjwithnamedefined>))]
        private sealed class AddressobjwithnamedefinedCase : InlineAddressUsChk11, ICaseValue<AddressobjwithnamedefinedCase, Addressobjwithnamedefined>
        {
            public Addressobjwithnamedefined _value;

            public override T Match<T>(Func<Addressobjwithnamedefined, T> addressobjwithnamedefined, Func<Addressobjwithcompanydefined, T> addressobjwithcompanydefined)
            {
                return addressobjwithnamedefined(_value);
            }

            public AddressobjwithnamedefinedCase Set(Addressobjwithnamedefined value)
            {
                _value = value;
                return this;
            }

            public Addressobjwithnamedefined Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AddressobjwithcompanydefinedCase, Addressobjwithcompanydefined>))]
        private sealed class AddressobjwithcompanydefinedCase : InlineAddressUsChk11, ICaseValue<AddressobjwithcompanydefinedCase, Addressobjwithcompanydefined>
        {
            public Addressobjwithcompanydefined _value;

            public override T Match<T>(Func<Addressobjwithnamedefined, T> addressobjwithnamedefined, Func<Addressobjwithcompanydefined, T> addressobjwithcompanydefined)
            {
                return addressobjwithcompanydefined(_value);
            }

            public AddressobjwithcompanydefinedCase Set(Addressobjwithcompanydefined value)
            {
                _value = value;
                return this;
            }

            public Addressobjwithcompanydefined Get()
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