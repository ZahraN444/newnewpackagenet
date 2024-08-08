// <copyright file="BillingGroupsController.cs" company="APIMatic">
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
    /// BillingGroupsController.
    /// </summary>
    public class BillingGroupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingGroupsController"/> class.
        /// </summary>
        internal BillingGroupsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the details of an existing billing_group. You need only supply the unique billing_group identifier that was returned upon billing_group creation.
        /// </summary>
        /// <param name="bgId">Required parameter: id of the billing_group.</param>
        /// <returns>Returns the Models.BillingGroup response from the API call.</returns>
        public Models.BillingGroup BillingGroupRetrieve(
                string bgId)
            => CoreHelper.RunTask(BillingGroupRetrieveAsync(bgId));

        /// <summary>
        /// Retrieves the details of an existing billing_group. You need only supply the unique billing_group identifier that was returned upon billing_group creation.
        /// </summary>
        /// <param name="bgId">Required parameter: id of the billing_group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BillingGroup response from the API call.</returns>
        public async Task<Models.BillingGroup> BillingGroupRetrieveAsync(
                string bgId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BillingGroup>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/billing_groups/{bg_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("bg_id", bgId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates all editable attributes of the billing_group with the given id.
        /// </summary>
        /// <param name="bgId">Required parameter: id of the billing_group.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: Description of the billing group..</param>
        /// <param name="name">Optional parameter: Name of the billing group..</param>
        /// <returns>Returns the Models.BillingGroup response from the API call.</returns>
        public Models.BillingGroup BillingGroupUpdate(
                string bgId,
                Models.ContentTypeEnum contentType,
                string description = null,
                string name = null)
            => CoreHelper.RunTask(BillingGroupUpdateAsync(bgId, contentType, description, name));

        /// <summary>
        /// Updates all editable attributes of the billing_group with the given id.
        /// </summary>
        /// <param name="bgId">Required parameter: id of the billing_group.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: Description of the billing group..</param>
        /// <param name="name">Optional parameter: Name of the billing group..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BillingGroup response from the API call.</returns>
        public async Task<Models.BillingGroup> BillingGroupUpdateAsync(
                string bgId,
                Models.ContentTypeEnum contentType,
                string description = null,
                string name = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BillingGroup>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/billing_groups/{bg_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("bg_id", bgId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("name", name))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of your billing_groups. The billing_groups are returned sorted by creation date, with the most recently created billing_groups appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="dateModified"><![CDATA[Optional parameter: Filter by date modified. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="sortBy">Optional parameter: Sorts items by ascending or descending dates. Use either `date_created` or `date_modified`, not both..</param>
        /// <returns>Returns the Models.BillingGroupsResponse response from the API call.</returns>
        public Models.BillingGroupsResponse BillingGroupsList(
                int? limit = 10,
                int? offset = 0,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> dateModified = null,
                Models.SortBy sortBy = null)
            => CoreHelper.RunTask(BillingGroupsListAsync(limit, offset, include, dateCreated, dateModified, sortBy));

        /// <summary>
        /// Returns a list of your billing_groups. The billing_groups are returned sorted by creation date, with the most recently created billing_groups appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="dateModified"><![CDATA[Optional parameter: Filter by date modified. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="sortBy">Optional parameter: Sorts items by ascending or descending dates. Use either `date_created` or `date_modified`, not both..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BillingGroupsResponse response from the API call.</returns>
        public async Task<Models.BillingGroupsResponse> BillingGroupsListAsync(
                int? limit = 10,
                int? offset = 0,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> dateModified = null,
                Models.SortBy sortBy = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BillingGroupsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/billing_groups")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("offset", offset ?? 0))
                      .Query(_query => _query.Setup("include", include))
                      .Query(_query => _query.Setup("date_created", dateCreated))
                      .Query(_query => _query.Setup("date_modified", dateModified))
                      .Query(_query => _query.Setup("sort_by", sortBy))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new billing_group with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.BillingGroup response from the API call.</returns>
        public Models.BillingGroup BillingGroupCreate(
                Models.BillingGroupEditable body)
            => CoreHelper.RunTask(BillingGroupCreateAsync(body));

        /// <summary>
        /// Creates a new billing_group with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BillingGroup response from the API call.</returns>
        public async Task<Models.BillingGroup> BillingGroupCreateAsync(
                Models.BillingGroupEditable body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BillingGroup>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/billing_groups")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}