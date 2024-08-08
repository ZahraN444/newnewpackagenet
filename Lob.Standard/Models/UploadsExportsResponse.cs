// <copyright file="UploadsExportsResponse.cs" company="APIMatic">
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
    /// UploadsExportsResponse.
    /// </summary>
    public class UploadsExportsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsExportsResponse"/> class.
        /// </summary>
        public UploadsExportsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsExportsResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="dateModified">dateModified.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="s3Url">s3Url.</param>
        /// <param name="state">state.</param>
        /// <param name="type">type.</param>
        /// <param name="uploadId">uploadId.</param>
        public UploadsExportsResponse(
            string id,
            DateTime dateCreated,
            DateTime dateModified,
            bool deleted,
            string s3Url,
            Models.StateEnum state,
            Models.Type1Enum type,
            string uploadId)
        {
            this.Id = id;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.S3Url = s3Url;
            this.State = state;
            this.Type = type;
            this.UploadId = uploadId;
        }

        /// <summary>
        /// Unique identifier prefixed with `ex_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the export was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the export was last modified
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateModified")]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Returns as `true` if the resource has been successfully deleted.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// The URL for the generated export file.
        /// </summary>
        [JsonProperty("s3Url")]
        public string S3Url { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.StateEnum State { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type1Enum Type { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `upl_`.
        /// </summary>
        [JsonProperty("uploadId")]
        public string UploadId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadsExportsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is UploadsExportsResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                this.Deleted.Equals(other.Deleted) &&
                ((this.S3Url == null && other.S3Url == null) || (this.S3Url?.Equals(other.S3Url) == true)) &&
                this.State.Equals(other.State) &&
                this.Type.Equals(other.Type) &&
                ((this.UploadId == null && other.UploadId == null) || (this.UploadId?.Equals(other.UploadId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.Deleted = {this.Deleted}");
            toStringOutput.Add($"this.S3Url = {(this.S3Url == null ? "null" : this.S3Url)}");
            toStringOutput.Add($"this.State = {this.State}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.UploadId = {(this.UploadId == null ? "null" : this.UploadId)}");
        }
    }
}