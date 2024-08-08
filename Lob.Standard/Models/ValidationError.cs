// <copyright file="ValidationError.cs" company="APIMatic">
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
    /// ValidationError.
    /// </summary>
    public class ValidationError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError"/> class.
        /// </summary>
        public ValidationError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError"/> class.
        /// </summary>
        /// <param name="loc">loc.</param>
        /// <param name="msg">msg.</param>
        /// <param name="type">type.</param>
        public ValidationError(
            List<ValidationErrorLoc> loc,
            string msg,
            string type)
        {
            this.Loc = loc;
            this.Msg = msg;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Loc.
        /// </summary>
        [JsonProperty("loc")]
        public List<ValidationErrorLoc> Loc { get; set; }

        /// <summary>
        /// Gets or sets Msg.
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ValidationError : ({string.Join(", ", toStringOutput)})";
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
            return obj is ValidationError other &&                ((this.Loc == null && other.Loc == null) || (this.Loc?.Equals(other.Loc) == true)) &&
                ((this.Msg == null && other.Msg == null) || (this.Msg?.Equals(other.Msg) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Loc = {(this.Loc == null ? "null" : this.Loc.ToString())}");
            toStringOutput.Add($"this.Msg = {(this.Msg == null ? "null" : this.Msg)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}