// <copyright file="ReverseGeocode.cs" company="APIMatic">
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
    /// ReverseGeocode.
    /// </summary>
    public class ReverseGeocode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocode"/> class.
        /// </summary>
        public ReverseGeocode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocode"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="mObject">object.</param>
        public ReverseGeocode(
            string id = null,
            List<Models.Addresses> addresses = null,
            Models.Object15Enum? mObject = null)
        {
            this.Id = id;
            this.Addresses = addresses;
            this.MObject = mObject;
        }

        /// <summary>
        /// Unique identifier prefixed with `us_reverse_geocode_`.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// list of addresses
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Addresses> Addresses { get; set; }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Object15Enum? MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReverseGeocode : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReverseGeocode other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Addresses == null && other.Addresses == null) || (this.Addresses?.Equals(other.Addresses) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Addresses = {(this.Addresses == null ? "null" : $"[{string.Join(", ", this.Addresses)} ]")}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
        }
    }
}