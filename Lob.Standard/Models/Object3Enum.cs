// <copyright file="Object3Enum.cs" company="APIMatic">
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
    /// Object3Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Object3Enum
    {
        /// <summary>
        /// TrackingEvent.
        /// </summary>
        [EnumMember(Value = "tracking_event")]
        TrackingEvent
    }
}