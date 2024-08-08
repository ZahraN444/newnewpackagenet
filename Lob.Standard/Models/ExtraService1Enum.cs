// <copyright file="ExtraService1Enum.cs" company="APIMatic">
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
    /// ExtraService1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtraService1Enum
    {
        /// <summary>
        /// Certified.
        /// </summary>
        [EnumMember(Value = "certified")]
        Certified,

        /// <summary>
        /// CertifiedReturnReceipt.
        /// </summary>
        [EnumMember(Value = "certified_return_receipt")]
        CertifiedReturnReceipt
    }
}