// <copyright file="CompanyValidation.cs" company="APIMatic">
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
    /// CompanyValidation.
    /// </summary>
    public class CompanyValidation
    {
        private string company;
        private double? score;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "company", false },
            { "score", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyValidation"/> class.
        /// </summary>
        public CompanyValidation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyValidation"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="company">company.</param>
        /// <param name="primaryLine">primary_line.</param>
        /// <param name="secondaryLine">secondary_line.</param>
        /// <param name="urbanization">urbanization.</param>
        /// <param name="lastLine">last_line.</param>
        /// <param name="score">score.</param>
        /// <param name="confidence">confidence.</param>
        /// <param name="mObject">object.</param>
        public CompanyValidation(
            string id = null,
            string company = null,
            string primaryLine = null,
            string secondaryLine = null,
            string urbanization = null,
            string lastLine = null,
            double? score = null,
            Models.ConfidenceEnum? confidence = null,
            Models.Object6Enum? mObject = null)
        {
            this.Id = id;
            if (company != null)
            {
                this.Company = company;
            }

            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.Urbanization = urbanization;
            this.LastLine = lastLine;
            if (score != null)
            {
                this.Score = score;
            }

            this.Confidence = confidence;
            this.MObject = mObject;
        }

        /// <summary>
        /// Unique identifier prefixed with `id_validation_`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the company or firm.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("company")]
        public string Company
        {
            get
            {
                return this.company;
            }

            set
            {
                this.shouldSerialize["company"] = true;
                this.company = value;
            }
        }

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
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("primary_line", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// The secondary delivery line of the address. This field is typically empty but may contain information if `primary_line` is too long.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("secondary_line", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See <a href="https://pe.usps.com/text/pub28/28api_008.htm#:~:text=I51.,-4%20Urbanizations&text=In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name." target="_blank">USPS documentation</a> for clarification.
        /// ]]>
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("urbanization", NullValueHandling = NullValueHandling.Ignore)]
        public string Urbanization { get; set; }

        /// <summary>
        /// Combination of the following applicable `components`:
        /// * City (`city`)
        /// * State (`state`)
        /// * ZIP code (`zip_code`)
        /// * ZIP+4 (`zip_code_plus_4`)
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("last_line", NullValueHandling = NullValueHandling.Ignore)]
        public string LastLine { get; set; }

        /// <summary>
        /// A numerical score between 0 and 100 that represents the likelihood the provided name is associated with a physical address.
        /// </summary>
        [JsonProperty("score")]
        public double? Score
        {
            get
            {
                return this.score;
            }

            set
            {
                this.shouldSerialize["score"] = true;
                this.score = value;
            }
        }

        /// <summary>
        /// Gets or sets Confidence.
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ConfidenceEnum? Confidence { get; set; }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Object6Enum? MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CompanyValidation : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCompany()
        {
            this.shouldSerialize["company"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetScore()
        {
            this.shouldSerialize["score"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCompany()
        {
            return this.shouldSerialize["company"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeScore()
        {
            return this.shouldSerialize["score"];
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
            return obj is CompanyValidation other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.PrimaryLine == null && other.PrimaryLine == null) || (this.PrimaryLine?.Equals(other.PrimaryLine) == true)) &&
                ((this.SecondaryLine == null && other.SecondaryLine == null) || (this.SecondaryLine?.Equals(other.SecondaryLine) == true)) &&
                ((this.Urbanization == null && other.Urbanization == null) || (this.Urbanization?.Equals(other.Urbanization) == true)) &&
                ((this.LastLine == null && other.LastLine == null) || (this.LastLine?.Equals(other.LastLine) == true)) &&
                ((this.Score == null && other.Score == null) || (this.Score?.Equals(other.Score) == true)) &&
                ((this.Confidence == null && other.Confidence == null) || (this.Confidence?.Equals(other.Confidence) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company)}");
            toStringOutput.Add($"this.PrimaryLine = {(this.PrimaryLine == null ? "null" : this.PrimaryLine)}");
            toStringOutput.Add($"this.SecondaryLine = {(this.SecondaryLine == null ? "null" : this.SecondaryLine)}");
            toStringOutput.Add($"this.Urbanization = {(this.Urbanization == null ? "null" : this.Urbanization)}");
            toStringOutput.Add($"this.LastLine = {(this.LastLine == null ? "null" : this.LastLine)}");
            toStringOutput.Add($"this.Score = {(this.Score == null ? "null" : this.Score.ToString())}");
            toStringOutput.Add($"this.Confidence = {(this.Confidence == null ? "null" : this.Confidence.ToString())}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
        }
    }
}