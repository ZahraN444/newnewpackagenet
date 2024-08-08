// <copyright file="QrCodeScans.cs" company="APIMatic">
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
    /// QrCodeScans.
    /// </summary>
    public class QrCodeScans
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QrCodeScans"/> class.
        /// </summary>
        public QrCodeScans()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QrCodeScans"/> class.
        /// </summary>
        /// <param name="resourceId">resource_id.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="numberOfScans">number_of_scans.</param>
        /// <param name="scans">scans.</param>
        public QrCodeScans(
            string resourceId = null,
            DateTime? dateCreated = null,
            double? numberOfScans = null,
            List<Models.Scans> scans = null)
        {
            this.ResourceId = resourceId;
            this.DateCreated = dateCreated;
            this.NumberOfScans = numberOfScans;
            this.Scans = scans;
        }

        /// <summary>
        /// Unique identifier for each mail piece.
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Number of times the QR Code associated with this mail piece was scanned.
        /// </summary>
        [JsonProperty("number_of_scans", NullValueHandling = NullValueHandling.Ignore)]
        public double? NumberOfScans { get; set; }

        /// <summary>
        /// Detailed scan information associated with each mail piece.
        /// </summary>
        [JsonProperty("scans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Scans> Scans { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QrCodeScans : ({string.Join(", ", toStringOutput)})";
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
            return obj is QrCodeScans other &&                ((this.ResourceId == null && other.ResourceId == null) || (this.ResourceId?.Equals(other.ResourceId) == true)) &&
                ((this.DateCreated == null && other.DateCreated == null) || (this.DateCreated?.Equals(other.DateCreated) == true)) &&
                ((this.NumberOfScans == null && other.NumberOfScans == null) || (this.NumberOfScans?.Equals(other.NumberOfScans) == true)) &&
                ((this.Scans == null && other.Scans == null) || (this.Scans?.Equals(other.Scans) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResourceId = {(this.ResourceId == null ? "null" : this.ResourceId)}");
            toStringOutput.Add($"this.DateCreated = {(this.DateCreated == null ? "null" : this.DateCreated.ToString())}");
            toStringOutput.Add($"this.NumberOfScans = {(this.NumberOfScans == null ? "null" : this.NumberOfScans.ToString())}");
            toStringOutput.Add($"this.Scans = {(this.Scans == null ? "null" : $"[{string.Join(", ", this.Scans)} ]")}");
        }
    }
}