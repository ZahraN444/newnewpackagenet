// <copyright file="RequiredAddressColumnMapping.cs" company="APIMatic">
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
    /// RequiredAddressColumnMapping.
    /// </summary>
    public class RequiredAddressColumnMapping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAddressColumnMapping"/> class.
        /// </summary>
        public RequiredAddressColumnMapping()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAddressColumnMapping"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="addressLine1">address_line1.</param>
        /// <param name="addressCity">address_city.</param>
        /// <param name="addressState">address_state.</param>
        /// <param name="addressZip">address_zip.</param>
        public RequiredAddressColumnMapping(
            string name = null,
            string addressLine1 = null,
            string addressCity = null,
            string addressState = null,
            string addressZip = null)
        {
            this.Name = name;
            this.AddressLine1 = addressLine1;
            this.AddressCity = addressCity;
            this.AddressState = addressState;
            this.AddressZip = addressZip;
        }

        /// <summary>
        /// The column header from the csv file that should be mapped to the required field `name`
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Include)]
        public string Name { get; set; }

        /// <summary>
        /// The column header from the csv file that should be mapped to the required field `address_line1`
        /// </summary>
        [JsonProperty("address_line1", NullValueHandling = NullValueHandling.Include)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The column header from the csv file that should be mapped to the required field `address_city`
        /// </summary>
        [JsonProperty("address_city", NullValueHandling = NullValueHandling.Include)]
        public string AddressCity { get; set; }

        /// <summary>
        /// The column header from the csv file that should be mapped to the required field `address_state`
        /// </summary>
        [JsonProperty("address_state", NullValueHandling = NullValueHandling.Include)]
        public string AddressState { get; set; }

        /// <summary>
        /// The column header from the csv file that should be mapped to the required field `address_zip`
        /// </summary>
        [JsonProperty("address_zip", NullValueHandling = NullValueHandling.Include)]
        public string AddressZip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequiredAddressColumnMapping : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequiredAddressColumnMapping other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.AddressCity == null && other.AddressCity == null) || (this.AddressCity?.Equals(other.AddressCity) == true)) &&
                ((this.AddressState == null && other.AddressState == null) || (this.AddressState?.Equals(other.AddressState) == true)) &&
                ((this.AddressZip == null && other.AddressZip == null) || (this.AddressZip?.Equals(other.AddressZip) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.AddressLine1 = {(this.AddressLine1 == null ? "null" : this.AddressLine1)}");
            toStringOutput.Add($"this.AddressCity = {(this.AddressCity == null ? "null" : this.AddressCity)}");
            toStringOutput.Add($"this.AddressState = {(this.AddressState == null ? "null" : this.AddressState)}");
            toStringOutput.Add($"this.AddressZip = {(this.AddressZip == null ? "null" : this.AddressZip)}");
        }
    }
}