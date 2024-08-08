// <copyright file="FailureStatusCodeEnum.cs" company="APIMatic">
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
    /// FailureStatusCodeEnum.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum FailureStatusCodeEnum
    {
        /// <summary>
        /// Enum401.
        /// </summary>
        Enum401 = 401,

        /// <summary>
        /// Enum403.
        /// </summary>
        Enum403 = 403,

        /// <summary>
        /// Enum404.
        /// </summary>
        Enum404 = 404,

        /// <summary>
        /// Enum413.
        /// </summary>
        Enum413 = 413,

        /// <summary>
        /// Enum422.
        /// </summary>
        Enum422 = 422,

        /// <summary>
        /// Enum429.
        /// </summary>
        Enum429 = 429,

        /// <summary>
        /// Enum500.
        /// </summary>
        Enum500 = 500
    }
}