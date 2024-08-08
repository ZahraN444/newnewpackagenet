// <copyright file="Wordsatcheckbottom.cs" company="APIMatic">
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
    /// Wordsatcheckbottom.
    /// </summary>
    public class Wordsatcheckbottom
    {
        private string description;
        private object mergeVariables;
        private string memo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "merge_variables", false },
            { "memo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Wordsatcheckbottom"/> class.
        /// </summary>
        public Wordsatcheckbottom()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wordsatcheckbottom"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="useType">use_type.</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="bankAccount">bank_account.</param>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mergeVariables">merge_variables.</param>
        /// <param name="sendDate">send_date.</param>
        /// <param name="mailType">mail_type.</param>
        /// <param name="memo">memo.</param>
        /// <param name="checkNumber">check_number.</param>
        /// <param name="logo">logo.</param>
        /// <param name="checkBottom">check_bottom.</param>
        /// <param name="attachment">attachment.</param>
        /// <param name="billingGroupId">billing_group_id.</param>
        public Wordsatcheckbottom(
            string message,
            object useType,
            WordsatcheckbottomTo to,
            WordsatcheckbottomFrom from,
            string bankAccount,
            double amount,
            string description = null,
            Dictionary<string, string> metadata = null,
            object mergeVariables = null,
            object sendDate = null,
            Models.MailType2Enum? mailType = null,
            string memo = null,
            int? checkNumber = null,
            WordsatcheckbottomLogo logo = null,
            object checkBottom = null,
            WordsatcheckbottomAttachment attachment = null,
            string billingGroupId = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Metadata = metadata;
            if (mergeVariables != null)
            {
                this.MergeVariables = mergeVariables;
            }

            this.SendDate = sendDate;
            this.MailType = mailType;
            if (memo != null)
            {
                this.Memo = memo;
            }

            this.CheckNumber = checkNumber;
            this.Message = message;
            this.UseType = useType;
            this.To = to;
            this.From = from;
            this.BankAccount = bankAccount;
            this.Amount = amount;
            this.Logo = logo;
            this.CheckBottom = checkBottom;
            this.Attachment = attachment;
            this.BillingGroupId = billingGroupId;
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
        /// Gets or sets MailType.
        /// </summary>
        [JsonProperty("mail_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MailType2Enum? MailType { get; set; }

        /// <summary>
        /// Text to include on the memo line of the check.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo
        {
            get
            {
                return this.memo;
            }

            set
            {
                this.shouldSerialize["memo"] = true;
                this.memo = value;
            }
        }

        /// <summary>
        /// An integer that designates the check number.
        /// If `check_number` is not provided, checks created from a new `bank_account` will start at `10000` and increment with each check created with the `bank_account`.
        /// A provided `check_number` overrides the defaults. Subsequent checks created with the same `bank_account` will increment from the provided check number.
        /// </summary>
        [JsonProperty("check_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? CheckNumber { get; set; }

        /// <summary>
        /// Max of 400 characters to be included at the bottom of the check page.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets UseType.
        /// </summary>
        [JsonProperty("use_type")]
        public object UseType { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Must either be an address ID or an inline object with correct address parameters. Checks cannot be sent internationally (`address_country` must be `US`). The total string of the sum of `address_line1` and `address_line2` must be no longer than 50 characters combined. If an object is used, an address will be created, corrected, and standardized for free whenever possible using our US Address Verification engine, and returned back with an ID. Depending on your <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a>, addresses may also be run through [National Change of Address (NCOALink)](#tag/National-Change-of-Address). If an address used does not meet your account’s <a href="https://dashboard.lob.com/#/settings/account" target="_blank">US Mail Strictness Setting</a>, the request will fail. <a href="https://help.lob.com/print-and-mail/all-about-addresses" target="_blank">More about verification of mailing addresses</a>
        /// ]]>
        /// </summary>
        [JsonProperty("to")]
        public WordsatcheckbottomTo To { get; set; }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters. Must either be an address ID or an inline object with correct address parameters. All addresses will be standardized into uppercase without being modified by verification.
        /// </summary>
        [JsonProperty("from")]
        public WordsatcheckbottomFrom From { get; set; }

        /// <summary>
        /// Gets or sets BankAccount.
        /// </summary>
        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// The payment amount to be sent in US dollars. Amounts will be rounded to two decimal places.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Accepts a remote URL or local file upload to an image to print (in grayscale) in the upper-left corner of your check. Image requirements:
        ///   * RGB or CMYK
        ///   * square
        ///   * minimum size: 100px x 100px
        ///   * transparent backgrond
        ///   * `png` or `jpg`
        /// </summary>
        [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
        public WordsatcheckbottomLogo Logo { get; set; }

        /// <summary>
        /// Gets or sets CheckBottom.
        /// </summary>
        [JsonProperty("check_bottom", NullValueHandling = NullValueHandling.Ignore)]
        public object CheckBottom { get; set; }

        /// <summary>
        /// <![CDATA[
        /// A document to include with the check.
        /// Notes:
        /// - HTML merge variables should not include delimiting whitespace.
        /// - All pages of PDF, PNG, and JPGs must be sized at 8.5"x11" at 300 DPI, while supplied HTML will be rendered and trimmed to as many 8.5"x11" pages as necessary.
        /// - If a PDF is provided, it must be 6 pages or fewer.
        /// - The attachment will be printed double-sided in black & white and will be included in the envelope after the check page.
        /// - Please follow these <a href="https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/check_attachment_template.pdf" target="_blank">design guidelines</a>.
        /// See <a href="https://lob.com/pricing/print-mail#compare" target="_blank">pricing</a> for extra costs incurred. Need more help? Consult our [HTML examples](#section/HTML-Examples).
        /// ]]>
        /// </summary>
        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public WordsatcheckbottomAttachment Attachment { get; set; }

        /// <summary>
        /// An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information.
        /// </summary>
        [JsonProperty("billing_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingGroupId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Wordsatcheckbottom : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
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
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
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
            return obj is Wordsatcheckbottom other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.MergeVariables == null && other.MergeVariables == null) || (this.MergeVariables?.Equals(other.MergeVariables) == true)) &&
                ((this.SendDate == null && other.SendDate == null) || (this.SendDate?.Equals(other.SendDate) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.CheckNumber == null && other.CheckNumber == null) || (this.CheckNumber?.Equals(other.CheckNumber) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.UseType == null && other.UseType == null) || (this.UseType?.Equals(other.UseType) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.BankAccount == null && other.BankAccount == null) || (this.BankAccount?.Equals(other.BankAccount) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Logo == null && other.Logo == null) || (this.Logo?.Equals(other.Logo) == true)) &&
                ((this.CheckBottom == null && other.CheckBottom == null) || (this.CheckBottom?.Equals(other.CheckBottom) == true)) &&
                ((this.Attachment == null && other.Attachment == null) || (this.Attachment?.Equals(other.Attachment) == true)) &&
                ((this.BillingGroupId == null && other.BillingGroupId == null) || (this.BillingGroupId?.Equals(other.BillingGroupId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"MergeVariables = {(this.MergeVariables == null ? "null" : this.MergeVariables.ToString())}");
            toStringOutput.Add($"SendDate = {(this.SendDate == null ? "null" : this.SendDate.ToString())}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.CheckNumber = {(this.CheckNumber == null ? "null" : this.CheckNumber.ToString())}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"UseType = {(this.UseType == null ? "null" : this.UseType.ToString())}");
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"this.BankAccount = {(this.BankAccount == null ? "null" : this.BankAccount)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"Logo = {(this.Logo == null ? "null" : this.Logo.ToString())}");
            toStringOutput.Add($"CheckBottom = {(this.CheckBottom == null ? "null" : this.CheckBottom.ToString())}");
            toStringOutput.Add($"Attachment = {(this.Attachment == null ? "null" : this.Attachment.ToString())}");
            toStringOutput.Add($"this.BillingGroupId = {(this.BillingGroupId == null ? "null" : this.BillingGroupId)}");
        }
    }
}