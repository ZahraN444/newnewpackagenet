// <copyright file="Buckslip.cs" company="APIMatic">
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
    /// Buckslip.
    /// </summary>
    public class Buckslip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Buckslip"/> class.
        /// </summary>
        public Buckslip()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Buckslip"/> class.
        /// </summary>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="autoReorder">auto_reorder.</param>
        /// <param name="thresholdAmount">threshold_amount.</param>
        /// <param name="url">url.</param>
        /// <param name="rawUrl">raw_url.</param>
        /// <param name="frontOriginalUrl">front_original_url.</param>
        /// <param name="backOriginalUrl">back_original_url.</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="availableQuantity">available_quantity.</param>
        /// <param name="allocatedQuantity">allocated_quantity.</param>
        /// <param name="onhandQuantity">onhand_quantity.</param>
        /// <param name="pendingQuantity">pending_quantity.</param>
        /// <param name="projectedQuantity">projected_quantity.</param>
        /// <param name="buckslipOrders">buckslip_orders.</param>
        /// <param name="stock">stock.</param>
        /// <param name="weight">weight.</param>
        /// <param name="finish">finish.</param>
        /// <param name="status">status.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="description">description.</param>
        /// <param name="size">size.</param>
        /// <param name="reorderQuantity">reorder_quantity.</param>
        public Buckslip(
            DateTime dateCreated,
            DateTime dateModified,
            string mObject,
            string id,
            bool autoReorder,
            int thresholdAmount,
            string url,
            string rawUrl,
            string frontOriginalUrl,
            string backOriginalUrl,
            List<Models.Thumbnail> thumbnails,
            double availableQuantity,
            double allocatedQuantity,
            double onhandQuantity,
            double pendingQuantity,
            double projectedQuantity,
            List<Models.BuckslipOrder> buckslipOrders,
            Models.ThestockofthebuckslipEnum stock,
            string weight,
            Models.ThefinishofthebuckslipEnum finish,
            Models.ThestatusofthebuckslipEnum status,
            bool? deleted = null,
            string description = null,
            Models.SizeEnum? size = null,
            int? reorderQuantity = null)
        {
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.MObject = mObject;
            this.Description = description;
            this.Size = size;
            this.Id = id;
            this.AutoReorder = autoReorder;
            this.ReorderQuantity = reorderQuantity;
            this.ThresholdAmount = thresholdAmount;
            this.Url = url;
            this.RawUrl = rawUrl;
            this.FrontOriginalUrl = frontOriginalUrl;
            this.BackOriginalUrl = backOriginalUrl;
            this.Thumbnails = thumbnails;
            this.AvailableQuantity = availableQuantity;
            this.AllocatedQuantity = allocatedQuantity;
            this.OnhandQuantity = onhandQuantity;
            this.PendingQuantity = pendingQuantity;
            this.ProjectedQuantity = projectedQuantity;
            this.BuckslipOrders = buckslipOrders;
            this.Stock = stock;
            this.Weight = weight;
            this.Finish = finish;
            this.Status = status;
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
        /// Description of the buckslip.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SizeEnum? Size { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `bck_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// True if the buckslips should be auto-reordered.
        /// </summary>
        [JsonProperty("auto_reorder")]
        public bool AutoReorder { get; set; }

        /// <summary>
        /// The number of buckslips to be reordered.
        /// </summary>
        [JsonProperty("reorder_quantity", NullValueHandling = NullValueHandling.Include)]
        public int? ReorderQuantity { get; set; }

        /// <summary>
        /// The threshold amount of the buckslip
        /// </summary>
        [JsonProperty("threshold_amount")]
        public int ThresholdAmount { get; set; }

        /// <summary>
        /// The signed link for the buckslip.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The raw URL of the buckslip.
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
        /// The available quantity of buckslips.
        /// </summary>
        [JsonProperty("available_quantity")]
        public double AvailableQuantity { get; set; }

        /// <summary>
        /// The allocated quantity of buckslips.
        /// </summary>
        [JsonProperty("allocated_quantity")]
        public double AllocatedQuantity { get; set; }

        /// <summary>
        /// The onhand quantity of buckslips.
        /// </summary>
        [JsonProperty("onhand_quantity")]
        public double OnhandQuantity { get; set; }

        /// <summary>
        /// The pending quantity of buckslips.
        /// </summary>
        [JsonProperty("pending_quantity")]
        public double PendingQuantity { get; set; }

        /// <summary>
        /// The sum of pending and onhand quantities of buckslips.
        /// </summary>
        [JsonProperty("projected_quantity")]
        public double ProjectedQuantity { get; set; }

        /// <summary>
        /// An array of buckslip orders that are associated with the buckslip.
        /// </summary>
        [JsonProperty("buckslip_orders")]
        public List<Models.BuckslipOrder> BuckslipOrders { get; set; }

        /// <summary>
        /// Gets or sets Stock.
        /// </summary>
        [JsonProperty("stock")]
        public Models.ThestockofthebuckslipEnum Stock { get; set; }

        /// <summary>
        /// Gets or sets Weight.
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// Gets or sets Finish.
        /// </summary>
        [JsonProperty("finish")]
        public Models.ThefinishofthebuckslipEnum Finish { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.ThestatusofthebuckslipEnum Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Buckslip : ({string.Join(", ", toStringOutput)})";
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
            return obj is Buckslip other &&                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.AutoReorder.Equals(other.AutoReorder) &&
                ((this.ReorderQuantity == null && other.ReorderQuantity == null) || (this.ReorderQuantity?.Equals(other.ReorderQuantity) == true)) &&
                this.ThresholdAmount.Equals(other.ThresholdAmount) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.RawUrl == null && other.RawUrl == null) || (this.RawUrl?.Equals(other.RawUrl) == true)) &&
                ((this.FrontOriginalUrl == null && other.FrontOriginalUrl == null) || (this.FrontOriginalUrl?.Equals(other.FrontOriginalUrl) == true)) &&
                ((this.BackOriginalUrl == null && other.BackOriginalUrl == null) || (this.BackOriginalUrl?.Equals(other.BackOriginalUrl) == true)) &&
                ((this.Thumbnails == null && other.Thumbnails == null) || (this.Thumbnails?.Equals(other.Thumbnails) == true)) &&
                this.AvailableQuantity.Equals(other.AvailableQuantity) &&
                this.AllocatedQuantity.Equals(other.AllocatedQuantity) &&
                this.OnhandQuantity.Equals(other.OnhandQuantity) &&
                this.PendingQuantity.Equals(other.PendingQuantity) &&
                this.ProjectedQuantity.Equals(other.ProjectedQuantity) &&
                ((this.BuckslipOrders == null && other.BuckslipOrders == null) || (this.BuckslipOrders?.Equals(other.BuckslipOrders) == true)) &&
                this.Stock.Equals(other.Stock) &&
                ((this.Weight == null && other.Weight == null) || (this.Weight?.Equals(other.Weight) == true)) &&
                this.Finish.Equals(other.Finish) &&
                this.Status.Equals(other.Status);
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
            toStringOutput.Add($"this.AutoReorder = {this.AutoReorder}");
            toStringOutput.Add($"this.ReorderQuantity = {(this.ReorderQuantity == null ? "null" : this.ReorderQuantity.ToString())}");
            toStringOutput.Add($"this.ThresholdAmount = {this.ThresholdAmount}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.RawUrl = {(this.RawUrl == null ? "null" : this.RawUrl)}");
            toStringOutput.Add($"this.FrontOriginalUrl = {(this.FrontOriginalUrl == null ? "null" : this.FrontOriginalUrl)}");
            toStringOutput.Add($"this.BackOriginalUrl = {(this.BackOriginalUrl == null ? "null" : this.BackOriginalUrl)}");
            toStringOutput.Add($"this.Thumbnails = {(this.Thumbnails == null ? "null" : $"[{string.Join(", ", this.Thumbnails)} ]")}");
            toStringOutput.Add($"this.AvailableQuantity = {this.AvailableQuantity}");
            toStringOutput.Add($"this.AllocatedQuantity = {this.AllocatedQuantity}");
            toStringOutput.Add($"this.OnhandQuantity = {this.OnhandQuantity}");
            toStringOutput.Add($"this.PendingQuantity = {this.PendingQuantity}");
            toStringOutput.Add($"this.ProjectedQuantity = {this.ProjectedQuantity}");
            toStringOutput.Add($"this.BuckslipOrders = {(this.BuckslipOrders == null ? "null" : $"[{string.Join(", ", this.BuckslipOrders)} ]")}");
            toStringOutput.Add($"this.Stock = {this.Stock}");
            toStringOutput.Add($"this.Weight = {(this.Weight == null ? "null" : this.Weight)}");
            toStringOutput.Add($"this.Finish = {this.Finish}");
            toStringOutput.Add($"this.Status = {this.Status}");
        }
    }
}