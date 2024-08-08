// <copyright file="TrackingEventDetails.cs" company="APIMatic">
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
    /// TrackingEventDetails.
    /// </summary>
    public class TrackingEventDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventDetails"/> class.
        /// </summary>
        public TrackingEventDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventDetails"/> class.
        /// </summary>
        /// <param name="mEvent">event.</param>
        /// <param name="description">description.</param>
        /// <param name="actionRequired">action_required.</param>
        /// <param name="notes">notes.</param>
        public TrackingEventDetails(
            Models.EventEnum mEvent,
            string description,
            bool actionRequired,
            string notes = null)
        {
            this.MEvent = mEvent;
            this.Description = description;
            this.Notes = notes;
            this.ActionRequired = actionRequired;
        }

        /// <summary>
        /// Gets or sets MEvent.
        /// </summary>
        [JsonProperty("event")]
        public Models.EventEnum MEvent { get; set; }

        /// <summary>
        /// The description as listed in the description for event.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Event-specific notes from USPS about the tracking event.
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// `true` if action is required by the end recipient, `false` otherwise.
        /// </summary>
        [JsonProperty("action_required")]
        public bool ActionRequired { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TrackingEventDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is TrackingEventDetails other &&                this.MEvent.Equals(other.MEvent) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Notes == null && other.Notes == null) || (this.Notes?.Equals(other.Notes) == true)) &&
                this.ActionRequired.Equals(other.ActionRequired);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MEvent = {this.MEvent}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Notes = {(this.Notes == null ? "null" : this.Notes)}");
            toStringOutput.Add($"this.ActionRequired = {this.ActionRequired}");
        }
    }
}