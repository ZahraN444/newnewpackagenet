// <copyright file="ThestockofthebuckslipEnum.cs" company="APIMatic">
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
    /// ThestockofthebuckslipEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThestockofthebuckslipEnum
    {
        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Cover.
        /// </summary>
        [EnumMember(Value = "cover")]
        Cover
    }
}