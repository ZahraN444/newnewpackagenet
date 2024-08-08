// <copyright file="InputFromUs.cs" company="APIMatic">
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
    /// InputFromUs.
    /// </summary>
    public class InputFromUs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFromUs"/> class.
        /// </summary>
        public InputFromUs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFromUs"/> class.
        /// </summary>
        /// <param name="from">from.</param>
        public InputFromUs(
            InputFromUsFrom from = null)
        {
            this.From = from;
        }

        /// <summary>
        /// *Required* if `to` address is international. Must either be an address ID or an inline object with correct address parameters. Must either be an address ID or an inline object with correct address parameters. All addresses will be standardized into uppercase without being modified by verification.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public InputFromUsFrom From { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InputFromUs : ({string.Join(", ", toStringOutput)})";
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
            return obj is InputFromUs other &&                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true));
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