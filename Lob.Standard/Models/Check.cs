// <copyright file="Check.cs" company="APIMatic">
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
    /// Check.
    /// </summary>
    public class Check
    {
        private string description;
        private object mergeVariables;
        private string memo;
        private List<Models.TrackingEventNormal> trackingEvents;
        private string failureReason;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "merge_variables", false },
            { "memo", false },
            { "tracking_events", false },
            { "failure_reason", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Check"/> class.
        /// </summary>
        public Check()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Check"/> class.
        /// </summary>
        /// <param name="useType">use_type.</param>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="bankAccount">bank_account.</param>
        /// <param name="url">url.</param>
        /// <param name="to">to.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mergeVariables">merge_variables.</param>
        /// <param name="sendDate">send_date.</param>
        /// <param name="mailType">mail_type.</param>
        /// <param name="memo">memo.</param>
        /// <param name="checkNumber">check_number.</param>
        /// <param name="message">message.</param>
        /// <param name="from">from.</param>
        /// <param name="checkBottomTemplateId">check_bottom_template_id.</param>
        /// <param name="attachmentTemplateId">attachment_template_id.</param>
        /// <param name="checkBottomTemplateVersionId">check_bottom_template_version_id.</param>
        /// <param name="attachmentTemplateVersionId">attachment_template_version_id.</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="expectedDeliveryDate">expected_delivery_date.</param>
        /// <param name="trackingEvents">tracking_events.</param>
        /// <param name="status">status.</param>
        /// <param name="failureReason">failure_reason.</param>
        /// <param name="mObject">object.</param>
        /// <param name="deleted">deleted.</param>
        public Check(
            object useType,
            string id,
            double amount,
            Models.BankAccount bankAccount,
            string url,
            Models.ToAddressUsChk to,
            string carrier,
            DateTime dateCreated,
            DateTime dateModified,
            string description = null,
            Dictionary<string, string> metadata = null,
            object mergeVariables = null,
            object sendDate = null,
            Models.MailType2Enum? mailType = null,
            string memo = null,
            int? checkNumber = null,
            string message = null,
            Models.AddressUs from = null,
            string checkBottomTemplateId = null,
            string attachmentTemplateId = null,
            string checkBottomTemplateVersionId = null,
            string attachmentTemplateVersionId = null,
            List<Models.Thumbnail> thumbnails = null,
            DateTime? expectedDeliveryDate = null,
            List<Models.TrackingEventNormal> trackingEvents = null,
            Models.ThestatusofthebuckslipEnum? status = null,
            string failureReason = null,
            Models.Object5Enum? mObject = null,
            bool? deleted = null)
        {
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
            if (memo != null)
            {
                this.Memo = memo;
            }

            this.CheckNumber = checkNumber;
            this.Message = message;
            this.UseType = useType;
            this.From = from;
            this.Id = id;
            this.Amount = amount;
            this.BankAccount = bankAccount;
            this.CheckBottomTemplateId = checkBottomTemplateId;
            this.AttachmentTemplateId = attachmentTemplateId;
            this.CheckBottomTemplateVersionId = checkBottomTemplateVersionId;
            this.AttachmentTemplateVersionId = attachmentTemplateVersionId;
            this.Url = url;
            this.To = to;
            this.Carrier = carrier;
            this.Thumbnails = thumbnails;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
            if (trackingEvents != null)
            {
                this.TrackingEvents = trackingEvents;
            }

            this.Status = status;
            if (failureReason != null)
            {
                this.FailureReason = failureReason;
            }

            this.MObject = mObject;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
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
        public Models.MailType2Enum? MailType { get; set; }

        /// <summary>
        /// Text to include on the memo line of the check.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo
        {
            get
            {
                return this.memo;
            }

            set
            {
                this.shouldSerialize["memo"] = true;
                this.memo = value;
            }
        }

        /// <summary>
        /// An integer that designates the check number.
        /// If `check_number` is not provided, checks created from a new `bank_account` will start at `10000` and increment with each check created with the `bank_account`.
        /// A provided `check_number` overrides the defaults. Subsequent checks created with the same `bank_account` will increment from the provided check number.
        /// </summary>
        [JsonProperty("check_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? CheckNumber { get; set; }

        /// <summary>
        /// Max of 400 characters to be included at the bottom of the check page.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets UseType.
        /// </summary>
        [JsonProperty("use_type")]
        public object UseType { get; set; }

        /// <summary>
        /// Gets or sets From.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressUs From { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `chk_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The payment amount to be sent in US dollars.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets BankAccount.
        /// </summary>
        [JsonProperty("bank_account")]
        public Models.BankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or sets CheckBottomTemplateId.
        /// </summary>
        [JsonProperty("check_bottom_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckBottomTemplateId { get; set; }

        /// <summary>
        /// Gets or sets AttachmentTemplateId.
        /// </summary>
        [JsonProperty("attachment_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentTemplateId { get; set; }

        /// <summary>
        /// Gets or sets CheckBottomTemplateVersionId.
        /// </summary>
        [JsonProperty("check_bottom_template_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckBottomTemplateVersionId { get; set; }

        /// <summary>
        /// Gets or sets AttachmentTemplateVersionId.
        /// </summary>
        [JsonProperty("attachment_template_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentTemplateVersionId { get; set; }

        /// <summary>
        /// A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to")]
        public Models.ToAddressUsChk To { get; set; }

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
        /// An array of tracking_event objects ordered by ascending `time`. Will not be populated for checks created in test mode.
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
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThestatusofthebuckslipEnum? Status { get; set; }

        /// <summary>
        /// A string describing the reason for failure if the check failed to render.
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
        public Models.Object5Enum? MObject { get; set; }

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

            return $"Check : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
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
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
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
            return obj is Check other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MergeVariables == null && other.MergeVariables == null) || (this.MergeVariables?.Equals(other.MergeVariables) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.CheckNumber == null && other.CheckNumber == null) || (this.CheckNumber?.Equals(other.CheckNumber) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.UseType == null && other.UseType == null) || (this.UseType?.Equals(other.UseType) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.BankAccount == null && other.BankAccount == null) || (this.BankAccount?.Equals(other.BankAccount) == true)) &&
                ((this.CheckBottomTemplateId == null && other.CheckBottomTemplateId == null) || (this.CheckBottomTemplateId?.Equals(other.CheckBottomTemplateId) == true)) &&
                ((this.AttachmentTemplateId == null && other.AttachmentTemplateId == null) || (this.AttachmentTemplateId?.Equals(other.AttachmentTemplateId) == true)) &&
                ((this.CheckBottomTemplateVersionId == null && other.CheckBottomTemplateVersionId == null) || (this.CheckBottomTemplateVersionId?.Equals(other.CheckBottomTemplateVersionId) == true)) &&
                ((this.AttachmentTemplateVersionId == null && other.AttachmentTemplateVersionId == null) || (this.AttachmentTemplateVersionId?.Equals(other.AttachmentTemplateVersionId) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.Carrier == null && other.Carrier == null) || (this.Carrier?.Equals(other.Carrier) == true)) &&
                ((this.Thumbnails == null && other.Thumbnails == null) || (this.Thumbnails?.Equals(other.Thumbnails) == true)) &&
                ((this.ExpectedDeliveryDate == null && other.ExpectedDeliveryDate == null) || (this.ExpectedDeliveryDate?.Equals(other.ExpectedDeliveryDate) == true)) &&
                ((this.TrackingEvents == null && other.TrackingEvents == null) || (this.TrackingEvents?.Equals(other.TrackingEvents) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.FailureReason == null && other.FailureReason == null) || (this.FailureReason?.Equals(other.FailureReason) == true)) &&
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
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"MergeVariables = {(this.MergeVariables == null ? "null" : this.MergeVariables.ToString())}");
            toStringOutput.Add($"SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.CheckNumber = {(this.CheckNumber == null ? "null" : this.CheckNumber.ToString())}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"UseType = {(this.UseType == null ? "null" : this.UseType.ToString())}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.BankAccount = {(this.BankAccount == null ? "null" : this.BankAccount.ToString())}");
            toStringOutput.Add($"this.CheckBottomTemplateId = {(this.CheckBottomTemplateId == null ? "null" : this.CheckBottomTemplateId)}");
            toStringOutput.Add($"this.AttachmentTemplateId = {(this.AttachmentTemplateId == null ? "null" : this.AttachmentTemplateId)}");
            toStringOutput.Add($"this.CheckBottomTemplateVersionId = {(this.CheckBottomTemplateVersionId == null ? "null" : this.CheckBottomTemplateVersionId)}");
            toStringOutput.Add($"this.AttachmentTemplateVersionId = {(this.AttachmentTemplateVersionId == null ? "null" : this.AttachmentTemplateVersionId)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"this.Carrier = {(this.Carrier == null ? "null" : this.Carrier)}");
            toStringOutput.Add($"this.Thumbnails = {(this.Thumbnails == null ? "null" : $"[{string.Join(", ", this.Thumbnails)} ]")}");
            toStringOutput.Add($"this.ExpectedDeliveryDate = {(this.ExpectedDeliveryDate == null ? "null" : this.ExpectedDeliveryDate.ToString())}");
            toStringOutput.Add($"this.TrackingEvents = {(this.TrackingEvents == null ? "null" : $"[{string.Join(", ", this.TrackingEvents)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.FailureReason = {(this.FailureReason == null ? "null" : this.FailureReason)}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
        }
    }
}