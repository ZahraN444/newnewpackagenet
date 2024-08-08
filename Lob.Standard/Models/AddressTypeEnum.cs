// <copyright file="AddressTypeEnum.cs" company="APIMatic">
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
    /// AddressTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressTypeEnum
    {
        /// <summary>
        /// Residential.
        /// </summary>
        [EnumMember(Value = "residential")]
        Residential,

        /// <summary>
        /// Commercial.
        /// </summary>
        [EnumMember(Value = "commercial")]
        Commercial
    }
}