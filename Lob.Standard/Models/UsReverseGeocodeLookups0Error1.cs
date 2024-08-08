// <copyright file="UsReverseGeocodeLookups0Error1.cs" company="APIMatic">
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
    /// UsReverseGeocodeLookups0Error1.
    /// </summary>
    public class UsReverseGeocodeLookups0Error1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsReverseGeocodeLookups0Error1"/> class.
        /// </summary>
        public UsReverseGeocodeLookups0Error1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsReverseGeocodeLookups0Error1"/> class.
        /// </summary>
        /// <param name="error">error.</param>
        public UsReverseGeocodeLookups0Error1(
            Models.Error1 error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error")]
        public Models.Error1 Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsReverseGeocodeLookups0Error1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsReverseGeocodeLookups0Error1 other &&                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}