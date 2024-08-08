// <copyright file="AddressTypesEnum.cs" company="APIMatic">
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
    /// AddressTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressTypesEnum
    {
        /// <summary>
        /// EnumAddresscreated.
        /// </summary>
        [EnumMember(Value = "address.created")]
        EnumAddresscreated,

        /// <summary>
        /// EnumAddressdeleted.
        /// </summary>
        [EnumMember(Value = "address.deleted")]
        EnumAddressdeleted
    }
}