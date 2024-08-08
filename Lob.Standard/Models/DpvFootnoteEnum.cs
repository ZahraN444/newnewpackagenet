// <copyright file="DpvFootnoteEnum.cs" company="APIMatic">
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
    /// DpvFootnoteEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DpvFootnoteEnum
    {
        /// <summary>
        /// AA.
        /// </summary>
        [EnumMember(Value = "AA")]
        AA,

        /// <summary>
        /// A1.
        /// </summary>
        [EnumMember(Value = "A1")]
        A1,

        /// <summary>
        /// BB.
        /// </summary>
        [EnumMember(Value = "BB")]
        BB,

        /// <summary>
        /// CC.
        /// </summary>
        [EnumMember(Value = "CC")]
        CC,

        /// <summary>
        /// N1.
        /// </summary>
        [EnumMember(Value = "N1")]
        N1,

        /// <summary>
        /// F1.
        /// </summary>
        [EnumMember(Value = "F1")]
        F1,

        /// <summary>
        /// G1.
        /// </summary>
        [EnumMember(Value = "G1")]
        G1,

        /// <summary>
        /// U1.
        /// </summary>
        [EnumMember(Value = "U1")]
        U1,

        /// <summary>
        /// M1.
        /// </summary>
        [EnumMember(Value = "M1")]
        M1,

        /// <summary>
        /// M3.
        /// </summary>
        [EnumMember(Value = "M3")]
        M3,

        /// <summary>
        /// P1.
        /// </summary>
        [EnumMember(Value = "P1")]
        P1,

        /// <summary>
        /// P3.
        /// </summary>
        [EnumMember(Value = "P3")]
        P3,

        /// <summary>
        /// R1.
        /// </summary>
        [EnumMember(Value = "R1")]
        R1,

        /// <summary>
        /// R7.
        /// </summary>
        [EnumMember(Value = "R7")]
        R7,

        /// <summary>
        /// RR.
        /// </summary>
        [EnumMember(Value = "RR")]
        RR
    }
}