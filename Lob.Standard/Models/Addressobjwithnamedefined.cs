// <copyright file="Addressobjwithnamedefined.cs" company="APIMatic">
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
    /// Addressobjwithnamedefined.
    /// </summary>
    public class Addressobjwithnamedefined
    {
        private string description;
        private string company;
        private string addressLine2;
        private string phone;
        private string email;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "company", false },
            { "address_line2", false },
            { "phone", false },
            { "email", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Addressobjwithnamedefined"/> class.
        /// </summary>
        public Addressobjwithnamedefined()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Addressobjwithnamedefined"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="company">company.</param>
        /// <param name="addressLine1">address_line1.</param>
        /// <param name="addressLine2">address_line2.</param>
        /// <param name="addressCity">address_city.</param>
        /// <param name="addressState">address_state.</param>
        /// <param name="addressZip">address_zip.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="addressCountry">address_country.</param>
        /// <param name="metadata">metadata.</param>
        public Addressobjwithnamedefined(
            string description = null,
            string name = null,
            string company = null,
            string addressLine1 = null,
            string addressLine2 = null,
            string addressCity = null,
            string addressState = null,
            string addressZip = null,
            string phone = null,
            string email = null,
            Models.AddressCountry2Enum? addressCountry = null,
            Dictionary<string, string> metadata = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.Name = name;
            if (company != null)
            {
                this.Company = company;
            }

            this.AddressLine1 = addressLine1;
            if (addressLine2 != null)
            {
                this.AddressLine2 = addressLine2;
            }

            this.AddressCity = addressCity;
            this.AddressState = addressState;
            this.AddressZip = addressZip;
            if (phone != null)
            {
                this.Phone = phone;
            }

            if (email != null)
            {
                this.Email = email;
            }

            this.AddressCountry = addressCountry;
            this.Metadata = metadata;
        }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Include)]
        public string Name { get; set; }

        /// <summary>
        /// Either `name` or `company` is required, you may also add both. Must be no longer than 40 characters. If both `name` and `company` are provided, they will be printed on two separate lines above the rest of the address. This field can be used for any secondary recipient information which is not part of the actual mailing address (Company Name, Department, Attention Line, etc).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("company")]
        public string Company
        {
            get
            {
                return this.company;
            }

            set
            {
                this.shouldSerialize["company"] = true;
                this.company = value;
            }
        }

        /// <summary>
        /// The primary number, street name, and directional information.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("address_line1", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// An optional field for address unit information. Total string sum of this plus `address_line1` may not exceed 50 characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("address_city", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressCity { get; set; }

        /// <summary>
        /// 2 letter state short-name code
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("address_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressState { get; set; }

        /// <summary>
        /// Must follow the ZIP format of `12345` or ZIP+4 format of `12345-1234`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("address_zip", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressZip { get; set; }

        /// <summary>
        /// Must be no longer than 40 characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        [JsonConverter(typeof(JsonStringConverter))]
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
        /// Gets or sets AddressCountry.
        /// </summary>
        [JsonProperty("address_country", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddressCountry2Enum? AddressCountry { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Addressobjwithnamedefined : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCompany()
        {
            this.shouldSerialize["company"] = false;
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
        public bool ShouldSerializeCompany()
        {
            return this.shouldSerialize["company"];
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
            return obj is Addressobjwithnamedefined other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.AddressLine2 == null && other.AddressLine2 == null) || (this.AddressLine2?.Equals(other.AddressLine2) == true)) &&
                ((this.AddressCity == null && other.AddressCity == null) || (this.AddressCity?.Equals(other.AddressCity) == true)) &&
                ((this.AddressState == null && other.AddressState == null) || (this.AddressState?.Equals(other.AddressState) == true)) &&
                ((this.AddressZip == null && other.AddressZip == null) || (this.AddressZip?.Equals(other.AddressZip) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.AddressCountry == null && other.AddressCountry == null) || (this.AddressCountry?.Equals(other.AddressCountry) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company)}");
            toStringOutput.Add($"this.AddressLine1 = {(this.AddressLine1 == null ? "null" : this.AddressLine1)}");
            toStringOutput.Add($"this.AddressLine2 = {(this.AddressLine2 == null ? "null" : this.AddressLine2)}");
            toStringOutput.Add($"this.AddressCity = {(this.AddressCity == null ? "null" : this.AddressCity)}");
            toStringOutput.Add($"this.AddressState = {(this.AddressState == null ? "null" : this.AddressState)}");
            toStringOutput.Add($"this.AddressZip = {(this.AddressZip == null ? "null" : this.AddressZip)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.AddressCountry = {(this.AddressCountry == null ? "null" : this.AddressCountry.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
        }
    }
}