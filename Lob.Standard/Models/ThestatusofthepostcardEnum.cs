// <copyright file="ThestatusofthepostcardEnum.cs" company="APIMatic">
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
    /// ThestatusofthepostcardEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThestatusofthepostcardEnum
    {
        /// <summary>
        /// Processed.
        /// </summary>
        [EnumMember(Value = "processed")]
        Processed,

        /// <summary>
        /// Rendered.
        /// </summary>
        [EnumMember(Value = "rendered")]
        Rendered,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed
    }
}