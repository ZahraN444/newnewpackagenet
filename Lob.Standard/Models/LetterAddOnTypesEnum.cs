// <copyright file="LetterAddOnTypesEnum.cs" company="APIMatic">
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
    /// LetterAddOnTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LetterAddOnTypesEnum
    {
        /// <summary>
        /// Buckslips.
        /// </summary>
        [EnumMember(Value = "buckslips")]
        Buckslips,

        /// <summary>
        /// Cards.
        /// </summary>
        [EnumMember(Value = "cards")]
        Cards,

        /// <summary>
        /// CustomEnvelope.
        /// </summary>
        [EnumMember(Value = "custom_envelope")]
        CustomEnvelope
    }
}