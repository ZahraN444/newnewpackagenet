// <copyright file="UploadCreateExport.cs" company="APIMatic">
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
    /// UploadCreateExport.
    /// </summary>
    public class UploadCreateExport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCreateExport"/> class.
        /// </summary>
        public UploadCreateExport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCreateExport"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="exportId">exportId.</param>
        public UploadCreateExport(
            string message,
            string exportId)
        {
            this.Message = message;
            this.ExportId = exportId;
        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets ExportId.
        /// </summary>
        [JsonProperty("exportId")]
        public string ExportId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadCreateExport : ({string.Join(", ", toStringOutput)})";
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
            return obj is UploadCreateExport other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.ExportId == null && other.ExportId == null) || (this.ExportId?.Equals(other.ExportId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.ExportId = {(this.ExportId == null ? "null" : this.ExportId)}");
        }
    }
}