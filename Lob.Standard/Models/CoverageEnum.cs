// <copyright file="CoverageEnum.cs" company="APIMatic">
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
    /// CoverageEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CoverageEnum
    {
        /// <summary>
        /// SUBBUILDING.
        /// </summary>
        [EnumMember(Value = "SUBBUILDING")]
        SUBBUILDING,

        /// <summary>
        /// EnumHOUSENUMBERBUILDING.
        /// </summary>
        [EnumMember(Value = "HOUSENUMBER/BUILDING")]
        EnumHOUSENUMBERBUILDING,

        /// <summary>
        /// STREET.
        /// </summary>
        [EnumMember(Value = "STREET")]
        STREET,

        /// <summary>
        /// LOCALITY.
        /// </summary>
        [EnumMember(Value = "LOCALITY")]
        LOCALITY,

        /// <summary>
        /// SPARSE.
        /// </summary>
        [EnumMember(Value = "SPARSE")]
        SPARSE
    }
}