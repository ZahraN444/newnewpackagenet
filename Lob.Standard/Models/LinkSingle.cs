// <copyright file="LinkSingle.cs" company="APIMatic">
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
    /// LinkSingle.
    /// </summary>
    public class LinkSingle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkSingle"/> class.
        /// </summary>
        public LinkSingle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkSingle"/> class.
        /// </summary>
        /// <param name="redirectLink">redirect_link.</param>
        /// <param name="domain">domain.</param>
        /// <param name="slug">slug.</param>
        /// <param name="metadataTag">metadata_tag.</param>
        /// <param name="billingGroupId">billing_group_id.</param>
        public LinkSingle(
            string redirectLink,
            string domain = null,
            string slug = null,
            Dictionary<string, string> metadataTag = null,
            string billingGroupId = null)
        {
            this.RedirectLink = redirectLink;
            this.Domain = domain;
            this.Slug = slug;
            this.MetadataTag = metadataTag;
            this.BillingGroupId = billingGroupId;
        }

        /// <summary>
        /// The original target URL.
        /// </summary>
        [JsonProperty("redirect_link")]
        public string RedirectLink { get; set; }

        /// <summary>
        /// The registered domain to be used for the short URL.
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// The unique path for the shortened URL, if empty a unique path will be used.
        /// </summary>
        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata_tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> MetadataTag { get; set; }

        /// <summary>
        /// An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information.
        /// </summary>
        [JsonProperty("billing_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingGroupId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LinkSingle : ({string.Join(", ", toStringOutput)})";
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
            return obj is LinkSingle other &&                ((this.RedirectLink == null && other.RedirectLink == null) || (this.RedirectLink?.Equals(other.RedirectLink) == true)) &&
                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true)) &&
                ((this.Slug == null && other.Slug == null) || (this.Slug?.Equals(other.Slug) == true)) &&
                ((this.MetadataTag == null && other.MetadataTag == null) || (this.MetadataTag?.Equals(other.MetadataTag) == true)) &&
                ((this.BillingGroupId == null && other.BillingGroupId == null) || (this.BillingGroupId?.Equals(other.BillingGroupId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RedirectLink = {(this.RedirectLink == null ? "null" : this.RedirectLink)}");
            toStringOutput.Add($"this.Domain = {(this.Domain == null ? "null" : this.Domain)}");
            toStringOutput.Add($"this.Slug = {(this.Slug == null ? "null" : this.Slug)}");
            toStringOutput.Add($"MetadataTag = {(this.MetadataTag == null ? "null" : this.MetadataTag.ToString())}");
            toStringOutput.Add($"this.BillingGroupId = {(this.BillingGroupId == null ? "null" : this.BillingGroupId)}");
        }
    }
}