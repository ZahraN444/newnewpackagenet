// <copyright file="DpvConfirmationEnum.cs" company="APIMatic">
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
    /// DpvConfirmationEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DpvConfirmationEnum
    {
        /// <summary>
        /// Y.
        /// </summary>
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>
        /// S.
        /// </summary>
        [EnumMember(Value = "S")]
        S,

        /// <summary>
        /// D.
        /// </summary>
        [EnumMember(Value = "D")]
        D,

        /// <summary>
        /// N.
        /// </summary>
        [EnumMember(Value = "N")]
        N
    }
}