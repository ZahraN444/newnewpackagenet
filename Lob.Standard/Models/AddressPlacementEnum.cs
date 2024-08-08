// <copyright file="AddressPlacementEnum.cs" company="APIMatic">
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
    /// AddressPlacementEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressPlacementEnum
    {
        /// <summary>
        /// TopFirstPage.
        /// </summary>
        [EnumMember(Value = "top_first_page")]
        TopFirstPage,

        /// <summary>
        /// InsertBlankPage.
        /// </summary>
        [EnumMember(Value = "insert_blank_page")]
        InsertBlankPage,

        /// <summary>
        /// BottomFirstPageCenter.
        /// </summary>
        [EnumMember(Value = "bottom_first_page_center")]
        BottomFirstPageCenter,

        /// <summary>
        /// BottomFirstPage.
        /// </summary>
        [EnumMember(Value = "bottom_first_page")]
        BottomFirstPage
    }
}