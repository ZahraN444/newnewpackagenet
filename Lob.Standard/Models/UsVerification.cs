// <copyright file="UsVerification.cs" company="APIMatic">
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
    /// UsVerification.
    /// </summary>
    public class UsVerification
    {
        private string recipient;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recipient", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UsVerification"/> class.
        /// </summary>
        public UsVerification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsVerification"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="primaryLine">primary_line.</param>
        /// <param name="secondaryLine">secondary_line.</param>
        /// <param name="urbanization">urbanization.</param>
        /// <param name="lastLine">last_line.</param>
        /// <param name="deliverability">deliverability.</param>
        /// <param name="validAddress">valid_address.</param>
        /// <param name="components">components.</param>
        /// <param name="deliverabilityAnalysis">deliverability_analysis.</param>
        /// <param name="lobConfidenceScore">lob_confidence_score.</param>
        /// <param name="mObject">object.</param>
        public UsVerification(
            string id = null,
            string recipient = null,
            string primaryLine = null,
            string secondaryLine = null,
            string urbanization = null,
            string lastLine = null,
            Models.DeliverabilityEnum? deliverability = null,
            bool? validAddress = null,
            Models.Components4 components = null,
            Models.DeliverabilityAnalysis1 deliverabilityAnalysis = null,
            Models.LobConfidenceScore1 lobConfidenceScore = null,
            Models.Object1Enum? mObject = null)
        {
            this.Id = id;
            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            this.PrimaryLine = primaryLine;
            this.SecondaryLine = secondaryLine;
            this.Urbanization = urbanization;
            this.LastLine = lastLine;
            this.Deliverability = deliverability;
            this.ValidAddress = validAddress;
            this.Components = components;
            this.DeliverabilityAnalysis = deliverabilityAnalysis;
            this.LobConfidenceScore = lobConfidenceScore;
            this.MObject = mObject;
        }

        /// <summary>
        /// Unique identifier prefixed with `us_ver_`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

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
        /// Gets or sets Deliverability.
        /// </summary>
        [JsonProperty("deliverability", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliverabilityEnum? Deliverability { get; set; }

        /// <summary>
        /// This field indicates whether an address was found in a more comprehensive address dataset that includes sources from the USPS, open source mapping data, and our proprietary mail delivery data.
        /// This field can be interpreted as a representation of whether an address is a real location or not. Additionally a valid address may contradict the deliverability field since an address can be a real valid location but the USPS may not deliver to that address.
        /// </summary>
        [JsonProperty("valid_address", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidAddress { get; set; }

        /// <summary>
        /// Gets or sets Components.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Components4 Components { get; set; }

        /// <summary>
        /// Gets or sets DeliverabilityAnalysis.
        /// </summary>
        [JsonProperty("deliverability_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliverabilityAnalysis1 DeliverabilityAnalysis { get; set; }

        /// <summary>
        /// Gets or sets LobConfidenceScore.
        /// </summary>
        [JsonProperty("lob_confidence_score", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LobConfidenceScore1 LobConfidenceScore { get; set; }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Object1Enum? MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsVerification : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsVerification other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.PrimaryLine == null && other.PrimaryLine == null) || (this.PrimaryLine?.Equals(other.PrimaryLine) == true)) &&
                ((this.SecondaryLine == null && other.SecondaryLine == null) || (this.SecondaryLine?.Equals(other.SecondaryLine) == true)) &&
                ((this.Urbanization == null && other.Urbanization == null) || (this.Urbanization?.Equals(other.Urbanization) == true)) &&
                ((this.LastLine == null && other.LastLine == null) || (this.LastLine?.Equals(other.LastLine) == true)) &&
                ((this.Deliverability == null && other.Deliverability == null) || (this.Deliverability?.Equals(other.Deliverability) == true)) &&
                ((this.ValidAddress == null && other.ValidAddress == null) || (this.ValidAddress?.Equals(other.ValidAddress) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.DeliverabilityAnalysis == null && other.DeliverabilityAnalysis == null) || (this.DeliverabilityAnalysis?.Equals(other.DeliverabilityAnalysis) == true)) &&
                ((this.LobConfidenceScore == null && other.LobConfidenceScore == null) || (this.LobConfidenceScore?.Equals(other.LobConfidenceScore) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient)}");
            toStringOutput.Add($"this.PrimaryLine = {(this.PrimaryLine == null ? "null" : this.PrimaryLine)}");
            toStringOutput.Add($"this.SecondaryLine = {(this.SecondaryLine == null ? "null" : this.SecondaryLine)}");
            toStringOutput.Add($"this.Urbanization = {(this.Urbanization == null ? "null" : this.Urbanization)}");
            toStringOutput.Add($"this.LastLine = {(this.LastLine == null ? "null" : this.LastLine)}");
            toStringOutput.Add($"this.Deliverability = {(this.Deliverability == null ? "null" : this.Deliverability.ToString())}");
            toStringOutput.Add($"this.ValidAddress = {(this.ValidAddress == null ? "null" : this.ValidAddress.ToString())}");
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : this.Components.ToString())}");
            toStringOutput.Add($"this.DeliverabilityAnalysis = {(this.DeliverabilityAnalysis == null ? "null" : this.DeliverabilityAnalysis.ToString())}");
            toStringOutput.Add($"this.LobConfidenceScore = {(this.LobConfidenceScore == null ? "null" : this.LobConfidenceScore.ToString())}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
        }
    }
}