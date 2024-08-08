// <copyright file="BankAccountVerify.cs" company="APIMatic">
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
    /// BankAccountVerify.
    /// </summary>
    public class BankAccountVerify
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountVerify"/> class.
        /// </summary>
        public BankAccountVerify()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountVerify"/> class.
        /// </summary>
        /// <param name="amounts">amounts.</param>
        public BankAccountVerify(
            List<int> amounts)
        {
            this.Amounts = amounts;
        }

        /// <summary>
        /// In live mode, an array containing the two micro deposits (in cents) placed in the bank account. In test mode, no micro deposits will be placed, so any two integers between `1` and `100` will work.
        /// </summary>
        [JsonProperty("amounts")]
        public List<int> Amounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BankAccountVerify : ({string.Join(", ", toStringOutput)})";
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
            return obj is BankAccountVerify other &&                ((this.Amounts == null && other.Amounts == null) || (this.Amounts?.Equals(other.Amounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amounts = {(this.Amounts == null ? "null" : $"[{string.Join(", ", this.Amounts)} ]")}");
        }
    }
}