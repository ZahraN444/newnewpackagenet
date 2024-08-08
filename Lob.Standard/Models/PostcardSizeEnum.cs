// <copyright file="PostcardSizeEnum.cs" company="APIMatic">
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
    /// PostcardSizeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PostcardSizeEnum
    {
        /// <summary>
        /// Enum4x6.
        /// </summary>
        [EnumMember(Value = "4x6")]
        Enum4x6,

        /// <summary>
        /// Enum6x9.
        /// </summary>
        [EnumMember(Value = "6x9")]
        Enum6x9,

        /// <summary>
        /// Enum6x11.
        /// </summary>
        [EnumMember(Value = "6x11")]
        Enum6x11
    }
}