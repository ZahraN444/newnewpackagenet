// <copyright file="IntlAutocompletionsController.cs" company="APIMatic">
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
    /// IntlAutocompletionsController.
    /// </summary>
    public class IntlAutocompletionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlAutocompletionsController"/> class.
        /// </summary>
        internal IntlAutocompletionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they'll need to be [verified](#operation/intl_verification).
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addressPrefix">Required parameter: Only accepts numbers and street names in an alphanumeric format..</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <param name="city">Optional parameter: An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="state">Optional parameter: An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="zipCode">Optional parameter: An optional Zip Code input used to filter suggestions. Matches partial entries..</param>
        /// <param name="geoIpSort">Optional parameter: If `true`, sort suggestions by proximity to the IP set in the `X-Forwarded-For` header..</param>
        /// <returns>Returns the Models.IntlAutocompletions response from the API call.</returns>
        public Models.IntlAutocompletions IntlAutocompletions(
                Models.ContentTypeEnum contentType,
                string addressPrefix,
                Models.CountryExtendedEnum country,
                Models.XLangOutput1Enum? xLangOutput = null,
                string city = null,
                string state = null,
                string zipCode = null,
                bool? geoIpSort = null)
            => CoreHelper.RunTask(IntlAutocompletionsAsync(contentType, addressPrefix, country, xLangOutput, city, state, zipCode, geoIpSort));

        /// <summary>
        /// Given an address prefix consisting of a partial primary line and country, as well as optional input of city, state, and zip code, this functionality returns up to 10 full International address suggestions. Not all of them will turn out to be valid addresses; they'll need to be [verified](#operation/intl_verification).
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="addressPrefix">Required parameter: Only accepts numbers and street names in an alphanumeric format..</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <param name="city">Optional parameter: An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="state">Optional parameter: An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations..</param>
        /// <param name="zipCode">Optional parameter: An optional Zip Code input used to filter suggestions. Matches partial entries..</param>
        /// <param name="geoIpSort">Optional parameter: If `true`, sort suggestions by proximity to the IP set in the `X-Forwarded-For` header..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IntlAutocompletions response from the API call.</returns>
        public async Task<Models.IntlAutocompletions> IntlAutocompletionsAsync(
                Models.ContentTypeEnum contentType,
                string addressPrefix,
                Models.CountryExtendedEnum country,
                Models.XLangOutput1Enum? xLangOutput = null,
                string city = null,
                string state = null,
                string zipCode = null,
                bool? geoIpSort = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IntlAutocompletions>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/intl_autocompletions")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("address_prefix", addressPrefix))
                      .Form(_form => _form.Setup("country", ApiHelper.JsonSerialize(country).Trim('\"')))
                      .Header(_header => _header.Setup("x-lang-output", (xLangOutput.HasValue) ? ApiHelper.JsonSerialize(xLangOutput.Value).Trim('\"') : null))
                      .Form(_form => _form.Setup("city", city))
                      .Form(_form => _form.Setup("state", state))
                      .Form(_form => _form.Setup("zip_code", zipCode))
                      .Form(_form => _form.Setup("geo_ip_sort", geoIpSort))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}