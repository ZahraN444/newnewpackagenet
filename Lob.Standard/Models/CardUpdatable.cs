// <copyright file="CardUpdatable.cs" company="APIMatic">
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
    /// CardUpdatable.
    /// </summary>
    public class CardUpdatable
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardUpdatable"/> class.
        /// </summary>
        public CardUpdatable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardUpdatable"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="autoReorder">auto_reorder.</param>
        /// <param name="reorderQuantity">reorder_quantity.</param>
        public CardUpdatable(
            string description = null,
            bool? autoReorder = null,
            double? reorderQuantity = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.AutoReorder = autoReorder;
            this.ReorderQuantity = reorderQuantity;
        }

        /// <summary>
        /// Description of the card.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Allows for auto reordering
        /// </summary>
        [JsonProperty("auto_reorder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoReorder { get; set; }

        /// <summary>
        /// The quantity of items to be reordered (only required when auto_reorder is true).
        /// </summary>
        [JsonProperty("reorder_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public double? ReorderQuantity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardUpdatable : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
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
            return obj is CardUpdatable other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AutoReorder == null && other.AutoReorder == null) || (this.AutoReorder?.Equals(other.AutoReorder) == true)) &&
                ((this.ReorderQuantity == null && other.ReorderQuantity == null) || (this.ReorderQuantity?.Equals(other.ReorderQuantity) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AutoReorder = {(this.AutoReorder == null ? "null" : this.AutoReorder.ToString())}");
            toStringOutput.Add($"this.ReorderQuantity = {(this.ReorderQuantity == null ? "null" : this.ReorderQuantity.ToString())}");
        }
    }
}