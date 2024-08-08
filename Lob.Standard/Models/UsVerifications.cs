// <copyright file="UsVerifications.cs" company="APIMatic">
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
    using Lob.Standard.Models.Containers;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UsVerifications.
    /// </summary>
    public class UsVerifications
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsVerifications"/> class.
        /// </summary>
        public UsVerifications()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsVerifications"/> class.
        /// </summary>
        /// <param name="addresses">addresses.</param>
        /// <param name="errors">errors.</param>
        public UsVerifications(
            List<UsVerificationsAddresses> addresses,
            bool errors)
        {
            this.Addresses = addresses;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or sets Addresses.
        /// </summary>
        [JsonProperty("addresses")]
        public List<UsVerificationsAddresses> Addresses { get; set; }

        /// <summary>
        /// Indicates whether any errors occurred during the verification process.
        /// </summary>
        [JsonProperty("errors")]
        public bool Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsVerifications : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsVerifications other &&                ((this.Addresses == null && other.Addresses == null) || (this.Addresses?.Equals(other.Addresses) == true)) &&
                this.Errors.Equals(other.Errors);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Addresses = {(this.Addresses == null ? "null" : this.Addresses.ToString())}");
            toStringOutput.Add($"this.Errors = {this.Errors}");
        }
    }
}