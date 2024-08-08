// <copyright file="AddressesController.cs" company="APIMatic">
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
    using Lob.Standard.Models.Containers;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// AddressesController.
    /// </summary>
    public class AddressesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesController"/> class.
        /// </summary>
        internal AddressesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of your addresses. The addresses are returned sorted by creation date, with the most recently created addresses appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <returns>Returns the Models.AllAddresses response from the API call.</returns>
        public Models.AllAddresses AddressesList(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null)
            => CoreHelper.RunTask(AddressesListAsync(limit, beforeAfter, include, dateCreated, metadata));

        /// <summary>
        /// Returns a list of your addresses. The addresses are returned sorted by creation date, with the most recently created addresses appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllAddresses response from the API call.</returns>
        public async Task<Models.AllAddresses> AddressesListAsync(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllAddresses>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/addresses")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("before/after", beforeAfter))
                      .Query(_query => _query.Setup("include", include))
                      .Query(_query => _query.Setup("date_created", dateCreated))
                      .Query(_query => _query.Setup("metadata", metadata))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new address given information.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the object response from the API call.</returns>
        public object AddressCreate(
                object body)
            => CoreHelper.RunTask(AddressCreateAsync(body));

        /// <summary>
        /// Creates a new address given information.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the object response from the API call.</returns>
        public async Task<object> AddressCreateAsync(
                object body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<object>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/addresses")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context)))
                  .Deserializer(_response => (Models.MObjectEnum)Enum.Parse(typeof(Models.MObjectEnum), _response)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing address. You need only supply the unique identifier that was returned upon address creation.
        /// </summary>
        /// <param name="adrId">Required parameter: id of the address.</param>
        /// <returns>Returns the Address response from the API call.</returns>
        public Address AddressRetrieve(
                string adrId)
            => CoreHelper.RunTask(AddressRetrieveAsync(adrId));

        /// <summary>
        /// Retrieves the details of an existing address. You need only supply the unique identifier that was returned upon address creation.
        /// </summary>
        /// <param name="adrId">Required parameter: id of the address.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Address response from the API call.</returns>
        public async Task<Address> AddressRetrieveAsync(
                string adrId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Address>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/addresses/{adr_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("adr_id", adrId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes the details of an existing address. You need only supply the unique identifier that was returned upon address creation.
        /// </summary>
        /// <param name="adrId">Required parameter: id of the address.</param>
        /// <returns>Returns the Models.AddressesResponse1 response from the API call.</returns>
        public Models.AddressesResponse1 AddressDelete(
                string adrId)
            => CoreHelper.RunTask(AddressDeleteAsync(adrId));

        /// <summary>
        /// Deletes the details of an existing address. You need only supply the unique identifier that was returned upon address creation.
        /// </summary>
        /// <param name="adrId">Required parameter: id of the address.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AddressesResponse1 response from the API call.</returns>
        public async Task<Models.AddressesResponse1> AddressDeleteAsync(
                string adrId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AddressesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/addresses/{adr_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("adr_id", adrId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}