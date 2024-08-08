// <copyright file="ToAddressUsChk.cs" company="APIMatic">
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
    /// ToAddressUsChk.
    /// </summary>
    public class ToAddressUsChk
    {
        private string description;
        private string phone;
        private string email;
        private string addressLine2;
        private bool? recipientMoved;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "phone", false },
            { "email", false },
            { "address_line2", false },
            { "recipient_moved", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ToAddressUsChk"/> class.
        /// </summary>
        public ToAddressUsChk()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToAddressUsChk"/> class.
        /// </summary>
        /// <param name="dateCreated">date_created.</param>
        /// <param name="dateModified">date_modified.</param>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="addressLine1">address_line1.</param>
        /// <param name="addressCity">address_city.</param>
        /// <param name="addressState">address_state.</param>
        /// <param name="addressZip">address_zip.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="company">company.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="addressLine2">address_line2.</param>
        /// <param name="addressCountry">address_country.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="recipientMoved">recipient_moved.</param>
        public ToAddressUsChk(
            DateTime dateCreated,
            DateTime dateModified,
            string mObject,
            string id,
            string addressLine1,
            string addressCity,
            string addressState,
            string addressZip,
            bool? deleted = null,
            string description = null,
            string name = null,
            string company = null,
            string phone = null,
            string email = null,
            string addressLine2 = null,
            Models.AddressCountryEnum? addressCountry = null,
            Dictionary<string, string> metadata = null,
            bool? recipientMoved = null)
        {
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.MObject = mObject;
            this.Id = id;
            if (description != null)
            {
                this.Description = description;
            }

            this.Name = name;
            this.Company = company;
            if (phone != null)
            {
                this.Phone = phone;
            }

            if (email != null)
            {
                this.Email = email;
            }

            this.AddressLine1 = addressLine1;
            if (addressLine2 != null)
            {
                this.AddressLine2 = addressLine2;
            }

            this.AddressCity = addressCity;
            this.AddressState = addressState;
            this.AddressZip = addressZip;
            this.AddressCountry = addressCountry;
            this.Metadata = metadata;
            if (recipientMoved != null)
            {
                this.RecipientMoved = recipientMoved;
            }

        }

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
        /// Unique identifier prefixed with `adr_`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

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
        /// Either `name` or `company` is required, you may also add both. Must be no longer than 40 characters. If both `name` and `company` are provided, they will be printed on two separate lines above the rest of the address.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Include)]
        public string Name { get; set; }

        /// <summary>
        /// Either `name` or `company` is required, you may also add both. Must be no longer than 40 characters. If both `name` and `company` are provided, they will be printed on two separate lines above the rest of the address. This field can be used for any secondary recipient information which is not part of the actual mailing address (Company Name, Department, Attention Line, etc).
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Include)]
        public string Company { get; set; }

        /// <summary>
        /// Must be no longer than 40 characters.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                this.shouldSerialize["phone"] = true;
                this.phone = value;
            }
        }

        /// <summary>
        /// Must be no longer than 100 characters.
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.shouldSerialize["email"] = true;
                this.email = value;
            }
        }

        /// <summary>
        /// The primary number, street name, and directional information.
        /// </summary>
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// An optional field containing any information which can't fit into line 1.
        /// </summary>
        [JsonProperty("address_line2")]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }

            set
            {
                this.shouldSerialize["address_line2"] = true;
                this.addressLine2 = value;
            }
        }

        /// <summary>
        /// Gets or sets AddressCity.
        /// </summary>
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// 2 letter state short-name code
        /// </summary>
        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// Must follow the ZIP format of `12345` or ZIP+4 format of `12345-1234`.
        /// </summary>
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// Gets or sets AddressCountry.
        /// </summary>
        [JsonProperty("address_country", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressCountryEnum? AddressCountry { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Only returned for accounts on certain <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print &amp; Mail Editions</a>. Value is `true` if the address was altered because the recipient filed for a <a href="#tag/National-Change-of-Address">National Change of Address Linkage (NCOALink)</a>, `false` if the NCOALink check was run but no altered address was found, and `null` if the NCOALink check was not run. The NCOALink check does not happen for non-US addresses, for non-deliverable US addresses, or for addresses created before the NCOALink feature was added to your account.
        /// </summary>
        [JsonProperty("recipient_moved")]
        public bool? RecipientMoved
        {
            get
            {
                return this.recipientMoved;
            }

            set
            {
                this.shouldSerialize["recipient_moved"] = true;
                this.recipientMoved = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ToAddressUsChk : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPhone()
        {
            this.shouldSerialize["phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEmail()
        {
            this.shouldSerialize["email"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddressLine2()
        {
            this.shouldSerialize["address_line2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRecipientMoved()
        {
            this.shouldSerialize["recipient_moved"] = false;
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
        public bool ShouldSerializePhone()
        {
            return this.shouldSerialize["phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmail()
        {
            return this.shouldSerialize["email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddressLine2()
        {
            return this.shouldSerialize["address_line2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipientMoved()
        {
            return this.shouldSerialize["recipient_moved"];
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
            return obj is ToAddressUsChk other &&                this.DateCreated.Equals(other.DateCreated) &&
                this.DateModified.Equals(other.DateModified) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.AddressLine2 == null && other.AddressLine2 == null) || (this.AddressLine2?.Equals(other.AddressLine2) == true)) &&
                ((this.AddressCity == null && other.AddressCity == null) || (this.AddressCity?.Equals(other.AddressCity) == true)) &&
                ((this.AddressState == null && other.AddressState == null) || (this.AddressState?.Equals(other.AddressState) == true)) &&
                ((this.AddressZip == null && other.AddressZip == null) || (this.AddressZip?.Equals(other.AddressZip) == true)) &&
                ((this.AddressCountry == null && other.AddressCountry == null) || (this.AddressCountry?.Equals(other.AddressCountry) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.RecipientMoved == null && other.RecipientMoved == null) || (this.RecipientMoved?.Equals(other.RecipientMoved) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateCreated = {this.DateCreated}");
            toStringOutput.Add($"this.DateModified = {this.DateModified}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
            toStringOutput.Add($"this.MObject = {(this.MObject == null ? "null" : this.MObject)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.AddressLine1 = {(this.AddressLine1 == null ? "null" : this.AddressLine1)}");
            toStringOutput.Add($"this.AddressLine2 = {(this.AddressLine2 == null ? "null" : this.AddressLine2)}");
            toStringOutput.Add($"this.AddressCity = {(this.AddressCity == null ? "null" : this.AddressCity)}");
            toStringOutput.Add($"this.AddressState = {(this.AddressState == null ? "null" : this.AddressState)}");
            toStringOutput.Add($"this.AddressZip = {(this.AddressZip == null ? "null" : this.AddressZip)}");
            toStringOutput.Add($"this.AddressCountry = {(this.AddressCountry == null ? "null" : this.AddressCountry.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.RecipientMoved = {(this.RecipientMoved == null ? "null" : this.RecipientMoved.ToString())}");
        }
    }
}