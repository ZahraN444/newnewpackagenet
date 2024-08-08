using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<EventTypeId>),
        new Type[] {
            typeof(PostcardTypesCase),
            typeof(SelfMailerTypesCase),
            typeof(LetterTypesCase),
            typeof(CheckTypesCase),
            typeof(AddressTypesCase),
            typeof(BankAccountTypesCase)
        },
        true
    )]
    public abstract class EventTypeId
    {
        /// <summary>
        /// This is postcard_types case.
        /// </summary>
        /// <returns>
        /// The EventTypeId instance, wrapping the provided PostcardTypesEnum value.
        /// </returns>
        public static EventTypeId FromPostcardTypes(PostcardTypesEnum postcardTypes)
        {
            return new PostcardTypesCase().Set(postcardTypes);
        }

        /// <summary>
        /// This is self_mailer_types case.
        /// </summary>
        /// <returns>
        /// The EventTypeId instance, wrapping the provided SelfMailerTypesEnum value.
        /// </returns>
        public static EventTypeId FromSelfMailerTypes(SelfMailerTypesEnum selfMailerTypes)
        {
            return new SelfMailerTypesCase().Set(selfMailerTypes);
        }

        /// <summary>
        /// This is letter_types case.
        /// </summary>
        /// <returns>
        /// The EventTypeId instance, wrapping the provided LetterTypesEnum value.
        /// </returns>
        public static EventTypeId FromLetterTypes(LetterTypesEnum letterTypes)
        {
            return new LetterTypesCase().Set(letterTypes);
        }

        /// <summary>
        /// This is check_types case.
        /// </summary>
        /// <returns>
        /// The EventTypeId instance, wrapping the provided CheckTypesEnum value.
        /// </returns>
        public static EventTypeId FromCheckTypes(CheckTypesEnum checkTypes)
        {
            return new CheckTypesCase().Set(checkTypes);
        }

        /// <summary>
        /// This is address_types case.
        /// </summary>
        /// <returns>
        /// The EventTypeId instance, wrapping the provided AddressTypesEnum value.
        /// </returns>
        public static EventTypeId FromAddressTypes(AddressTypesEnum addressTypes)
        {
            return new AddressTypesCase().Set(addressTypes);
        }

        /// <summary>
        /// This is bank_account_types case.
        /// </summary>
        /// <returns>
        /// The EventTypeId instance, wrapping the provided BankAccountTypesEnum value.
        /// </returns>
        public static EventTypeId FromBankAccountTypes(BankAccountTypesEnum bankAccountTypes)
        {
            return new BankAccountTypesCase().Set(bankAccountTypes);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<PostcardTypesEnum, T> postcardTypes,
            Func<SelfMailerTypesEnum, T> selfMailerTypes,
            Func<LetterTypesEnum, T> letterTypes,
            Func<CheckTypesEnum, T> checkTypes,
            Func<AddressTypesEnum, T> addressTypes,
            Func<BankAccountTypesEnum, T> bankAccountTypes);

        [JsonConverter(typeof(UnionTypeCaseConverter<PostcardTypesCase, PostcardTypesEnum>))]
        private sealed class PostcardTypesCase : EventTypeId, ICaseValue<PostcardTypesCase, PostcardTypesEnum>
        {
            public PostcardTypesEnum _value;

            public override T Match<T>(
                Func<PostcardTypesEnum, T> postcardTypes,
                Func<SelfMailerTypesEnum, T> selfMailerTypes,
                Func<LetterTypesEnum, T> letterTypes,
                Func<CheckTypesEnum, T> checkTypes,
                Func<AddressTypesEnum, T> addressTypes,
                Func<BankAccountTypesEnum, T> bankAccountTypes)
            {
                return postcardTypes(_value);
            }

            public PostcardTypesCase Set(PostcardTypesEnum value)
            {
                _value = value;
                return this;
            }

            public PostcardTypesEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SelfMailerTypesCase, SelfMailerTypesEnum>))]
        private sealed class SelfMailerTypesCase : EventTypeId, ICaseValue<SelfMailerTypesCase, SelfMailerTypesEnum>
        {
            public SelfMailerTypesEnum _value;

            public override T Match<T>(
                Func<PostcardTypesEnum, T> postcardTypes,
                Func<SelfMailerTypesEnum, T> selfMailerTypes,
                Func<LetterTypesEnum, T> letterTypes,
                Func<CheckTypesEnum, T> checkTypes,
                Func<AddressTypesEnum, T> addressTypes,
                Func<BankAccountTypesEnum, T> bankAccountTypes)
            {
                return selfMailerTypes(_value);
            }

            public SelfMailerTypesCase Set(SelfMailerTypesEnum value)
            {
                _value = value;
                return this;
            }

            public SelfMailerTypesEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<LetterTypesCase, LetterTypesEnum>))]
        private sealed class LetterTypesCase : EventTypeId, ICaseValue<LetterTypesCase, LetterTypesEnum>
        {
            public LetterTypesEnum _value;

            public override T Match<T>(
                Func<PostcardTypesEnum, T> postcardTypes,
                Func<SelfMailerTypesEnum, T> selfMailerTypes,
                Func<LetterTypesEnum, T> letterTypes,
                Func<CheckTypesEnum, T> checkTypes,
                Func<AddressTypesEnum, T> addressTypes,
                Func<BankAccountTypesEnum, T> bankAccountTypes)
            {
                return letterTypes(_value);
            }

            public LetterTypesCase Set(LetterTypesEnum value)
            {
                _value = value;
                return this;
            }

            public LetterTypesEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CheckTypesCase, CheckTypesEnum>))]
        private sealed class CheckTypesCase : EventTypeId, ICaseValue<CheckTypesCase, CheckTypesEnum>
        {
            public CheckTypesEnum _value;

            public override T Match<T>(
                Func<PostcardTypesEnum, T> postcardTypes,
                Func<SelfMailerTypesEnum, T> selfMailerTypes,
                Func<LetterTypesEnum, T> letterTypes,
                Func<CheckTypesEnum, T> checkTypes,
                Func<AddressTypesEnum, T> addressTypes,
                Func<BankAccountTypesEnum, T> bankAccountTypes)
            {
                return checkTypes(_value);
            }

            public CheckTypesCase Set(CheckTypesEnum value)
            {
                _value = value;
                return this;
            }

            public CheckTypesEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AddressTypesCase, AddressTypesEnum>))]
        private sealed class AddressTypesCase : EventTypeId, ICaseValue<AddressTypesCase, AddressTypesEnum>
        {
            public AddressTypesEnum _value;

            public override T Match<T>(
                Func<PostcardTypesEnum, T> postcardTypes,
                Func<SelfMailerTypesEnum, T> selfMailerTypes,
                Func<LetterTypesEnum, T> letterTypes,
                Func<CheckTypesEnum, T> checkTypes,
                Func<AddressTypesEnum, T> addressTypes,
                Func<BankAccountTypesEnum, T> bankAccountTypes)
            {
                return addressTypes(_value);
            }

            public AddressTypesCase Set(AddressTypesEnum value)
            {
                _value = value;
                return this;
            }

            public AddressTypesEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BankAccountTypesCase, BankAccountTypesEnum>))]
        private sealed class BankAccountTypesCase : EventTypeId, ICaseValue<BankAccountTypesCase, BankAccountTypesEnum>
        {
            public BankAccountTypesEnum _value;

            public override T Match<T>(
                Func<PostcardTypesEnum, T> postcardTypes,
                Func<SelfMailerTypesEnum, T> selfMailerTypes,
                Func<LetterTypesEnum, T> letterTypes,
                Func<CheckTypesEnum, T> checkTypes,
                Func<AddressTypesEnum, T> addressTypes,
                Func<BankAccountTypesEnum, T> bankAccountTypes)
            {
                return bankAccountTypes(_value);
            }

            public BankAccountTypesCase Set(BankAccountTypesEnum value)
            {
                _value = value;
                return this;
            }

            public BankAccountTypesEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }
    }
}