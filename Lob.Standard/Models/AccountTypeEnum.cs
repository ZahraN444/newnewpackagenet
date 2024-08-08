// <copyright file="AccountTypeEnum.cs" company="APIMatic">
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
    /// AccountTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountTypeEnum
    {
        /// <summary>
        /// Company.
        /// </summary>
        [EnumMember(Value = "company")]
        Company,

        /// <summary>
        /// Individual.
        /// </summary>
        [EnumMember(Value = "individual")]
        Individual
    }
}