// <copyright file="CardOrder.cs" company="APIMatic">
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
    /// CardOrder.
    /// </summary>
    public class CardOrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrder"/> class.
        /// </summary>
        public CardOrder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrder"/> class.
        /// </summary>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="mObject">object.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="id">id.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="status">status.</param>
        /// <param name="inventory">inventory.</param>
        /// <param name="quantityOrdered">quantity_ordered.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="cancelledReason">cancelled_reason.</param>
        /// <param name="availabilityDate">availability_date.</param>
        /// <param name="expectedAvailabilityDate">expected_availability_date.</param>
        public CardOrder(
            DateTime dateCreated,
            DateTime dateModified,
            string mObject,
            bool? deleted = null,
            string id = null,
            string cardId = null,
            Models.Status2Enum? status = null,
            double? inventory = 0,
            double? quantityOrdered = 0,
            double? unitPrice = 0,
            string cancelledReason = null,
            DateTime? availabilityDate = null,
            DateTime? expectedAvailabilityDate = null)
        {
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.MObject = mObject;
            this.Id = id;
            this.CardId = cardId;
            this.Status = status;
            this.Inventory = inventory;
            this.QuantityOrdered = quantityOrdered;
            this.UnitPrice = unitPrice;
            this.CancelledReason = cancelledReason;
            this.AvailabilityDate = availabilityDate;
            this.ExpectedAvailabilityDate = expectedAvailabilityDate;
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
        /// Unique identifier prefixed with `co_`.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `card_`.
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Status2Enum? Status { get; set; }

        /// <summary>
        /// The inventory of the card order.
        /// </summary>
        [JsonProperty("inventory", NullValueHandling = NullValueHandling.Ignore)]
        public double? Inventory { get; set; }

        /// <summary>
        /// The quantity of cards ordered
        /// </summary>
        [JsonProperty("quantity_ordered", NullValueHandling = NullValueHandling.Ignore)]
        public double? QuantityOrdered { get; set; }

        /// <summary>
        /// The unit price for the card order.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// The reason for cancellation.
        /// </summary>
        [JsonProperty("cancelled_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelledReason { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("availability_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AvailabilityDate { get; set; }

        /// <summary>
        /// The fixed deadline for the cards to be printed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expected_availability_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpectedAvailabilityDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardOrder : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardOrder other &&                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Inventory == null && other.Inventory == null) || (this.Inventory?.Equals(other.Inventory) == true)) &&
                ((this.QuantityOrdered == null && other.QuantityOrdered == null) || (this.QuantityOrdered?.Equals(other.QuantityOrdered) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.CancelledReason == null && other.CancelledReason == null) || (this.CancelledReason?.Equals(other.CancelledReason) == true)) &&
                ((this.AvailabilityDate == null && other.AvailabilityDate == null) || (this.AvailabilityDate?.Equals(other.AvailabilityDate) == true)) &&
                ((this.ExpectedAvailabilityDate == null && other.ExpectedAvailabilityDate == null) || (this.ExpectedAvailabilityDate?.Equals(other.ExpectedAvailabilityDate) == true));
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
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Inventory = {(this.Inventory == null ? "null" : this.Inventory.ToString())}");
            toStringOutput.Add($"this.QuantityOrdered = {(this.QuantityOrdered == null ? "null" : this.QuantityOrdered.ToString())}");
            toStringOutput.Add($"this.UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"this.CancelledReason = {(this.CancelledReason == null ? "null" : this.CancelledReason)}");
            toStringOutput.Add($"this.AvailabilityDate = {(this.AvailabilityDate == null ? "null" : this.AvailabilityDate.ToString())}");
            toStringOutput.Add($"this.ExpectedAvailabilityDate = {(this.ExpectedAvailabilityDate == null ? "null" : this.ExpectedAvailabilityDate.ToString())}");
        }
    }
}