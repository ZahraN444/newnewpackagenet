// <copyright file="Suggestions.cs" company="APIMatic">
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
    /// Suggestions.
    /// </summary>
    public class Suggestions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestions"/> class.
        /// </summary>
        public Suggestions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestions"/> class.
        /// </summary>
        /// <param name="primaryLine">primary_line.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="mObject">object.</param>
        public Suggestions(
            string primaryLine,
            string city,
            string state,
            string zipCode,
            Models.Object13Enum? mObject = null)
        {
            this.PrimaryLine = primaryLine;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.MObject = mObject;
        }

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
        /// The <a href="https://en.wikipedia.org/wiki/ISO_3166-2" target="_blank">ISO 3166-2</a> two letter code for the state.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets ZipCode.
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Object13Enum? MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Suggestions : ({string.Join(", ", toStringOutput)})";
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
            return obj is Suggestions other &&                ((this.PrimaryLine == null && other.PrimaryLine == null) || (this.PrimaryLine?.Equals(other.PrimaryLine) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrimaryLine = {(this.PrimaryLine == null ? "null" : this.PrimaryLine)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
        }
    }
}