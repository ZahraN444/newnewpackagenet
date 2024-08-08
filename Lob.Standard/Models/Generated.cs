// <copyright file="Generated.cs" company="APIMatic">
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
    /// Generated.
    /// </summary>
    public class Generated
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Generated"/> class.
        /// </summary>
        public Generated()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generated"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="expectedDeliveryDate">expected_delivery_date.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="deleted">deleted.</param>
        public Generated(
            object to,
            string carrier,
            List<Models.Thumbnail> thumbnails = null,
            DateTime? expectedDeliveryDate = null,
            DateTime? dateCreated = null,
            DateTime? dateModified = null,
            bool? deleted = null)
        {
            this.To = to;
            this.Carrier = carrier;
            this.Thumbnails = thumbnails;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to")]
        public object To { get; set; }

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
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was last modified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateModified { get; set; }

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

            return $"Generated : ({string.Join(", ", toStringOutput)})";
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
            return obj is Generated other &&                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.Carrier == null && other.Carrier == null) || (this.Carrier?.Equals(other.Carrier) == true)) &&
                ((this.Thumbnails == null && other.Thumbnails == null) || (this.Thumbnails?.Equals(other.Thumbnails) == true)) &&
                ((this.ExpectedDeliveryDate == null && other.ExpectedDeliveryDate == null) || (this.ExpectedDeliveryDate?.Equals(other.ExpectedDeliveryDate) == true)) &&
                ((this.DateCreated == null && other.DateCreated == null) || (this.DateCreated?.Equals(other.DateCreated) == true)) &&
                ((this.DateModified == null && other.DateModified == null) || (this.DateModified?.Equals(other.DateModified) == true)) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"this.Carrier = {(this.Carrier == null ? "null" : this.Carrier)}");
            toStringOutput.Add($"this.Thumbnails = {(this.Thumbnails == null ? "null" : $"[{string.Join(", ", this.Thumbnails)} ]")}");
            toStringOutput.Add($"this.ExpectedDeliveryDate = {(this.ExpectedDeliveryDate == null ? "null" : this.ExpectedDeliveryDate.ToString())}");
            toStringOutput.Add($"this.DateCreated = {(this.DateCreated == null ? "null" : this.DateCreated.ToString())}");
            toStringOutput.Add($"this.DateModified = {(this.DateModified == null ? "null" : this.DateModified.ToString())}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
        }
    }
}