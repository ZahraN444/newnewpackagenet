// <copyright file="AllLetters.cs" company="APIMatic">
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
    /// AllLetters.
    /// </summary>
    public class AllLetters
    {
        private string nextUrl;
        private string previousUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "next_url", false },
            { "previous_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AllLetters"/> class.
        /// </summary>
        public AllLetters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllLetters"/> class.
        /// </summary>
        /// <param name="mObject">object.</param>
        /// <param name="nextUrl">next_url.</param>
        /// <param name="previousUrl">previous_url.</param>
        /// <param name="count">count.</param>
        /// <param name="totalCount">total_count.</param>
        /// <param name="data">data.</param>
        public AllLetters(
            string mObject = null,
            string nextUrl = null,
            string previousUrl = null,
            int? count = null,
            int? totalCount = null,
            List<Letter> data = null)
        {
            this.MObject = mObject;
            if (nextUrl != null)
            {
                this.NextUrl = nextUrl;
            }

            if (previousUrl != null)
            {
                this.PreviousUrl = previousUrl;
            }

            this.Count = count;
            this.TotalCount = totalCount;
            this.Data = data;
        }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string MObject { get; set; }

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
        [JsonProperty("previous_url")]
        public string PreviousUrl
        {
            get
            {
                return this.previousUrl;
            }

            set
            {
                this.shouldSerialize["previous_url"] = true;
                this.previousUrl = value;
            }
        }

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
        /// list of letters
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Letter> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AllLetters : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPreviousUrl()
        {
            this.shouldSerialize["previous_url"] = false;
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
        public bool ShouldSerializePreviousUrl()
        {
            return this.shouldSerialize["previous_url"];
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
            return obj is AllLetters other &&                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.NextUrl == null && other.NextUrl == null) || (this.NextUrl?.Equals(other.NextUrl) == true)) &&
                ((this.PreviousUrl == null && other.PreviousUrl == null) || (this.PreviousUrl?.Equals(other.PreviousUrl) == true)) &&
                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true)) &&
                ((this.TotalCount == null && other.TotalCount == null) || (this.TotalCount?.Equals(other.TotalCount) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
            toStringOutput.Add($"this.NextUrl = {(this.NextUrl == null ? "null" : this.NextUrl)}");
            toStringOutput.Add($"this.PreviousUrl = {(this.PreviousUrl == null ? "null" : this.PreviousUrl)}");
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}