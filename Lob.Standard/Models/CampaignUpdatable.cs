// <copyright file="CampaignUpdatable.cs" company="APIMatic">
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
    /// CampaignUpdatable.
    /// </summary>
    public class CampaignUpdatable
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignUpdatable"/> class.
        /// </summary>
        public CampaignUpdatable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignUpdatable"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="scheduleType">schedule_type.</param>
        /// <param name="targetDeliveryDate">target_delivery_date.</param>
        /// <param name="sendDate">send_date.</param>
        /// <param name="cancelWindowCampaignMinutes">cancel_window_campaign_minutes.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="isDraft">is_draft.</param>
        /// <param name="useType">use_type.</param>
        /// <param name="autoCancelIfNcoa">auto_cancel_if_ncoa.</param>
        public CampaignUpdatable(
            string name = null,
            string description = null,
            Models.CmpScheduleTypeEnum? scheduleType = null,
            DateTime? targetDeliveryDate = null,
            DateTime? sendDate = null,
            int? cancelWindowCampaignMinutes = null,
            Dictionary<string, string> metadata = null,
            bool? isDraft = null,
            object useType = null,
            bool? autoCancelIfNcoa = null)
        {
            this.Name = name;
            if (description != null)
            {
                this.Description = description;
            }

            this.ScheduleType = scheduleType;
            this.TargetDeliveryDate = targetDeliveryDate;
            this.SendDate = sendDate;
            this.CancelWindowCampaignMinutes = cancelWindowCampaignMinutes;
            this.Metadata = metadata;
            this.IsDraft = isDraft;
            this.UseType = useType;
            this.AutoCancelIfNcoa = autoCancelIfNcoa;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets ScheduleType.
        /// </summary>
        [JsonProperty("schedule_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CmpScheduleTypeEnum? ScheduleType { get; set; }

        /// <summary>
        /// If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("target_delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetDeliveryDate { get; set; }

        /// <summary>
        /// If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("send_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SendDate { get; set; }

        /// <summary>
        /// A window, in minutes, within which the campaign can be canceled.
        /// </summary>
        [JsonProperty("cancel_window_campaign_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? CancelWindowCampaignMinutes { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Whether or not the campaign is still a draft. Can either be excluded or `false`.
        /// </summary>
        [JsonProperty("is_draft", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// Gets or sets UseType.
        /// </summary>
        [JsonProperty("use_type", NullValueHandling = NullValueHandling.Ignore)]
        public object UseType { get; set; }

        /// <summary>
        /// Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA.
        /// </summary>
        [JsonProperty("auto_cancel_if_ncoa", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCancelIfNcoa { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CampaignUpdatable : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
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
            return obj is CampaignUpdatable other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ScheduleType == null && other.ScheduleType == null) || (this.ScheduleType?.Equals(other.ScheduleType) == true)) &&
                ((this.TargetDeliveryDate == null && other.TargetDeliveryDate == null) || (this.TargetDeliveryDate?.Equals(other.TargetDeliveryDate) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true)) &&
                ((this.CancelWindowCampaignMinutes == null && other.CancelWindowCampaignMinutes == null) || (this.CancelWindowCampaignMinutes?.Equals(other.CancelWindowCampaignMinutes) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.IsDraft == null && other.IsDraft == null) || (this.IsDraft?.Equals(other.IsDraft) == true)) &&
                ((this.UseType == null && other.UseType == null) || (this.UseType?.Equals(other.UseType) == true)) &&
                ((this.AutoCancelIfNcoa == null && other.AutoCancelIfNcoa == null) || (this.AutoCancelIfNcoa?.Equals(other.AutoCancelIfNcoa) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.ScheduleType = {(this.ScheduleType == null ? "null" : this.ScheduleType.ToString())}");
            toStringOutput.Add($"this.TargetDeliveryDate = {(this.TargetDeliveryDate == null ? "null" : this.TargetDeliveryDate.ToString())}");
            toStringOutput.Add($"this.SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
            toStringOutput.Add($"this.CancelWindowCampaignMinutes = {(this.CancelWindowCampaignMinutes == null ? "null" : this.CancelWindowCampaignMinutes.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.IsDraft = {(this.IsDraft == null ? "null" : this.IsDraft.ToString())}");
            toStringOutput.Add($"UseType = {(this.UseType == null ? "null" : this.UseType.ToString())}");
            toStringOutput.Add($"this.AutoCancelIfNcoa = {(this.AutoCancelIfNcoa == null ? "null" : this.AutoCancelIfNcoa.ToString())}");
        }
    }
}