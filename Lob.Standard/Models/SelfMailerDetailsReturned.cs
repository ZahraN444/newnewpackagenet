// <copyright file="SelfMailerDetailsReturned.cs" company="APIMatic">
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
    /// SelfMailerDetailsReturned.
    /// </summary>
    public class SelfMailerDetailsReturned
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelfMailerDetailsReturned"/> class.
        /// </summary>
        public SelfMailerDetailsReturned()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfMailerDetailsReturned"/> class.
        /// </summary>
        /// <param name="mailType">mail_type.</param>
        /// <param name="size">size.</param>
        /// <param name="insideOriginalUrl">inside_original_url.</param>
        /// <param name="outsideOriginalUrl">outside_original_url.</param>
        public SelfMailerDetailsReturned(
            Models.MailTypeEnum? mailType = null,
            Models.SelfMailerSizeEnum? size = null,
            string insideOriginalUrl = null,
            string outsideOriginalUrl = null)
        {
            this.MailType = mailType;
            this.Size = size;
            this.InsideOriginalUrl = insideOriginalUrl;
            this.OutsideOriginalUrl = outsideOriginalUrl;
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
        public Models.SelfMailerSizeEnum? Size { get; set; }

        /// <summary>
        /// The original URL of the `inside` template.
        /// </summary>
        [JsonProperty("inside_original_url", NullValueHandling = NullValueHandling.Ignore)]
        public string InsideOriginalUrl { get; set; }

        /// <summary>
        /// The original URL of the `outside` template.
        /// </summary>
        [JsonProperty("outside_original_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OutsideOriginalUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SelfMailerDetailsReturned : ({string.Join(", ", toStringOutput)})";
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
            return obj is SelfMailerDetailsReturned other &&                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.InsideOriginalUrl == null && other.InsideOriginalUrl == null) || (this.InsideOriginalUrl?.Equals(other.InsideOriginalUrl) == true)) &&
                ((this.OutsideOriginalUrl == null && other.OutsideOriginalUrl == null) || (this.OutsideOriginalUrl?.Equals(other.OutsideOriginalUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size.ToString())}");
            toStringOutput.Add($"this.InsideOriginalUrl = {(this.InsideOriginalUrl == null ? "null" : this.InsideOriginalUrl)}");
            toStringOutput.Add($"this.OutsideOriginalUrl = {(this.OutsideOriginalUrl == null ? "null" : this.OutsideOriginalUrl)}");
        }
    }
}