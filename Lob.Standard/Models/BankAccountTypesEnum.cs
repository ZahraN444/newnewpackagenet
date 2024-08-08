// <copyright file="BankAccountTypesEnum.cs" company="APIMatic">
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
    /// BankAccountTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountTypesEnum
    {
        /// <summary>
        /// EnumBankAccountcreated.
        /// </summary>
        [EnumMember(Value = "bank_account.created")]
        EnumBankAccountcreated,

        /// <summary>
        /// EnumBankAccountdeleted.
        /// </summary>
        [EnumMember(Value = "bank_account.deleted")]
        EnumBankAccountdeleted,

        /// <summary>
        /// EnumBankAccountverified.
        /// </summary>
        [EnumMember(Value = "bank_account.verified")]
        EnumBankAccountverified
    }
}