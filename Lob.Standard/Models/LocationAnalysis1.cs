// <copyright file="LocationAnalysis1.cs" company="APIMatic">
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
    /// LocationAnalysis1.
    /// </summary>
    public class LocationAnalysis1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAnalysis1"/> class.
        /// </summary>
        public LocationAnalysis1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAnalysis1"/> class.
        /// </summary>
        /// <param name="distance">distance.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public LocationAnalysis1(
            double distance,
            double? latitude = null,
            double? longitude = null)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Distance = distance;
        }

        /// <summary>
        /// A positive or negative decimal indicating the geographic latitude of the address, specifying the north-to-south position of a location. This should be used with `longitude` to pinpoint locations on a map. Will not be returned for undeliverable addresses or military addresses (state is `AA`, `AE`, or `AP`).
        /// </summary>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Include)]
        public double? Latitude { get; set; }

        /// <summary>
        /// A positive or negative decimal indicating the geographic longitude of the address, specifying the north-to-south position of a location. This should be used with `latitude` to pinpoint locations on a map. Will not be returned for undeliverable addresses or military addresses (state is `AA`, `AE`, or `AP`).
        /// </summary>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Include)]
        public double? Longitude { get; set; }

        /// <summary>
        /// The distance from the input location to this exact zip code in miles.
        /// </summary>
        [JsonProperty("distance")]
        public double Distance { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationAnalysis1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationAnalysis1 other &&                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true)) &&
                this.Distance.Equals(other.Distance);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude.ToString())}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude.ToString())}");
            toStringOutput.Add($"this.Distance = {this.Distance}");
        }
    }
}