// <copyright file="TemplateWritable.cs" company="APIMatic">
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
    /// TemplateWritable.
    /// </summary>
    public class TemplateWritable
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateWritable"/> class.
        /// </summary>
        public TemplateWritable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateWritable"/> class.
        /// </summary>
        /// <param name="html">html.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="engine">engine.</param>
        /// <param name="requiredVars">required_vars.</param>
        public TemplateWritable(
            string html,
            string description = null,
            Dictionary<string, string> metadata = null,
            object engine = null,
            List<string> requiredVars = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Html = html;
            this.Metadata = metadata;
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
        /// An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details:
        /// - [Postcards](#operation/postcard_create) - `front` and `back`
        /// - [Self Mailers](#operation/self_mailer_create) - `inside` and `outside`
        /// - [Letters](#operation/letter_create) - `file`
        /// - [Checks](#operation/check_create) - `check_bottom` and `attachment`
        /// - [Cards](#operation/card_create) - `front` and `back`
        /// If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`.
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

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

            return $"TemplateWritable : ({string.Join(", ", toStringOutput)})";
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
            return obj is TemplateWritable other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Html == null && other.Html == null) || (this.Html?.Equals(other.Html) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
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
            toStringOutput.Add($"this.Html = {(this.Html == null ? "null" : this.Html)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Engine = {(this.Engine == null ? "null" : this.Engine.ToString())}");
            toStringOutput.Add($"this.RequiredVars = {(this.RequiredVars == null ? "null" : $"[{string.Join(", ", this.RequiredVars)} ]")}");
        }
    }
}