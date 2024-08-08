using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace Lob.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<IdentityValidation>),
        new Type[] {
            typeof(RecipientValidationCase),
            typeof(CompanyValidationCase)
        },
        true
    )]
    public abstract class IdentityValidation
    {
        /// <summary>
        /// This is recipient_validation case.
        /// </summary>
        /// <returns>
        /// The IdentityValidation instance, wrapping the provided RecipientValidation value.
        /// </returns>
        public static IdentityValidation FromRecipientValidation(RecipientValidation recipientValidation)
        {
            return new RecipientValidationCase().Set(recipientValidation);
        }

        /// <summary>
        /// This is company_validation case.
        /// </summary>
        /// <returns>
        /// The IdentityValidation instance, wrapping the provided CompanyValidation value.
        /// </returns>
        public static IdentityValidation FromCompanyValidation(CompanyValidation companyValidation)
        {
            return new CompanyValidationCase().Set(companyValidation);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RecipientValidation, T> recipientValidation, Func<CompanyValidation, T> companyValidation);

        [JsonConverter(typeof(UnionTypeCaseConverter<RecipientValidationCase, RecipientValidation>))]
        private sealed class RecipientValidationCase : IdentityValidation, ICaseValue<RecipientValidationCase, RecipientValidation>
        {
            public RecipientValidation _value;

            public override T Match<T>(Func<RecipientValidation, T> recipientValidation, Func<CompanyValidation, T> companyValidation)
            {
                return recipientValidation(_value);
            }

            public RecipientValidationCase Set(RecipientValidation value)
            {
                _value = value;
                return this;
            }

            public RecipientValidation Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CompanyValidationCase, CompanyValidation>))]
        private sealed class CompanyValidationCase : IdentityValidation, ICaseValue<CompanyValidationCase, CompanyValidation>
        {
            public CompanyValidation _value;

            public override T Match<T>(Func<RecipientValidation, T> recipientValidation, Func<CompanyValidation, T> companyValidation)
            {
                return companyValidation(_value);
            }

            public CompanyValidationCase Set(CompanyValidation value)
            {
                _value = value;
                return this;
            }

            public CompanyValidation Get()
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