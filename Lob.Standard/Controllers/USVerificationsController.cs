// <copyright file="USVerificationsController.cs" company="APIMatic">
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
    /// USVerificationsController.
    /// </summary>
    public class USVerificationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="USVerificationsController"/> class.
        /// </summary>
        internal USVerificationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Verify a list of US or US territory addresses _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addresses">Required parameter: Example: .</param>
        /// <param name="mCase">Optional parameter: Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `recipient`, `primary_line`, `secondary_line`, `urbanization`, and `last_line`. Default casing is `upper`..</param>
        /// <returns>Returns the Models.UsVerifications response from the API call.</returns>
        public Models.UsVerifications BulkUsVerifications(
                Models.ContentTypeEnum contentType,
                List<Models.MultipleComponents> addresses,
                Models.Case2Enum? mCase = null)
            => CoreHelper.RunTask(BulkUsVerificationsAsync(contentType, addresses, mCase));

        /// <summary>
        /// Verify a list of US or US territory addresses _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addresses">Required parameter: Example: .</param>
        /// <param name="mCase">Optional parameter: Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `recipient`, `primary_line`, `secondary_line`, `urbanization`, and `last_line`. Default casing is `upper`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsVerifications response from the API call.</returns>
        public async Task<Models.UsVerifications> BulkUsVerificationsAsync(
                Models.ContentTypeEnum contentType,
                List<Models.MultipleComponents> addresses,
                Models.Case2Enum? mCase = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsVerifications>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/bulk/us_verifications")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("addresses", addresses))
                      .Query(_query => _query.Setup("case", (mCase.HasValue) ? ApiHelper.JsonSerialize(mCase.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Verify a US or US territory address _with a live API key_. The address can be in components (e.g. `primary_line` is "210 King Street", `zip_code` is "94107") or as a single string (e.g. "210 King Street 94107"), but not as both. Requests using a test API key validate required fields but return empty values unless specific `primary_line` values are provided. See the [US Verifications Test Environment](#section/US-Verifications-Test-Env) for details.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="mCase">Optional parameter: Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `recipient`, `primary_line`, `secondary_line`, `urbanization`, and `last_line`. Default casing is `upper`..</param>
        /// <returns>Returns the Models.UsVerification response from the API call.</returns>
        public Models.UsVerification UsVerification(
                object body,
                Models.Case2Enum? mCase = null)
            => CoreHelper.RunTask(UsVerificationAsync(body, mCase));

        /// <summary>
        /// Verify a US or US territory address _with a live API key_. The address can be in components (e.g. `primary_line` is "210 King Street", `zip_code` is "94107") or as a single string (e.g. "210 King Street 94107"), but not as both. Requests using a test API key validate required fields but return empty values unless specific `primary_line` values are provided. See the [US Verifications Test Environment](#section/US-Verifications-Test-Env) for details.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="mCase">Optional parameter: Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `recipient`, `primary_line`, `secondary_line`, `urbanization`, and `last_line`. Default casing is `upper`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsVerification response from the API call.</returns>
        public async Task<Models.UsVerification> UsVerificationAsync(
                object body,
                Models.Case2Enum? mCase = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsVerification>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/us_verifications")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("case", (mCase.HasValue) ? ApiHelper.JsonSerialize(mCase.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}