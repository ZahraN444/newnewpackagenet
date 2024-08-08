// <copyright file="BuckslipsController.cs" company="APIMatic">
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
    /// BuckslipsController.
    /// </summary>
    public class BuckslipsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuckslipsController"/> class.
        /// </summary>
        internal BuckslipsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of your buckslips. The buckslips are returned sorted by creation date, with the most recently created buckslips appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <returns>Returns the Models.BuckslipsResponse response from the API call.</returns>
        public Models.BuckslipsResponse BuckslipsList(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null)
            => CoreHelper.RunTask(BuckslipsListAsync(limit, beforeAfter, include));

        /// <summary>
        /// Returns a list of your buckslips. The buckslips are returned sorted by creation date, with the most recently created buckslips appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BuckslipsResponse response from the API call.</returns>
        public async Task<Models.BuckslipsResponse> BuckslipsListAsync(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BuckslipsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/buckslips")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("before/after", beforeAfter))
                      .Query(_query => _query.Setup("include", include))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new buckslip given information.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Buckslip response from the API call.</returns>
        public Models.Buckslip BuckslipCreate(
                Models.BuckslipEditable body)
            => CoreHelper.RunTask(BuckslipCreateAsync(body));

        /// <summary>
        /// Creates a new buckslip given information.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Buckslip response from the API call.</returns>
        public async Task<Models.Buckslip> BuckslipCreateAsync(
                Models.BuckslipEditable body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Buckslip>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/buckslips")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing buckslip. You need only supply the unique customer identifier that was returned upon buckslip creation.
        /// </summary>
        /// <param name="buckslipId">Required parameter: id of the buckslip.</param>
        /// <returns>Returns the Models.Buckslip response from the API call.</returns>
        public Models.Buckslip BuckslipRetrieve(
                string buckslipId)
            => CoreHelper.RunTask(BuckslipRetrieveAsync(buckslipId));

        /// <summary>
        /// Retrieves the details of an existing buckslip. You need only supply the unique customer identifier that was returned upon buckslip creation.
        /// </summary>
        /// <param name="buckslipId">Required parameter: id of the buckslip.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Buckslip response from the API call.</returns>
        public async Task<Models.Buckslip> BuckslipRetrieveAsync(
                string buckslipId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Buckslip>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/buckslips/{buckslip_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("buckslip_id", buckslipId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update the details of an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.
        /// </summary>
        /// <param name="buckslipId">Required parameter: id of the buckslip.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: Description of the buckslip..</param>
        /// <param name="autoReorder">Optional parameter: Allows for auto reordering.</param>
        /// <param name="reorderQuantity">Optional parameter: The quantity of items to be reordered (only required when auto_reorder is true)..</param>
        /// <returns>Returns the Models.Buckslip response from the API call.</returns>
        public Models.Buckslip BuckslipUpdate(
                string buckslipId,
                Models.ContentTypeEnum contentType,
                string description = null,
                bool? autoReorder = null,
                double? reorderQuantity = null)
            => CoreHelper.RunTask(BuckslipUpdateAsync(buckslipId, contentType, description, autoReorder, reorderQuantity));

        /// <summary>
        /// Update the details of an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.
        /// </summary>
        /// <param name="buckslipId">Required parameter: id of the buckslip.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: Description of the buckslip..</param>
        /// <param name="autoReorder">Optional parameter: Allows for auto reordering.</param>
        /// <param name="reorderQuantity">Optional parameter: The quantity of items to be reordered (only required when auto_reorder is true)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Buckslip response from the API call.</returns>
        public async Task<Models.Buckslip> BuckslipUpdateAsync(
                string buckslipId,
                Models.ContentTypeEnum contentType,
                string description = null,
                bool? autoReorder = null,
                double? reorderQuantity = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Buckslip>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/buckslips/{buckslip_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("buckslip_id", buckslipId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("auto_reorder", autoReorder))
                      .Form(_form => _form.Setup("reorder_quantity", reorderQuantity))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.
        /// </summary>
        /// <param name="buckslipId">Required parameter: id of the buckslip.</param>
        /// <returns>Returns the Models.BuckslipsResponse1 response from the API call.</returns>
        public Models.BuckslipsResponse1 BuckslipDelete(
                string buckslipId)
            => CoreHelper.RunTask(BuckslipDeleteAsync(buckslipId));

        /// <summary>
        /// Delete an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.
        /// </summary>
        /// <param name="buckslipId">Required parameter: id of the buckslip.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BuckslipsResponse1 response from the API call.</returns>
        public async Task<Models.BuckslipsResponse1> BuckslipDeleteAsync(
                string buckslipId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BuckslipsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/buckslips/{buckslip_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("buckslip_id", buckslipId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}