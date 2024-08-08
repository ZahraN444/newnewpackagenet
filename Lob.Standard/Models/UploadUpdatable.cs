// <copyright file="UploadUpdatable.cs" company="APIMatic">
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
    /// UploadUpdatable.
    /// </summary>
    public class UploadUpdatable
    {
        private object mergeVariableColumnMapping;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "mergeVariableColumnMapping", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadUpdatable"/> class.
        /// </summary>
        public UploadUpdatable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadUpdatable"/> class.
        /// </summary>
        /// <param name="originalFilename">originalFilename.</param>
        /// <param name="requiredAddressColumnMapping">requiredAddressColumnMapping.</param>
        /// <param name="optionalAddressColumnMapping">optionalAddressColumnMapping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mergeVariableColumnMapping">mergeVariableColumnMapping.</param>
        public UploadUpdatable(
            string originalFilename = null,
            Models.RequiredAddressColumnMapping requiredAddressColumnMapping = null,
            Models.OptionalAddressColumnMapping optionalAddressColumnMapping = null,
            Models.Metadata1 metadata = null,
            object mergeVariableColumnMapping = null)
        {
            this.OriginalFilename = originalFilename;
            this.RequiredAddressColumnMapping = requiredAddressColumnMapping;
            this.OptionalAddressColumnMapping = optionalAddressColumnMapping;
            this.Metadata = metadata;
            if (mergeVariableColumnMapping != null)
            {
                this.MergeVariableColumnMapping = mergeVariableColumnMapping;
            }

        }

        /// <summary>
        /// Original filename provided when the upload is created.
        /// </summary>
        [JsonProperty("originalFilename", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Gets or sets RequiredAddressColumnMapping.
        /// </summary>
        [JsonProperty("requiredAddressColumnMapping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RequiredAddressColumnMapping RequiredAddressColumnMapping { get; set; }

        /// <summary>
        /// Gets or sets OptionalAddressColumnMapping.
        /// </summary>
        [JsonProperty("optionalAddressColumnMapping", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OptionalAddressColumnMapping OptionalAddressColumnMapping { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Metadata1 Metadata { get; set; }

        /// <summary>
        /// The mapping of column headers in your file to the merge variables present in your creative. See our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#step-3-map-merge-variable-data-if-applicable-7" target="_blank">Campaign Audience Guide</a> for additional details. <br />If a merge variable has the same "name" as a "key" in the `requiredAddressColumnMapping` or `optionalAddressColumnMapping` objects, then they **CANNOT** have a different value in this object. If a different value is provided, then when the campaign is processing it will get overwritten with the mapped value present in the `requiredAddressColumnMapping` or `optionalAddressColumnMapping` objects. If using customized QR code redirect from the Audience file, then a `qr_code_redirect_url` must be mapped to the column header as used in the CSV.
        /// </summary>
        [JsonProperty("mergeVariableColumnMapping")]
        public object MergeVariableColumnMapping
        {
            get
            {
                return this.mergeVariableColumnMapping;
            }

            set
            {
                this.shouldSerialize["mergeVariableColumnMapping"] = true;
                this.mergeVariableColumnMapping = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadUpdatable : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMergeVariableColumnMapping()
        {
            this.shouldSerialize["mergeVariableColumnMapping"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMergeVariableColumnMapping()
        {
            return this.shouldSerialize["mergeVariableColumnMapping"];
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
            return obj is UploadUpdatable other &&                ((this.OriginalFilename == null && other.OriginalFilename == null) || (this.OriginalFilename?.Equals(other.OriginalFilename) == true)) &&
                ((this.RequiredAddressColumnMapping == null && other.RequiredAddressColumnMapping == null) || (this.RequiredAddressColumnMapping?.Equals(other.RequiredAddressColumnMapping) == true)) &&
                ((this.OptionalAddressColumnMapping == null && other.OptionalAddressColumnMapping == null) || (this.OptionalAddressColumnMapping?.Equals(other.OptionalAddressColumnMapping) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MergeVariableColumnMapping == null && other.MergeVariableColumnMapping == null) || (this.MergeVariableColumnMapping?.Equals(other.MergeVariableColumnMapping) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OriginalFilename = {(this.OriginalFilename == null ? "null" : this.OriginalFilename)}");
            toStringOutput.Add($"this.RequiredAddressColumnMapping = {(this.RequiredAddressColumnMapping == null ? "null" : this.RequiredAddressColumnMapping.ToString())}");
            toStringOutput.Add($"this.OptionalAddressColumnMapping = {(this.OptionalAddressColumnMapping == null ? "null" : this.OptionalAddressColumnMapping.ToString())}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"MergeVariableColumnMapping = {(this.MergeVariableColumnMapping == null ? "null" : this.MergeVariableColumnMapping.ToString())}");
        }
    }
}