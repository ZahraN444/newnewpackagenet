// <copyright file="UploadsReportResponse.cs" company="APIMatic">
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
    /// UploadsReportResponse.
    /// </summary>
    public class UploadsReportResponse
    {
        private string nextUrl;
        private string prevUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "next_url", false },
            { "prev_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsReportResponse"/> class.
        /// </summary>
        public UploadsReportResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsReportResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="count">count.</param>
        /// <param name="totalCount">total_count.</param>
        /// <param name="nextUrl">next_url.</param>
        /// <param name="prevUrl">prev_url.</param>
        public UploadsReportResponse(
            List<Models.Datum> data,
            int count,
            int totalCount,
            string nextUrl = null,
            string prevUrl = null)
        {
            this.Data = data;
            if (nextUrl != null)
            {
                this.NextUrl = nextUrl;
            }

            if (prevUrl != null)
            {
                this.PrevUrl = prevUrl;
            }

            this.Count = count;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public List<Models.Datum> Data { get; set; }

        /// <summary>
        /// Url of next page of items in list.
        /// </summary>
        [JsonProperty("next_url")]
        public string NextUrl
        {
            get
            {
                return this.nextUrl;
            }

            set
            {
                this.shouldSerialize["next_url"] = true;
                this.nextUrl = value;
            }
        }

        /// <summary>
        /// Url of previous page of items in list.
        /// </summary>
        [JsonProperty("prev_url")]
        public string PrevUrl
        {
            get
            {
                return this.prevUrl;
            }

            set
            {
                this.shouldSerialize["prev_url"] = true;
                this.prevUrl = value;
            }
        }

        /// <summary>
        /// number of resources in a set
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Indicates the total number of records. Provided when the request specifies an "include" query parameter
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadsReportResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNextUrl()
        {
            this.shouldSerialize["next_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPrevUrl()
        {
            this.shouldSerialize["prev_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextUrl()
        {
            return this.shouldSerialize["next_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrevUrl()
        {
            return this.shouldSerialize["prev_url"];
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
            return obj is UploadsReportResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.NextUrl == null && other.NextUrl == null) || (this.NextUrl?.Equals(other.NextUrl) == true)) &&
                ((this.PrevUrl == null && other.PrevUrl == null) || (this.PrevUrl?.Equals(other.PrevUrl) == true)) &&
                this.Count.Equals(other.Count) &&
                this.TotalCount.Equals(other.TotalCount);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.NextUrl = {(this.NextUrl == null ? "null" : this.NextUrl)}");
            toStringOutput.Add($"this.PrevUrl = {(this.PrevUrl == null ? "null" : this.PrevUrl)}");
            toStringOutput.Add($"this.Count = {this.Count}");
            toStringOutput.Add($"this.TotalCount = {this.TotalCount}");
        }
    }
}