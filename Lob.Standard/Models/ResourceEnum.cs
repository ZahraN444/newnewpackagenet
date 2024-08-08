// <copyright file="ResourceEnum.cs" company="APIMatic">
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
    /// ResourceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceEnum
    {
        /// <summary>
        /// Postcards.
        /// </summary>
        [EnumMember(Value = "postcards")]
        Postcards,

        /// <summary>
        /// EnumSelfMailers.
        /// </summary>
        [EnumMember(Value = "self mailers")]
        EnumSelfMailers,

        /// <summary>
        /// Letters.
        /// </summary>
        [EnumMember(Value = "letters")]
        Letters,

        /// <summary>
        /// Checks.
        /// </summary>
        [EnumMember(Value = "checks")]
        Checks,

        /// <summary>
        /// Addresses.
        /// </summary>
        [EnumMember(Value = "addresses")]
        Addresses,

        /// <summary>
        /// EnumBankAccounts.
        /// </summary>
        [EnumMember(Value = "bank accounts")]
        EnumBankAccounts
    }
}