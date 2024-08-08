// <copyright file="CheckTypesEnum.cs" company="APIMatic">
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
    /// CheckTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckTypesEnum
    {
        /// <summary>
        /// EnumCheckcreated.
        /// </summary>
        [EnumMember(Value = "check.created")]
        EnumCheckcreated,

        /// <summary>
        /// EnumCheckrenderedPdf.
        /// </summary>
        [EnumMember(Value = "check.rendered_pdf")]
        EnumCheckrenderedPdf,

        /// <summary>
        /// EnumCheckrenderedThumbnails.
        /// </summary>
        [EnumMember(Value = "check.rendered_thumbnails")]
        EnumCheckrenderedThumbnails,

        /// <summary>
        /// EnumCheckdeleted.
        /// </summary>
        [EnumMember(Value = "check.deleted")]
        EnumCheckdeleted,

        /// <summary>
        /// EnumCheckdelivered.
        /// </summary>
        [EnumMember(Value = "check.delivered")]
        EnumCheckdelivered,

        /// <summary>
        /// EnumCheckfailed.
        /// </summary>
        [EnumMember(Value = "check.failed")]
        EnumCheckfailed,

        /// <summary>
        /// EnumCheckmailed.
        /// </summary>
        [EnumMember(Value = "check.mailed")]
        EnumCheckmailed,

        /// <summary>
        /// EnumCheckinTransit.
        /// </summary>
        [EnumMember(Value = "check.in_transit")]
        EnumCheckinTransit,

        /// <summary>
        /// EnumCheckinLocalArea.
        /// </summary>
        [EnumMember(Value = "check.in_local_area")]
        EnumCheckinLocalArea,

        /// <summary>
        /// EnumCheckinternationalExit.
        /// </summary>
        [EnumMember(Value = "check.international_exit")]
        EnumCheckinternationalExit,

        /// <summary>
        /// EnumCheckprocessedForDelivery.
        /// </summary>
        [EnumMember(Value = "check.processed_for_delivery")]
        EnumCheckprocessedForDelivery,

        /// <summary>
        /// EnumCheckrerouted.
        /// </summary>
        [EnumMember(Value = "check.re-routed")]
        EnumCheckrerouted,

        /// <summary>
        /// EnumCheckreturnedToSender.
        /// </summary>
        [EnumMember(Value = "check.returned_to_sender")]
        EnumCheckreturnedToSender
    }
}