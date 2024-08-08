// <copyright file="MultipleComponentsList.cs" company="APIMatic">
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
    /// MultipleComponentsList.
    /// </summary>
    public class MultipleComponentsList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleComponentsList"/> class.
        /// </summary>
        public MultipleComponentsList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleComponentsList"/> class.
        /// </summary>
        /// <param name="addresses">addresses.</param>
        public MultipleComponentsList(
            List<Models.MultipleComponents> addresses)
        {
            this.Addresses = addresses;
        }

        /// <summary>
        /// Gets or sets Addresses.
        /// </summary>
        [JsonProperty("addresses")]
        public List<Models.MultipleComponents> Addresses { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MultipleComponentsList : ({string.Join(", ", toStringOutput)})";
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
            return obj is MultipleComponentsList other &&                ((this.Addresses == null && other.Addresses == null) || (this.Addresses?.Equals(other.Addresses) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Addresses = {(this.Addresses == null ? "null" : $"[{string.Join(", ", this.Addresses)} ]")}");
        }
    }
}