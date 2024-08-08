// <copyright file="QrCodeAnalyticsResponse.cs" company="APIMatic">
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
    /// QrCodeAnalyticsResponse.
    /// </summary>
    public class QrCodeAnalyticsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QrCodeAnalyticsResponse"/> class.
        /// </summary>
        public QrCodeAnalyticsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QrCodeAnalyticsResponse"/> class.
        /// </summary>
        /// <param name="mObject">object.</param>
        /// <param name="count">count.</param>
        /// <param name="totalCount">total_count.</param>
        /// <param name="scannedCount">scanned_count.</param>
        /// <param name="data">data.</param>
        public QrCodeAnalyticsResponse(
            string mObject = null,
            int? count = null,
            int? totalCount = null,
            int? scannedCount = null,
            List<Models.QrCodeScans> data = null)
        {
            this.MObject = mObject;
            this.Count = count;
            this.TotalCount = totalCount;
            this.ScannedCount = scannedCount;
            this.Data = data;
        }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string MObject { get; set; }

        /// <summary>
        /// number of resources in a set
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// Indicates the total number of records. Provided when the request specifies an "include" query parameter
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Indicates the number of QR Codes out of `count` that were scanned atleast once.
        /// </summary>
        [JsonProperty("scanned_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScannedCount { get; set; }

        /// <summary>
        /// List of QR code analytics
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.QrCodeScans> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QrCodeAnalyticsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is QrCodeAnalyticsResponse other &&                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true)) &&
                ((this.TotalCount == null && other.TotalCount == null) || (this.TotalCount?.Equals(other.TotalCount) == true)) &&
                ((this.ScannedCount == null && other.ScannedCount == null) || (this.ScannedCount?.Equals(other.ScannedCount) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"this.ScannedCount = {(this.ScannedCount == null ? "null" : this.ScannedCount.ToString())}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}