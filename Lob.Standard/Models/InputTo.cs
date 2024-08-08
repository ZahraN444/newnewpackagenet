// <copyright file="InputTo.cs" company="APIMatic">
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
    using Lob.Standard.Models.Containers;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// InputTo.
    /// </summary>
    public class InputTo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputTo"/> class.
        /// </summary>
        public InputTo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTo"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        public InputTo(
            InputToTo to = null)
        {
            this.To = to;
        }

        /// <summary>
        /// <![CDATA[
        /// Must either be an address ID or an inline object with correct address parameters. If an object is used, an address will be created, corrected, and standardized for free whenever possible using our US Address Verification engine (if it is a US address), and returned back with an ID. Depending on your <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a>, US addresses may also be run through <a href="#tag/National-Change-of-Address">National Change of Address Linkage(NCOALink)</a>. Non-US addresses will be standardized into uppercase only. If a US address used does not meet your account’s <a href="https://dashboard.lob.com/#/settings/account" target="_blank">US Mail strictness setting</a>, the request will fail. <a href="https://help.lob.com/print-and-mail/all-about-addresses" target="_blank">Lob Guide: Verification of Mailing Addresses</a>
        /// ]]>
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public InputToTo To { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InputTo : ({string.Join(", ", toStringOutput)})";
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
            return obj is InputTo other &&                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
        }
    }
}