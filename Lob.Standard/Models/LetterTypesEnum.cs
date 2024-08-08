// <copyright file="LetterTypesEnum.cs" company="APIMatic">
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
    /// LetterTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LetterTypesEnum
    {
        /// <summary>
        /// EnumLettercreated.
        /// </summary>
        [EnumMember(Value = "letter.created")]
        EnumLettercreated,

        /// <summary>
        /// EnumLetterrenderedPdf.
        /// </summary>
        [EnumMember(Value = "letter.rendered_pdf")]
        EnumLetterrenderedPdf,

        /// <summary>
        /// EnumLetterrenderedThumbnails.
        /// </summary>
        [EnumMember(Value = "letter.rendered_thumbnails")]
        EnumLetterrenderedThumbnails,

        /// <summary>
        /// EnumLetterdeleted.
        /// </summary>
        [EnumMember(Value = "letter.deleted")]
        EnumLetterdeleted,

        /// <summary>
        /// EnumLetterdelivered.
        /// </summary>
        [EnumMember(Value = "letter.delivered")]
        EnumLetterdelivered,

        /// <summary>
        /// EnumLetterfailed.
        /// </summary>
        [EnumMember(Value = "letter.failed")]
        EnumLetterfailed,

        /// <summary>
        /// EnumLettermailed.
        /// </summary>
        [EnumMember(Value = "letter.mailed")]
        EnumLettermailed,

        /// <summary>
        /// EnumLetterinTransit.
        /// </summary>
        [EnumMember(Value = "letter.in_transit")]
        EnumLetterinTransit,

        /// <summary>
        /// EnumLetterinLocalArea.
        /// </summary>
        [EnumMember(Value = "letter.in_local_area")]
        EnumLetterinLocalArea,

        /// <summary>
        /// EnumLetterinternationalExit.
        /// </summary>
        [EnumMember(Value = "letter.international_exit")]
        EnumLetterinternationalExit,

        /// <summary>
        /// EnumLetterprocessedForDelivery.
        /// </summary>
        [EnumMember(Value = "letter.processed_for_delivery")]
        EnumLetterprocessedForDelivery,

        /// <summary>
        /// EnumLetterrerouted.
        /// </summary>
        [EnumMember(Value = "letter.re-routed")]
        EnumLetterrerouted,

        /// <summary>
        /// EnumLetterreturnedToSender.
        /// </summary>
        [EnumMember(Value = "letter.returned_to_sender")]
        EnumLetterreturnedToSender,

        /// <summary>
        /// EnumLettercertifiedmailed.
        /// </summary>
        [EnumMember(Value = "letter.certified.mailed")]
        EnumLettercertifiedmailed,

        /// <summary>
        /// EnumLettercertifiedinTransit.
        /// </summary>
        [EnumMember(Value = "letter.certified.in_transit")]
        EnumLettercertifiedinTransit,

        /// <summary>
        /// EnumLettercertifiedinLocalArea.
        /// </summary>
        [EnumMember(Value = "letter.certified.in_local_area")]
        EnumLettercertifiedinLocalArea,

        /// <summary>
        /// EnumLettercertifiedprocessedForDelivery.
        /// </summary>
        [EnumMember(Value = "letter.certified.processed_for_delivery")]
        EnumLettercertifiedprocessedForDelivery,

        /// <summary>
        /// EnumLettercertifiedrerouted.
        /// </summary>
        [EnumMember(Value = "letter.certified.re-routed")]
        EnumLettercertifiedrerouted,

        /// <summary>
        /// EnumLettercertifiedreturnedToSender.
        /// </summary>
        [EnumMember(Value = "letter.certified.returned_to_sender")]
        EnumLettercertifiedreturnedToSender,

        /// <summary>
        /// EnumLettercertifieddelivered.
        /// </summary>
        [EnumMember(Value = "letter.certified.delivered")]
        EnumLettercertifieddelivered,

        /// <summary>
        /// EnumLettercertifiedpickupAvailable.
        /// </summary>
        [EnumMember(Value = "letter.certified.pickup_available")]
        EnumLettercertifiedpickupAvailable,

        /// <summary>
        /// EnumLettercertifiedissue.
        /// </summary>
        [EnumMember(Value = "letter.certified.issue")]
        EnumLettercertifiedissue,

        /// <summary>
        /// EnumLetterreturnEnvelopecreated.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.created")]
        EnumLetterreturnEnvelopecreated,

        /// <summary>
        /// EnumLetterreturnEnvelopedelivered.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.delivered")]
        EnumLetterreturnEnvelopedelivered,

        /// <summary>
        /// EnumLetterreturnEnvelopeinTransit.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.in_transit")]
        EnumLetterreturnEnvelopeinTransit,

        /// <summary>
        /// EnumLetterreturnEnvelopeinLocalArea.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.in_local_area")]
        EnumLetterreturnEnvelopeinLocalArea,

        /// <summary>
        /// EnumLetterreturnEnvelopeinternationalExit.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.international_exit")]
        EnumLetterreturnEnvelopeinternationalExit,

        /// <summary>
        /// EnumLetterreturnEnvelopeprocessedForDelivery.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.processed_for_delivery")]
        EnumLetterreturnEnvelopeprocessedForDelivery,

        /// <summary>
        /// EnumLetterreturnEnvelopereRouted.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.re_routed")]
        EnumLetterreturnEnvelopereRouted,

        /// <summary>
        /// EnumLetterreturnEnvelopereturnedToSender.
        /// </summary>
        [EnumMember(Value = "letter.return_envelope.returned_to_sender")]
        EnumLetterreturnEnvelopereturnedToSender,

        /// <summary>
        /// EnumLetterviewed.
        /// </summary>
        [EnumMember(Value = "letter.viewed")]
        EnumLetterviewed
    }
}