// <copyright file="CardEditable.cs" company="APIMatic">
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
    using Lob.Standard.Models.Containers;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CardEditable.
    /// </summary>
    public class CardEditable
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardEditable"/> class.
        /// </summary>
        public CardEditable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardEditable"/> class.
        /// </summary>
        /// <param name="front">front.</param>
        /// <param name="description">description.</param>
        /// <param name="size">size.</param>
        /// <param name="back">back.</param>
        public CardEditable(
            CardEditableFront front,
            string description = null,
            Models.Size1Enum? size = null,
            CardEditableBack back = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Size = size;
            this.Front = front;
            this.Back = back;
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
        /// Gets or sets Size.
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Size1Enum? Size { get; set; }

        /// <summary>
        /// A PDF template for the front of the card
        /// </summary>
        [JsonProperty("front")]
        public CardEditableFront Front { get; set; }

        /// <summary>
        /// A PDF template for the back of the card
        /// </summary>
        [JsonProperty("back", NullValueHandling = NullValueHandling.Ignore)]
        public CardEditableBack Back { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardEditable : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardEditable other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Size == null && other.Size == null) || (this.Size?.Equals(other.Size) == true)) &&
                ((this.Front == null && other.Front == null) || (this.Front?.Equals(other.Front) == true)) &&
                ((this.Back == null && other.Back == null) || (this.Back?.Equals(other.Back) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Size = {(this.Size == null ? "null" : this.Size.ToString())}");
            toStringOutput.Add($"Front = {(this.Front == null ? "null" : this.Front.ToString())}");
            toStringOutput.Add($"Back = {(this.Back == null ? "null" : this.Back.ToString())}");
        }
    }
}