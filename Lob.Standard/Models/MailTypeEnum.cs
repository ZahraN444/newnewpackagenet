// <copyright file="MailTypeEnum.cs" company="APIMatic">
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
    /// MailTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MailTypeEnum
    {
        /// <summary>
        /// UspsFirstClass.
        /// </summary>
        [EnumMember(Value = "usps_first_class")]
        UspsFirstClass,

        /// <summary>
        /// UspsStandard.
        /// </summary>
        [EnumMember(Value = "usps_standard")]
        UspsStandard
    }
}