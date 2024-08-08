// <copyright file="LacsIndicatorEnum.cs" company="APIMatic">
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
    /// LacsIndicatorEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LacsIndicatorEnum
    {
        /// <summary>
        /// Y.
        /// </summary>
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>
        /// N.
        /// </summary>
        [EnumMember(Value = "N")]
        N
    }
}