// <copyright file="IntlComponents.cs" company="APIMatic">
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
    /// IntlComponents.
    /// </summary>
    public class IntlComponents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlComponents"/> class.
        /// </summary>
        public IntlComponents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlComponents"/> class.
        /// </summary>
        /// <param name="primaryNumber">primary_number.</param>
        /// <param name="streetName">street_name.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="postalCode">postal_code.</param>
        public IntlComponents(
            string primaryNumber = null,
            string streetName = null,
            string city = null,
            string state = null,
            string postalCode = null)
        {
            this.PrimaryNumber = primaryNumber;
            this.StreetName = streetName;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// The numeric or alphanumeric part of an address preceding the street name. Often the house, building, or PO Box number.
        /// </summary>
        [JsonProperty("primary_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryNumber { get; set; }

        /// <summary>
        /// The name of the street.
        /// </summary>
        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// The <a href="https://en.wikipedia.org/wiki/ISO_3166-2" target="_blank">ISO 3166-2</a> two letter code for the state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntlComponents : ({string.Join(", ", toStringOutput)})";
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
            return obj is IntlComponents other &&                ((this.PrimaryNumber == null && other.PrimaryNumber == null) || (this.PrimaryNumber?.Equals(other.PrimaryNumber) == true)) &&
                ((this.StreetName == null && other.StreetName == null) || (this.StreetName?.Equals(other.StreetName) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrimaryNumber = {(this.PrimaryNumber == null ? "null" : this.PrimaryNumber)}");
            toStringOutput.Add($"this.StreetName = {(this.StreetName == null ? "null" : this.StreetName)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.PostalCode = {(this.PostalCode == null ? "null" : this.PostalCode)}");
        }
    }
}