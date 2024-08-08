// <copyright file="TemplateVersion.cs" company="APIMatic">
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
    /// TemplateVersion.
    /// </summary>
    public class TemplateVersion
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVersion"/> class.
        /// </summary>
        public TemplateVersion()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVersion"/> class.
        /// </summary>
        /// <param name="html">html.</param>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="engine">engine.</param>
        /// <param name="requiredVars">required_vars.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="suggestJsonEditor">suggest_json_editor.</param>
        /// <param name="mergeVariables">merge_variables.</param>
        public TemplateVersion(
            string html,
            DateTime dateCreated,
            DateTime dateModified,
            string mObject,
            string id,
            string description = null,
            object engine = null,
            List<string> requiredVars = null,
            bool? deleted = null,
            bool? suggestJsonEditor = null,
            object mergeVariables = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Html = html;
            this.Engine = engine;
            this.RequiredVars = requiredVars;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.MObject = mObject;
            this.Id = id;
            this.SuggestJsonEditor = suggestJsonEditor;
            this.MergeVariables = mergeVariables;
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
        /// Gets or sets Engine.
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public object Engine { get; set; }

        /// <summary>
        /// An array of required variables to be used in a template. Only available for `handlebars` templates.
        /// </summary>
        [JsonProperty("required_vars", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RequiredVars { get; set; }

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
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Value is resource type.
        /// </summary>
        [JsonProperty("object")]
        public string MObject { get; set; }

        /// <summary>
        /// Unique identifier prefixed with `vrsn_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Used by frontend, true if the template uses advanced features.
        /// </summary>
        [JsonProperty("suggest_json_editor", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SuggestJsonEditor { get; set; }

        /// <summary>
        /// Object representing the keys of every merge variable present in the template. It has one key named 'keys', and its value is an array of strings.
        /// </summary>
        [JsonProperty("merge_variables", NullValueHandling = NullValueHandling.Ignore)]
        public object MergeVariables { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TemplateVersion : ({string.Join(", ", toStringOutput)})";
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
            return obj is TemplateVersion other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Html == null && other.Html == null) || (this.Html?.Equals(other.Html) == true)) &&
                ((this.Engine == null && other.Engine == null) || (this.Engine?.Equals(other.Engine) == true)) &&
                ((this.RequiredVars == null && other.RequiredVars == null) || (this.RequiredVars?.Equals(other.RequiredVars) == true)) &&
                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SuggestJsonEditor == null && other.SuggestJsonEditor == null) || (this.SuggestJsonEditor?.Equals(other.SuggestJsonEditor) == true)) &&
                ((this.MergeVariables == null && other.MergeVariables == null) || (this.MergeVariables?.Equals(other.MergeVariables) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Html = {(this.Html == null ? "null" : this.Html)}");
            toStringOutput.Add($"Engine = {(this.Engine == null ? "null" : this.Engine.ToString())}");
            toStringOutput.Add($"this.RequiredVars = {(this.RequiredVars == null ? "null" : $"[{string.Join(", ", this.RequiredVars)} ]")}");
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.SuggestJsonEditor = {(this.SuggestJsonEditor == null ? "null" : this.SuggestJsonEditor.ToString())}");
            toStringOutput.Add($"MergeVariables = {(this.MergeVariables == null ? "null" : this.MergeVariables.ToString())}");
        }
    }
}