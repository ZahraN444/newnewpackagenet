// <copyright file="DateCreatedEnum.cs" company="APIMatic">
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
    /// DateCreatedEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DateCreatedEnum
    {
        /// <summary>
        /// Asc.
        /// </summary>
        [EnumMember(Value = "asc")]
        Asc,

        /// <summary>
        /// Desc.
        /// </summary>
        [EnumMember(Value = "desc")]
        Desc
    }
}