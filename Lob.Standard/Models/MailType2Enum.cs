// <copyright file="MailType2Enum.cs" company="APIMatic">
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
    /// MailType2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MailType2Enum
    {
        /// <summary>
        /// UspsFirstClass.
        /// </summary>
        [EnumMember(Value = "usps_first_class")]
        UspsFirstClass
    }
}