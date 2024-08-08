// <copyright file="Code1Enum.cs" company="APIMatic">
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
    /// Code1Enum.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum Code1Enum
    {
        /// <summary>
        /// Enum400.
        /// </summary>
        Enum400 = 400,

        /// <summary>
        /// Enum404.
        /// </summary>
        Enum404 = 404
    }
}