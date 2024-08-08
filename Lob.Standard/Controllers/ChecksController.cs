// <copyright file="ChecksController.cs" company="APIMatic">
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
    /// ChecksController.
    /// </summary>
    public class ChecksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksController"/> class.
        /// </summary>
        internal ChecksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of your checks. The checks are returned sorted by creation date, with the most recently created checks appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <param name="scheduled">Optional parameter: * `true` - only return orders (past or future) where `send_date` is greater than `date_created` * `false` - only return orders where `send_date` is equal to `date_created`.</param>
        /// <param name="sendDate"><![CDATA[Optional parameter: Filter by ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="mailType">Optional parameter: A string designating the mail postage type: * `usps_first_class` - (default) * `usps_standard` - a <a href="https://lob.com/pricing/print-mail#compare" target="_blank">cheaper option</a> which is less predictable and takes longer to deliver. `usps_standard` cannot be used with `4x6` postcards or for any postcards sent outside of the United States..</param>
        /// <param name="sortBy">Optional parameter: Sorts items by ascending or descending dates. Use either `date_created` or `send_date`, not both..</param>
        /// <returns>Returns the Models.AllChecks response from the API call.</returns>
        public Models.AllChecks ChecksList(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null,
                bool? scheduled = null,
                object sendDate = null,
                Models.MailTypeEnum? mailType = null,
                Models.SortBy1 sortBy = null)
            => CoreHelper.RunTask(ChecksListAsync(limit, beforeAfter, include, dateCreated, metadata, scheduled, sendDate, mailType, sortBy));

        /// <summary>
        /// Returns a list of your checks. The checks are returned sorted by creation date, with the most recently created checks appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <param name="scheduled">Optional parameter: * `true` - only return orders (past or future) where `send_date` is greater than `date_created` * `false` - only return orders where `send_date` is equal to `date_created`.</param>
        /// <param name="sendDate"><![CDATA[Optional parameter: Filter by ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="mailType">Optional parameter: A string designating the mail postage type: * `usps_first_class` - (default) * `usps_standard` - a <a href="https://lob.com/pricing/print-mail#compare" target="_blank">cheaper option</a> which is less predictable and takes longer to deliver. `usps_standard` cannot be used with `4x6` postcards or for any postcards sent outside of the United States..</param>
        /// <param name="sortBy">Optional parameter: Sorts items by ascending or descending dates. Use either `date_created` or `send_date`, not both..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllChecks response from the API call.</returns>
        public async Task<Models.AllChecks> ChecksListAsync(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null,
                bool? scheduled = null,
                object sendDate = null,
                Models.MailTypeEnum? mailType = null,
                Models.SortBy1 sortBy = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllChecks>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/checks")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("before/after", beforeAfter))
                      .Query(_query => _query.Setup("include", include))
                      .Query(_query => _query.Setup("date_created", dateCreated))
                      .Query(_query => _query.Setup("metadata", metadata))
                      .Query(_query => _query.Setup("scheduled", scheduled))
                      .Query(_query => _query.Setup("send_date", sendDate))
                      .Query(_query => _query.Setup("mail_type", (mailType.HasValue) ? ApiHelper.JsonSerialize(mailType.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("sort_by", sortBy))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new check with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>..</param>
        /// <param name="idempotencyKey2">Optional parameter: A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>..</param>
        /// <returns>Returns the Models.Check response from the API call.</returns>
        public Models.Check CheckCreate(
                object body,
                string idempotencyKey = null,
                string idempotencyKey2 = null)
            => CoreHelper.RunTask(CheckCreateAsync(body, idempotencyKey, idempotencyKey2));

        /// <summary>
        /// Creates a new check with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>..</param>
        /// <param name="idempotencyKey2">Optional parameter: A string of no longer than 256 characters that uniquely identifies this resource. For more help integrating idempotency keys, refer to our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/managing-mail-settings#idempotent-requests-12" target="_blank">implementation guide</a>..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Check response from the API call.</returns>
        public async Task<Models.Check> CheckCreateAsync(
                object body,
                string idempotencyKey = null,
                string idempotencyKey2 = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Check>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/checks")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))
                      .Query(_query => _query.Setup("idempotency_key2", idempotencyKey2))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing check. You need only supply the unique check identifier that was returned upon check creation.
        /// </summary>
        /// <param name="chkId">Required parameter: id of the check.</param>
        /// <returns>Returns the Models.Check response from the API call.</returns>
        public Models.Check CheckRetrieve(
                string chkId)
            => CoreHelper.RunTask(CheckRetrieveAsync(chkId));

        /// <summary>
        /// Retrieves the details of an existing check. You need only supply the unique check identifier that was returned upon check creation.
        /// </summary>
        /// <param name="chkId">Required parameter: id of the check.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Check response from the API call.</returns>
        public async Task<Models.Check> CheckRetrieveAsync(
                string chkId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Check>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/checks/{chk_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("chk_id", chkId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Completely removes a check from production. This can only be done if the check has a `send_date` and the `send_date` has not yet passed. If the check is successfully canceled, you will not be charged for it. Read more on [cancellation windows](#section/Cancellation-Windows) and [scheduling](#section/Scheduled-Mailings). Scheduling and cancellation is a premium feature. Upgrade to the appropriate <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a> to gain access.
        /// ]]>
        /// </summary>
        /// <param name="chkId">Required parameter: id of the check.</param>
        /// <returns>Returns the Models.ChecksResponse response from the API call.</returns>
        public Models.ChecksResponse CheckCancel(
                string chkId)
            => CoreHelper.RunTask(CheckCancelAsync(chkId));

        /// <summary>
        /// <![CDATA[
        /// Completely removes a check from production. This can only be done if the check has a `send_date` and the `send_date` has not yet passed. If the check is successfully canceled, you will not be charged for it. Read more on [cancellation windows](#section/Cancellation-Windows) and [scheduling](#section/Scheduled-Mailings). Scheduling and cancellation is a premium feature. Upgrade to the appropriate <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a> to gain access.
        /// ]]>
        /// </summary>
        /// <param name="chkId">Required parameter: id of the check.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ChecksResponse response from the API call.</returns>
        public async Task<Models.ChecksResponse> CheckCancelAsync(
                string chkId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChecksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/checks/{chk_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("chk_id", chkId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}