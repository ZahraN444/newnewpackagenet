// <copyright file="DeliverabilityAnalysis1.cs" company="APIMatic">
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
    /// DeliverabilityAnalysis1.
    /// </summary>
    public class DeliverabilityAnalysis1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverabilityAnalysis1"/> class.
        /// </summary>
        public DeliverabilityAnalysis1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverabilityAnalysis1"/> class.
        /// </summary>
        /// <param name="dpvConfirmation">dpv_confirmation.</param>
        /// <param name="dpvCmra">dpv_cmra.</param>
        /// <param name="dpvVacant">dpv_vacant.</param>
        /// <param name="dpvActive">dpv_active.</param>
        /// <param name="dpvFootnotes">dpv_footnotes.</param>
        /// <param name="ewsMatch">ews_match.</param>
        /// <param name="lacsIndicator">lacs_indicator.</param>
        /// <param name="lacsReturnCode">lacs_return_code.</param>
        /// <param name="suiteReturnCode">suite_return_code.</param>
        public DeliverabilityAnalysis1(
            Models.DpvConfirmationEnum dpvConfirmation,
            Models.DpvCmraEnum dpvCmra,
            Models.DpvVacantEnum dpvVacant,
            Models.DpvActiveEnum dpvActive,
            List<Models.DpvFootnoteEnum> dpvFootnotes,
            bool ewsMatch,
            Models.LacsIndicatorEnum lacsIndicator,
            string lacsReturnCode,
            Models.SuiteReturnCodeEnum suiteReturnCode)
        {
            this.DpvConfirmation = dpvConfirmation;
            this.DpvCmra = dpvCmra;
            this.DpvVacant = dpvVacant;
            this.DpvActive = dpvActive;
            this.DpvFootnotes = dpvFootnotes;
            this.EwsMatch = ewsMatch;
            this.LacsIndicator = lacsIndicator;
            this.LacsReturnCode = lacsReturnCode;
            this.SuiteReturnCode = suiteReturnCode;
        }

        /// <summary>
        /// Gets or sets DpvConfirmation.
        /// </summary>
        [JsonProperty("dpv_confirmation")]
        public Models.DpvConfirmationEnum DpvConfirmation { get; set; }

        /// <summary>
        /// Gets or sets DpvCmra.
        /// </summary>
        [JsonProperty("dpv_cmra")]
        public Models.DpvCmraEnum DpvCmra { get; set; }

        /// <summary>
        /// Gets or sets DpvVacant.
        /// </summary>
        [JsonProperty("dpv_vacant")]
        public Models.DpvVacantEnum DpvVacant { get; set; }

        /// <summary>
        /// Gets or sets DpvActive.
        /// </summary>
        [JsonProperty("dpv_active")]
        public Models.DpvActiveEnum DpvActive { get; set; }

        /// <summary>
        /// An array of 2-character strings that gives more insight into how `deliverability_analysis[dpv_confirmation]` was determined. Will always include at least 1 string, and can include up to 3. For details, see [US Verification Details](#tag/US-Verification-Types).
        /// </summary>
        [JsonProperty("dpv_footnotes")]
        public List<Models.DpvFootnoteEnum> DpvFootnotes { get; set; }

        /// <summary>
        /// Indicates whether or not an address has been flagged in the <a href="https://docs.informatica.com/data-engineering/data-engineering-quality/10-4-0/address-validator-port-reference/postal-carrier-certification-data-ports/early-warning-system-return-code.html" target="_blank">Early Warning System</a>, meaning the address is under development and not yet ready to receive mail. However, it should become available in a few months.
        /// </summary>
        [JsonProperty("ews_match")]
        public bool EwsMatch { get; set; }

        /// <summary>
        /// Gets or sets LacsIndicator.
        /// </summary>
        [JsonProperty("lacs_indicator")]
        public Models.LacsIndicatorEnum LacsIndicator { get; set; }

        /// <summary>
        /// A code indicating how `deliverability_analysis[lacs_indicator]` was determined.
        /// Possible values are:
        /// * `A` — A new address was produced because a match was found in LACS<sup>Link</sup>.
        /// * `92` — A LACS<sup>Link</sup> record was matched after dropping secondary information.
        /// * `14` — A match was found in LACS<sup>Link</sup>, but could not be converted to a deliverable address.
        /// * `00` — A match was not found in LACS<sup>Link</sup>, and no new address was produced.
        /// * `''` — LACS<sup>Link</sup> was not attempted.
        /// </summary>
        [JsonProperty("lacs_return_code")]
        public string LacsReturnCode { get; set; }

        /// <summary>
        /// Gets or sets SuiteReturnCode.
        /// </summary>
        [JsonProperty("suite_return_code")]
        public Models.SuiteReturnCodeEnum SuiteReturnCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeliverabilityAnalysis1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeliverabilityAnalysis1 other &&                this.DpvConfirmation.Equals(other.DpvConfirmation) &&
                this.DpvCmra.Equals(other.DpvCmra) &&
                this.DpvVacant.Equals(other.DpvVacant) &&
                this.DpvActive.Equals(other.DpvActive) &&
                ((this.DpvFootnotes == null && other.DpvFootnotes == null) || (this.DpvFootnotes?.Equals(other.DpvFootnotes) == true)) &&
                this.EwsMatch.Equals(other.EwsMatch) &&
                this.LacsIndicator.Equals(other.LacsIndicator) &&
                ((this.LacsReturnCode == null && other.LacsReturnCode == null) || (this.LacsReturnCode?.Equals(other.LacsReturnCode) == true)) &&
                this.SuiteReturnCode.Equals(other.SuiteReturnCode);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DpvConfirmation = {this.DpvConfirmation}");
            toStringOutput.Add($"this.DpvCmra = {this.DpvCmra}");
            toStringOutput.Add($"this.DpvVacant = {this.DpvVacant}");
            toStringOutput.Add($"this.DpvActive = {this.DpvActive}");
            toStringOutput.Add($"this.DpvFootnotes = {(this.DpvFootnotes == null ? "null" : $"[{string.Join(", ", this.DpvFootnotes)} ]")}");
            toStringOutput.Add($"this.EwsMatch = {this.EwsMatch}");
            toStringOutput.Add($"this.LacsIndicator = {this.LacsIndicator}");
            toStringOutput.Add($"this.LacsReturnCode = {(this.LacsReturnCode == null ? "null" : this.LacsReturnCode)}");
            toStringOutput.Add($"this.SuiteReturnCode = {this.SuiteReturnCode}");
        }
    }
}