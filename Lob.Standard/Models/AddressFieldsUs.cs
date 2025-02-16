// <copyright file="AddressFieldsUs.cs" company="APIMatic">
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
    /// AddressFieldsUs.
    /// </summary>
    public class AddressFieldsUs
    {
        private string addressLine2;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "address_line2", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressFieldsUs"/> class.
        /// </summary>
        public AddressFieldsUs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressFieldsUs"/> class.
        /// </summary>
        /// <param name="addressLine1">address_line1.</param>
        /// <param name="addressCity">address_city.</param>
        /// <param name="addressState">address_state.</param>
        /// <param name="addressZip">address_zip.</param>
        /// <param name="addressLine2">address_line2.</param>
        public AddressFieldsUs(
            string addressLine1,
            string addressCity,
            string addressState,
            string addressZip,
            string addressLine2 = null)
        {
            this.AddressLine1 = addressLine1;
            if (addressLine2 != null)
            {
                this.AddressLine2 = addressLine2;
            }

            this.AddressCity = addressCity;
            this.AddressState = addressState;
            this.AddressZip = addressZip;
        }

        /// <summary>
        /// The primary number, street name, and directional information.
        /// </summary>
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// An optional field containing any information which can't fit into line 1.
        /// </summary>
        [JsonProperty("address_line2")]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }

            set
            {
                this.shouldSerialize["address_line2"] = true;
                this.addressLine2 = value;
            }
        }

        /// <summary>
        /// Gets or sets AddressCity.
        /// </summary>
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// 2 letter state short-name code
        /// </summary>
        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// Must follow the ZIP format of `12345` or ZIP+4 format of `12345-1234`.
        /// </summary>
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AddressFieldsUs : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddressLine2()
        {
            this.shouldSerialize["address_line2"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddressLine2()
        {
            return this.shouldSerialize["address_line2"];
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
            return obj is AddressFieldsUs other &&                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.AddressLine2 == null && other.AddressLine2 == null) || (this.AddressLine2?.Equals(other.AddressLine2) == true)) &&
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
            toStringOutput.Add($"this.AddressLine1 = {(this.AddressLine1 == null ? "null" : this.AddressLine1)}");
            toStringOutput.Add($"this.AddressLine2 = {(this.AddressLine2 == null ? "null" : this.AddressLine2)}");
            toStringOutput.Add($"this.AddressCity = {(this.AddressCity == null ? "null" : this.AddressCity)}");
            toStringOutput.Add($"this.AddressState = {(this.AddressState == null ? "null" : this.AddressState)}");
            toStringOutput.Add($"this.AddressZip = {(this.AddressZip == null ? "null" : this.AddressZip)}");
        }
    }
}