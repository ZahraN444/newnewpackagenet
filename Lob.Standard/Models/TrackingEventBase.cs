// <copyright file="TrackingEventBase.cs" company="APIMatic">
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
    /// TrackingEventBase.
    /// </summary>
    public class TrackingEventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventBase"/> class.
        /// </summary>
        public TrackingEventBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventBase"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="mObject">object.</param>
        /// <param name="time">time.</param>
        public TrackingEventBase(
            string id,
            DateTime dateCreated,
            DateTime dateModified,
            Models.Object3Enum mObject,
            DateTime? time = null)
        {
            this.Id = id;
            this.Time = time;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.MObject = mObject;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TrackingEventBase : ({string.Join(", ", toStringOutput)})";
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
            return obj is TrackingEventBase other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                this.MObject.Equals(other.MObject);
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
        }
    }
}