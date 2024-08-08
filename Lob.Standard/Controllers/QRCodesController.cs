// <copyright file="QRCodesController.cs" company="APIMatic">
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
    using Lob.Standard.Http.Client;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// QRCodesController.
    /// </summary>
    public class QRCodesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QRCodesController"/> class.
        /// </summary>
        internal QRCodesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of your QR codes. The QR codes are returned sorted by scan date, with the most recently scanned QR codes appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="scanned">Optional parameter: Filter list of responses to only include QR codes with at least one scan event..</param>
        /// <param name="resourceIds">Optional parameter: Filter by the resource ID..</param>
        /// <returns>Returns the Models.QrCodeAnalyticsResponse response from the API call.</returns>
        public Models.QrCodeAnalyticsResponse QrCodesList(
                int? limit = 10,
                int? offset = 0,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                bool? scanned = null,
                object resourceIds = null)
            => CoreHelper.RunTask(QrCodesListAsync(limit, offset, include, dateCreated, scanned, resourceIds));

        /// <summary>
        /// Returns a list of your QR codes. The QR codes are returned sorted by scan date, with the most recently scanned QR codes appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="scanned">Optional parameter: Filter list of responses to only include QR codes with at least one scan event..</param>
        /// <param name="resourceIds">Optional parameter: Filter by the resource ID..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QrCodeAnalyticsResponse response from the API call.</returns>
        public async Task<Models.QrCodeAnalyticsResponse> QrCodesListAsync(
                int? limit = 10,
                int? offset = 0,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                bool? scanned = null,
                object resourceIds = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QrCodeAnalyticsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/qr_code_analytics")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("offset", offset ?? 0))
                      .Query(_query => _query.Setup("include", include))
                      .Query(_query => _query.Setup("date_created", dateCreated))
                      .Query(_query => _query.Setup("scanned", scanned))
                      .Query(_query => _query.Setup("resource_ids", resourceIds))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}