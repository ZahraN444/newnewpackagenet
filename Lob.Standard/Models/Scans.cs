// <copyright file="Scans.cs" company="APIMatic">
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
    /// Scans.
    /// </summary>
    public class Scans
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scans"/> class.
        /// </summary>
        public Scans()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scans"/> class.
        /// </summary>
        /// <param name="ipLocation">ip_location.</param>
        /// <param name="scanDate">scan_date.</param>
        public Scans(
            string ipLocation = null,
            string scanDate = null)
        {
            this.IpLocation = ipLocation;
            this.ScanDate = scanDate;
        }

        /// <summary>
        /// Gets or sets IpLocation.
        /// </summary>
        [JsonProperty("ip_location", NullValueHandling = NullValueHandling.Ignore)]
        public string IpLocation { get; set; }

        /// <summary>
        /// Gets or sets ScanDate.
        /// </summary>
        [JsonProperty("scan_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ScanDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Scans : ({string.Join(", ", toStringOutput)})";
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
            return obj is Scans other &&                ((this.IpLocation == null && other.IpLocation == null) || (this.IpLocation?.Equals(other.IpLocation) == true)) &&
                ((this.ScanDate == null && other.ScanDate == null) || (this.ScanDate?.Equals(other.ScanDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IpLocation = {(this.IpLocation == null ? "null" : this.IpLocation)}");
            toStringOutput.Add($"this.ScanDate = {(this.ScanDate == null ? "null" : this.ScanDate)}");
        }
    }
}