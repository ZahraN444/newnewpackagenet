// <copyright file="Writable.cs" company="APIMatic">
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
    /// Writable.
    /// </summary>
    public class Writable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Writable"/> class.
        /// </summary>
        public Writable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Writable"/> class.
        /// </summary>
        /// <param name="mailType">mail_type.</param>
        /// <param name="size">size.</param>
        /// <param name="qrCode">qr_code.</param>
        public Writable(
            Models.MailTypeEnum? mailType = null,
            Models.PostcardSizeEnum? size = null,
            Models.QrCode1 qrCode = null)
        {
            this.MailType = mailType;
            this.Size = size;
            this.QrCode = qrCode;
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
        /// Gets or sets QrCode.
        /// </summary>
        [JsonProperty("qr_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QrCode1 QrCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Writable : ({string.Join(", ", toStringOutput)})";
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
            return obj is Writable other &&                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.QrCode == null && other.QrCode == null) || (this.QrCode?.Equals(other.QrCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size.ToString())}");
            toStringOutput.Add($"this.QrCode = {(this.QrCode == null ? "null" : this.QrCode.ToString())}");
        }
    }
}