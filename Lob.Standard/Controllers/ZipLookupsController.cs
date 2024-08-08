// <copyright file="ZipLookupsController.cs" company="APIMatic">
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
    /// ZipLookupsController.
    /// </summary>
    public class ZipLookupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipLookupsController"/> class.
        /// </summary>
        internal ZipLookupsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns information about a ZIP code.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="zipCode">Required parameter: A 5-digit ZIP code..</param>
        /// <returns>Returns the Models.Zip response from the API call.</returns>
        public Models.Zip ZipLookup(
                Models.ContentTypeEnum contentType,
                string zipCode)
            => CoreHelper.RunTask(ZipLookupAsync(contentType, zipCode));

        /// <summary>
        /// Returns information about a ZIP code.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="zipCode">Required parameter: A 5-digit ZIP code..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Zip response from the API call.</returns>
        public async Task<Models.Zip> ZipLookupAsync(
                Models.ContentTypeEnum contentType,
                string zipCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Zip>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/us_zip_lookups")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("zip_code", zipCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}