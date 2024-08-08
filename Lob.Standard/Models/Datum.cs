// <copyright file="Datum.cs" company="APIMatic">
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
    /// Datum.
    /// </summary>
    public class Datum
    {
        private string errorMessage;
        private string mailpieceId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "errorMessage", false },
            { "mailpieceId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Datum"/> class.
        /// </summary>
        public Datum()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Datum"/> class.
        /// </summary>
        /// <param name="rowNumber">rowNumber.</param>
        /// <param name="status">status.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="mailpieceId">mailpieceId.</param>
        /// <param name="originalData">originalData.</param>
        public Datum(
            double? rowNumber = null,
            Models.Status4Enum? status = null,
            string errorMessage = null,
            string mailpieceId = null,
            object originalData = null)
        {
            this.RowNumber = rowNumber;
            this.Status = status;
            if (errorMessage != null)
            {
                this.ErrorMessage = errorMessage;
            }

            if (mailpieceId != null)
            {
                this.MailpieceId = mailpieceId;
            }

            this.OriginalData = originalData;
        }

        /// <summary>
        /// The row number of the csv file containing this data.
        /// </summary>
        [JsonProperty("rowNumber", NullValueHandling = NullValueHandling.Ignore)]
        public double? RowNumber { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Status4Enum? Status { get; set; }

        /// <summary>
        /// The error message detailing the reason why processing the line item failed.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }

            set
            {
                this.shouldSerialize["errorMessage"] = true;
                this.errorMessage = value;
            }
        }

        /// <summary>
        /// The mailpiece id created from the line item when it was validated.
        /// </summary>
        [JsonProperty("mailpieceId")]
        public string MailpieceId
        {
            get
            {
                return this.mailpieceId;
            }

            set
            {
                this.shouldSerialize["mailpieceId"] = true;
                this.mailpieceId = value;
            }
        }

        /// <summary>
        /// Key-value pairs where each key is the column header and each value is the value of the column for the row.
        /// </summary>
        [JsonProperty("originalData", NullValueHandling = NullValueHandling.Ignore)]
        public object OriginalData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Datum : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrorMessage()
        {
            this.shouldSerialize["errorMessage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMailpieceId()
        {
            this.shouldSerialize["mailpieceId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrorMessage()
        {
            return this.shouldSerialize["errorMessage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMailpieceId()
        {
            return this.shouldSerialize["mailpieceId"];
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
            return obj is Datum other &&                ((this.RowNumber == null && other.RowNumber == null) || (this.RowNumber?.Equals(other.RowNumber) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.ErrorMessage == null && other.ErrorMessage == null) || (this.ErrorMessage?.Equals(other.ErrorMessage) == true)) &&
                ((this.MailpieceId == null && other.MailpieceId == null) || (this.MailpieceId?.Equals(other.MailpieceId) == true)) &&
                ((this.OriginalData == null && other.OriginalData == null) || (this.OriginalData?.Equals(other.OriginalData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RowNumber = {(this.RowNumber == null ? "null" : this.RowNumber.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.ErrorMessage = {(this.ErrorMessage == null ? "null" : this.ErrorMessage)}");
            toStringOutput.Add($"this.MailpieceId = {(this.MailpieceId == null ? "null" : this.MailpieceId)}");
            toStringOutput.Add($"OriginalData = {(this.OriginalData == null ? "null" : this.OriginalData.ToString())}");
        }
    }
}