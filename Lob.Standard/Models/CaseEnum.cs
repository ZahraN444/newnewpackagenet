// <copyright file="CaseEnum.cs" company="APIMatic">
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
    /// CaseEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CaseEnum
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