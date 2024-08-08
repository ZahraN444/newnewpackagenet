// <copyright file="Beforeafter.cs" company="APIMatic">
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
    /// Beforeafter.
    /// </summary>
    public class Beforeafter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beforeafter"/> class.
        /// </summary>
        public Beforeafter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Beforeafter"/> class.
        /// </summary>
        /// <param name="before">before.</param>
        /// <param name="after">after.</param>
        public Beforeafter(
            string before,
            string after)
        {
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the `previous_url` field in the return response.
        /// </summary>
        [JsonProperty("before")]
        public string Before { get; set; }

        /// <summary>
        /// A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the `next_url` field in the return response.
        /// </summary>
        [JsonProperty("after")]
        public string After { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Beforeafter : ({string.Join(", ", toStringOutput)})";
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
            return obj is Beforeafter other &&                ((this.Before == null && other.Before == null) || (this.Before?.Equals(other.Before) == true)) &&
                ((this.After == null && other.After == null) || (this.After?.Equals(other.After) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Before = {(this.Before == null ? "null" : this.Before)}");
            toStringOutput.Add($"this.After = {(this.After == null ? "null" : this.After)}");
        }
    }
}