// <copyright file="BankAccountBase.cs" company="APIMatic">
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
    /// BankAccountBase.
    /// </summary>
    public class BankAccountBase
    {
        private string description;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountBase"/> class.
        /// </summary>
        public BankAccountBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountBase"/> class.
        /// </summary>
        /// <param name="routingNumber">routing_number.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountType">account_type.</param>
        /// <param name="signatory">signatory.</param>
        /// <param name="description">description.</param>
        /// <param name="checkTemplate">check_template.</param>
        /// <param name="fractionalRoutingNumber">fractional_routing_number.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zipcode">zipcode.</param>
        /// <param name="metadata">metadata.</param>
        public BankAccountBase(
            string routingNumber,
            string accountNumber,
            Models.AccountTypeEnum accountType,
            string signatory,
            string description = null,
            Models.CheckTemplateEnum? checkTemplate = null,
            string fractionalRoutingNumber = null,
            string city = null,
            string state = null,
            string zipcode = null,
            Dictionary<string, string> metadata = null)
        {
            if (description != null)
            {
                this.Description = description;
            }

            this.RoutingNumber = routingNumber;
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.Signatory = signatory;
            this.CheckTemplate = checkTemplate;
            this.FractionalRoutingNumber = fractionalRoutingNumber;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
            this.Metadata = metadata;
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
        /// Must be a <a href="https://www.frbservices.org/index.html" target="_blank">valid US routing number</a>.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets AccountType.
        /// </summary>
        [JsonProperty("account_type")]
        public Models.AccountTypeEnum AccountType { get; set; }

        /// <summary>
        /// The signatory associated with your account. This name will be printed on checks created with this bank account. If you prefer to use a custom signature image on your checks instead, please create your bank account from the <a href="https://dashboard.lob.com/#/login" target="_blank">Dashboard</a>.
        /// </summary>
        [JsonProperty("signatory")]
        public string Signatory { get; set; }

        /// <summary>
        /// Gets or sets CheckTemplate.
        /// </summary>
        [JsonProperty("check_template", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckTemplateEnum? CheckTemplate { get; set; }

        /// <summary>
        /// The fractional routing number for your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the fractional routing number associated with your home bank institution.
        /// </summary>
        [JsonProperty("fractional_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FractionalRoutingNumber { get; set; }

        /// <summary>
        /// The city associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the city associated with your home bank institution.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// The state associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the state associated with your home bank institution.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// The zipcode associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the zipcode associated with your home bank institution.
        /// </summary>
        [JsonProperty("zipcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BankAccountBase : ({string.Join(", ", toStringOutput)})";
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
            return obj is BankAccountBase other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.RoutingNumber == null && other.RoutingNumber == null) || (this.RoutingNumber?.Equals(other.RoutingNumber) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                this.AccountType.Equals(other.AccountType) &&
                ((this.Signatory == null && other.Signatory == null) || (this.Signatory?.Equals(other.Signatory) == true)) &&
                ((this.CheckTemplate == null && other.CheckTemplate == null) || (this.CheckTemplate?.Equals(other.CheckTemplate) == true)) &&
                ((this.FractionalRoutingNumber == null && other.FractionalRoutingNumber == null) || (this.FractionalRoutingNumber?.Equals(other.FractionalRoutingNumber) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Zipcode == null && other.Zipcode == null) || (this.Zipcode?.Equals(other.Zipcode) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.RoutingNumber = {(this.RoutingNumber == null ? "null" : this.RoutingNumber)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountType = {this.AccountType}");
            toStringOutput.Add($"this.Signatory = {(this.Signatory == null ? "null" : this.Signatory)}");
            toStringOutput.Add($"this.CheckTemplate = {(this.CheckTemplate == null ? "null" : this.CheckTemplate.ToString())}");
            toStringOutput.Add($"this.FractionalRoutingNumber = {(this.FractionalRoutingNumber == null ? "null" : this.FractionalRoutingNumber)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Zipcode = {(this.Zipcode == null ? "null" : this.Zipcode)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
        }
    }
}