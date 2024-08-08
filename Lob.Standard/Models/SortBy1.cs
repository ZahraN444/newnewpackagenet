// <copyright file="SortBy1.cs" company="APIMatic">
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
    /// SortBy1.
    /// </summary>
    public class SortBy1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy1"/> class.
        /// </summary>
        public SortBy1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy1"/> class.
        /// </summary>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="sendDate">send_date.</param>
        public SortBy1(
            Models.DateCreatedEnum dateCreated,
            Models.DateCreatedEnum sendDate)
        {
            this.DateCreated = dateCreated;
            this.SendDate = sendDate;
        }

        /// <summary>
        /// Gets or sets DateCreated.
        /// </summary>
        [JsonProperty("date_created")]
        public Models.DateCreatedEnum DateCreated { get; set; }

        /// <summary>
        /// Gets or sets SendDate.
        /// </summary>
        [JsonProperty("send_date")]
        public Models.DateCreatedEnum SendDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SortBy1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is SortBy1 other &&                this.DateCreated.Equals(other.DateCreated) &&
                this.SendDate.Equals(other.SendDate);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.SendDate = {this.SendDate}");
        }
    }
}