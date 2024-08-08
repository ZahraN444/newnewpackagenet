// <copyright file="IntlVerificationsController.cs" company="APIMatic">
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
    /// IntlVerificationsController.
    /// </summary>
    public class IntlVerificationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlVerificationsController"/> class.
        /// </summary>
        internal IntlVerificationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Verify a list of international (except US or US territories) address _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addresses">Required parameter: Example: .</param>
        /// <returns>Returns the Models.IntlVerifications response from the API call.</returns>
        public Models.IntlVerifications BulkIntlVerifications(
                Models.ContentTypeEnum contentType,
                List<Models.MultipleComponentsIntl> addresses)
            => CoreHelper.RunTask(BulkIntlVerificationsAsync(contentType, addresses));

        /// <summary>
        /// Verify a list of international (except US or US territories) address _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addresses">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IntlVerifications response from the API call.</returns>
        public async Task<Models.IntlVerifications> BulkIntlVerificationsAsync(
                Models.ContentTypeEnum contentType,
                List<Models.MultipleComponentsIntl> addresses,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IntlVerifications>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/bulk/intl_verifications")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("addresses", addresses))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Verify an international (except US or US territories) address _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <returns>Returns the Models.IntlVerification response from the API call.</returns>
        public Models.IntlVerification IntlVerification(
                object body,
                Models.XLangOutput1Enum? xLangOutput = null)
            => CoreHelper.RunTask(IntlVerificationAsync(body, xLangOutput));

        /// <summary>
        /// Verify an international (except US or US territories) address _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IntlVerification response from the API call.</returns>
        public async Task<Models.IntlVerification> IntlVerificationAsync(
                object body,
                Models.XLangOutput1Enum? xLangOutput = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IntlVerification>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/intl_verifications")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("x-lang-output", (xLangOutput.HasValue) ? ApiHelper.JsonSerialize(xLangOutput.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}