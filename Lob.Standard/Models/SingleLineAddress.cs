// <copyright file="SingleLineAddress.cs" company="APIMatic">
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
    /// SingleLineAddress.
    /// </summary>
    public class SingleLineAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLineAddress"/> class.
        /// </summary>
        public SingleLineAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLineAddress"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        public SingleLineAddress(
            string address)
        {
            this.Address = address;
        }

        /// <summary>
        /// The entire address in one string (e.g., "210 King Street 94107"). _Does not support a recipient and will error when other payload parameters are provided._
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SingleLineAddress : ({string.Join(", ", toStringOutput)})";
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
            return obj is SingleLineAddress other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
        }
    }
}