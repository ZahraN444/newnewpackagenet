// <copyright file="Name1Enum.cs" company="APIMatic">
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
    /// Name1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Name1Enum
    {
        /// <summary>
        /// Mailed.
        /// </summary>
        [EnumMember(Value = "Mailed")]
        Mailed,

        /// <summary>
        /// EnumInTransit.
        /// </summary>
        [EnumMember(Value = "In Transit")]
        EnumInTransit,

        /// <summary>
        /// EnumInLocalArea.
        /// </summary>
        [EnumMember(Value = "In Local Area")]
        EnumInLocalArea,

        /// <summary>
        /// EnumProcessedForDelivery.
        /// </summary>
        [EnumMember(Value = "Processed for Delivery")]
        EnumProcessedForDelivery,

        /// <summary>
        /// EnumPickupAvailable.
        /// </summary>
        [EnumMember(Value = "Pickup Available")]
        EnumPickupAvailable,

        /// <summary>
        /// Delivered.
        /// </summary>
        [EnumMember(Value = "Delivered")]
        Delivered,

        /// <summary>
        /// ReRouted.
        /// </summary>
        [EnumMember(Value = "Re-Routed")]
        ReRouted,

        /// <summary>
        /// EnumReturnedToSender.
        /// </summary>
        [EnumMember(Value = "Returned to Sender")]
        EnumReturnedToSender,

        /// <summary>
        /// Issue.
        /// </summary>
        [EnumMember(Value = "Issue")]
        Issue
    }
}