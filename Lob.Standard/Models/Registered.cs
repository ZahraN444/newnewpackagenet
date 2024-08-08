// <copyright file="Registered.cs" company="APIMatic">
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
    /// Registered.
    /// </summary>
    public class Registered
    {
        private string trackingNumber;
        private string description;
        private object mergeVariables;
        private int? perforatedPage;
        private string campaignId;
        private string failureReason;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "tracking_number", false },
            { "description", false },
            { "merge_variables", false },
            { "perforated_page", false },
            { "campaign_id", false },
            { "failure_reason", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Registered"/> class.
        /// </summary>
        public Registered()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Registered"/> class.
        /// </summary>
        /// <param name="extraService">extra_service.</param>
        /// <param name="color">color.</param>
        /// <param name="to">to.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="from">from.</param>
        /// <param name="id">id.</param>
        /// <param name="useType">use_type.</param>
        /// <param name="trackingNumber">tracking_number.</param>
        /// <param name="trackingEvents">tracking_events.</param>
        /// <param name="returnAddress">return_address.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mergeVariables">merge_variables.</param>
        /// <param name="sendDate">send_date.</param>
        /// <param name="mailType">mail_type.</param>
        /// <param name="doubleSided">double_sided.</param>
        /// <param name="addressPlacement">address_placement.</param>
        /// <param name="returnEnvelope">return_envelope.</param>
        /// <param name="perforatedPage">perforated_page.</param>
        /// <param name="customEnvelope">custom_envelope.</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="expectedDeliveryDate">expected_delivery_date.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="url">url.</param>
        /// <param name="templateId">template_id.</param>
        /// <param name="templateVersionId">template_version_id.</param>
        /// <param name="campaignId">campaign_id.</param>
        /// <param name="fsc">fsc.</param>
        /// <param name="status">status.</param>
        /// <param name="failureReason">failure_reason.</param>
        /// <param name="mObject">object.</param>
        public Registered(
            string extraService,
            bool color,
            object to,
            string carrier,
            object from,
            string id,
            object useType,
            string trackingNumber = null,
            List<Models.TrackingEventNormal> trackingEvents = null,
            object returnAddress = null,
            string description = null,
            Dictionary<string, string> metadata = null,
            object mergeVariables = null,
            object sendDate = null,
            Models.MailTypeEnum? mailType = null,
            bool? doubleSided = true,
            Models.AddressPlacementEnum? addressPlacement = null,
            object returnEnvelope = null,
            int? perforatedPage = null,
            object customEnvelope = null,
            List<Models.Thumbnail> thumbnails = null,
            DateTime? expectedDeliveryDate = null,
            DateTime? dateCreated = null,
            DateTime? dateModified = null,
            bool? deleted = null,
            string url = null,
            string templateId = null,
            string templateVersionId = null,
            string campaignId = null,
            bool? fsc = false,
            Models.ThestatusofthebuckslipEnum? status = null,
            string failureReason = null,
            Models.Object8Enum? mObject = null)
        {
            this.ExtraService = extraService;
            if (trackingNumber != null)
            {
                this.TrackingNumber = trackingNumber;
            }

            this.TrackingEvents = trackingEvents;
            this.ReturnAddress = returnAddress;
            if (description != null)
            {
                this.Description = description;
            }

            this.Metadata = metadata;
            if (mergeVariables != null)
            {
                this.MergeVariables = mergeVariables;
            }

            this.SendDate = sendDate;
            this.MailType = mailType;
            this.Color = color;
            this.DoubleSided = doubleSided;
            this.AddressPlacement = addressPlacement;
            this.ReturnEnvelope = returnEnvelope;
            if (perforatedPage != null)
            {
                this.PerforatedPage = perforatedPage;
            }

            this.CustomEnvelope = customEnvelope;
            this.To = to;
            this.Carrier = carrier;
            this.Thumbnails = thumbnails;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.From = from;
            this.Url = url;
            this.Id = id;
            this.TemplateId = templateId;
            this.TemplateVersionId = templateVersionId;
            if (campaignId != null)
            {
                this.CampaignId = campaignId;
            }

            this.UseType = useType;
            this.Fsc = fsc;
            this.Status = status;
            if (failureReason != null)
            {
                this.FailureReason = failureReason;
            }

            this.MObject = mObject;
        }

        /// <summary>
        /// Add an extra service to your letter. See <a href="https://www.lob.com/pricing/print-mail#compare" target="_blank">pricing</a> for extra costs incurred.
        ///   * registered - provides tracking and confirmation for international addresses
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("extra_service")]
        [JsonRequired]
        public string ExtraService { get; set; }

        /// <summary>
        /// The tracking number will appear here when it becomes available.
        /// Dummy tracking numbers are not created in test mode.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("tracking_number")]
        public string TrackingNumber
        {
            get
            {
                return this.trackingNumber;
            }

            set
            {
                this.shouldSerialize["tracking_number"] = true;
                this.trackingNumber = value;
            }
        }

        /// <summary>
        /// Tracking events are not populated for registered letters.
        /// </summary>
        [JsonProperty("tracking_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TrackingEventNormal> TrackingEvents { get; set; }

        /// <summary>
        /// Gets or sets ReturnAddress.
        /// </summary>
        [JsonProperty("return_address", NullValueHandling = NullValueHandling.Ignore)]
        public object ReturnAddress { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

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
        /// Gets or sets MailType.
        /// </summary>
        [JsonProperty("mail_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MailTypeEnum? MailType { get; set; }

        /// <summary>
        /// Set this key to `true` if you would like to print in color. Set to `false` if you would like to print in black and white.
        /// </summary>
        [JsonProperty("color")]
        [JsonRequired]
        public bool Color { get; set; }

        /// <summary>
        /// Set this attribute to `true` for double sided printing, or `false` for for single sided printing. Defaults to `true`.
        /// </summary>
        [JsonProperty("double_sided", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoubleSided { get; set; }

        /// <summary>
        /// Gets or sets AddressPlacement.
        /// </summary>
        [JsonProperty("address_placement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressPlacementEnum? AddressPlacement { get; set; }

        /// <summary>
        /// Gets or sets ReturnEnvelope.
        /// </summary>
        [JsonProperty("return_envelope", NullValueHandling = NullValueHandling.Ignore)]
        public object ReturnEnvelope { get; set; }

        /// <summary>
        /// Required if `return_envelope` is `true`. The number of the page that should be perforated for use with the return envelope. Must be greater than or equal to `1`. The blank page added by `address_placement=insert_blank_page` will be ignored when considering the perforated page number. To see how perforation will impact your letter design, view our <a href="https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/letter_perf_template.pdf" target="_blank">perforation guide</a>.
        /// </summary>
        [JsonProperty("perforated_page")]
        public int? PerforatedPage
        {
            get
            {
                return this.perforatedPage;
            }

            set
            {
                this.shouldSerialize["perforated_page"] = true;
                this.perforatedPage = value;
            }
        }

        /// <summary>
        /// Gets or sets CustomEnvelope.
        /// </summary>
        [JsonProperty("custom_envelope", NullValueHandling = NullValueHandling.Ignore)]
        public object CustomEnvelope { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to")]
        [JsonRequired]
        public object To { get; set; }

        /// <summary>
        /// Gets or sets Carrier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("carrier")]
        [JsonRequired]
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
        [JsonProperty("from")]
        [JsonRequired]
        public object From { get; set; }

        /// <summary>
        /// A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `ltr_`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets TemplateId.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or sets TemplateVersionId.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("template_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateVersionId { get; set; }

        /// <summary>
        /// The unique ID of the associated campaign if the resource was generated from a campaign.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        [JsonProperty("use_type")]
        [JsonRequired]
        public object UseType { get; set; }

        /// <summary>
        /// This is in beta. Contact support@lob.com or your account contact to learn more. Not available for `A4` letter size.
        /// </summary>
        [JsonProperty("fsc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fsc { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThestatusofthebuckslipEnum? Status { get; set; }

        /// <summary>
        /// A string describing the reason for failure if the letter failed to render.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        public Models.Object8Enum? MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Registered : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrackingNumber()
        {
            this.shouldSerialize["tracking_number"] = false;
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
        public void UnsetPerforatedPage()
        {
            this.shouldSerialize["perforated_page"] = false;
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
        public bool ShouldSerializeTrackingNumber()
        {
            return this.shouldSerialize["tracking_number"];
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
        public bool ShouldSerializePerforatedPage()
        {
            return this.shouldSerialize["perforated_page"];
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
            return obj is Registered other &&                ((this.ExtraService == null && other.ExtraService == null) || (this.ExtraService?.Equals(other.ExtraService) == true)) &&
                ((this.TrackingNumber == null && other.TrackingNumber == null) || (this.TrackingNumber?.Equals(other.TrackingNumber) == true)) &&
                ((this.TrackingEvents == null && other.TrackingEvents == null) || (this.TrackingEvents?.Equals(other.TrackingEvents) == true)) &&
                ((this.ReturnAddress == null && other.ReturnAddress == null) || (this.ReturnAddress?.Equals(other.ReturnAddress) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MergeVariables == null && other.MergeVariables == null) || (this.MergeVariables?.Equals(other.MergeVariables) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                this.Color.Equals(other.Color) &&
                ((this.DoubleSided == null && other.DoubleSided == null) || (this.DoubleSided?.Equals(other.DoubleSided) == true)) &&
                ((this.AddressPlacement == null && other.AddressPlacement == null) || (this.AddressPlacement?.Equals(other.AddressPlacement) == true)) &&
                ((this.ReturnEnvelope == null && other.ReturnEnvelope == null) || (this.ReturnEnvelope?.Equals(other.ReturnEnvelope) == true)) &&
                ((this.PerforatedPage == null && other.PerforatedPage == null) || (this.PerforatedPage?.Equals(other.PerforatedPage) == true)) &&
                ((this.CustomEnvelope == null && other.CustomEnvelope == null) || (this.CustomEnvelope?.Equals(other.CustomEnvelope) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.Carrier == null && other.Carrier == null) || (this.Carrier?.Equals(other.Carrier) == true)) &&
                ((this.Thumbnails == null && other.Thumbnails == null) || (this.Thumbnails?.Equals(other.Thumbnails) == true)) &&
                ((this.ExpectedDeliveryDate == null && other.ExpectedDeliveryDate == null) || (this.ExpectedDeliveryDate?.Equals(other.ExpectedDeliveryDate) == true)) &&
                ((this.DateCreated == null && other.DateCreated == null) || (this.DateCreated?.Equals(other.DateCreated) == true)) &&
                ((this.DateModified == null && other.DateModified == null) || (this.DateModified?.Equals(other.DateModified) == true)) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.TemplateId == null && other.TemplateId == null) || (this.TemplateId?.Equals(other.TemplateId) == true)) &&
                ((this.TemplateVersionId == null && other.TemplateVersionId == null) || (this.TemplateVersionId?.Equals(other.TemplateVersionId) == true)) &&
                ((this.CampaignId == null && other.CampaignId == null) || (this.CampaignId?.Equals(other.CampaignId) == true)) &&
                ((this.UseType == null && other.UseType == null) || (this.UseType?.Equals(other.UseType) == true)) &&
                ((this.Fsc == null && other.Fsc == null) || (this.Fsc?.Equals(other.Fsc) == true)) &&
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
            toStringOutput.Add($"this.ExtraService = {(this.ExtraService == null ? "null" : this.ExtraService)}");
            toStringOutput.Add($"this.TrackingNumber = {(this.TrackingNumber == null ? "null" : this.TrackingNumber)}");
            toStringOutput.Add($"this.TrackingEvents = {(this.TrackingEvents == null ? "null" : $"[{string.Join(", ", this.TrackingEvents)} ]")}");
            toStringOutput.Add($"ReturnAddress = {(this.ReturnAddress == null ? "null" : this.ReturnAddress.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"MergeVariables = {(this.MergeVariables == null ? "null" : this.MergeVariables.ToString())}");
            toStringOutput.Add($"SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"this.Color = {this.Color}");
            toStringOutput.Add($"this.DoubleSided = {(this.DoubleSided == null ? "null" : this.DoubleSided.ToString())}");
            toStringOutput.Add($"this.AddressPlacement = {(this.AddressPlacement == null ? "null" : this.AddressPlacement.ToString())}");
            toStringOutput.Add($"ReturnEnvelope = {(this.ReturnEnvelope == null ? "null" : this.ReturnEnvelope.ToString())}");
            toStringOutput.Add($"this.PerforatedPage = {(this.PerforatedPage == null ? "null" : this.PerforatedPage.ToString())}");
            toStringOutput.Add($"CustomEnvelope = {(this.CustomEnvelope == null ? "null" : this.CustomEnvelope.ToString())}");
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"this.Carrier = {(this.Carrier == null ? "null" : this.Carrier)}");
            toStringOutput.Add($"this.Thumbnails = {(this.Thumbnails == null ? "null" : $"[{string.Join(", ", this.Thumbnails)} ]")}");
            toStringOutput.Add($"this.ExpectedDeliveryDate = {(this.ExpectedDeliveryDate == null ? "null" : this.ExpectedDeliveryDate.ToString())}");
            toStringOutput.Add($"this.DateCreated = {(this.DateCreated == null ? "null" : this.DateCreated.ToString())}");
            toStringOutput.Add($"this.DateModified = {(this.DateModified == null ? "null" : this.DateModified.ToString())}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
            toStringOutput.Add($"From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.TemplateId = {(this.TemplateId == null ? "null" : this.TemplateId)}");
            toStringOutput.Add($"this.TemplateVersionId = {(this.TemplateVersionId == null ? "null" : this.TemplateVersionId)}");
            toStringOutput.Add($"this.CampaignId = {(this.CampaignId == null ? "null" : this.CampaignId)}");
            toStringOutput.Add($"UseType = {(this.UseType == null ? "null" : this.UseType.ToString())}");
            toStringOutput.Add($"this.Fsc = {(this.Fsc == null ? "null" : this.Fsc.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.FailureReason = {(this.FailureReason == null ? "null" : this.FailureReason)}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
        }
    }
}