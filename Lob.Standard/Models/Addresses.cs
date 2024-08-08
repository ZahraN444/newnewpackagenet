// <copyright file="Addresses.cs" company="APIMatic">
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
    /// Addresses.
    /// </summary>
    public class Addresses
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Addresses"/> class.
        /// </summary>
        public Addresses()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Addresses"/> class.
        /// </summary>
        /// <param name="components">components.</param>
        /// <param name="locationAnalysis">location_analysis.</param>
        public Addresses(
            Models.Components3 components = null,
            Models.LocationAnalysis1 locationAnalysis = null)
        {
            this.Components = components;
            this.LocationAnalysis = locationAnalysis;
        }

        /// <summary>
        /// Gets or sets Components.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Components3 Components { get; set; }

        /// <summary>
        /// Gets or sets LocationAnalysis.
        /// </summary>
        [JsonProperty("location_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LocationAnalysis1 LocationAnalysis { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Addresses : ({string.Join(", ", toStringOutput)})";
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
            return obj is Addresses other &&                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.LocationAnalysis == null && other.LocationAnalysis == null) || (this.LocationAnalysis?.Equals(other.LocationAnalysis) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : this.Components.ToString())}");
            toStringOutput.Add($"this.LocationAnalysis = {(this.LocationAnalysis == null ? "null" : this.LocationAnalysis.ToString())}");
        }
    }
}