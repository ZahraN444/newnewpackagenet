using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<UsVerificationsAddresses>),
        new Type[] {
            typeof(UsVerificationCase),
            typeof(ErrorCase)
        },
        true
    )]
    public abstract class UsVerificationsAddresses
    {
        /// <summary>
        /// This is us_verification case.
        /// </summary>
        /// <returns>
        /// The UsVerificationsAddresses instance, wrapping the provided UsVerification value.
        /// </returns>
        public static UsVerificationsAddresses FromUsVerification(UsVerification usVerification)
        {
            return new UsVerificationCase().Set(usVerification);
        }

        /// <summary>
        /// This is error case.
        /// </summary>
        /// <returns>
        /// The UsVerificationsAddresses instance, wrapping the provided Error value.
        /// </returns>
        public static UsVerificationsAddresses FromError(Error error)
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
        public abstract T Match<T>(Func<UsVerification, T> usVerification, Func<Error, T> error);

        [JsonConverter(typeof(UnionTypeCaseConverter<UsVerificationCase, UsVerification>))]
        private sealed class UsVerificationCase : UsVerificationsAddresses, ICaseValue<UsVerificationCase, UsVerification>
        {
            public UsVerification _value;

            public override T Match<T>(Func<UsVerification, T> usVerification, Func<Error, T> error)
            {
                return usVerification(_value);
            }

            public UsVerificationCase Set(UsVerification value)
            {
                _value = value;
                return this;
            }

            public UsVerification Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ErrorCase, Error>))]
        private sealed class ErrorCase : UsVerificationsAddresses, ICaseValue<ErrorCase, Error>
        {
            public Error _value;

            public override T Match<T>(Func<UsVerification, T> usVerification, Func<Error, T> error)
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