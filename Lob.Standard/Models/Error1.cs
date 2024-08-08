// <copyright file="Error1.cs" company="APIMatic">
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
    /// Error1.
    /// </summary>
    public class Error1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error1"/> class.
        /// </summary>
        public Error1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error1"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="statusCode">status_code.</param>
        /// <param name="code">code.</param>
        public Error1(
            string message,
            Models.FailureStatusCodeEnum statusCode,
            Models.CodeEnum code)
        {
            this.Message = message;
            this.StatusCode = statusCode;
            this.Code = code;
        }

        /// <summary>
        /// A human-readable message with more details about the error
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets StatusCode.
        /// </summary>
        [JsonProperty("status_code")]
        public Models.FailureStatusCodeEnum StatusCode { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public Models.CodeEnum Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Error1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Error1 other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                this.StatusCode.Equals(other.StatusCode) &&
                this.Code.Equals(other.Code);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.StatusCode = {this.StatusCode}");
            toStringOutput.Add($"this.Code = {this.Code}");
        }
    }
}