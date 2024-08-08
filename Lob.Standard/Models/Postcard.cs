// <copyright file="Postcard.cs" company="APIMatic">
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
    /// Postcard.
    /// </summary>
    public class Postcard
    {
        private string description;
        private object mergeVariables;
        private string frontTemplateVersionId;
        private string backTemplateVersionId;
        private List<Models.TrackingEventNormal> trackingEvents;
        private string campaignId;
        private string failureReason;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "merge_variables", false },
            { "front_template_version_id", false },
            { "back_template_version_id", false },
            { "tracking_events", false },
            { "campaign_id", false },
            { "failure_reason", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Postcard"/> class.
        /// </summary>
        public Postcard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Postcard"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="id">id.</param>
        /// <param name="url">url.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mailType">mail_type.</param>
        /// <param name="mergeVariables">merge_variables.</param>
        /// <param name="sendDate">send_date.</param>
        /// <param name="size">size.</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="expectedDeliveryDate">expected_delivery_date.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="from">from.</param>
        /// <param name="frontTemplateId">front_template_id.</param>
        /// <param name="backTemplateId">back_template_id.</param>
        /// <param name="frontTemplateVersionId">front_template_version_id.</param>
        /// <param name="backTemplateVersionId">back_template_version_id.</param>
        /// <param name="trackingEvents">tracking_events.</param>
        /// <param name="campaignId">campaign_id.</param>
        /// <param name="useType">use_type.</param>
        /// <param name="status">status.</param>
        /// <param name="failureReason">failure_reason.</param>
        /// <param name="mObject">object.</param>
        public Postcard(
            object to,
            string carrier,
            string id,
            string url,
            string description = null,
            Dictionary<string, string> metadata = null,
            Models.MailTypeEnum? mailType = null,
            object mergeVariables = null,
            object sendDate = null,
            Models.PostcardSizeEnum? size = null,
            List<Models.Thumbnail> thumbnails = null,
            DateTime? expectedDeliveryDate = null,
            DateTime? dateCreated = null,
            DateTime? dateModified = null,
            bool? deleted = null,
            Models.AddressUs from = null,
            string frontTemplateId = null,
            string backTemplateId = null,
            string frontTemplateVersionId = null,
            string backTemplateVersionId = null,
            List<Models.TrackingEventNormal> trackingEvents = null,
            string campaignId = null,
            object useType = null,
            Models.ThestatusofthebuckslipEnum? status = null,
            string failureReason = null,
            Models.Object10Enum? mObject = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Metadata = metadata;
            this.MailType = mailType;
            if (mergeVariables != null)
            {
                this.MergeVariables = mergeVariables;
            }

            this.SendDate = sendDate;
            this.Size = size;
            this.To = to;
            this.Carrier = carrier;
            this.Thumbnails = thumbnails;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.From = from;
            this.Id = id;
            this.FrontTemplateId = frontTemplateId;
            this.BackTemplateId = backTemplateId;
            if (frontTemplateVersionId != null)
            {
                this.FrontTemplateVersionId = frontTemplateVersionId;
            }

            if (backTemplateVersionId != null)
            {
                this.BackTemplateVersionId = backTemplateVersionId;
            }

            if (trackingEvents != null)
            {
                this.TrackingEvents = trackingEvents;
            }

            this.Url = url;
            if (campaignId != null)
            {
                this.CampaignId = campaignId;
            }

            this.UseType = useType;
            this.Status = status;
            if (failureReason != null)
            {
                this.FailureReason = failureReason;
            }

            this.MObject = mObject;
        }

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
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets MailType.
        /// </summary>
        [JsonProperty("mail_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MailTypeEnum? MailType { get; set; }

        /// <summary>
        /// <![CDATA[
        /// You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: `{{variable_name}}`, pass in `{"variable_name": "Harry"}` to render `Harry`. `merge_variables` must be an object. Any type of value is accepted as long as the object is valid JSON; you can use `strings`, `numbers`, `booleans`, `arrays`, `objects`, or `null`. The max length of the object is 25,000 characters. If you call `JSON.stringify` on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: `!`, `"`, `#`, `%`, `&`, `'`, `(`, `)`, `*`, `+`, `,`, `/`, `;`, `<`, `=`, `>`, `@`, `[`, `\`, `]`, `^`, `` ` ``, `{`, `|`, `}`, `~`. More instructions can be found in <a href="https://help.lob.com/print-and-mail/designing-mail-creatives/dynamic-personalization#using-html-and-merge-variables-10" target="_blank">our guide to using html and merge variables</a>. Depending on your <a href="https://dashboard.lob.com/#/settings/account" target="_blank">Merge Variable strictness</a> setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.
        /// ]]>
        /// </summary>
        [JsonProperty("merge_variables")]
        public object MergeVariables
        {
            get
            {
                return this.mergeVariables;
            }

            set
            {
                this.shouldSerialize["merge_variables"] = true;
                this.mergeVariables = value;
            }
        }

        /// <summary>
        /// Gets or sets SendDate.
        /// </summary>
        [JsonProperty("send_date", NullValueHandling = NullValueHandling.Ignore)]
        public object SendDate { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PostcardSizeEnum? Size { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to")]
        public object To { get; set; }

        /// <summary>
        /// Gets or sets Carrier.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or sets Thumbnails.
        /// </summary>
        [JsonProperty("thumbnails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// A date in YYYY-MM-DD format of the mailpiece's expected delivery date based on its `send_date`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("expected_delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was last modified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or sets From.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressUs From { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `psc_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the HTML template used for the front of the postcard. Only filled out when the request contains a valid postcard template ID.
        /// </summary>
        [JsonProperty("front_template_id", NullValueHandling = NullValueHandling.Include)]
        public string FrontTemplateId { get; set; }

        /// <summary>
        /// The unique ID of the HTML template used for the back of the postcard. Only filled out when the request contains a valid postcard template ID.
        /// </summary>
        [JsonProperty("back_template_id", NullValueHandling = NullValueHandling.Include)]
        public string BackTemplateId { get; set; }

        /// <summary>
        /// The unique ID of the specific version of the HTML template used for the front of the postcard. Only filled out when the request contains a valid postcard template ID.
        /// </summary>
        [JsonProperty("front_template_version_id")]
        public string FrontTemplateVersionId
        {
            get
            {
                return this.frontTemplateVersionId;
            }

            set
            {
                this.shouldSerialize["front_template_version_id"] = true;
                this.frontTemplateVersionId = value;
            }
        }

        /// <summary>
        /// The unique ID of the specific version of the HTML template used for the back of the postcard. Only filled out when the request contains a valid postcard template ID.
        /// </summary>
        [JsonProperty("back_template_version_id")]
        public string BackTemplateVersionId
        {
            get
            {
                return this.backTemplateVersionId;
            }

            set
            {
                this.shouldSerialize["back_template_version_id"] = true;
                this.backTemplateVersionId = value;
            }
        }

        /// <summary>
        /// An array of tracking_event objects ordered by ascending `time`. Will not be populated for postcards created in test mode.
        /// </summary>
        [JsonProperty("tracking_events")]
        public List<Models.TrackingEventNormal> TrackingEvents
        {
            get
            {
                return this.trackingEvents;
            }

            set
            {
                this.shouldSerialize["tracking_events"] = true;
                this.trackingEvents = value;
            }
        }

        /// <summary>
        /// A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The unique ID of the associated campaign if the resource was generated from a campaign.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId
        {
            get
            {
                return this.campaignId;
            }

            set
            {
                this.shouldSerialize["campaign_id"] = true;
                this.campaignId = value;
            }
        }

        /// <summary>
        /// Gets or sets UseType.
        /// </summary>
        [JsonProperty("use_type", NullValueHandling = NullValueHandling.Ignore)]
        public object UseType { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThestatusofthebuckslipEnum? Status { get; set; }

        /// <summary>
        /// A string describing the reason for failure if the postcard failed to render.
        /// </summary>
        [JsonProperty("failure_reason")]
        public string FailureReason
        {
            get
            {
                return this.failureReason;
            }

            set
            {
                this.shouldSerialize["failure_reason"] = true;
                this.failureReason = value;
            }
        }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Object10Enum? MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Postcard : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMergeVariables()
        {
            this.shouldSerialize["merge_variables"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFrontTemplateVersionId()
        {
            this.shouldSerialize["front_template_version_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBackTemplateVersionId()
        {
            this.shouldSerialize["back_template_version_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrackingEvents()
        {
            this.shouldSerialize["tracking_events"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCampaignId()
        {
            this.shouldSerialize["campaign_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFailureReason()
        {
            this.shouldSerialize["failure_reason"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMergeVariables()
        {
            return this.shouldSerialize["merge_variables"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFrontTemplateVersionId()
        {
            return this.shouldSerialize["front_template_version_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBackTemplateVersionId()
        {
            return this.shouldSerialize["back_template_version_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrackingEvents()
        {
            return this.shouldSerialize["tracking_events"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCampaignId()
        {
            return this.shouldSerialize["campaign_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFailureReason()
        {
            return this.shouldSerialize["failure_reason"];
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
            return obj is Postcard other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.MergeVariables == null && other.MergeVariables == null) || (this.MergeVariables?.Equals(other.MergeVariables) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.Carrier == null && other.Carrier == null) || (this.Carrier?.Equals(other.Carrier) == true)) &&
                ((this.Thumbnails == null && other.Thumbnails == null) || (this.Thumbnails?.Equals(other.Thumbnails) == true)) &&
                ((this.ExpectedDeliveryDate == null && other.ExpectedDeliveryDate == null) || (this.ExpectedDeliveryDate?.Equals(other.ExpectedDeliveryDate) == true)) &&
                ((this.DateCreated == null && other.DateCreated == null) || (this.DateCreated?.Equals(other.DateCreated) == true)) &&
                ((this.DateModified == null && other.DateModified == null) || (this.DateModified?.Equals(other.DateModified) == true)) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.FrontTemplateId == null && other.FrontTemplateId == null) || (this.FrontTemplateId?.Equals(other.FrontTemplateId) == true)) &&
                ((this.BackTemplateId == null && other.BackTemplateId == null) || (this.BackTemplateId?.Equals(other.BackTemplateId) == true)) &&
                ((this.FrontTemplateVersionId == null && other.FrontTemplateVersionId == null) || (this.FrontTemplateVersionId?.Equals(other.FrontTemplateVersionId) == true)) &&
                ((this.BackTemplateVersionId == null && other.BackTemplateVersionId == null) || (this.BackTemplateVersionId?.Equals(other.BackTemplateVersionId) == true)) &&
                ((this.TrackingEvents == null && other.TrackingEvents == null) || (this.TrackingEvents?.Equals(other.TrackingEvents) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.CampaignId == null && other.CampaignId == null) || (this.CampaignId?.Equals(other.CampaignId) == true)) &&
                ((this.UseType == null && other.UseType == null) || (this.UseType?.Equals(other.UseType) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.FailureReason == null && other.FailureReason == null) || (this.FailureReason?.Equals(other.FailureReason) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"MergeVariables = {(this.MergeVariables == null ? "null" : this.MergeVariables.ToString())}");
            toStringOutput.Add($"SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size.ToString())}");
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"this.Carrier = {(this.Carrier == null ? "null" : this.Carrier)}");
            toStringOutput.Add($"this.Thumbnails = {(this.Thumbnails == null ? "null" : $"[{string.Join(", ", this.Thumbnails)} ]")}");
            toStringOutput.Add($"this.ExpectedDeliveryDate = {(this.ExpectedDeliveryDate == null ? "null" : this.ExpectedDeliveryDate.ToString())}");
            toStringOutput.Add($"this.DateCreated = {(this.DateCreated == null ? "null" : this.DateCreated.ToString())}");
            toStringOutput.Add($"this.DateModified = {(this.DateModified == null ? "null" : this.DateModified.ToString())}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.FrontTemplateId = {(this.FrontTemplateId == null ? "null" : this.FrontTemplateId)}");
            toStringOutput.Add($"this.BackTemplateId = {(this.BackTemplateId == null ? "null" : this.BackTemplateId)}");
            toStringOutput.Add($"this.FrontTemplateVersionId = {(this.FrontTemplateVersionId == null ? "null" : this.FrontTemplateVersionId)}");
            toStringOutput.Add($"this.BackTemplateVersionId = {(this.BackTemplateVersionId == null ? "null" : this.BackTemplateVersionId)}");
            toStringOutput.Add($"this.TrackingEvents = {(this.TrackingEvents == null ? "null" : $"[{string.Join(", ", this.TrackingEvents)} ]")}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.CampaignId = {(this.CampaignId == null ? "null" : this.CampaignId)}");
            toStringOutput.Add($"UseType = {(this.UseType == null ? "null" : this.UseType.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.FailureReason = {(this.FailureReason == null ? "null" : this.FailureReason)}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
        }
    }
}