// <copyright file="CodeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Lob.Standard;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// CodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CodeEnum
    {
        /// <summary>
        /// BadRequest.
        /// </summary>
        [EnumMember(Value = "bad_request")]
        BadRequest,

        /// <summary>
        /// Conflict.
        /// </summary>
        [EnumMember(Value = "conflict")]
        Conflict,

        /// <summary>
        /// FeatureLimitReached.
        /// </summary>
        [EnumMember(Value = "feature_limit_reached")]
        FeatureLimitReached,

        /// <summary>
        /// InternalServerError.
        /// </summary>
        [EnumMember(Value = "internal_server_error")]
        InternalServerError,

        /// <summary>
        /// Invalid.
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid,

        /// <summary>
        /// NotDeletable.
        /// </summary>
        [EnumMember(Value = "not_deletable")]
        NotDeletable,

        /// <summary>
        /// NotFound.
        /// </summary>
        [EnumMember(Value = "not_found")]
        NotFound,

        /// <summary>
        /// RequestTimeout.
        /// </summary>
        [EnumMember(Value = "request_timeout")]
        RequestTimeout,

        /// <summary>
        /// ServiceUnavailable.
        /// </summary>
        [EnumMember(Value = "service_unavailable")]
        ServiceUnavailable,

        /// <summary>
        /// UnrecognizedEndpoint.
        /// </summary>
        [EnumMember(Value = "unrecognized_endpoint")]
        UnrecognizedEndpoint,

        /// <summary>
        /// UnsupportedLobVersion.
        /// </summary>
        [EnumMember(Value = "unsupported_lob_version")]
        UnsupportedLobVersion,

        /// <summary>
        /// AddressLengthExceedsLimit.
        /// </summary>
        [EnumMember(Value = "address_length_exceeds_limit")]
        AddressLengthExceedsLimit,

        /// <summary>
        /// BankAccountAlreadyVerified.
        /// </summary>
        [EnumMember(Value = "bank_account_already_verified")]
        BankAccountAlreadyVerified,

        /// <summary>
        /// BankError.
        /// </summary>
        [EnumMember(Value = "bank_error")]
        BankError,

        /// <summary>
        /// BillingAddressRequired.
        /// </summary>
        [EnumMember(Value = "billing_address_required")]
        BillingAddressRequired,

        /// <summary>
        /// CustomEnvelopeInventoryDepleted.
        /// </summary>
        [EnumMember(Value = "custom_envelope_inventory_depleted")]
        CustomEnvelopeInventoryDepleted,

        /// <summary>
        /// DeletedBankAccount.
        /// </summary>
        [EnumMember(Value = "deleted_bank_account")]
        DeletedBankAccount,

        /// <summary>
        /// FailedDeliverabilityStrictness.
        /// </summary>
        [EnumMember(Value = "failed_deliverability_strictness")]
        FailedDeliverabilityStrictness,

        /// <summary>
        /// FilePagesBelowMin.
        /// </summary>
        [EnumMember(Value = "file_pages_below_min")]
        FilePagesBelowMin,

        /// <summary>
        /// FilePagesExceedMax.
        /// </summary>
        [EnumMember(Value = "file_pages_exceed_max")]
        FilePagesExceedMax,

        /// <summary>
        /// FileSizeExceedsLimit.
        /// </summary>
        [EnumMember(Value = "file_size_exceeds_limit")]
        FileSizeExceedsLimit,

        /// <summary>
        /// ForeignReturnAddress.
        /// </summary>
        [EnumMember(Value = "foreign_return_address")]
        ForeignReturnAddress,

        /// <summary>
        /// InconsistentPageDimensions.
        /// </summary>
        [EnumMember(Value = "inconsistent_page_dimensions")]
        InconsistentPageDimensions,

        /// <summary>
        /// InvalidBankAccount.
        /// </summary>
        [EnumMember(Value = "invalid_bank_account")]
        InvalidBankAccount,

        /// <summary>
        /// InvalidBankAccountVerification.
        /// </summary>
        [EnumMember(Value = "invalid_bank_account_verification")]
        InvalidBankAccountVerification,

        /// <summary>
        /// InvalidCheckInternational.
        /// </summary>
        [EnumMember(Value = "invalid_check_international")]
        InvalidCheckInternational,

        /// <summary>
        /// InvalidCountryCovid.
        /// </summary>
        [EnumMember(Value = "invalid_country_covid")]
        InvalidCountryCovid,

        /// <summary>
        /// InvalidFile.
        /// </summary>
        [EnumMember(Value = "invalid_file")]
        InvalidFile,

        /// <summary>
        /// InvalidFileDimensions.
        /// </summary>
        [EnumMember(Value = "invalid_file_dimensions")]
        InvalidFileDimensions,

        /// <summary>
        /// InvalidFileDownloadTime.
        /// </summary>
        [EnumMember(Value = "invalid_file_download_time")]
        InvalidFileDownloadTime,

        /// <summary>
        /// InvalidFileUrl.
        /// </summary>
        [EnumMember(Value = "invalid_file_url")]
        InvalidFileUrl,

        /// <summary>
        /// InvalidImageDpi.
        /// </summary>
        [EnumMember(Value = "invalid_image_dpi")]
        InvalidImageDpi,

        /// <summary>
        /// InvalidInternationalFeature.
        /// </summary>
        [EnumMember(Value = "invalid_international_feature")]
        InvalidInternationalFeature,

        /// <summary>
        /// InvalidPerforationReturnEnvelope.
        /// </summary>
        [EnumMember(Value = "invalid_perforation_return_envelope")]
        InvalidPerforationReturnEnvelope,

        /// <summary>
        /// InvalidTemplateHtml.
        /// </summary>
        [EnumMember(Value = "invalid_template_html")]
        InvalidTemplateHtml,

        /// <summary>
        /// MailUseTypeCanNotBeNull.
        /// </summary>
        [EnumMember(Value = "mail_use_type_can_not_be_null")]
        MailUseTypeCanNotBeNull,

        /// <summary>
        /// MergeVariableRequired.
        /// </summary>
        [EnumMember(Value = "merge_variable_required")]
        MergeVariableRequired,

        /// <summary>
        /// MergeVariableWhitespace.
        /// </summary>
        [EnumMember(Value = "merge_variable_whitespace")]
        MergeVariableWhitespace,

        /// <summary>
        /// PaymentMethodUnverified.
        /// </summary>
        [EnumMember(Value = "payment_method_unverified")]
        PaymentMethodUnverified,

        /// <summary>
        /// PdfEncrypted.
        /// </summary>
        [EnumMember(Value = "pdf_encrypted")]
        PdfEncrypted,

        /// <summary>
        /// SpecialCharactersRestricted.
        /// </summary>
        [EnumMember(Value = "special_characters_restricted")]
        SpecialCharactersRestricted,

        /// <summary>
        /// UnembeddedFonts.
        /// </summary>
        [EnumMember(Value = "unembedded_fonts")]
        UnembeddedFonts,

        /// <summary>
        /// EmailRequired.
        /// </summary>
        [EnumMember(Value = "email_required")]
        EmailRequired,

        /// <summary>
        /// InvalidApiKey.
        /// </summary>
        [EnumMember(Value = "invalid_api_key")]
        InvalidApiKey,

        /// <summary>
        /// PublishableKeyNotAllowed.
        /// </summary>
        [EnumMember(Value = "publishable_key_not_allowed")]
        PublishableKeyNotAllowed,

        /// <summary>
        /// RateLimitExceeded.
        /// </summary>
        [EnumMember(Value = "rate_limit_exceeded")]
        RateLimitExceeded,

        /// <summary>
        /// Unauthorized.
        /// </summary>
        [EnumMember(Value = "unauthorized")]
        Unauthorized,

        /// <summary>
        /// UnauthorizedToken.
        /// </summary>
        [EnumMember(Value = "unauthorized_token")]
        UnauthorizedToken
    }
}