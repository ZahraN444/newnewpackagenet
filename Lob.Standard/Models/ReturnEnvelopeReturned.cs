// <copyright file="ReturnEnvelopeReturned.cs" company="APIMatic">
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
    /// ReturnEnvelopeReturned.
    /// </summary>
    public class ReturnEnvelopeReturned
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEnvelopeReturned"/> class.
        /// </summary>
        public ReturnEnvelopeReturned()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnEnvelopeReturned"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mAlias">alias.</param>
        /// <param name="url">url.</param>
        /// <param name="mObject">object.</param>
        public ReturnEnvelopeReturned(
            string id = null,
            string mAlias = null,
            string url = null,
            string mObject = null)
        {
            this.Id = id;
            this.MAlias = mAlias;
            this.Url = url;
            this.MObject = mObject;
        }

        /// <summary>
        /// The unique ID of the Return Envelope.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// A quick reference name for the Return Envelope.
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string MAlias { get; set; }

        /// <summary>
        /// The url of the return envelope.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnEnvelopeReturned : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnEnvelopeReturned other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.MAlias == null && other.MAlias == null) || (this.MAlias?.Equals(other.MAlias) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.MAlias = {(this.MAlias == null ? "null" : this.MAlias)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
        }
    }
}