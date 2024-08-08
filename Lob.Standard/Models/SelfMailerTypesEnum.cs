// <copyright file="SelfMailerTypesEnum.cs" company="APIMatic">
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
    /// SelfMailerTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SelfMailerTypesEnum
    {
        /// <summary>
        /// EnumSelfMailercreated.
        /// </summary>
        [EnumMember(Value = "self_mailer.created")]
        EnumSelfMailercreated,

        /// <summary>
        /// EnumSelfMailerrenderedPdf.
        /// </summary>
        [EnumMember(Value = "self_mailer.rendered_pdf")]
        EnumSelfMailerrenderedPdf,

        /// <summary>
        /// EnumSelfMailerrenderedThumbnails.
        /// </summary>
        [EnumMember(Value = "self_mailer.rendered_thumbnails")]
        EnumSelfMailerrenderedThumbnails,

        /// <summary>
        /// EnumSelfMailerdeleted.
        /// </summary>
        [EnumMember(Value = "self_mailer.deleted")]
        EnumSelfMailerdeleted,

        /// <summary>
        /// EnumSelfMailerdelivered.
        /// </summary>
        [EnumMember(Value = "self_mailer.delivered")]
        EnumSelfMailerdelivered,

        /// <summary>
        /// EnumSelfMailerfailed.
        /// </summary>
        [EnumMember(Value = "self_mailer.failed")]
        EnumSelfMailerfailed,

        /// <summary>
        /// EnumSelfMailermailed.
        /// </summary>
        [EnumMember(Value = "self_mailer.mailed")]
        EnumSelfMailermailed,

        /// <summary>
        /// EnumSelfMailerinTransit.
        /// </summary>
        [EnumMember(Value = "self_mailer.in_transit")]
        EnumSelfMailerinTransit,

        /// <summary>
        /// EnumSelfMailerinLocalArea.
        /// </summary>
        [EnumMember(Value = "self_mailer.in_local_area")]
        EnumSelfMailerinLocalArea,

        /// <summary>
        /// EnumSelfMailerinternationalExit.
        /// </summary>
        [EnumMember(Value = "self_mailer.international_exit")]
        EnumSelfMailerinternationalExit,

        /// <summary>
        /// EnumSelfMailerprocessedForDelivery.
        /// </summary>
        [EnumMember(Value = "self_mailer.processed_for_delivery")]
        EnumSelfMailerprocessedForDelivery,

        /// <summary>
        /// EnumSelfMailerrerouted.
        /// </summary>
        [EnumMember(Value = "self_mailer.re-routed")]
        EnumSelfMailerrerouted,

        /// <summary>
        /// EnumSelfMailerreturnedToSender.
        /// </summary>
        [EnumMember(Value = "self_mailer.returned_to_sender")]
        EnumSelfMailerreturnedToSender,

        /// <summary>
        /// EnumSelfMailerviewed.
        /// </summary>
        [EnumMember(Value = "self_mailer.viewed")]
        EnumSelfMailerviewed
    }
}