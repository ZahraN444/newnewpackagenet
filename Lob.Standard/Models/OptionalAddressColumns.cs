// <copyright file="OptionalAddressColumns.cs" company="APIMatic">
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
    /// OptionalAddressColumns.
    /// </summary>
    public class OptionalAddressColumns
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionalAddressColumns"/> class.
        /// </summary>
        public OptionalAddressColumns()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionalAddressColumns"/> class.
        /// </summary>
        /// <param name="addressLine2">address_line2.</param>
        /// <param name="company">company.</param>
        /// <param name="addressCountry">address_country.</param>
        public OptionalAddressColumns(
            string addressLine2 = null,
            string company = null,
            string addressCountry = null)
        {
            this.AddressLine2 = addressLine2;
            this.Company = company;
            this.AddressCountry = addressCountry;
        }

        /// <summary>
        /// The column header from the csv file that should be mapped to the optional field "address_line2"
        /// </summary>
        [JsonProperty("address_line2", NullValueHandling = NullValueHandling.Include)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The column header from the csv file that should be mapped to the optional field "company"
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Include)]
        public string Company { get; set; }

        /// <summary>
        /// The column header from the csv file that should be mapped to the optional field "address_country"
        /// </summary>
        [JsonProperty("address_country", NullValueHandling = NullValueHandling.Include)]
        public string AddressCountry { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OptionalAddressColumns : ({string.Join(", ", toStringOutput)})";
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
            return obj is OptionalAddressColumns other &&                ((this.AddressLine2 == null && other.AddressLine2 == null) || (this.AddressLine2?.Equals(other.AddressLine2) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.AddressCountry == null && other.AddressCountry == null) || (this.AddressCountry?.Equals(other.AddressCountry) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressLine2 = {(this.AddressLine2 == null ? "null" : this.AddressLine2)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company)}");
            toStringOutput.Add($"this.AddressCountry = {(this.AddressCountry == null ? "null" : this.AddressCountry)}");
        }
    }
}