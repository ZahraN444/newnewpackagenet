// <copyright file="UsAutocompletionsWritable.cs" company="APIMatic">
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
    /// UsAutocompletionsWritable.
    /// </summary>
    public class UsAutocompletionsWritable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsAutocompletionsWritable"/> class.
        /// </summary>
        public UsAutocompletionsWritable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsAutocompletionsWritable"/> class.
        /// </summary>
        /// <param name="addressPrefix">address_prefix.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="geoIpSort">geo_ip_sort.</param>
        public UsAutocompletionsWritable(
            string addressPrefix,
            string city = null,
            string state = null,
            string zipCode = null,
            bool? geoIpSort = null)
        {
            this.AddressPrefix = addressPrefix;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.GeoIpSort = geoIpSort;
        }

        /// <summary>
        /// Only accepts numbers and street names in an alphanumeric format.
        /// </summary>
        [JsonProperty("address_prefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// An optional ZIP Code input used to filter suggestions. Matches partial entries.
        /// </summary>
        [JsonProperty("zip_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        /// <summary>
        /// If `true`, sort suggestions by proximity to the IP set in the `X-Forwarded-For` header.
        /// </summary>
        [JsonProperty("geo_ip_sort", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GeoIpSort { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsAutocompletionsWritable : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsAutocompletionsWritable other &&                ((this.AddressPrefix == null && other.AddressPrefix == null) || (this.AddressPrefix?.Equals(other.AddressPrefix) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.GeoIpSort == null && other.GeoIpSort == null) || (this.GeoIpSort?.Equals(other.GeoIpSort) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressPrefix = {(this.AddressPrefix == null ? "null" : this.AddressPrefix)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.GeoIpSort = {(this.GeoIpSort == null ? "null" : this.GeoIpSort.ToString())}");
        }
    }
}