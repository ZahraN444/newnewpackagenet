// <copyright file="Object12Enum.cs" company="APIMatic">
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
    /// Object12Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Object12Enum
    {
        /// <summary>
        /// Template.
        /// </summary>
        [EnumMember(Value = "template")]
        Template
    }
}