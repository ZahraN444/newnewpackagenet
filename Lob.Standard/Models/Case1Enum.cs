// <copyright file="Case1Enum.cs" company="APIMatic">
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
    /// Case1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Case1Enum
    {
        /// <summary>
        /// Upper.
        /// </summary>
        [EnumMember(Value = "upper")]
        Upper,

        /// <summary>
        /// Proper.
        /// </summary>
        [EnumMember(Value = "proper")]
        Proper
    }
}