// <copyright file="AddressCountry2Enum.cs" company="APIMatic">
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
    /// AddressCountry2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressCountry2Enum
    {
        /// <summary>
        /// US.
        /// </summary>
        [EnumMember(Value = "US")]
        US
    }
}