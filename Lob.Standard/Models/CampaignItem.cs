// <copyright file="CampaignItem.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Lob.Standard;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CampaignItem.
    /// </summary>
    public class CampaignItem
    {
        private string billingGroupId;
        private DateTime? targetDeliveryDate;
        private DateTime? sendDate;
        private int? cancelWindowCampaignMinutes;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "billing_group_id", false },
            { "target_delivery_date", false },
            { "send_date", false },
            { "cancel_window_campaign_minutes", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignItem"/> class.
        /// </summary>
        public CampaignItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignItem"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="scheduleType">schedule_type.</param>
        /// <param name="useType">use_type.</param>
        /// <param name="autoCancelIfNcoa">auto_cancel_if_ncoa.</param>
        /// <param name="id">id.</param>
        /// <param name="isDraft">is_draft.</param>
        /// <param name="creatives">creatives.</param>
        /// <param name="uploads">uploads.</param>
        /// <param name="mObject">object.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="billingGroupId">billing_group_id.</param>
        /// <param name="description">description.</param>
        /// <param name="targetDeliveryDate">target_delivery_date.</param>
        /// <param name="sendDate">send_date.</param>
        /// <param name="cancelWindowCampaignMinutes">cancel_window_campaign_minutes.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="deleted">deleted.</param>
        public CampaignItem(
            string name,
            string scheduleType,
            object useType,
            bool autoCancelIfNcoa,
            string id,
            bool isDraft,
            object creatives,
            object uploads,
            string mObject,
            DateTime dateCreated,
            DateTime dateModified,
            string billingGroupId = null,
            string description = null,
            DateTime? targetDeliveryDate = null,
            DateTime? sendDate = null,
            int? cancelWindowCampaignMinutes = null,
            Dictionary<string, string> metadata = null,
            bool? deleted = null)
        {
            if (billingGroupId != null)
            {
                this.BillingGroupId = billingGroupId;
            }

            this.Name = name;
            this.Description = description;
            this.ScheduleType = scheduleType;
            if (targetDeliveryDate != null)
            {
                this.TargetDeliveryDate = targetDeliveryDate;
            }

            if (sendDate != null)
            {
                this.SendDate = sendDate;
            }

            if (cancelWindowCampaignMinutes != null)
            {
                this.CancelWindowCampaignMinutes = cancelWindowCampaignMinutes;
            }

            this.Metadata = metadata;
            this.UseType = useType;
            this.AutoCancelIfNcoa = autoCancelIfNcoa;
            this.Id = id;
            this.IsDraft = isDraft;
            this.Creatives = creatives;
            this.Uploads = uploads;
            this.MObject = mObject;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Unique identifier prefixed with `bg_`.
        /// </summary>
        [JsonProperty("billing_group_id")]
        public string BillingGroupId
        {
            get
            {
                return this.billingGroupId;
            }

            set
            {
                this.shouldSerialize["billing_group_id"] = true;
                this.billingGroupId = value;
            }
        }

        /// <summary>
        /// Name of the campaign.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// How the campaign should be scheduled. Only value available today is `immediate`.
        /// </summary>
        [JsonProperty("schedule_type")]
        public string ScheduleType { get; set; }

        /// <summary>
        /// If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("target_delivery_date")]
        public DateTime? TargetDeliveryDate
        {
            get
            {
                return this.targetDeliveryDate;
            }

            set
            {
                this.shouldSerialize["target_delivery_date"] = true;
                this.targetDeliveryDate = value;
            }
        }

        /// <summary>
        /// If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("send_date")]
        public DateTime? SendDate
        {
            get
            {
                return this.sendDate;
            }

            set
            {
                this.shouldSerialize["send_date"] = true;
                this.sendDate = value;
            }
        }

        /// <summary>
        /// A window, in minutes, within which the campaign can be canceled.
        /// </summary>
        [JsonProperty("cancel_window_campaign_minutes")]
        public int? CancelWindowCampaignMinutes
        {
            get
            {
                return this.cancelWindowCampaignMinutes;
            }

            set
            {
                this.shouldSerialize["cancel_window_campaign_minutes"] = true;
                this.cancelWindowCampaignMinutes = value;
            }
        }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets UseType.
        /// </summary>
        [JsonProperty("use_type")]
        public object UseType { get; set; }

        /// <summary>
        /// Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA.
        /// </summary>
        [JsonProperty("auto_cancel_if_ncoa")]
        public bool AutoCancelIfNcoa { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `cmp_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Whether or not the campaign is still a draft.
        /// </summary>
        [JsonProperty("is_draft")]
        public bool IsDraft { get; set; }

        /// <summary>
        /// An array of creatives that have been associated with this campaign.
        /// </summary>
        [JsonProperty("creatives")]
        public object Creatives { get; set; }

        /// <summary>
        /// A single-element array containing the upload object that is assocated with this campaign.
        /// </summary>
        [JsonProperty("uploads")]
        public object Uploads { get; set; }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object")]
        public string MObject { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was last modified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CampaignItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingGroupId()
        {
            this.shouldSerialize["billing_group_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTargetDeliveryDate()
        {
            this.shouldSerialize["target_delivery_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSendDate()
        {
            this.shouldSerialize["send_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCancelWindowCampaignMinutes()
        {
            this.shouldSerialize["cancel_window_campaign_minutes"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingGroupId()
        {
            return this.shouldSerialize["billing_group_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTargetDeliveryDate()
        {
            return this.shouldSerialize["target_delivery_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSendDate()
        {
            return this.shouldSerialize["send_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCancelWindowCampaignMinutes()
        {
            return this.shouldSerialize["cancel_window_campaign_minutes"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CampaignItem other &&                ((this.BillingGroupId == null && other.BillingGroupId == null) || (this.BillingGroupId?.Equals(other.BillingGroupId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ScheduleType == null && other.ScheduleType == null) || (this.ScheduleType?.Equals(other.ScheduleType) == true)) &&
                ((this.TargetDeliveryDate == null && other.TargetDeliveryDate == null) || (this.TargetDeliveryDate?.Equals(other.TargetDeliveryDate) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true)) &&
                ((this.CancelWindowCampaignMinutes == null && other.CancelWindowCampaignMinutes == null) || (this.CancelWindowCampaignMinutes?.Equals(other.CancelWindowCampaignMinutes) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.UseType == null && other.UseType == null) || (this.UseType?.Equals(other.UseType) == true)) &&
                this.AutoCancelIfNcoa.Equals(other.AutoCancelIfNcoa) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.IsDraft.Equals(other.IsDraft) &&
                ((this.Creatives == null && other.Creatives == null) || (this.Creatives?.Equals(other.Creatives) == true)) &&
                ((this.Uploads == null && other.Uploads == null) || (this.Uploads?.Equals(other.Uploads) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingGroupId = {(this.BillingGroupId == null ? "null" : this.BillingGroupId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.ScheduleType = {(this.ScheduleType == null ? "null" : this.ScheduleType)}");
            toStringOutput.Add($"this.TargetDeliveryDate = {(this.TargetDeliveryDate == null ? "null" : this.TargetDeliveryDate.ToString())}");
            toStringOutput.Add($"this.SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
            toStringOutput.Add($"this.CancelWindowCampaignMinutes = {(this.CancelWindowCampaignMinutes == null ? "null" : this.CancelWindowCampaignMinutes.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"UseType = {(this.UseType == null ? "null" : this.UseType.ToString())}");
            toStringOutput.Add($"this.AutoCancelIfNcoa = {this.AutoCancelIfNcoa}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.IsDraft = {this.IsDraft}");
            toStringOutput.Add($"Creatives = {(this.Creatives == null ? "null" : this.Creatives.ToString())}");
            toStringOutput.Add($"Uploads = {(this.Uploads == null ? "null" : this.Uploads.ToString())}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
        }
    }
}