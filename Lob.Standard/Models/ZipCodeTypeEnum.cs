// <copyright file="ZipCodeTypeEnum.cs" company="APIMatic">
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
    /// ZipCodeTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ZipCodeTypeEnum
    {
        /// <summary>
        /// Standard.
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard,

        /// <summary>
        /// PoBox.
        /// </summary>
        [EnumMember(Value = "po_box")]
        PoBox,

        /// <summary>
        /// Unique.
        /// </summary>
        [EnumMember(Value = "unique")]
        Unique,

        /// <summary>
        /// Military.
        /// </summary>
        [EnumMember(Value = "military")]
        Military
    }
}