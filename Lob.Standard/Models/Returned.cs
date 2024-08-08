// <copyright file="Returned.cs" company="APIMatic">
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
    /// Returned.
    /// </summary>
    public class Returned
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Returned"/> class.
        /// </summary>
        public Returned()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Returned"/> class.
        /// </summary>
        /// <param name="mailType">mail_type.</param>
        /// <param name="size">size.</param>
        /// <param name="frontOriginalUrl">front_original_url.</param>
        /// <param name="backOriginalUrl">back_original_url.</param>
        public Returned(
            Models.MailTypeEnum? mailType = null,
            Models.PostcardSizeEnum? size = null,
            string frontOriginalUrl = null,
            string backOriginalUrl = null)
        {
            this.MailType = mailType;
            this.Size = size;
            this.FrontOriginalUrl = frontOriginalUrl;
            this.BackOriginalUrl = backOriginalUrl;
        }

        /// <summary>
        /// Gets or sets MailType.
        /// </summary>
        [JsonProperty("mail_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MailTypeEnum? MailType { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PostcardSizeEnum? Size { get; set; }

        /// <summary>
        /// The original URL of the `front` template.
        /// </summary>
        [JsonProperty("front_original_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontOriginalUrl { get; set; }

        /// <summary>
        /// The original URL of the `back` template.
        /// </summary>
        [JsonProperty("back_original_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BackOriginalUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Returned : ({string.Join(", ", toStringOutput)})";
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
            return obj is Returned other &&                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.FrontOriginalUrl == null && other.FrontOriginalUrl == null) || (this.FrontOriginalUrl?.Equals(other.FrontOriginalUrl) == true)) &&
                ((this.BackOriginalUrl == null && other.BackOriginalUrl == null) || (this.BackOriginalUrl?.Equals(other.BackOriginalUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size.ToString())}");
            toStringOutput.Add($"this.FrontOriginalUrl = {(this.FrontOriginalUrl == null ? "null" : this.FrontOriginalUrl)}");
            toStringOutput.Add($"this.BackOriginalUrl = {(this.BackOriginalUrl == null ? "null" : this.BackOriginalUrl)}");
        }
    }
}