// <copyright file="SortBy.cs" company="APIMatic">
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
    /// SortBy.
    /// </summary>
    public class SortBy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy"/> class.
        /// </summary>
        public SortBy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy"/> class.
        /// </summary>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        public SortBy(
            Models.DateCreatedEnum dateCreated,
            Models.DateCreatedEnum dateModified)
        {
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
        }

        /// <summary>
        /// Gets or sets DateCreated.
        /// </summary>
        [JsonProperty("date_created")]
        public Models.DateCreatedEnum DateCreated { get; set; }

        /// <summary>
        /// Gets or sets DateModified.
        /// </summary>
        [JsonProperty("date_modified")]
        public Models.DateCreatedEnum DateModified { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SortBy : ({string.Join(", ", toStringOutput)})";
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
            return obj is SortBy other &&                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
        }
    }
}