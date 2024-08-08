// <copyright file="MultipleComponentsIntl.cs" company="APIMatic">
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
    /// MultipleComponentsIntl.
    /// </summary>
    public class MultipleComponentsIntl
    {
        private string recipient;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recipient", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleComponentsIntl"/> class.
        /// </summary>
        public MultipleComponentsIntl()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleComponentsIntl"/> class.
        /// </summary>
        /// <param name="primaryLine">primary_line.</param>
        /// <param name="country">country.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="secondaryLine">secondary_line.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="postalCode">postal_code.</param>
        public MultipleComponentsIntl(
            string primaryLine,
            Models.CountryExtendedEnum country,
            string recipient = null,
            string secondaryLine = null,
            string city = null,
            string state = null,
            string postalCode = null)
        {
            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        /// <summary>
        /// The intended recipient, typically a person's or firm's name.
        /// </summary>
        [JsonProperty("recipient")]
        public string Recipient
        {
            get
            {
                return this.recipient;
            }

            set
            {
                this.shouldSerialize["recipient"] = true;
                this.recipient = value;
            }
        }

        /// <summary>
        /// The primary delivery line (usually the street address) of the address.
        /// </summary>
        [JsonProperty("primary_line")]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// The secondary delivery line of the address. This field is typically empty but may contain information if `primary_line` is too long.
        /// </summary>
        [JsonProperty("secondary_line", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// The name of the state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

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

            return $"MultipleComponentsIntl : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRecipient()
        {
            this.shouldSerialize["recipient"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipient()
        {
            return this.shouldSerialize["recipient"];
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
            return obj is MultipleComponentsIntl other &&                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.PrimaryLine == null && other.PrimaryLine == null) || (this.PrimaryLine?.Equals(other.PrimaryLine) == true)) &&
                ((this.SecondaryLine == null && other.SecondaryLine == null) || (this.SecondaryLine?.Equals(other.SecondaryLine) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true)) &&
                this.Country.Equals(other.Country);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient)}");
            toStringOutput.Add($"this.PrimaryLine = {(this.PrimaryLine == null ? "null" : this.PrimaryLine)}");
            toStringOutput.Add($"this.SecondaryLine = {(this.SecondaryLine == null ? "null" : this.SecondaryLine)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.PostalCode = {(this.PostalCode == null ? "null" : this.PostalCode)}");
            toStringOutput.Add($"this.Country = {this.Country}");
        }
    }
}