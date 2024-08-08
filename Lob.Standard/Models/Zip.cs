// <copyright file="Zip.cs" company="APIMatic">
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
    /// Zip.
    /// </summary>
    public class Zip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zip"/> class.
        /// </summary>
        public Zip()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zip"/> class.
        /// </summary>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="id">id.</param>
        /// <param name="cities">cities.</param>
        /// <param name="zipCodeType">zip_code_type.</param>
        /// <param name="mObject">object.</param>
        public Zip(
            string zipCode,
            string id,
            List<Models.ZipLookupCity> cities,
            Models.ZipCodeTypeEnum zipCodeType,
            string mObject)
        {
            this.ZipCode = zipCode;
            this.Id = id;
            this.Cities = cities;
            this.ZipCodeType = zipCodeType;
            this.MObject = mObject;
        }

        /// <summary>
        /// A 5-digit ZIP code.
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `us_zip_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// An array of city objects containing valid cities for the `zip_code`. Multiple cities will be returned if more than one city is associated with the input ZIP code.
        /// </summary>
        [JsonProperty("cities")]
        public List<Models.ZipLookupCity> Cities { get; set; }

        /// <summary>
        /// Gets or sets ZipCodeType.
        /// </summary>
        [JsonProperty("zip_code_type")]
        public Models.ZipCodeTypeEnum ZipCodeType { get; set; }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object")]
        public string MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Zip : ({string.Join(", ", toStringOutput)})";
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
            return obj is Zip other &&                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Cities == null && other.Cities == null) || (this.Cities?.Equals(other.Cities) == true)) &&
                this.ZipCodeType.Equals(other.ZipCodeType) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Cities = {(this.Cities == null ? "null" : $"[{string.Join(", ", this.Cities)} ]")}");
            toStringOutput.Add($"this.ZipCodeType = {this.ZipCodeType}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
        }
    }
}