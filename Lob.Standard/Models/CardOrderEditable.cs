// <copyright file="CardOrderEditable.cs" company="APIMatic">
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
    /// CardOrderEditable.
    /// </summary>
    public class CardOrderEditable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrderEditable"/> class.
        /// </summary>
        public CardOrderEditable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrderEditable"/> class.
        /// </summary>
        /// <param name="quantity">quantity.</param>
        public CardOrderEditable(
            int quantity)
        {
            this.Quantity = quantity;
        }

        /// <summary>
        /// The quantity of cards in the order (minimum 10,000).
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardOrderEditable : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardOrderEditable other &&                this.Quantity.Equals(other.Quantity);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
        }
    }
}