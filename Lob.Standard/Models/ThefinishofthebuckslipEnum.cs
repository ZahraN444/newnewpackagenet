// <copyright file="ThefinishofthebuckslipEnum.cs" company="APIMatic">
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
    /// ThefinishofthebuckslipEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThefinishofthebuckslipEnum
    {
        /// <summary>
        /// Gloss.
        /// </summary>
        [EnumMember(Value = "gloss")]
        Gloss,

        /// <summary>
        /// Matte.
        /// </summary>
        [EnumMember(Value = "matte")]
        Matte
    }
}