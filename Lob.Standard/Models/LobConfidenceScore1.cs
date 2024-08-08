// <copyright file="LobConfidenceScore1.cs" company="APIMatic">
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
    /// LobConfidenceScore1.
    /// </summary>
    public class LobConfidenceScore1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LobConfidenceScore1"/> class.
        /// </summary>
        public LobConfidenceScore1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LobConfidenceScore1"/> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="score">score.</param>
        public LobConfidenceScore1(
            Models.LevelEnum level,
            double? score = null)
        {
            this.Score = score;
            this.Level = level;
        }

        /// <summary>
        /// A numerical score between 0 and 100 that represents the percentage of mailpieces Lob has sent to this addresses that have been delivered successfully over the past 2 years. Will be `null` if no tracking data exists for this address.
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Include)]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or sets Level.
        /// </summary>
        [JsonProperty("level")]
        public Models.LevelEnum Level { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LobConfidenceScore1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is LobConfidenceScore1 other &&                ((this.Score == null && other.Score == null) || (this.Score?.Equals(other.Score) == true)) &&
                this.Level.Equals(other.Level);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Score = {(this.Score == null ? "null" : this.Score.ToString())}");
            toStringOutput.Add($"this.Level = {this.Level}");
        }
    }
}