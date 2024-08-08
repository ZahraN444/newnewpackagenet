// <copyright file="USAutocompletionsController.cs" company="APIMatic">
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
    /// USAutocompletionsController.
    /// </summary>
    public class USAutocompletionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="USAutocompletionsController"/> class.
        /// </summary>
        internal USAutocompletionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Given an address prefix consisting of a partial primary line, as well as optional input of city, state, and zip code, this functionality returns up to 10 full US address suggestions. Not all of them will turn out to be valid addresses; they'll need to be [verified](#operation/verification_us).
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addressPrefix">Required parameter: Only accepts numbers and street names in an alphanumeric format..</param>
        /// <param name="mCase">Optional parameter: Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `primary_line`, `city`, and `state`. Default casing is `upper`..</param>
        /// <param name="validAddresses">Optional parameter: Possible values are `true` and `false`. If false, not all of the suggestions in the response will be valid addresses; they'll need to be verified in order to determine the deliverability. The valid_addresses flag will greatly reduce the number of keystrokes needed before reaching an intended address..</param>
        /// <param name="city">Optional parameter: An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="state">Optional parameter: An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="zipCode">Optional parameter: An optional ZIP Code input used to filter suggestions. Matches partial entries..</param>
        /// <param name="geoIpSort">Optional parameter: If `true`, sort suggestions by proximity to the IP set in the `X-Forwarded-For` header..</param>
        /// <returns>Returns the Models.UsAutocompletions response from the API call.</returns>
        public Models.UsAutocompletions Autocompletion(
                Models.ContentTypeEnum contentType,
                string addressPrefix,
                Models.Case1Enum? mCase = null,
                bool? validAddresses = false,
                string city = null,
                string state = null,
                string zipCode = null,
                bool? geoIpSort = null)
            => CoreHelper.RunTask(AutocompletionAsync(contentType, addressPrefix, mCase, validAddresses, city, state, zipCode, geoIpSort));

        /// <summary>
        /// Given an address prefix consisting of a partial primary line, as well as optional input of city, state, and zip code, this functionality returns up to 10 full US address suggestions. Not all of them will turn out to be valid addresses; they'll need to be [verified](#operation/verification_us).
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addressPrefix">Required parameter: Only accepts numbers and street names in an alphanumeric format..</param>
        /// <param name="mCase">Optional parameter: Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `primary_line`, `city`, and `state`. Default casing is `upper`..</param>
        /// <param name="validAddresses">Optional parameter: Possible values are `true` and `false`. If false, not all of the suggestions in the response will be valid addresses; they'll need to be verified in order to determine the deliverability. The valid_addresses flag will greatly reduce the number of keystrokes needed before reaching an intended address..</param>
        /// <param name="city">Optional parameter: An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="state">Optional parameter: An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="zipCode">Optional parameter: An optional ZIP Code input used to filter suggestions. Matches partial entries..</param>
        /// <param name="geoIpSort">Optional parameter: If `true`, sort suggestions by proximity to the IP set in the `X-Forwarded-For` header..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsAutocompletions response from the API call.</returns>
        public async Task<Models.UsAutocompletions> AutocompletionAsync(
                Models.ContentTypeEnum contentType,
                string addressPrefix,
                Models.Case1Enum? mCase = null,
                bool? validAddresses = false,
                string city = null,
                string state = null,
                string zipCode = null,
                bool? geoIpSort = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsAutocompletions>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/us_autocompletions")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("address_prefix", addressPrefix))
                      .Query(_query => _query.Setup("case", (mCase.HasValue) ? ApiHelper.JsonSerialize(mCase.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("valid_addresses", validAddresses ?? false))
                      .Form(_form => _form.Setup("city", city))
                      .Form(_form => _form.Setup("state", state))
                      .Form(_form => _form.Setup("zip_code", zipCode))
                      .Form(_form => _form.Setup("geo_ip_sort", geoIpSort))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}