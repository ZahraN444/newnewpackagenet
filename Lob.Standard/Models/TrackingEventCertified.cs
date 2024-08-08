// <copyright file="TrackingEventCertified.cs" company="APIMatic">
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
    /// TrackingEventCertified.
    /// </summary>
    public class TrackingEventCertified
    {
        private string location;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "location", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventCertified"/> class.
        /// </summary>
        public TrackingEventCertified()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventCertified"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="mObject">object.</param>
        /// <param name="type">type.</param>
        /// <param name="name">name.</param>
        /// <param name="time">time.</param>
        /// <param name="details">details.</param>
        /// <param name="location">location.</param>
        public TrackingEventCertified(
            string id,
            DateTime dateCreated,
            DateTime dateModified,
            Models.Object3Enum mObject,
            string type,
            Models.Name1Enum name,
            DateTime? time = null,
            Models.TrackingEventDetails details = null,
            string location = null)
        {
            this.Id = id;
            this.Time = time;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.MObject = mObject;
            this.Type = type;
            this.Name = name;
            this.Details = details;
            if (location != null)
            {
                this.Location = location;
            }

        }

        /// <summary>
        /// Unique identifier prefixed with `evnt_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date USPS registered the event.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was last modified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object")]
        public Models.Object3Enum MObject { get; set; }

        /// <summary>
        /// a Certified letter tracking event
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public Models.Name1Enum Name { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TrackingEventDetails Details { get; set; }

        /// <summary>
        /// The zip code in which the event occurred if it exists, otherwise will be the name of a Regional Distribution Center if it exists, otherwise will be null.
        /// </summary>
        [JsonProperty("location")]
        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.shouldSerialize["location"] = true;
                this.location = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TrackingEventCertified : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocation()
        {
            this.shouldSerialize["location"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocation()
        {
            return this.shouldSerialize["location"];
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
            return obj is TrackingEventCertified other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                this.MObject.Equals(other.MObject) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Name.Equals(other.Name) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time.ToString())}");
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.MObject = {this.MObject}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Name = {this.Name}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details.ToString())}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location)}");
        }
    }
}