// <copyright file="Thumbnail.cs" company="APIMatic">
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
    /// Thumbnail.
    /// </summary>
    public class Thumbnail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail"/> class.
        /// </summary>
        public Thumbnail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail"/> class.
        /// </summary>
        /// <param name="small">small.</param>
        /// <param name="medium">medium.</param>
        /// <param name="large">large.</param>
        public Thumbnail(
            string small = null,
            string medium = null,
            string large = null)
        {
            this.Small = small;
            this.Medium = medium;
            this.Large = large;
        }

        /// <summary>
        /// A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.
        /// </summary>
        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public string Small { get; set; }

        /// <summary>
        /// A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.
        /// </summary>
        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public string Medium { get; set; }

        /// <summary>
        /// A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.
        /// </summary>
        [JsonProperty("large", NullValueHandling = NullValueHandling.Ignore)]
        public string Large { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Thumbnail : ({string.Join(", ", toStringOutput)})";
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
            return obj is Thumbnail other &&                ((this.Small == null && other.Small == null) || (this.Small?.Equals(other.Small) == true)) &&
                ((this.Medium == null && other.Medium == null) || (this.Medium?.Equals(other.Medium) == true)) &&
                ((this.Large == null && other.Large == null) || (this.Large?.Equals(other.Large) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Small = {(this.Small == null ? "null" : this.Small)}");
            toStringOutput.Add($"this.Medium = {(this.Medium == null ? "null" : this.Medium)}");
            toStringOutput.Add($"this.Large = {(this.Large == null ? "null" : this.Large)}");
        }
    }
}