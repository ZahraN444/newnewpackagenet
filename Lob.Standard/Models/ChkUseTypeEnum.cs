// <copyright file="ChkUseTypeEnum.cs" company="APIMatic">
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
    /// ChkUseTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChkUseTypeEnum
    {
        /// <summary>
        /// Marketing.
        /// </summary>
        [EnumMember(Value = "marketing")]
        Marketing,

        /// <summary>
        /// Operational.
        /// </summary>
        [EnumMember(Value = "operational")]
        Operational
    }
}