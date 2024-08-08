// <copyright file="NameEnum.cs" company="APIMatic">
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
    /// NameEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NameEnum
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
        /// EnumInternationalExit.
        /// </summary>
        [EnumMember(Value = "International Exit")]
        EnumInternationalExit
    }
}