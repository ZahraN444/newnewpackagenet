// <copyright file="CmpUseTypeEnum.cs" company="APIMatic">
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
    /// CmpUseTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CmpUseTypeEnum
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