// <copyright file="LinkResponse.cs" company="APIMatic">
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
    /// LinkResponse.
    /// </summary>
    public class LinkResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkResponse"/> class.
        /// </summary>
        public LinkResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="campaignId">campaign_id.</param>
        /// <param name="domainId">domain_id.</param>
        /// <param name="resourceId">resource_id.</param>
        /// <param name="redirectLink">redirect_link.</param>
        /// <param name="shortLink">short_link.</param>
        /// <param name="metadataTag">metadata_tag.</param>
        /// <param name="billingGroupId">billing_group_id.</param>
        public LinkResponse(
            string id = null,
            string campaignId = null,
            string domainId = null,
            string resourceId = null,
            string redirectLink = null,
            string shortLink = null,
            Dictionary<string, string> metadataTag = null,
            string billingGroupId = null)
        {
            this.Id = id;
            this.CampaignId = campaignId;
            this.DomainId = domainId;
            this.ResourceId = resourceId;
            this.RedirectLink = redirectLink;
            this.ShortLink = shortLink;
            this.MetadataTag = metadataTag;
            this.BillingGroupId = billingGroupId;
        }

        /// <summary>
        /// Unique identifier prefixed with `lnk_`.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `cmp_`.
        /// </summary>
        [JsonProperty("campaign_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignId { get; set; }

        /// <summary>
        /// A unique identifier for the registered domain.
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// The unique ID of the associated resource where the link was used.
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The original target URL.
        /// </summary>
        [JsonProperty("redirect_link", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectLink { get; set; }

        /// <summary>
        /// The shortened URL for the associated original URL.
        /// </summary>
        [JsonProperty("short_link", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortLink { get; set; }

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

            return $"LinkResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is LinkResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CampaignId == null && other.CampaignId == null) || (this.CampaignId?.Equals(other.CampaignId) == true)) &&
                ((this.DomainId == null && other.DomainId == null) || (this.DomainId?.Equals(other.DomainId) == true)) &&
                ((this.ResourceId == null && other.ResourceId == null) || (this.ResourceId?.Equals(other.ResourceId) == true)) &&
                ((this.RedirectLink == null && other.RedirectLink == null) || (this.RedirectLink?.Equals(other.RedirectLink) == true)) &&
                ((this.ShortLink == null && other.ShortLink == null) || (this.ShortLink?.Equals(other.ShortLink) == true)) &&
                ((this.MetadataTag == null && other.MetadataTag == null) || (this.MetadataTag?.Equals(other.MetadataTag) == true)) &&
                ((this.BillingGroupId == null && other.BillingGroupId == null) || (this.BillingGroupId?.Equals(other.BillingGroupId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.CampaignId = {(this.CampaignId == null ? "null" : this.CampaignId)}");
            toStringOutput.Add($"this.DomainId = {(this.DomainId == null ? "null" : this.DomainId)}");
            toStringOutput.Add($"this.ResourceId = {(this.ResourceId == null ? "null" : this.ResourceId)}");
            toStringOutput.Add($"this.RedirectLink = {(this.RedirectLink == null ? "null" : this.RedirectLink)}");
            toStringOutput.Add($"this.ShortLink = {(this.ShortLink == null ? "null" : this.ShortLink)}");
            toStringOutput.Add($"MetadataTag = {(this.MetadataTag == null ? "null" : this.MetadataTag.ToString())}");
            toStringOutput.Add($"this.BillingGroupId = {(this.BillingGroupId == null ? "null" : this.BillingGroupId)}");
        }
    }
}