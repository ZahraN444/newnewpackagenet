// <copyright file="Metadata1.cs" company="APIMatic">
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
    /// Metadata1.
    /// </summary>
    public class Metadata1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata1"/> class.
        /// </summary>
        public Metadata1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata1"/> class.
        /// </summary>
        /// <param name="columns">columns.</param>
        public Metadata1(
            List<string> columns)
        {
            this.Columns = columns;
        }

        /// <summary>
        /// The list of column names from the csv file which you want associated with each of your mailpieces
        /// </summary>
        [JsonProperty("columns")]
        public List<string> Columns { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Metadata1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Metadata1 other &&                ((this.Columns == null && other.Columns == null) || (this.Columns?.Equals(other.Columns) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Columns = {(this.Columns == null ? "null" : $"[{string.Join(", ", this.Columns)} ]")}");
        }
    }
}