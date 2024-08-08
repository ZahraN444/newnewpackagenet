// <copyright file="Type1Enum.cs" company="APIMatic">
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
    /// Type1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type1Enum
    {
        /// <summary>
        /// All.
        /// </summary>
        [EnumMember(Value = "all")]
        All,

        /// <summary>
        /// Failures.
        /// </summary>
        [EnumMember(Value = "failures")]
        Failures,

        /// <summary>
        /// Successes.
        /// </summary>
        [EnumMember(Value = "successes")]
        Successes
    }
}