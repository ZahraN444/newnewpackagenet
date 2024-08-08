// <copyright file="SuiteReturnCodeEnum.cs" company="APIMatic">
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
    /// SuiteReturnCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SuiteReturnCodeEnum
    {
        /// <summary>
        /// A.
        /// </summary>
        [EnumMember(Value = "A")]
        A,

        /// <summary>
        /// Enum00.
        /// </summary>
        [EnumMember(Value = "00")]
        Enum00
    }
}