// <copyright file="DeliverabilityEnum.cs" company="APIMatic">
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
    /// DeliverabilityEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliverabilityEnum
    {
        /// <summary>
        /// Deliverable.
        /// </summary>
        [EnumMember(Value = "deliverable")]
        Deliverable,

        /// <summary>
        /// DeliverableUnnecessaryUnit.
        /// </summary>
        [EnumMember(Value = "deliverable_unnecessary_unit")]
        DeliverableUnnecessaryUnit,

        /// <summary>
        /// DeliverableIncorrectUnit.
        /// </summary>
        [EnumMember(Value = "deliverable_incorrect_unit")]
        DeliverableIncorrectUnit,

        /// <summary>
        /// DeliverableMissingUnit.
        /// </summary>
        [EnumMember(Value = "deliverable_missing_unit")]
        DeliverableMissingUnit,

        /// <summary>
        /// Undeliverable.
        /// </summary>
        [EnumMember(Value = "undeliverable")]
        Undeliverable
    }
}