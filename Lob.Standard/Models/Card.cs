// <copyright file="Card.cs" company="APIMatic">
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
    /// Card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="url">url.</param>
        /// <param name="autoReorder">auto_reorder.</param>
        /// <param name="rawUrl">raw_url.</param>
        /// <param name="frontOriginalUrl">front_original_url.</param>
        /// <param name="backOriginalUrl">back_original_url.</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="availableQuantity">available_quantity.</param>
        /// <param name="pendingQuantity">pending_quantity.</param>
        /// <param name="status">status.</param>
        /// <param name="orientation">orientation.</param>
        /// <param name="thresholdAmount">threshold_amount.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="description">description.</param>
        /// <param name="size">size.</param>
        /// <param name="reorderQuantity">reorder_quantity.</param>
        public Card(
            DateTime dateCreated,
            DateTime dateModified,
            string mObject,
            string id,
            string url,
            bool autoReorder,
            string rawUrl,
            string frontOriginalUrl,
            string backOriginalUrl,
            List<Models.Thumbnail> thumbnails,
            int availableQuantity,
            int pendingQuantity,
            Models.ThestatusofthecardEnum status,
            Models.OrientationEnum orientation,
            int thresholdAmount,
            bool? deleted = null,
            string description = null,
            Models.Size1Enum? size = null,
            int? reorderQuantity = null)
        {
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.MObject = mObject;
            this.Description = description;
            this.Size = size;
            this.Id = id;
            this.Url = url;
            this.AutoReorder = autoReorder;
            this.ReorderQuantity = reorderQuantity;
            this.RawUrl = rawUrl;
            this.FrontOriginalUrl = frontOriginalUrl;
            this.BackOriginalUrl = backOriginalUrl;
            this.Thumbnails = thumbnails;
            this.AvailableQuantity = availableQuantity;
            this.PendingQuantity = pendingQuantity;
            this.Status = status;
            this.Orientation = orientation;
            this.ThresholdAmount = thresholdAmount;
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
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object")]
        public string MObject { get; set; }

        /// <summary>
        /// Description of the card.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Size1Enum? Size { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `card_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The signed link for the card.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// True if the cards should be auto-reordered.
        /// </summary>
        [JsonProperty("auto_reorder")]
        public bool AutoReorder { get; set; }

        /// <summary>
        /// The number of cards to be reordered.
        /// </summary>
        [JsonProperty("reorder_quantity", NullValueHandling = NullValueHandling.Include)]
        public int? ReorderQuantity { get; set; }

        /// <summary>
        /// The raw URL of the card.
        /// </summary>
        [JsonProperty("raw_url")]
        public string RawUrl { get; set; }

        /// <summary>
        /// The original URL of the front template.
        /// </summary>
        [JsonProperty("front_original_url")]
        public string FrontOriginalUrl { get; set; }

        /// <summary>
        /// The original URL of the back template.
        /// </summary>
        [JsonProperty("back_original_url")]
        public string BackOriginalUrl { get; set; }

        /// <summary>
        /// Gets or sets Thumbnails.
        /// </summary>
        [JsonProperty("thumbnails")]
        public List<Models.Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// The available quantity of cards.
        /// </summary>
        [JsonProperty("available_quantity")]
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// The pending quantity of cards.
        /// </summary>
        [JsonProperty("pending_quantity")]
        public int PendingQuantity { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.ThestatusofthecardEnum Status { get; set; }

        /// <summary>
        /// Gets or sets Orientation.
        /// </summary>
        [JsonProperty("orientation")]
        public Models.OrientationEnum Orientation { get; set; }

        /// <summary>
        /// The threshold amount of the card
        /// </summary>
        [JsonProperty("threshold_amount")]
        public int ThresholdAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Card : ({string.Join(", ", toStringOutput)})";
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
            return obj is Card other &&                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                this.AutoReorder.Equals(other.AutoReorder) &&
                ((this.ReorderQuantity == null && other.ReorderQuantity == null) || (this.ReorderQuantity?.Equals(other.ReorderQuantity) == true)) &&
                ((this.RawUrl == null && other.RawUrl == null) || (this.RawUrl?.Equals(other.RawUrl) == true)) &&
                ((this.FrontOriginalUrl == null && other.FrontOriginalUrl == null) || (this.FrontOriginalUrl?.Equals(other.FrontOriginalUrl) == true)) &&
                ((this.BackOriginalUrl == null && other.BackOriginalUrl == null) || (this.BackOriginalUrl?.Equals(other.BackOriginalUrl) == true)) &&
                ((this.Thumbnails == null && other.Thumbnails == null) || (this.Thumbnails?.Equals(other.Thumbnails) == true)) &&
                this.AvailableQuantity.Equals(other.AvailableQuantity) &&
                this.PendingQuantity.Equals(other.PendingQuantity) &&
                this.Status.Equals(other.Status) &&
                this.Orientation.Equals(other.Orientation) &&
                this.ThresholdAmount.Equals(other.ThresholdAmount);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.AutoReorder = {this.AutoReorder}");
            toStringOutput.Add($"this.ReorderQuantity = {(this.ReorderQuantity == null ? "null" : this.ReorderQuantity.ToString())}");
            toStringOutput.Add($"this.RawUrl = {(this.RawUrl == null ? "null" : this.RawUrl)}");
            toStringOutput.Add($"this.FrontOriginalUrl = {(this.FrontOriginalUrl == null ? "null" : this.FrontOriginalUrl)}");
            toStringOutput.Add($"this.BackOriginalUrl = {(this.BackOriginalUrl == null ? "null" : this.BackOriginalUrl)}");
            toStringOutput.Add($"this.Thumbnails = {(this.Thumbnails == null ? "null" : $"[{string.Join(", ", this.Thumbnails)} ]")}");
            toStringOutput.Add($"this.AvailableQuantity = {this.AvailableQuantity}");
            toStringOutput.Add($"this.PendingQuantity = {this.PendingQuantity}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Orientation = {this.Orientation}");
            toStringOutput.Add($"this.ThresholdAmount = {this.ThresholdAmount}");
        }
    }
}