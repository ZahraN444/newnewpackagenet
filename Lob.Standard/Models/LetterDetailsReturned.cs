// <copyright file="LetterDetailsReturned.cs" company="APIMatic">
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
    /// LetterDetailsReturned.
    /// </summary>
    public class LetterDetailsReturned
    {
        private List<string> buckslips;
        private List<string> cards;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "buckslips", false },
            { "cards", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LetterDetailsReturned"/> class.
        /// </summary>
        public LetterDetailsReturned()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LetterDetailsReturned"/> class.
        /// </summary>
        /// <param name="addressPlacement">address_placement.</param>
        /// <param name="buckslips">buckslips.</param>
        /// <param name="cards">cards.</param>
        /// <param name="customEnvelope">custom_envelope.</param>
        /// <param name="color">color.</param>
        /// <param name="doubleSided">double_sided.</param>
        /// <param name="extraService">extra_service.</param>
        /// <param name="fileOriginalUrl">file_original_url.</param>
        /// <param name="mailType">mail_type.</param>
        public LetterDetailsReturned(
            Models.AddressPlacementEnum? addressPlacement = null,
            List<string> buckslips = null,
            List<string> cards = null,
            object customEnvelope = null,
            bool? color = null,
            bool? doubleSided = true,
            object extraService = null,
            string fileOriginalUrl = null,
            Models.MailTypeEnum? mailType = null)
        {
            this.AddressPlacement = addressPlacement;
            if (buckslips != null)
            {
                this.Buckslips = buckslips;
            }

            if (cards != null)
            {
                this.Cards = cards;
            }

            this.CustomEnvelope = customEnvelope;
            this.Color = color;
            this.DoubleSided = doubleSided;
            this.ExtraService = extraService;
            this.FileOriginalUrl = fileOriginalUrl;
            this.MailType = mailType;
        }

        /// <summary>
        /// Gets or sets AddressPlacement.
        /// </summary>
        [JsonProperty("address_placement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressPlacementEnum? AddressPlacement { get; set; }

        /// <summary>
        /// A single-element array containing an existing buckslip id in a string format. See [buckslips](#tag/Buckslips) for more information.
        /// </summary>
        [JsonProperty("buckslips")]
        public List<string> Buckslips
        {
            get
            {
                return this.buckslips;
            }

            set
            {
                this.shouldSerialize["buckslips"] = true;
                this.buckslips = value;
            }
        }

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
        /// Gets or sets CustomEnvelope.
        /// </summary>
        [JsonProperty("custom_envelope", NullValueHandling = NullValueHandling.Ignore)]
        public object CustomEnvelope { get; set; }

        /// <summary>
        /// Set this key to `true` if you would like to print in color. Set to `false` if you would like to print in black and white.
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Color { get; set; }

        /// <summary>
        /// Set this attribute to `true` for double sided printing, or `false` for for single sided printing. Defaults to `true`.
        /// </summary>
        [JsonProperty("double_sided", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoubleSided { get; set; }

        /// <summary>
        /// Gets or sets ExtraService.
        /// </summary>
        [JsonProperty("extra_service", NullValueHandling = NullValueHandling.Ignore)]
        public object ExtraService { get; set; }

        /// <summary>
        /// The original URL of the `file` template.
        /// </summary>
        [JsonProperty("file_original_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FileOriginalUrl { get; set; }

        /// <summary>
        /// Gets or sets MailType.
        /// </summary>
        [JsonProperty("mail_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MailTypeEnum? MailType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LetterDetailsReturned : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBuckslips()
        {
            this.shouldSerialize["buckslips"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCards()
        {
            this.shouldSerialize["cards"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBuckslips()
        {
            return this.shouldSerialize["buckslips"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCards()
        {
            return this.shouldSerialize["cards"];
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
            return obj is LetterDetailsReturned other &&                ((this.AddressPlacement == null && other.AddressPlacement == null) || (this.AddressPlacement?.Equals(other.AddressPlacement) == true)) &&
                ((this.Buckslips == null && other.Buckslips == null) || (this.Buckslips?.Equals(other.Buckslips) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                ((this.CustomEnvelope == null && other.CustomEnvelope == null) || (this.CustomEnvelope?.Equals(other.CustomEnvelope) == true)) &&
                ((this.Color == null && other.Color == null) || (this.Color?.Equals(other.Color) == true)) &&
                ((this.DoubleSided == null && other.DoubleSided == null) || (this.DoubleSided?.Equals(other.DoubleSided) == true)) &&
                ((this.ExtraService == null && other.ExtraService == null) || (this.ExtraService?.Equals(other.ExtraService) == true)) &&
                ((this.FileOriginalUrl == null && other.FileOriginalUrl == null) || (this.FileOriginalUrl?.Equals(other.FileOriginalUrl) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressPlacement = {(this.AddressPlacement == null ? "null" : this.AddressPlacement.ToString())}");
            toStringOutput.Add($"this.Buckslips = {(this.Buckslips == null ? "null" : $"[{string.Join(", ", this.Buckslips)} ]")}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"CustomEnvelope = {(this.CustomEnvelope == null ? "null" : this.CustomEnvelope.ToString())}");
            toStringOutput.Add($"this.Color = {(this.Color == null ? "null" : this.Color.ToString())}");
            toStringOutput.Add($"this.DoubleSided = {(this.DoubleSided == null ? "null" : this.DoubleSided.ToString())}");
            toStringOutput.Add($"ExtraService = {(this.ExtraService == null ? "null" : this.ExtraService.ToString())}");
            toStringOutput.Add($"this.FileOriginalUrl = {(this.FileOriginalUrl == null ? "null" : this.FileOriginalUrl)}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
        }
    }
}