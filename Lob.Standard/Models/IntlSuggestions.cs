// <copyright file="IntlSuggestions.cs" company="APIMatic">
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
    /// IntlSuggestions.
    /// </summary>
    public class IntlSuggestions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlSuggestions"/> class.
        /// </summary>
        public IntlSuggestions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlSuggestions"/> class.
        /// </summary>
        /// <param name="primaryNumberRange">primary_number_range.</param>
        /// <param name="primaryLine">primary_line.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="state">state.</param>
        /// <param name="zipCode">zip_code.</param>
        public IntlSuggestions(
            string primaryNumberRange,
            string primaryLine,
            string city,
            Models.CountryExtendedEnum country,
            string state,
            string zipCode)
        {
            this.PrimaryNumberRange = primaryNumberRange;
            this.PrimaryLine = primaryLine;
            this.City = city;
            this.Country = country;
            this.State = state;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// The primary number range of the address that identifies a building at street level.
        /// </summary>
        [JsonProperty("primary_number_range")]
        public string PrimaryNumberRange { get; set; }

        /// <summary>
        /// <![CDATA[
        /// The primary delivery line (usually the street address) of the address.
        /// Combination of the following applicable `components` (primary number &
        /// secondary information may be missing or inaccurate):
        /// * `primary_number`
        /// * `street_predirection`
        /// * `street_name`
        /// * `street_suffix`
        /// * `street_postdirection`
        /// * `secondary_designator`
        /// * `secondary_number`
        /// * `pmb_designator`
        /// * `pmb_number`
        /// ]]>
        /// </summary>
        [JsonProperty("primary_line")]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country")]
        public Models.CountryExtendedEnum Country { get; set; }

        /// <summary>
        /// The <a href="https://en.wikipedia.org/wiki/ISO_3166-2" target="_blank">ISO 3166-2</a> two letter code for the state.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntlSuggestions : ({string.Join(", ", toStringOutput)})";
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
            return obj is IntlSuggestions other &&                ((this.PrimaryNumberRange == null && other.PrimaryNumberRange == null) || (this.PrimaryNumberRange?.Equals(other.PrimaryNumberRange) == true)) &&
                ((this.PrimaryLine == null && other.PrimaryLine == null) || (this.PrimaryLine?.Equals(other.PrimaryLine) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                this.Country.Equals(other.Country) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrimaryNumberRange = {(this.PrimaryNumberRange == null ? "null" : this.PrimaryNumberRange)}");
            toStringOutput.Add($"this.PrimaryLine = {(this.PrimaryLine == null ? "null" : this.PrimaryLine)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.Country = {this.Country}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
        }
    }
}