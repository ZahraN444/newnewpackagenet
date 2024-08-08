// <copyright file="Status1Enum.cs" company="APIMatic">
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
    /// Status1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status1Enum
    {
        /// <summary>
        /// LV4.
        /// </summary>
        [EnumMember(Value = "LV4")]
        LV4,

        /// <summary>
        /// LV3.
        /// </summary>
        [EnumMember(Value = "LV3")]
        LV3,

        /// <summary>
        /// LV2.
        /// </summary>
        [EnumMember(Value = "LV2")]
        LV2,

        /// <summary>
        /// LV1.
        /// </summary>
        [EnumMember(Value = "LV1")]
        LV1,

        /// <summary>
        /// LF4.
        /// </summary>
        [EnumMember(Value = "LF4")]
        LF4,

        /// <summary>
        /// LF3.
        /// </summary>
        [EnumMember(Value = "LF3")]
        LF3,

        /// <summary>
        /// LF2.
        /// </summary>
        [EnumMember(Value = "LF2")]
        LF2,

        /// <summary>
        /// LF1.
        /// </summary>
        [EnumMember(Value = "LF1")]
        LF1,

        /// <summary>
        /// LM4.
        /// </summary>
        [EnumMember(Value = "LM4")]
        LM4,

        /// <summary>
        /// LM3.
        /// </summary>
        [EnumMember(Value = "LM3")]
        LM3,

        /// <summary>
        /// LM2.
        /// </summary>
        [EnumMember(Value = "LM2")]
        LM2,

        /// <summary>
        /// LU1.
        /// </summary>
        [EnumMember(Value = "LU1")]
        LU1
    }
}