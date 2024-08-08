// <copyright file="UploadExportError1Exception.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Standard.Exceptions
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
    using Lob.Standard.Http.Client;
    using Lob.Standard.Models;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UploadExportError1Exception.
    /// </summary>
    public class UploadExportError1Exception : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadExportError1Exception"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public UploadExportError1Exception(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public Models.Code1Enum Code { get; set; }

        /// <summary>
        /// A human-readable message with more details about the error
        /// </summary>
        [JsonProperty("message")]
        public new string Message { get; set; }

        /// <summary>
        /// An array of pre-defined strings that identify an error
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
    }
}