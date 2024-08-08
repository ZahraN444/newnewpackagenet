using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<Letter>),
        new Type[] {
            typeof(NoExtraServiceCase),
            typeof(RegisteredCase),
            typeof(CertifiedCase)
        },
        true
    )]
    public abstract class Letter
    {
        /// <summary>
        /// This is no_extra_service case.
        /// </summary>
        /// <returns>
        /// The Letter instance, wrapping the provided NoExtraService value.
        /// </returns>
        public static Letter FromNoExtraService(NoExtraService noExtraService)
        {
            return new NoExtraServiceCase().Set(noExtraService);
        }

        /// <summary>
        /// This is registered case.
        /// </summary>
        /// <returns>
        /// The Letter instance, wrapping the provided Registered value.
        /// </returns>
        public static Letter FromRegistered(Registered registered)
        {
            return new RegisteredCase().Set(registered);
        }

        /// <summary>
        /// This is certified case.
        /// </summary>
        /// <returns>
        /// The Letter instance, wrapping the provided Certified value.
        /// </returns>
        public static Letter FromCertified(Certified certified)
        {
            return new CertifiedCase().Set(certified);
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
            Func<NoExtraService, T> noExtraService,
            Func<Registered, T> registered,
            Func<Certified, T> certified);

        [JsonConverter(typeof(UnionTypeCaseConverter<NoExtraServiceCase, NoExtraService>))]
        private sealed class NoExtraServiceCase : Letter, ICaseValue<NoExtraServiceCase, NoExtraService>
        {
            public NoExtraService _value;

            public override T Match<T>(
                Func<NoExtraService, T> noExtraService,
                Func<Registered, T> registered,
                Func<Certified, T> certified)
            {
                return noExtraService(_value);
            }

            public NoExtraServiceCase Set(NoExtraService value)
            {
                _value = value;
                return this;
            }

            public NoExtraService Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RegisteredCase, Registered>))]
        private sealed class RegisteredCase : Letter, ICaseValue<RegisteredCase, Registered>
        {
            public Registered _value;

            public override T Match<T>(
                Func<NoExtraService, T> noExtraService,
                Func<Registered, T> registered,
                Func<Certified, T> certified)
            {
                return registered(_value);
            }

            public RegisteredCase Set(Registered value)
            {
                _value = value;
                return this;
            }

            public Registered Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CertifiedCase, Certified>))]
        private sealed class CertifiedCase : Letter, ICaseValue<CertifiedCase, Certified>
        {
            public Certified _value;

            public override T Match<T>(
                Func<NoExtraService, T> noExtraService,
                Func<Registered, T> registered,
                Func<Certified, T> certified)
            {
                return certified(_value);
            }

            public CertifiedCase Set(Certified value)
            {
                _value = value;
                return this;
            }

            public Certified Get()
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