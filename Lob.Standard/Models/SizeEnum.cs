// <copyright file="SizeEnum.cs" company="APIMatic">
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
    /// SizeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SizeEnum
    {
        /// <summary>
        /// Enum875x375.
        /// </summary>
        [EnumMember(Value = "8.75x3.75")]
        Enum875x375
    }
}