// <copyright file="ConfidenceEnum.cs" company="APIMatic">
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
    /// ConfidenceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfidenceEnum
    {
        /// <summary>
        /// High.
        /// </summary>
        [EnumMember(Value = "high")]
        High,

        /// <summary>
        /// Medium.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,

        /// <summary>
        /// Low.
        /// </summary>
        [EnumMember(Value = "low")]
        Low
    }
}