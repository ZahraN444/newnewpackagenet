// <copyright file="Size1Enum.cs" company="APIMatic">
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
    /// Size1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Size1Enum
    {
        /// <summary>
        /// Enum3375x2125.
        /// </summary>
        [EnumMember(Value = "3.375x2.125")]
        Enum3375x2125,

        /// <summary>
        /// Enum2125x3375.
        /// </summary>
        [EnumMember(Value = "2.125x3.375")]
        Enum2125x3375
    }
}