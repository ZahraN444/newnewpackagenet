// <copyright file="IntlVerification.cs" company="APIMatic">
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
    /// IntlVerification.
    /// </summary>
    public class IntlVerification
    {
        private string recipient;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recipient", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlVerification"/> class.
        /// </summary>
        public IntlVerification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlVerification"/> class.
        /// </summary>
        /// <param name="recipient">recipient.</param>
        /// <param name="primaryLine">primary_line.</param>
        /// <param name="secondaryLine">secondary_line.</param>
        /// <param name="id">id.</param>
        /// <param name="lastLine">last_line.</param>
        /// <param name="country">country.</param>
        /// <param name="coverage">coverage.</param>
        /// <param name="deliverability">deliverability.</param>
        /// <param name="status">status.</param>
        /// <param name="components">components.</param>
        /// <param name="mObject">object.</param>
        public IntlVerification(
            string recipient = null,
            string primaryLine = null,
            string secondaryLine = null,
            string id = null,
            string lastLine = null,
            string country = null,
            Models.CoverageEnum? coverage = null,
            Models.Deliverability1Enum? deliverability = null,
            Models.Status1Enum? status = null,
            Models.Components1 components = null,
            Models.Object2Enum? mObject = null)
        {
            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.Id = id;
            this.LastLine = lastLine;
            this.Country = country;
            this.Coverage = coverage;
            this.Deliverability = deliverability;
            this.Status = status;
            this.Components = components;
            this.MObject = mObject;
        }

        /// <summary>
        /// The intended recipient, typically a person's or firm's name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        /// Unique identifier prefixed with `intl_ver_`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Combination of the following applicable `components`:
        /// * `city`
        /// * `state`
        /// * `zip_code`
        /// * `zip_code_plus_4`
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("last_line", NullValueHandling = NullValueHandling.Ignore)]
        public string LastLine { get; set; }

        /// <summary>
        /// The country of the address. Will be returned as a 2 letter country short-name code (ISO 3166).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Coverage.
        /// </summary>
        [JsonProperty("coverage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CoverageEnum? Coverage { get; set; }

        /// <summary>
        /// Gets or sets Deliverability.
        /// </summary>
        [JsonProperty("deliverability", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Deliverability1Enum? Deliverability { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Status1Enum? Status { get; set; }

        /// <summary>
        /// Gets or sets Components.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Components1 Components { get; set; }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Object2Enum? MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntlVerification : ({string.Join(", ", toStringOutput)})";
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
            return obj is IntlVerification other &&                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.PrimaryLine == null && other.PrimaryLine == null) || (this.PrimaryLine?.Equals(other.PrimaryLine) == true)) &&
                ((this.SecondaryLine == null && other.SecondaryLine == null) || (this.SecondaryLine?.Equals(other.SecondaryLine) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.LastLine == null && other.LastLine == null) || (this.LastLine?.Equals(other.LastLine) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Coverage == null && other.Coverage == null) || (this.Coverage?.Equals(other.Coverage) == true)) &&
                ((this.Deliverability == null && other.Deliverability == null) || (this.Deliverability?.Equals(other.Deliverability) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
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
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.LastLine = {(this.LastLine == null ? "null" : this.LastLine)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Coverage = {(this.Coverage == null ? "null" : this.Coverage.ToString())}");
            toStringOutput.Add($"this.Deliverability = {(this.Deliverability == null ? "null" : this.Deliverability.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : this.Components.ToString())}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
        }
    }
}