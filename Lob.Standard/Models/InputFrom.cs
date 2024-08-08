// <copyright file="InputFrom.cs" company="APIMatic">
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
    /// InputFrom.
    /// </summary>
    public class InputFrom
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFrom"/> class.
        /// </summary>
        public InputFrom()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFrom"/> class.
        /// </summary>
        /// <param name="from">from.</param>
        public InputFrom(
            InputFromFrom from = null)
        {
            this.From = from;
        }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters. Must be a US address unless using a `custom_envelope`. All addresses will be standardized into uppercase without being modified by verification.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public InputFromFrom From { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InputFrom : ({string.Join(", ", toStringOutput)})";
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
            return obj is InputFrom other &&                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"From = {(this.From == null ? "null" : this.From.ToString())}");
        }
    }
}