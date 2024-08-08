// <copyright file="EventEnum.cs" company="APIMatic">
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
    /// EventEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventEnum
    {
        /// <summary>
        /// PackageAccepted.
        /// </summary>
        [EnumMember(Value = "package_accepted")]
        PackageAccepted,

        /// <summary>
        /// PackageArrived.
        /// </summary>
        [EnumMember(Value = "package_arrived")]
        PackageArrived,

        /// <summary>
        /// PackageDeparted.
        /// </summary>
        [EnumMember(Value = "package_departed")]
        PackageDeparted,

        /// <summary>
        /// PackageProcessing.
        /// </summary>
        [EnumMember(Value = "package_processing")]
        PackageProcessing,

        /// <summary>
        /// PackageProcessed.
        /// </summary>
        [EnumMember(Value = "package_processed")]
        PackageProcessed,

        /// <summary>
        /// PackageInLocalArea.
        /// </summary>
        [EnumMember(Value = "package_in_local_area")]
        PackageInLocalArea,

        /// <summary>
        /// DeliveryScheduled.
        /// </summary>
        [EnumMember(Value = "delivery_scheduled")]
        DeliveryScheduled,

        /// <summary>
        /// OutForDelivery.
        /// </summary>
        [EnumMember(Value = "out_for_delivery")]
        OutForDelivery,

        /// <summary>
        /// PickupAvailable.
        /// </summary>
        [EnumMember(Value = "pickup_available")]
        PickupAvailable,

        /// <summary>
        /// Delivered.
        /// </summary>
        [EnumMember(Value = "delivered")]
        Delivered,

        /// <summary>
        /// PackageForwarded.
        /// </summary>
        [EnumMember(Value = "package_forwarded")]
        PackageForwarded,

        /// <summary>
        /// ReturnedToSender.
        /// </summary>
        [EnumMember(Value = "returned_to_sender")]
        ReturnedToSender,

        /// <summary>
        /// AddressIssue.
        /// </summary>
        [EnumMember(Value = "address_issue")]
        AddressIssue,

        /// <summary>
        /// ContactCarrier.
        /// </summary>
        [EnumMember(Value = "contact_carrier")]
        ContactCarrier,

        /// <summary>
        /// Delayed.
        /// </summary>
        [EnumMember(Value = "delayed")]
        Delayed,

        /// <summary>
        /// DeliveryAttempted.
        /// </summary>
        [EnumMember(Value = "delivery_attempted")]
        DeliveryAttempted,

        /// <summary>
        /// DeliveryRescheduled.
        /// </summary>
        [EnumMember(Value = "delivery_rescheduled")]
        DeliveryRescheduled,

        /// <summary>
        /// LocationInaccessible.
        /// </summary>
        [EnumMember(Value = "location_inaccessible")]
        LocationInaccessible,

        /// <summary>
        /// NoticeLeft.
        /// </summary>
        [EnumMember(Value = "notice_left")]
        NoticeLeft,

        /// <summary>
        /// PackageDamaged.
        /// </summary>
        [EnumMember(Value = "package_damaged")]
        PackageDamaged,

        /// <summary>
        /// PackageDisposed.
        /// </summary>
        [EnumMember(Value = "package_disposed")]
        PackageDisposed,

        /// <summary>
        /// PackageHeld.
        /// </summary>
        [EnumMember(Value = "package_held")]
        PackageHeld,

        /// <summary>
        /// PackageLost.
        /// </summary>
        [EnumMember(Value = "package_lost")]
        PackageLost,

        /// <summary>
        /// PackageUnclaimed.
        /// </summary>
        [EnumMember(Value = "package_unclaimed")]
        PackageUnclaimed,

        /// <summary>
        /// PackageUndeliverable.
        /// </summary>
        [EnumMember(Value = "package_undeliverable")]
        PackageUndeliverable,

        /// <summary>
        /// RescheduleDelivery.
        /// </summary>
        [EnumMember(Value = "reschedule_delivery")]
        RescheduleDelivery,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}