// <copyright file="LetterEditable.cs" company="APIMatic">
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
    /// LetterEditable.
    /// </summary>
    public class LetterEditable
    {
        private string description;
        private object mergeVariables;
        private List<string> cards;
        private int? perforatedPage;
        private string customEnvelope;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "merge_variables", false },
            { "cards", false },
            { "perforated_page", false },
            { "custom_envelope", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LetterEditable"/> class.
        /// </summary>
        public LetterEditable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LetterEditable"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="file">file.</param>
        /// <param name="color">color.</param>
        /// <param name="useType">use_type.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mailType">mail_type.</param>
        /// <param name="mergeVariables">merge_variables.</param>
        /// <param name="sendDate">send_date.</param>
        /// <param name="extraService">extra_service.</param>
        /// <param name="cards">cards.</param>
        /// <param name="doubleSided">double_sided.</param>
        /// <param name="addressPlacement">address_placement.</param>
        /// <param name="returnEnvelope">return_envelope.</param>
        /// <param name="perforatedPage">perforated_page.</param>
        /// <param name="customEnvelope">custom_envelope.</param>
        /// <param name="billingGroupId">billing_group_id.</param>
        /// <param name="qrCode">qr_code.</param>
        /// <param name="fsc">fsc.</param>
        public LetterEditable(
            LetterEditableTo to,
            LetterEditableFrom from,
            object file,
            bool color,
            object useType,
            string description = null,
            Dictionary<string, string> metadata = null,
            Models.MailTypeEnum? mailType = null,
            object mergeVariables = null,
            object sendDate = null,
            object extraService = null,
            List<string> cards = null,
            bool? doubleSided = true,
            Models.AddressPlacementEnum? addressPlacement = null,
            object returnEnvelope = null,
            int? perforatedPage = null,
            string customEnvelope = null,
            string billingGroupId = null,
            Models.QrCode4 qrCode = null,
            bool? fsc = false)
        {
            this.To = to;
            this.From = from;
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
            this.File = file;
            this.ExtraService = extraService;
            if (cards != null)
            {
                this.Cards = cards;
            }

            this.Color = color;
            this.DoubleSided = doubleSided;
            this.AddressPlacement = addressPlacement;
            this.ReturnEnvelope = returnEnvelope;
            if (perforatedPage != null)
            {
                this.PerforatedPage = perforatedPage;
            }

            if (customEnvelope != null)
            {
                this.CustomEnvelope = customEnvelope;
            }

            this.BillingGroupId = billingGroupId;
            this.QrCode = qrCode;
            this.UseType = useType;
            this.Fsc = fsc;
        }

        /// <summary>
        /// <![CDATA[
        /// Must either be an address ID or an inline object with correct address parameters. If an object is used, an address will be created, corrected, and standardized for free whenever possible using our US Address Verification engine (if it is a US address), and returned back with an ID. Depending on your <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a>, US addresses may also be run through <a href="#tag/National-Change-of-Address">National Change of Address Linkage(NCOALink)</a>. Non-US addresses will be standardized into uppercase only. If a US address used does not meet your account’s <a href="https://dashboard.lob.com/#/settings/account" target="_blank">US Mail strictness setting</a>, the request will fail. <a href="https://help.lob.com/print-and-mail/all-about-addresses" target="_blank">Lob Guide: Verification of Mailing Addresses</a>
        /// ]]>
        /// </summary>
        [JsonProperty("to")]
        public LetterEditableTo To { get; set; }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters. Must be a US address unless using a `custom_envelope`. All addresses will be standardized into uppercase without being modified by verification.
        /// </summary>
        [JsonProperty("from")]
        public LetterEditableFrom From { get; set; }

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

        /// <summary>
        /// Gets or sets File.
        /// </summary>
        [JsonProperty("file")]
        public object File { get; set; }

        /// <summary>
        /// Gets or sets ExtraService.
        /// </summary>
        [JsonProperty("extra_service", NullValueHandling = NullValueHandling.Ignore)]
        public object ExtraService { get; set; }

        /// <summary>
        /// A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information.
        /// </summary>
        [JsonProperty("cards")]
        public List<string> Cards
        {
            get
            {
                return this.cards;
            }

            set
            {
                this.shouldSerialize["cards"] = true;
                this.cards = value;
            }
        }

        /// <summary>
        /// Gets or sets Color.
        /// </summary>
        [JsonProperty("color")]
        public bool Color { get; set; }

        /// <summary>
        /// Set this attribute to `true` for double sided printing, or `false` for for single sided printing. Defaults to `true`.
        /// </summary>
        [JsonProperty("double_sided", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoubleSided { get; set; }

        /// <summary>
        /// Gets or sets AddressPlacement.
        /// </summary>
        [JsonProperty("address_placement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressPlacementEnum? AddressPlacement { get; set; }

        /// <summary>
        /// Gets or sets ReturnEnvelope.
        /// </summary>
        [JsonProperty("return_envelope", NullValueHandling = NullValueHandling.Ignore)]
        public object ReturnEnvelope { get; set; }

        /// <summary>
        /// Required if `return_envelope` is `true`. The number of the page that should be perforated for use with the return envelope. Must be greater than or equal to `1`. The blank page added by `address_placement=insert_blank_page` will be ignored when considering the perforated page number. To see how perforation will impact your letter design, view our <a href="https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/letter_perf_template.pdf" target="_blank">perforation guide</a>.
        /// </summary>
        [JsonProperty("perforated_page")]
        public int? PerforatedPage
        {
            get
            {
                return this.perforatedPage;
            }

            set
            {
                this.shouldSerialize["perforated_page"] = true;
                this.perforatedPage = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Accepts an envelope ID for any customized envelope with available inventory. If no inventory is available for the specified ID, the letter will not be sent, and an error will be returned. If the letter has more than 6 sheets, it will be sent in a blank flat envelope. Custom envelopes may be created and ordered from the dashboard. This feature is exclusive to certain customers. Upgrade to the appropriate <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a> to gain access.
        /// ]]>
        /// </summary>
        [JsonProperty("custom_envelope")]
        public string CustomEnvelope
        {
            get
            {
                return this.customEnvelope;
            }

            set
            {
                this.shouldSerialize["custom_envelope"] = true;
                this.customEnvelope = value;
            }
        }

        /// <summary>
        /// An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information.
        /// </summary>
        [JsonProperty("billing_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets QrCode.
        /// </summary>
        [JsonProperty("qr_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QrCode4 QrCode { get; set; }

        /// <summary>
        /// Gets or sets UseType.
        /// </summary>
        [JsonProperty("use_type")]
        public object UseType { get; set; }

        /// <summary>
        /// This is in beta. Contact support@lob.com or your account contact to learn more. Not available for `A4` letter size.
        /// </summary>
        [JsonProperty("fsc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fsc { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LetterEditable : ({string.Join(", ", toStringOutput)})";
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCards()
        {
            this.shouldSerialize["cards"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPerforatedPage()
        {
            this.shouldSerialize["perforated_page"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomEnvelope()
        {
            this.shouldSerialize["custom_envelope"] = false;
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCards()
        {
            return this.shouldSerialize["cards"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePerforatedPage()
        {
            return this.shouldSerialize["perforated_page"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomEnvelope()
        {
            return this.shouldSerialize["custom_envelope"];
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
            return obj is LetterEditable other &&                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.MergeVariables == null && other.MergeVariables == null) || (this.MergeVariables?.Equals(other.MergeVariables) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true)) &&
                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true)) &&
                ((this.ExtraService == null && other.ExtraService == null) || (this.ExtraService?.Equals(other.ExtraService) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                this.Color.Equals(other.Color) &&
                ((this.DoubleSided == null && other.DoubleSided == null) || (this.DoubleSided?.Equals(other.DoubleSided) == true)) &&
                ((this.AddressPlacement == null && other.AddressPlacement == null) || (this.AddressPlacement?.Equals(other.AddressPlacement) == true)) &&
                ((this.ReturnEnvelope == null && other.ReturnEnvelope == null) || (this.ReturnEnvelope?.Equals(other.ReturnEnvelope) == true)) &&
                ((this.PerforatedPage == null && other.PerforatedPage == null) || (this.PerforatedPage?.Equals(other.PerforatedPage) == true)) &&
                ((this.CustomEnvelope == null && other.CustomEnvelope == null) || (this.CustomEnvelope?.Equals(other.CustomEnvelope) == true)) &&
                ((this.BillingGroupId == null && other.BillingGroupId == null) || (this.BillingGroupId?.Equals(other.BillingGroupId) == true)) &&
                ((this.QrCode == null && other.QrCode == null) || (this.QrCode?.Equals(other.QrCode) == true)) &&
                ((this.UseType == null && other.UseType == null) || (this.UseType?.Equals(other.UseType) == true)) &&
                ((this.Fsc == null && other.Fsc == null) || (this.Fsc?.Equals(other.Fsc) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"MergeVariables = {(this.MergeVariables == null ? "null" : this.MergeVariables.ToString())}");
            toStringOutput.Add($"SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
            toStringOutput.Add($"File = {(this.File == null ? "null" : this.File.ToString())}");
            toStringOutput.Add($"ExtraService = {(this.ExtraService == null ? "null" : this.ExtraService.ToString())}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.Color = {this.Color}");
            toStringOutput.Add($"this.DoubleSided = {(this.DoubleSided == null ? "null" : this.DoubleSided.ToString())}");
            toStringOutput.Add($"this.AddressPlacement = {(this.AddressPlacement == null ? "null" : this.AddressPlacement.ToString())}");
            toStringOutput.Add($"ReturnEnvelope = {(this.ReturnEnvelope == null ? "null" : this.ReturnEnvelope.ToString())}");
            toStringOutput.Add($"this.PerforatedPage = {(this.PerforatedPage == null ? "null" : this.PerforatedPage.ToString())}");
            toStringOutput.Add($"this.CustomEnvelope = {(this.CustomEnvelope == null ? "null" : this.CustomEnvelope)}");
            toStringOutput.Add($"this.BillingGroupId = {(this.BillingGroupId == null ? "null" : this.BillingGroupId)}");
            toStringOutput.Add($"this.QrCode = {(this.QrCode == null ? "null" : this.QrCode.ToString())}");
            toStringOutput.Add($"UseType = {(this.UseType == null ? "null" : this.UseType.ToString())}");
            toStringOutput.Add($"this.Fsc = {(this.Fsc == null ? "null" : this.Fsc.ToString())}");
        }
    }
}