// <copyright file="LettersResponse.cs" company="APIMatic">
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
    /// LettersResponse.
    /// </summary>
    public class LettersResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LettersResponse"/> class.
        /// </summary>
        public LettersResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettersResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="deleted">deleted.</param>
        public LettersResponse(
            string id = null,
            bool? deleted = null)
        {
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Unique identifier prefixed with `ltr_`.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LettersResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is LettersResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
        }
    }
}