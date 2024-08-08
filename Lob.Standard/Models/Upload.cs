// <copyright file="Upload.cs" company="APIMatic">
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
    /// Upload.
    /// </summary>
    public class Upload
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Upload"/> class.
        /// </summary>
        public Upload()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Upload"/> class.
        /// </summary>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="requiredAddressColumnMapping">requiredAddressColumnMapping.</param>
        /// <param name="optionalAddressColumnMapping">optionalAddressColumnMapping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="id">id.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="mode">mode.</param>
        /// <param name="state">state.</param>
        /// <param name="totalMailpieces">totalMailpieces.</param>
        /// <param name="failedMailpieces">failedMailpieces.</param>
        /// <param name="validatedMailpieces">validatedMailpieces.</param>
        /// <param name="bytesProcessed">bytesProcessed.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="dateModified">dateModified.</param>
        /// <param name="mergeVariableColumnMapping">mergeVariableColumnMapping.</param>
        /// <param name="failuresUrl">failuresUrl.</param>
        /// <param name="originalFilename">originalFilename.</param>
        public Upload(
            string campaignId,
            Models.RequiredAddressColumnMapping requiredAddressColumnMapping,
            Models.OptionalAddressColumnMapping optionalAddressColumnMapping,
            Models.Metadata1 metadata,
            string id,
            string accountId,
            Models.ModeEnum mode,
            Models.UploadStateEnum state,
            int totalMailpieces,
            int failedMailpieces,
            int validatedMailpieces,
            int bytesProcessed,
            DateTime dateCreated,
            DateTime dateModified,
            object mergeVariableColumnMapping = null,
            string failuresUrl = null,
            string originalFilename = null)
        {
            this.CampaignId = campaignId;
            this.RequiredAddressColumnMapping = requiredAddressColumnMapping;
            this.OptionalAddressColumnMapping = optionalAddressColumnMapping;
            this.Metadata = metadata;
            this.MergeVariableColumnMapping = mergeVariableColumnMapping;
            this.Id = id;
            this.AccountId = accountId;
            this.Mode = mode;
            this.FailuresUrl = failuresUrl;
            this.OriginalFilename = originalFilename;
            this.State = state;
            this.TotalMailpieces = totalMailpieces;
            this.FailedMailpieces = failedMailpieces;
            this.ValidatedMailpieces = validatedMailpieces;
            this.BytesProcessed = bytesProcessed;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
        }

        /// <summary>
        /// Gets or sets CampaignId.
        /// </summary>
        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets RequiredAddressColumnMapping.
        /// </summary>
        [JsonProperty("requiredAddressColumnMapping")]
        public Models.RequiredAddressColumnMapping RequiredAddressColumnMapping { get; set; }

        /// <summary>
        /// Gets or sets OptionalAddressColumnMapping.
        /// </summary>
        [JsonProperty("optionalAddressColumnMapping")]
        public Models.OptionalAddressColumnMapping OptionalAddressColumnMapping { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Models.Metadata1 Metadata { get; set; }

        /// <summary>
        /// The mapping of column headers in your file to the merge variables present in your creative. See our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#step-3-map-merge-variable-data-if-applicable-7" target="_blank">Campaign Audience Guide</a> for additional details. <br />If a merge variable has the same "name" as a "key" in the `requiredAddressColumnMapping` or `optionalAddressColumnMapping` objects, then they **CANNOT** have a different value in this object. If a different value is provided, then when the campaign is processing it will get overwritten with the mapped value present in the `requiredAddressColumnMapping` or `optionalAddressColumnMapping` objects. If using customized QR code redirect from the Audience file, then a `qr_code_redirect_url` must be mapped to the column header as used in the CSV.
        /// </summary>
        [JsonProperty("mergeVariableColumnMapping", NullValueHandling = NullValueHandling.Include)]
        public object MergeVariableColumnMapping { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `upl_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Account ID that made the request
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets Mode.
        /// </summary>
        [JsonProperty("mode")]
        public Models.ModeEnum Mode { get; set; }

        /// <summary>
        /// Url where your campaign mailpiece failures can be retrieved
        /// </summary>
        [JsonProperty("failuresUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string FailuresUrl { get; set; }

        /// <summary>
        /// Filename of the upload
        /// </summary>
        [JsonProperty("originalFilename", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.UploadStateEnum State { get; set; }

        /// <summary>
        /// Total number of recipients for the campaign
        /// </summary>
        [JsonProperty("totalMailpieces")]
        public int TotalMailpieces { get; set; }

        /// <summary>
        /// Number of mailpieces that failed to create
        /// </summary>
        [JsonProperty("failedMailpieces")]
        public int FailedMailpieces { get; set; }

        /// <summary>
        /// Number of mailpieces that were successfully created
        /// </summary>
        [JsonProperty("validatedMailpieces")]
        public int ValidatedMailpieces { get; set; }

        /// <summary>
        /// Number of bytes processed in your CSV
        /// </summary>
        [JsonProperty("bytesProcessed")]
        public int BytesProcessed { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the upload was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the upload was last modified
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateModified")]
        public DateTime DateModified { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Upload : ({string.Join(", ", toStringOutput)})";
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
            return obj is Upload other &&                ((this.CampaignId == null && other.CampaignId == null) || (this.CampaignId?.Equals(other.CampaignId) == true)) &&
                ((this.RequiredAddressColumnMapping == null && other.RequiredAddressColumnMapping == null) || (this.RequiredAddressColumnMapping?.Equals(other.RequiredAddressColumnMapping) == true)) &&
                ((this.OptionalAddressColumnMapping == null && other.OptionalAddressColumnMapping == null) || (this.OptionalAddressColumnMapping?.Equals(other.OptionalAddressColumnMapping) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MergeVariableColumnMapping == null && other.MergeVariableColumnMapping == null) || (this.MergeVariableColumnMapping?.Equals(other.MergeVariableColumnMapping) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                this.Mode.Equals(other.Mode) &&
                ((this.FailuresUrl == null && other.FailuresUrl == null) || (this.FailuresUrl?.Equals(other.FailuresUrl) == true)) &&
                ((this.OriginalFilename == null && other.OriginalFilename == null) || (this.OriginalFilename?.Equals(other.OriginalFilename) == true)) &&
                this.State.Equals(other.State) &&
                this.TotalMailpieces.Equals(other.TotalMailpieces) &&
                this.FailedMailpieces.Equals(other.FailedMailpieces) &&
                this.ValidatedMailpieces.Equals(other.ValidatedMailpieces) &&
                this.BytesProcessed.Equals(other.BytesProcessed) &&
                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CampaignId = {(this.CampaignId == null ? "null" : this.CampaignId)}");
            toStringOutput.Add($"this.RequiredAddressColumnMapping = {(this.RequiredAddressColumnMapping == null ? "null" : this.RequiredAddressColumnMapping.ToString())}");
            toStringOutput.Add($"this.OptionalAddressColumnMapping = {(this.OptionalAddressColumnMapping == null ? "null" : this.OptionalAddressColumnMapping.ToString())}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"MergeVariableColumnMapping = {(this.MergeVariableColumnMapping == null ? "null" : this.MergeVariableColumnMapping.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId)}");
            toStringOutput.Add($"this.Mode = {this.Mode}");
            toStringOutput.Add($"this.FailuresUrl = {(this.FailuresUrl == null ? "null" : this.FailuresUrl)}");
            toStringOutput.Add($"this.OriginalFilename = {(this.OriginalFilename == null ? "null" : this.OriginalFilename)}");
            toStringOutput.Add($"this.State = {this.State}");
            toStringOutput.Add($"this.TotalMailpieces = {this.TotalMailpieces}");
            toStringOutput.Add($"this.FailedMailpieces = {this.FailedMailpieces}");
            toStringOutput.Add($"this.ValidatedMailpieces = {this.ValidatedMailpieces}");
            toStringOutput.Add($"this.BytesProcessed = {this.BytesProcessed}");
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
        }
    }
}