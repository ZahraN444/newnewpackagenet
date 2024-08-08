// <copyright file="CheckInputTo.cs" company="APIMatic">
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
    /// CheckInputTo.
    /// </summary>
    public class CheckInputTo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckInputTo"/> class.
        /// </summary>
        public CheckInputTo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckInputTo"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        public CheckInputTo(
            CheckInputToTo to = null)
        {
            this.To = to;
        }

        /// <summary>
        /// <![CDATA[
        /// Must either be an address ID or an inline object with correct address parameters. Checks cannot be sent internationally (`address_country` must be `US`). The total string of the sum of `address_line1` and `address_line2` must be no longer than 50 characters combined. If an object is used, an address will be created, corrected, and standardized for free whenever possible using our US Address Verification engine, and returned back with an ID. Depending on your <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a>, addresses may also be run through [National Change of Address (NCOALink)](#tag/National-Change-of-Address). If an address used does not meet your account’s <a href="https://dashboard.lob.com/#/settings/account" target="_blank">US Mail Strictness Setting</a>, the request will fail. <a href="https://help.lob.com/print-and-mail/all-about-addresses" target="_blank">More about verification of mailing addresses</a>
        /// ]]>
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public CheckInputToTo To { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CheckInputTo : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckInputTo other &&                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true));
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