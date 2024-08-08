// <copyright file="Editable.cs" company="APIMatic">
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
    /// Editable.
    /// </summary>
    public class Editable
    {
        private string description;
        private object mergeVariables;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "merge_variables", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Editable"/> class.
        /// </summary>
        public Editable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Editable"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mailType">mail_type.</param>
        /// <param name="mergeVariables">merge_variables.</param>
        /// <param name="sendDate">send_date.</param>
        public Editable(
            string description = null,
            Dictionary<string, string> metadata = null,
            Models.MailTypeEnum? mailType = null,
            object mergeVariables = null,
            object sendDate = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Metadata = metadata;
            this.MailType = mailType;
            if (mergeVariables != null)
            {
                this.MergeVariables = mergeVariables;
            }

            this.SendDate = sendDate;
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
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets MailType.
        /// </summary>
        [JsonProperty("mail_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MailTypeEnum? MailType { get; set; }

        /// <summary>
        /// <![CDATA[
        /// You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: `{{variable_name}}`, pass in `{"variable_name": "Harry"}` to render `Harry`. `merge_variables` must be an object. Any type of value is accepted as long as the object is valid JSON; you can use `strings`, `numbers`, `booleans`, `arrays`, `objects`, or `null`. The max length of the object is 25,000 characters. If you call `JSON.stringify` on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: `!`, `"`, `#`, `%`, `&`, `'`, `(`, `)`, `*`, `+`, `,`, `/`, `;`, `<`, `=`, `>`, `@`, `[`, `\`, `]`, `^`, `` ` ``, `{`, `|`, `}`, `~`. More instructions can be found in <a href="https://help.lob.com/print-and-mail/designing-mail-creatives/dynamic-personalization#using-html-and-merge-variables-10" target="_blank">our guide to using html and merge variables</a>. Depending on your <a href="https://dashboard.lob.com/#/settings/account" target="_blank">Merge Variable strictness</a> setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.
        /// ]]>
        /// </summary>
        [JsonProperty("merge_variables")]
        public object MergeVariables
        {
            get
            {
                return this.mergeVariables;
            }

            set
            {
                this.shouldSerialize["merge_variables"] = true;
                this.mergeVariables = value;
            }
        }

        /// <summary>
        /// Gets or sets SendDate.
        /// </summary>
        [JsonProperty("send_date", NullValueHandling = NullValueHandling.Ignore)]
        public object SendDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Editable : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMergeVariables()
        {
            this.shouldSerialize["merge_variables"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMergeVariables()
        {
            return this.shouldSerialize["merge_variables"];
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
            return obj is Editable other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.MergeVariables == null && other.MergeVariables == null) || (this.MergeVariables?.Equals(other.MergeVariables) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"MergeVariables = {(this.MergeVariables == null ? "null" : this.MergeVariables.ToString())}");
            toStringOutput.Add($"SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
        }
    }
}