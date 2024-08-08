// <copyright file="QrCode.cs" company="APIMatic">
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
    /// QrCode.
    /// </summary>
    public class QrCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QrCode"/> class.
        /// </summary>
        public QrCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QrCode"/> class.
        /// </summary>
        /// <param name="position">position.</param>
        /// <param name="redirectUrl">redirect_url.</param>
        /// <param name="width">width.</param>
        /// <param name="top">top.</param>
        /// <param name="right">right.</param>
        /// <param name="left">left.</param>
        /// <param name="bottom">bottom.</param>
        /// <param name="pages">pages.</param>
        public QrCode(
            string position,
            string redirectUrl,
            string width,
            string top = null,
            string right = null,
            string left = null,
            string bottom = null,
            string pages = null)
        {
            this.Position = position;
            this.Top = top;
            this.Right = right;
            this.Left = left;
            this.Bottom = bottom;
            this.RedirectUrl = redirectUrl;
            this.Width = width;
            this.Pages = pages;
        }

        /// <summary>
        /// Sets how a QR code is being positioned in the document. Together with this, you should provide one of 'top' or 'bottom', and one of 'left' or 'right'.
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// Vertical distance (in inches) to place QR code from the top. Only allowed if "bottom" isn't provided.
        /// </summary>
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public string Top { get; set; }

        /// <summary>
        /// Horizonal distance (in inches) to place QR code from the right. Only allowed if "left" isn't provided.
        /// </summary>
        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public string Right { get; set; }

        /// <summary>
        /// Horizonal distance (in inches) to place QR code from the left. Only allowed if "right" isn't provided.
        /// </summary>
        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public string Left { get; set; }

        /// <summary>
        /// Vertical distance (in inches) to place QR code from the bottom. Only allowed if "top" isn't provided.
        /// </summary>
        [JsonProperty("bottom", NullValueHandling = NullValueHandling.Ignore)]
        public string Bottom { get; set; }

        /// <summary>
        /// The url to redirect the user when a QR code is scanned. The url must start with `https://`
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The size (in inches) of the QR code with a minimum of 1 inch. All QR codes are generated as a square.
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; }

        /// <summary>
        /// Specify the pages where the QR code should be stamped in a comma separated format. Your QR code can be printed in the same position on multiple pages. For postcards, the values should either be "front", "back" (for either front or back) or "front,back" (for the QR code to be printed on both sides). For self-mailers, the values should either be "inside", "outside" (for either inside or outside) or "inside,outside" (for the QR code to be printed on both sides). For letters, the values can be specific page numbers ("1", "3"), page number ranges such as "1-3", or a comma separated combination of both ("1,3,5-7").
        /// </summary>
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public string Pages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QrCode : ({string.Join(", ", toStringOutput)})";
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
            return obj is QrCode other &&                ((this.Position == null && other.Position == null) || (this.Position?.Equals(other.Position) == true)) &&
                ((this.Top == null && other.Top == null) || (this.Top?.Equals(other.Top) == true)) &&
                ((this.Right == null && other.Right == null) || (this.Right?.Equals(other.Right) == true)) &&
                ((this.Left == null && other.Left == null) || (this.Left?.Equals(other.Left) == true)) &&
                ((this.Bottom == null && other.Bottom == null) || (this.Bottom?.Equals(other.Bottom) == true)) &&
                ((this.RedirectUrl == null && other.RedirectUrl == null) || (this.RedirectUrl?.Equals(other.RedirectUrl) == true)) &&
                ((this.Width == null && other.Width == null) || (this.Width?.Equals(other.Width) == true)) &&
                ((this.Pages == null && other.Pages == null) || (this.Pages?.Equals(other.Pages) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Position = {(this.Position == null ? "null" : this.Position)}");
            toStringOutput.Add($"this.Top = {(this.Top == null ? "null" : this.Top)}");
            toStringOutput.Add($"this.Right = {(this.Right == null ? "null" : this.Right)}");
            toStringOutput.Add($"this.Left = {(this.Left == null ? "null" : this.Left)}");
            toStringOutput.Add($"this.Bottom = {(this.Bottom == null ? "null" : this.Bottom)}");
            toStringOutput.Add($"this.RedirectUrl = {(this.RedirectUrl == null ? "null" : this.RedirectUrl)}");
            toStringOutput.Add($"this.Width = {(this.Width == null ? "null" : this.Width)}");
            toStringOutput.Add($"this.Pages = {(this.Pages == null ? "null" : this.Pages)}");
        }
    }
}