// <copyright file="RecordTypeEnum.cs" company="APIMatic">
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
    /// RecordTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecordTypeEnum
    {
        /// <summary>
        /// Street.
        /// </summary>
        [EnumMember(Value = "street")]
        Street,

        /// <summary>
        /// Highrise.
        /// </summary>
        [EnumMember(Value = "highrise")]
        Highrise,

        /// <summary>
        /// Firm.
        /// </summary>
        [EnumMember(Value = "firm")]
        Firm,

        /// <summary>
        /// PoBox.
        /// </summary>
        [EnumMember(Value = "po_box")]
        PoBox,

        /// <summary>
        /// RuralRoute.
        /// </summary>
        [EnumMember(Value = "rural_route")]
        RuralRoute,

        /// <summary>
        /// GeneralDelivery.
        /// </summary>
        [EnumMember(Value = "general_delivery")]
        GeneralDelivery
    }
}