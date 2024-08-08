// <copyright file="OrientationEnum.cs" company="APIMatic">
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
    /// OrientationEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrientationEnum
    {
        /// <summary>
        /// Horizontal.
        /// </summary>
        [EnumMember(Value = "horizontal")]
        Horizontal,

        /// <summary>
        /// Vertical.
        /// </summary>
        [EnumMember(Value = "vertical")]
        Vertical
    }
}