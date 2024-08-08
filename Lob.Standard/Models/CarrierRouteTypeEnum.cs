// <copyright file="CarrierRouteTypeEnum.cs" company="APIMatic">
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
    /// CarrierRouteTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CarrierRouteTypeEnum
    {
        /// <summary>
        /// CityDelivery.
        /// </summary>
        [EnumMember(Value = "city_delivery")]
        CityDelivery,

        /// <summary>
        /// RuralRoute.
        /// </summary>
        [EnumMember(Value = "rural_route")]
        RuralRoute,

        /// <summary>
        /// HighwayContract.
        /// </summary>
        [EnumMember(Value = "highway_contract")]
        HighwayContract,

        /// <summary>
        /// PoBox.
        /// </summary>
        [EnumMember(Value = "po_box")]
        PoBox,

        /// <summary>
        /// GeneralDelivery.
        /// </summary>
        [EnumMember(Value = "general_delivery")]
        GeneralDelivery
    }
}