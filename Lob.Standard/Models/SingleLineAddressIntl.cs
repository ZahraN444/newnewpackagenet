// <copyright file="SingleLineAddressIntl.cs" company="APIMatic">
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
    /// SingleLineAddressIntl.
    /// </summary>
    public class SingleLineAddressIntl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLineAddressIntl"/> class.
        /// </summary>
        public SingleLineAddressIntl()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLineAddressIntl"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="country">country.</param>
        public SingleLineAddressIntl(
            string address,
            Models.CountryExtendedEnum country)
        {
            this.Address = address;
            this.Country = country;
        }

        /// <summary>
        /// The entire address in one string (e.g., "370 Water St C1N 1C4").
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country")]
        public Models.CountryExtendedEnum Country { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SingleLineAddressIntl : ({string.Join(", ", toStringOutput)})";
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
            return obj is SingleLineAddressIntl other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                this.Country.Equals(other.Country);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Country = {this.Country}");
        }
    }
}