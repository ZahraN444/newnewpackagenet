// <copyright file="SelfMailerSizeEnum.cs" company="APIMatic">
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
    /// SelfMailerSizeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SelfMailerSizeEnum
    {
        /// <summary>
        /// Enum6x18Bifold.
        /// </summary>
        [EnumMember(Value = "6x18_bifold")]
        Enum6x18Bifold,

        /// <summary>
        /// Enum11x9Bifold.
        /// </summary>
        [EnumMember(Value = "11x9_bifold")]
        Enum11x9Bifold,

        /// <summary>
        /// Enum12x9Bifold.
        /// </summary>
        [EnumMember(Value = "12x9_bifold")]
        Enum12x9Bifold,

        /// <summary>
        /// Enum1775x9Trifold.
        /// </summary>
        [EnumMember(Value = "17.75x9_trifold")]
        Enum1775x9Trifold
    }
}