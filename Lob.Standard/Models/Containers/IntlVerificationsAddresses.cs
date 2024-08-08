using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<IntlVerificationsAddresses>),
        new Type[] {
            typeof(IntlVerificationCase),
            typeof(ErrorCase)
        },
        true
    )]
    public abstract class IntlVerificationsAddresses
    {
        /// <summary>
        /// This is intl_verification case.
        /// </summary>
        /// <returns>
        /// The IntlVerificationsAddresses instance, wrapping the provided IntlVerification value.
        /// </returns>
        public static IntlVerificationsAddresses FromIntlVerification(IntlVerification intlVerification)
        {
            return new IntlVerificationCase().Set(intlVerification);
        }

        /// <summary>
        /// This is error case.
        /// </summary>
        /// <returns>
        /// The IntlVerificationsAddresses instance, wrapping the provided Error value.
        /// </returns>
        public static IntlVerificationsAddresses FromError(Error error)
        {
            return new ErrorCase().Set(error);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<IntlVerification, T> intlVerification, Func<Error, T> error);

        [JsonConverter(typeof(UnionTypeCaseConverter<IntlVerificationCase, IntlVerification>))]
        private sealed class IntlVerificationCase : IntlVerificationsAddresses, ICaseValue<IntlVerificationCase, IntlVerification>
        {
            public IntlVerification _value;

            public override T Match<T>(Func<IntlVerification, T> intlVerification, Func<Error, T> error)
            {
                return intlVerification(_value);
            }

            public IntlVerificationCase Set(IntlVerification value)
            {
                _value = value;
                return this;
            }

            public IntlVerification Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ErrorCase, Error>))]
        private sealed class ErrorCase : IntlVerificationsAddresses, ICaseValue<ErrorCase, Error>
        {
            public Error _value;

            public override T Match<T>(Func<IntlVerification, T> intlVerification, Func<Error, T> error)
            {
                return error(_value);
            }

            public ErrorCase Set(Error value)
            {
                _value = value;
                return this;
            }

            public Error Get()
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