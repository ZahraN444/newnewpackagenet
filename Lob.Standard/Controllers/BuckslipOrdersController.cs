// <copyright file="BuckslipOrdersController.cs" company="APIMatic">
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
    /// BuckslipOrdersController.
    /// </summary>
    public class BuckslipOrdersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuckslipOrdersController"/> class.
        /// </summary>
        internal BuckslipOrdersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the buckslip orders associated with the given buckslip id.
        /// </summary>
        /// <param name="buckslipId">Required parameter: The ID of the buckslip to which the buckslip orders belong..</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <returns>Returns the Models.BuckslipsOrdersResponse response from the API call.</returns>
        public Models.BuckslipsOrdersResponse BuckslipOrdersRetrieve(
                string buckslipId,
                int? limit = 10,
                int? offset = 0)
            => CoreHelper.RunTask(BuckslipOrdersRetrieveAsync(buckslipId, limit, offset));

        /// <summary>
        /// Retrieves the buckslip orders associated with the given buckslip id.
        /// </summary>
        /// <param name="buckslipId">Required parameter: The ID of the buckslip to which the buckslip orders belong..</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BuckslipsOrdersResponse response from the API call.</returns>
        public async Task<Models.BuckslipsOrdersResponse> BuckslipOrdersRetrieveAsync(
                string buckslipId,
                int? limit = 10,
                int? offset = 0,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BuckslipsOrdersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/buckslips/{buckslip_id}/orders")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("buckslip_id", buckslipId))
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("offset", offset ?? 0))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new buckslip order given information.
        /// </summary>
        /// <param name="buckslipId">Required parameter: The ID of the buckslip to which the buckslip orders belong..</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: The quantity of buckslips in the order (minimum 5,000)..</param>
        /// <returns>Returns the Models.BuckslipOrder response from the API call.</returns>
        public Models.BuckslipOrder BuckslipOrderCreate(
                string buckslipId,
                Models.ContentTypeEnum contentType,
                int quantity)
            => CoreHelper.RunTask(BuckslipOrderCreateAsync(buckslipId, contentType, quantity));

        /// <summary>
        /// Creates a new buckslip order given information.
        /// </summary>
        /// <param name="buckslipId">Required parameter: The ID of the buckslip to which the buckslip orders belong..</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: The quantity of buckslips in the order (minimum 5,000)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BuckslipOrder response from the API call.</returns>
        public async Task<Models.BuckslipOrder> BuckslipOrderCreateAsync(
                string buckslipId,
                Models.ContentTypeEnum contentType,
                int quantity,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BuckslipOrder>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/buckslips/{buckslip_id}/orders")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("buckslip_id", buckslipId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("quantity", quantity))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}