// <copyright file="CreativesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Lob.Standard;
    using Lob.Standard.Exceptions;
    using Lob.Standard.Http.Client;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// CreativesController.
    /// </summary>
    public class CreativesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreativesController"/> class.
        /// </summary>
        internal CreativesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a new creative with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <returns>Returns the Models.Creative response from the API call.</returns>
        public Models.Creative CreativeCreate(
                object body,
                Models.XLangOutput1Enum? xLangOutput = null)
            => CoreHelper.RunTask(CreativeCreateAsync(body, xLangOutput));

        /// <summary>
        /// Creates a new creative with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Creative response from the API call.</returns>
        public async Task<Models.Creative> CreativeCreateAsync(
                object body,
                Models.XLangOutput1Enum? xLangOutput = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Creative>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/creatives")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("x-lang-output", (xLangOutput.HasValue) ? ApiHelper.JsonSerialize(xLangOutput.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing creative. You need only supply the unique creative identifier that was returned upon creative creation.
        /// </summary>
        /// <param name="crvId">Required parameter: id of the creative.</param>
        /// <returns>Returns the Models.Creative response from the API call.</returns>
        public Models.Creative CreativeRetrieve(
                string crvId)
            => CoreHelper.RunTask(CreativeRetrieveAsync(crvId));

        /// <summary>
        /// Retrieves the details of an existing creative. You need only supply the unique creative identifier that was returned upon creative creation.
        /// </summary>
        /// <param name="crvId">Required parameter: id of the creative.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Creative response from the API call.</returns>
        public async Task<Models.Creative> CreativeRetrieveAsync(
                string crvId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Creative>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/creatives/{crv_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("crv_id", crvId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update the details of an existing creative. You need only supply the unique identifier that was returned upon creative creation.
        /// </summary>
        /// <param name="crvId">Required parameter: id of the creative.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="from">Optional parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <returns>Returns the Models.Creative response from the API call.</returns>
        public Models.Creative CreativeUpdate(
                string crvId,
                Models.ContentTypeEnum contentType,
                FileStreamInfo from = null,
                string description = null,
                Dictionary<string, string> metadata = null)
            => CoreHelper.RunTask(CreativeUpdateAsync(crvId, contentType, from, description, metadata));

        /// <summary>
        /// Update the details of an existing creative. You need only supply the unique identifier that was returned upon creative creation.
        /// </summary>
        /// <param name="crvId">Required parameter: id of the creative.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="from">Optional parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Creative response from the API call.</returns>
        public async Task<Models.Creative> CreativeUpdateAsync(
                string crvId,
                Models.ContentTypeEnum contentType,
                FileStreamInfo from = null,
                string description = null,
                Dictionary<string, string> metadata = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Creative>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/creatives/{crv_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("crv_id", crvId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("from", from))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("metadata", metadata))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}