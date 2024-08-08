// <copyright file="StreetPostdirectionEnum.cs" company="APIMatic">
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
    /// StreetPostdirectionEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StreetPostdirectionEnum
    {
        /// <summary>
        /// N.
        /// </summary>
        [EnumMember(Value = "N")]
        N,

        /// <summary>
        /// S.
        /// </summary>
        [EnumMember(Value = "S")]
        S,

        /// <summary>
        /// E.
        /// </summary>
        [EnumMember(Value = "E")]
        E,

        /// <summary>
        /// W.
        /// </summary>
        [EnumMember(Value = "W")]
        W,

        /// <summary>
        /// NE.
        /// </summary>
        [EnumMember(Value = "NE")]
        NE,

        /// <summary>
        /// SW.
        /// </summary>
        [EnumMember(Value = "SW")]
        SW,

        /// <summary>
        /// SE.
        /// </summary>
        [EnumMember(Value = "SE")]
        SE,

        /// <summary>
        /// NW.
        /// </summary>
        [EnumMember(Value = "NW")]
        NW
    }
}