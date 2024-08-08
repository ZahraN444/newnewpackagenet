// <copyright file="FromUs.cs" company="APIMatic">
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
    /// FromUs.
    /// </summary>
    public class FromUs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromUs"/> class.
        /// </summary>
        public FromUs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FromUs"/> class.
        /// </summary>
        /// <param name="from">from.</param>
        public FromUs(
            Models.AddressUs from = null)
        {
            this.From = from;
        }

        /// <summary>
        /// Gets or sets From.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressUs From { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FromUs : ({string.Join(", ", toStringOutput)})";
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
            return obj is FromUs other &&                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From.ToString())}");
        }
    }
}