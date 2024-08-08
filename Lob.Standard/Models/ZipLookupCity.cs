// <copyright file="ZipLookupCity.cs" company="APIMatic">
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
    /// ZipLookupCity.
    /// </summary>
    public class ZipLookupCity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipLookupCity"/> class.
        /// </summary>
        public ZipLookupCity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipLookupCity"/> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="county">county.</param>
        /// <param name="countyFips">county_fips.</param>
        /// <param name="preferred">preferred.</param>
        public ZipLookupCity(
            string city,
            string state,
            string county,
            string countyFips,
            bool preferred)
        {
            this.City = city;
            this.State = state;
            this.County = county;
            this.CountyFips = countyFips;
            this.Preferred = preferred;
        }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The <a href="https://en.wikipedia.org/wiki/ISO_3166-2" target="_blank">ISO 3166-2</a> two letter code for the state.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// County name of the address city.
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// A 5-digit <a href="https://en.wikipedia.org/wiki/FIPS_county_code" target="_blank">FIPS county code</a> which uniquely identifies `components[county]`. It consists of a 2-digit state code and a 3-digit county code.
        /// </summary>
        [JsonProperty("county_fips")]
        public string CountyFips { get; set; }

        /// <summary>
        /// Indicates whether or not the city is the <a href="https://en.wikipedia.org/wiki/ZIP_Code#ZIP_Codes_and_previous_zoning_lines" target="_blank">USPS default city</a> (preferred city) of a ZIP code. There is only one preferred city per ZIP code, which will always be in position 0 in the array of cities.
        /// </summary>
        [JsonProperty("preferred")]
        public bool Preferred { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ZipLookupCity : ({string.Join(", ", toStringOutput)})";
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
            return obj is ZipLookupCity other &&                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.County == null && other.County == null) || (this.County?.Equals(other.County) == true)) &&
                ((this.CountyFips == null && other.CountyFips == null) || (this.CountyFips?.Equals(other.CountyFips) == true)) &&
                this.Preferred.Equals(other.Preferred);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.County = {(this.County == null ? "null" : this.County)}");
            toStringOutput.Add($"this.CountyFips = {(this.CountyFips == null ? "null" : this.CountyFips)}");
            toStringOutput.Add($"this.Preferred = {this.Preferred}");
        }
    }
}