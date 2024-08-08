// <copyright file="Details3.cs" company="APIMatic">
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
    /// Details3.
    /// </summary>
    public class Details3
    {
        private List<Models.LetterAddOnTypesEnum> addOnTypes;
        private List<string> buckslips;
        private List<string> cards;
        private string customEnvelope;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "add_on_types", false },
            { "buckslips", false },
            { "cards", false },
            { "custom_envelope", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details3"/> class.
        /// </summary>
        public Details3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details3"/> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="addressPlacement">address_placement.</param>
        /// <param name="addOnTypes">add_on_types.</param>
        /// <param name="buckslips">buckslips.</param>
        /// <param name="cards">cards.</param>
        /// <param name="customEnvelope">custom_envelope.</param>
        /// <param name="doubleSided">double_sided.</param>
        /// <param name="extraService">extra_service.</param>
        /// <param name="mailType">mail_type.</param>
        /// <param name="qrCode">qr_code.</param>
        public Details3(
            bool color,
            Models.AddressPlacementEnum? addressPlacement = null,
            List<Models.LetterAddOnTypesEnum> addOnTypes = null,
            List<string> buckslips = null,
            List<string> cards = null,
            string customEnvelope = null,
            bool? doubleSided = true,
            object extraService = null,
            Models.MailTypeEnum? mailType = null,
            Models.QrCode1 qrCode = null)
        {
            this.AddressPlacement = addressPlacement;
            if (addOnTypes != null)
            {
                this.AddOnTypes = addOnTypes;
            }

            if (buckslips != null)
            {
                this.Buckslips = buckslips;
            }

            if (cards != null)
            {
                this.Cards = cards;
            }

            this.Color = color;
            if (customEnvelope != null)
            {
                this.CustomEnvelope = customEnvelope;
            }

            this.DoubleSided = doubleSided;
            this.ExtraService = extraService;
            this.MailType = mailType;
            this.QrCode = qrCode;
        }

        /// <summary>
        /// Gets or sets AddressPlacement.
        /// </summary>
        [JsonProperty("address_placement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressPlacementEnum? AddressPlacement { get; set; }

        /// <summary>
        /// An array containing the types of add-ons for the Letter Creative.
        /// </summary>
        [JsonProperty("add_on_types")]
        public List<Models.LetterAddOnTypesEnum> AddOnTypes
        {
            get
            {
                return this.addOnTypes;
            }

            set
            {
                this.shouldSerialize["add_on_types"] = true;
                this.addOnTypes = value;
            }
        }

        /// <summary>
        /// A single-element array containing an existing buckslip id in a string format. See [buckslips](#tag/Buckslips) for more information. Note that buckslip letter campaigns require a minimum send quantity of 5,000 letters per campaign.
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
        /// Set this key to `true` if you would like to print in color. Set to `false` if you would like to print in black and white.
        /// </summary>
        [JsonProperty("color")]
        public bool Color { get; set; }

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
        /// Gets or sets MailType.
        /// </summary>
        [JsonProperty("mail_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MailTypeEnum? MailType { get; set; }

        /// <summary>
        /// Gets or sets QrCode.
        /// </summary>
        [JsonProperty("qr_code", NullValueHandling = NullValueHandling.Ignore)]
        public Models.QrCode1 QrCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details3 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddOnTypes()
        {
            this.shouldSerialize["add_on_types"] = false;
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
        public bool ShouldSerializeAddOnTypes()
        {
            return this.shouldSerialize["add_on_types"];
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
            return obj is Details3 other &&                ((this.AddressPlacement == null && other.AddressPlacement == null) || (this.AddressPlacement?.Equals(other.AddressPlacement) == true)) &&
                ((this.AddOnTypes == null && other.AddOnTypes == null) || (this.AddOnTypes?.Equals(other.AddOnTypes) == true)) &&
                ((this.Buckslips == null && other.Buckslips == null) || (this.Buckslips?.Equals(other.Buckslips) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                this.Color.Equals(other.Color) &&
                ((this.CustomEnvelope == null && other.CustomEnvelope == null) || (this.CustomEnvelope?.Equals(other.CustomEnvelope) == true)) &&
                ((this.DoubleSided == null && other.DoubleSided == null) || (this.DoubleSided?.Equals(other.DoubleSided) == true)) &&
                ((this.ExtraService == null && other.ExtraService == null) || (this.ExtraService?.Equals(other.ExtraService) == true)) &&
                ((this.MailType == null && other.MailType == null) || (this.MailType?.Equals(other.MailType) == true)) &&
                ((this.QrCode == null && other.QrCode == null) || (this.QrCode?.Equals(other.QrCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressPlacement = {(this.AddressPlacement == null ? "null" : this.AddressPlacement.ToString())}");
            toStringOutput.Add($"this.AddOnTypes = {(this.AddOnTypes == null ? "null" : $"[{string.Join(", ", this.AddOnTypes)} ]")}");
            toStringOutput.Add($"this.Buckslips = {(this.Buckslips == null ? "null" : $"[{string.Join(", ", this.Buckslips)} ]")}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.Color = {this.Color}");
            toStringOutput.Add($"this.CustomEnvelope = {(this.CustomEnvelope == null ? "null" : this.CustomEnvelope)}");
            toStringOutput.Add($"this.DoubleSided = {(this.DoubleSided == null ? "null" : this.DoubleSided.ToString())}");
            toStringOutput.Add($"ExtraService = {(this.ExtraService == null ? "null" : this.ExtraService.ToString())}");
            toStringOutput.Add($"this.MailType = {(this.MailType == null ? "null" : this.MailType.ToString())}");
            toStringOutput.Add($"this.QrCode = {(this.QrCode == null ? "null" : this.QrCode.ToString())}");
        }
    }
}