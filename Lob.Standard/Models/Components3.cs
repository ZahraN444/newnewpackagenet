// <copyright file="Components3.cs" company="APIMatic">
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
    /// Components3.
    /// </summary>
    public class Components3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Components3"/> class.
        /// </summary>
        public Components3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Components3"/> class.
        /// </summary>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="zipCodePlus4">zip_code_plus_4.</param>
        public Components3(
            string zipCode,
            string zipCodePlus4)
        {
            this.ZipCode = zipCode;
            this.ZipCodePlus4 = zipCodePlus4;
        }

        /// <summary>
        /// The 5-digit ZIP code
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets ZipCodePlus4.
        /// </summary>
        [JsonProperty("zip_code_plus_4")]
        public string ZipCodePlus4 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Components3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Components3 other &&                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.ZipCodePlus4 == null && other.ZipCodePlus4 == null) || (this.ZipCodePlus4?.Equals(other.ZipCodePlus4) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.ZipCodePlus4 = {(this.ZipCodePlus4 == null ? "null" : this.ZipCodePlus4)}");
        }
    }
}