// <copyright file="TemplateVersionUpdatable.cs" company="APIMatic">
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
    /// TemplateVersionUpdatable.
    /// </summary>
    public class TemplateVersionUpdatable
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVersionUpdatable"/> class.
        /// </summary>
        public TemplateVersionUpdatable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVersionUpdatable"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="engine">engine.</param>
        /// <param name="requiredVars">required_vars.</param>
        public TemplateVersionUpdatable(
            string description = null,
            object engine = null,
            List<string> requiredVars = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Engine = engine;
            this.RequiredVars = requiredVars;
        }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters.
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
        /// Gets or sets Engine.
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public object Engine { get; set; }

        /// <summary>
        /// An array of required variables to be used in a template. Only available for `handlebars` templates.
        /// </summary>
        [JsonProperty("required_vars", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RequiredVars { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TemplateVersionUpdatable : ({string.Join(", ", toStringOutput)})";
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
            return obj is TemplateVersionUpdatable other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Engine == null && other.Engine == null) || (this.Engine?.Equals(other.Engine) == true)) &&
                ((this.RequiredVars == null && other.RequiredVars == null) || (this.RequiredVars?.Equals(other.RequiredVars) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Engine = {(this.Engine == null ? "null" : this.Engine.ToString())}");
            toStringOutput.Add($"this.RequiredVars = {(this.RequiredVars == null ? "null" : $"[{string.Join(", ", this.RequiredVars)} ]")}");
        }
    }
}