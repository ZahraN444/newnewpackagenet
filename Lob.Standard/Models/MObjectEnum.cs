// <copyright file="MObjectEnum.cs" company="APIMatic">
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
    /// MObjectEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MObjectEnum
    {
        /// <summary>
        /// BillingGroup.
        /// </summary>
        [EnumMember(Value = "billing_group")]
        BillingGroup
    }
}