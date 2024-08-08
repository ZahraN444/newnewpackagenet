// <copyright file="EventType.cs" company="APIMatic">
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
    /// EventType.
    /// </summary>
    public class EventType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventType"/> class.
        /// </summary>
        public EventType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventType"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="enabledForTest">enabled_for_test.</param>
        /// <param name="resource">resource.</param>
        /// <param name="mObject">object.</param>
        public EventType(
            EventTypeId id,
            bool enabledForTest,
            Models.ResourceEnum resource,
            string mObject)
        {
            this.Id = id;
            this.EnabledForTest = enabledForTest;
            this.Resource = resource;
            this.MObject = mObject;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public EventTypeId Id { get; set; }

        /// <summary>
        /// Value is `true` if the event type is enabled in both the test and live environments and `false` if it is only enabled in the live environment.
        /// </summary>
        [JsonProperty("enabled_for_test")]
        public bool EnabledForTest { get; set; }

        /// <summary>
        /// Gets or sets Resource.
        /// </summary>
        [JsonProperty("resource")]
        public Models.ResourceEnum Resource { get; set; }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object")]
        public string MObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EventType : ({string.Join(", ", toStringOutput)})";
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
            return obj is EventType other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.EnabledForTest.Equals(other.EnabledForTest) &&
                this.Resource.Equals(other.Resource) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.EnabledForTest = {this.EnabledForTest}");
            toStringOutput.Add($"this.Resource = {this.Resource}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
        }
    }
}