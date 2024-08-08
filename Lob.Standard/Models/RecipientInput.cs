// <copyright file="RecipientInput.cs" company="APIMatic">
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
    /// RecipientInput.
    /// </summary>
    public class RecipientInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientInput"/> class.
        /// </summary>
        public RecipientInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientInput"/> class.
        /// </summary>
        /// <param name="primaryLine">primary_line.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="secondaryLine">secondary_line.</param>
        /// <param name="urbanization">urbanization.</param>
        public RecipientInput(
            string primaryLine,
            string city,
            string state,
            string zipCode,
            string recipient = null,
            string secondaryLine = null,
            string urbanization = null)
        {
            this.Recipient = recipient;
            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.Urbanization = urbanization;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// The intended recipient, typically a person's or firm's name.
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Include)]
        public string Recipient { get; set; }

        /// <summary>
        /// The primary delivery line (usually the street address) of the address.
        /// Combination of the following applicable `components`:
        /// * `primary_number`
        /// * `street_predirection`
        /// * `street_name`
        /// * `street_suffix`
        /// * `street_postdirection`
        /// * `secondary_designator`
        /// * `secondary_number`
        /// * `pmb_designator`
        /// * `pmb_number`
        /// </summary>
        [JsonProperty("primary_line")]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// The secondary delivery line of the address. This field is typically empty but may contain information if `primary_line` is too long.
        /// </summary>
        [JsonProperty("secondary_line", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See <a href="https://pe.usps.com/text/pub28/28api_008.htm#:~:text=I51.,-4%20Urbanizations&text=In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name." target="_blank">USPS documentation</a> for clarification.
        /// ]]>
        /// </summary>
        [JsonProperty("urbanization", NullValueHandling = NullValueHandling.Ignore)]
        public string Urbanization { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The <a href="https://en.wikipedia.org/wiki/ISO_3166-2:US" target="_blank">ISO 3166-2</a> two letter code or subdivision name for the state. `city` and `state` are required if no `zip_code` is passed.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets ZipCode.
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RecipientInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is RecipientInput other &&                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.PrimaryLine == null && other.PrimaryLine == null) || (this.PrimaryLine?.Equals(other.PrimaryLine) == true)) &&
                ((this.SecondaryLine == null && other.SecondaryLine == null) || (this.SecondaryLine?.Equals(other.SecondaryLine) == true)) &&
                ((this.Urbanization == null && other.Urbanization == null) || (this.Urbanization?.Equals(other.Urbanization) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true));
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
            toStringOutput.Add($"this.Urbanization = {(this.Urbanization == null ? "null" : this.Urbanization)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
        }
    }
}