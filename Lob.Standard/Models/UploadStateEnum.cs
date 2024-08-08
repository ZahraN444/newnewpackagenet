// <copyright file="UploadStateEnum.cs" company="APIMatic">
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
    /// UploadStateEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UploadStateEnum
    {
        /// <summary>
        /// Preprocessing.
        /// </summary>
        [EnumMember(Value = "Preprocessing")]
        Preprocessing,

        /// <summary>
        /// Draft.
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,

        /// <summary>
        /// EnumReadyForValidation.
        /// </summary>
        [EnumMember(Value = "Ready for Validation")]
        EnumReadyForValidation,

        /// <summary>
        /// Validating.
        /// </summary>
        [EnumMember(Value = "Validating")]
        Validating,

        /// <summary>
        /// Scheduled.
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled,

        /// <summary>
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled,

        /// <summary>
        /// Errored.
        /// </summary>
        [EnumMember(Value = "Errored")]
        Errored
    }
}