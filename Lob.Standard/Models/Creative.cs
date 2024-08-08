// <copyright file="Creative.cs" company="APIMatic">
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
    using Lob.Standard.Models.Containers;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Creative.
    /// </summary>
    public class Creative
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Creative"/> class.
        /// </summary>
        public Creative()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Creative"/> class.
        /// </summary>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="mObject">object.</param>
        /// <param name="resourceType">resource_type.</param>
        /// <param name="details">details.</param>
        /// <param name="from">from.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="id">id.</param>
        /// <param name="templatePreviewUrls">template_preview_urls.</param>
        /// <param name="templatePreviews">template_previews.</param>
        /// <param name="campaigns">campaigns.</param>
        /// <param name="description">description.</param>
        public Creative(
            DateTime dateCreated,
            DateTime dateModified,
            bool deleted,
            string mObject,
            string resourceType,
            Models.Details details,
            CreativeFrom from,
            Dictionary<string, string> metadata,
            string id,
            object templatePreviewUrls,
            object templatePreviews,
            List<Models.CampaignItem> campaigns,
            string description = null)
        {
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.MObject = mObject;
            this.ResourceType = resourceType;
            this.Details = details;
            this.From = from;
            this.Description = description;
            this.Metadata = metadata;
            this.Id = id;
            this.TemplatePreviewUrls = templatePreviewUrls;
            this.TemplatePreviews = templatePreviews;
            this.Campaigns = campaigns;
        }

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
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object")]
        public string MObject { get; set; }

        /// <summary>
        /// Mailpiece type for the creative
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details")]
        public Models.Details Details { get; set; }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters. All addresses will be standardized into uppercase without being modified by verification.
        /// </summary>
        [JsonProperty("from")]
        public CreativeFrom From { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `crv_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Preview URLs associated with a creative's artwork asset(s) if the creative uses HTML templates as assets. An empty object will be returned if no `template_preview`s have been generated.
        /// </summary>
        [JsonProperty("template_preview_urls")]
        public object TemplatePreviewUrls { get; set; }

        /// <summary>
        /// A list of template preview objects if the creative uses HTML template(s) as artwork asset(s). An empty array will be returned if no `template_preview`s have been generated for the creative.
        /// </summary>
        [JsonProperty("template_previews")]
        public object TemplatePreviews { get; set; }

        /// <summary>
        /// Array of campaigns associated with the creative ID
        /// </summary>
        [JsonProperty("campaigns")]
        public List<Models.CampaignItem> Campaigns { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Creative : ({string.Join(", ", toStringOutput)})";
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
            return obj is Creative other &&                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                this.Deleted.Equals(other.Deleted) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.ResourceType == null && other.ResourceType == null) || (this.ResourceType?.Equals(other.ResourceType) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.TemplatePreviewUrls == null && other.TemplatePreviewUrls == null) || (this.TemplatePreviewUrls?.Equals(other.TemplatePreviewUrls) == true)) &&
                ((this.TemplatePreviews == null && other.TemplatePreviews == null) || (this.TemplatePreviews?.Equals(other.TemplatePreviews) == true)) &&
                ((this.Campaigns == null && other.Campaigns == null) || (this.Campaigns?.Equals(other.Campaigns) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.Deleted = {this.Deleted}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
            toStringOutput.Add($"this.ResourceType = {(this.ResourceType == null ? "null" : this.ResourceType)}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details.ToString())}");
            toStringOutput.Add($"From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"TemplatePreviewUrls = {(this.TemplatePreviewUrls == null ? "null" : this.TemplatePreviewUrls.ToString())}");
            toStringOutput.Add($"TemplatePreviews = {(this.TemplatePreviews == null ? "null" : this.TemplatePreviews.ToString())}");
            toStringOutput.Add($"this.Campaigns = {(this.Campaigns == null ? "null" : $"[{string.Join(", ", this.Campaigns)} ]")}");
        }
    }
}