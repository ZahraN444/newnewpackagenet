// <copyright file="PostcardTypesEnum.cs" company="APIMatic">
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
    /// PostcardTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PostcardTypesEnum
    {
        /// <summary>
        /// EnumPostcardcreated.
        /// </summary>
        [EnumMember(Value = "postcard.created")]
        EnumPostcardcreated,

        /// <summary>
        /// EnumPostcardrenderedPdf.
        /// </summary>
        [EnumMember(Value = "postcard.rendered_pdf")]
        EnumPostcardrenderedPdf,

        /// <summary>
        /// EnumPostcardrenderedThumbnails.
        /// </summary>
        [EnumMember(Value = "postcard.rendered_thumbnails")]
        EnumPostcardrenderedThumbnails,

        /// <summary>
        /// EnumPostcarddeleted.
        /// </summary>
        [EnumMember(Value = "postcard.deleted")]
        EnumPostcarddeleted,

        /// <summary>
        /// EnumPostcarddelivered.
        /// </summary>
        [EnumMember(Value = "postcard.delivered")]
        EnumPostcarddelivered,

        /// <summary>
        /// EnumPostcardfailed.
        /// </summary>
        [EnumMember(Value = "postcard.failed")]
        EnumPostcardfailed,

        /// <summary>
        /// EnumPostcardmailed.
        /// </summary>
        [EnumMember(Value = "postcard.mailed")]
        EnumPostcardmailed,

        /// <summary>
        /// EnumPostcardinTransit.
        /// </summary>
        [EnumMember(Value = "postcard.in_transit")]
        EnumPostcardinTransit,

        /// <summary>
        /// EnumPostcardinLocalArea.
        /// </summary>
        [EnumMember(Value = "postcard.in_local_area")]
        EnumPostcardinLocalArea,

        /// <summary>
        /// EnumPostcardinternationalExit.
        /// </summary>
        [EnumMember(Value = "postcard.international_exit")]
        EnumPostcardinternationalExit,

        /// <summary>
        /// EnumPostcardprocessedForDelivery.
        /// </summary>
        [EnumMember(Value = "postcard.processed_for_delivery")]
        EnumPostcardprocessedForDelivery,

        /// <summary>
        /// EnumPostcardrerouted.
        /// </summary>
        [EnumMember(Value = "postcard.re-routed")]
        EnumPostcardrerouted,

        /// <summary>
        /// EnumPostcardreturnedToSender.
        /// </summary>
        [EnumMember(Value = "postcard.returned_to_sender")]
        EnumPostcardreturnedToSender,

        /// <summary>
        /// EnumPostcardviewed.
        /// </summary>
        [EnumMember(Value = "postcard.viewed")]
        EnumPostcardviewed
    }
}