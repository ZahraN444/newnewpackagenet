// <copyright file="Status31Enum.cs" company="APIMatic">
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
    /// Status31Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status31Enum
    {
        /// <summary>
        /// Validated.
        /// </summary>
        [EnumMember(Value = "Validated")]
        Validated,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Processing.
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing
    }
}