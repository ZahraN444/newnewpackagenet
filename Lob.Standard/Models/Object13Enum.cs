// <copyright file="Object13Enum.cs" company="APIMatic">
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
    /// Object13Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Object13Enum
    {
        /// <summary>
        /// UsAutocompletion.
        /// </summary>
        [EnumMember(Value = "us_autocompletion")]
        UsAutocompletion
    }
}