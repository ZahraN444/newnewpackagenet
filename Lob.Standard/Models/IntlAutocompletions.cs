// <copyright file="IntlAutocompletions.cs" company="APIMatic">
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
    /// IntlAutocompletions.
    /// </summary>
    public class IntlAutocompletions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlAutocompletions"/> class.
        /// </summary>
        public IntlAutocompletions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntlAutocompletions"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="suggestions">suggestions.</param>
        public IntlAutocompletions(
            string id = null,
            List<Models.IntlSuggestions> suggestions = null)
        {
            this.Id = id;
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Unique identifier prefixed with `intl_auto_`.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// An array of objects representing suggested addresses.
        /// </summary>
        [JsonProperty("suggestions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IntlSuggestions> Suggestions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntlAutocompletions : ({string.Join(", ", toStringOutput)})";
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
            return obj is IntlAutocompletions other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Suggestions == null && other.Suggestions == null) || (this.Suggestions?.Equals(other.Suggestions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Suggestions = {(this.Suggestions == null ? "null" : $"[{string.Join(", ", this.Suggestions)} ]")}");
        }
    }
}