// <copyright file="XLangOutput1Enum.cs" company="APIMatic">
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
    /// XLangOutput1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum XLangOutput1Enum
    {
        /// <summary>
        /// Native.
        /// </summary>
        [EnumMember(Value = "native")]
        Native,

        /// <summary>
        /// Match.
        /// </summary>
        [EnumMember(Value = "match")]
        Match
    }
}