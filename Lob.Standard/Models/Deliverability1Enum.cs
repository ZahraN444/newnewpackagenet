// <copyright file="Deliverability1Enum.cs" company="APIMatic">
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
    /// Deliverability1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Deliverability1Enum
    {
        /// <summary>
        /// Deliverable.
        /// </summary>
        [EnumMember(Value = "deliverable")]
        Deliverable,

        /// <summary>
        /// DeliverableMissingInfo.
        /// </summary>
        [EnumMember(Value = "deliverable_missing_info")]
        DeliverableMissingInfo,

        /// <summary>
        /// Undeliverable.
        /// </summary>
        [EnumMember(Value = "undeliverable")]
        Undeliverable,

        /// <summary>
        /// NoMatch.
        /// </summary>
        [EnumMember(Value = "no_match")]
        NoMatch
    }
}