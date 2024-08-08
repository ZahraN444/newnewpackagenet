// <copyright file="CardsController.cs" company="APIMatic">
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
    /// CardsController.
    /// </summary>
    public class CardsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardsController"/> class.
        /// </summary>
        internal CardsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of your cards. The cards are returned sorted by creation date, with the most recently created addresses appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <returns>Returns the Models.CardsResponse response from the API call.</returns>
        public Models.CardsResponse CardsList(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null)
            => CoreHelper.RunTask(CardsListAsync(limit, beforeAfter, include));

        /// <summary>
        /// Returns a list of your cards. The cards are returned sorted by creation date, with the most recently created addresses appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardsResponse response from the API call.</returns>
        public async Task<Models.CardsResponse> CardsListAsync(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/cards")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("before/after", beforeAfter))
                      .Query(_query => _query.Setup("include", include))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new card given information.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Card response from the API call.</returns>
        public Models.Card CardCreate(
                Models.CardEditable body)
            => CoreHelper.RunTask(CardCreateAsync(body));

        /// <summary>
        /// Creates a new card given information.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Card response from the API call.</returns>
        public async Task<Models.Card> CardCreateAsync(
                Models.CardEditable body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Card>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/cards")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing card. You need only supply the unique customer identifier that was returned upon card creation.
        /// </summary>
        /// <param name="cardId">Required parameter: id of the card.</param>
        /// <returns>Returns the Models.Card response from the API call.</returns>
        public Models.Card CardRetrieve(
                string cardId)
            => CoreHelper.RunTask(CardRetrieveAsync(cardId));

        /// <summary>
        /// Retrieves the details of an existing card. You need only supply the unique customer identifier that was returned upon card creation.
        /// </summary>
        /// <param name="cardId">Required parameter: id of the card.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Card response from the API call.</returns>
        public async Task<Models.Card> CardRetrieveAsync(
                string cardId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Card>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/cards/{card_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("card_id", cardId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update the details of an existing card. You need only supply the unique identifier that was returned upon card creation.
        /// </summary>
        /// <param name="cardId">Required parameter: id of the card.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: Description of the card..</param>
        /// <param name="autoReorder">Optional parameter: Allows for auto reordering.</param>
        /// <param name="reorderQuantity">Optional parameter: The quantity of items to be reordered (only required when auto_reorder is true)..</param>
        /// <returns>Returns the Models.Card response from the API call.</returns>
        public Models.Card CardUpdate(
                string cardId,
                Models.ContentTypeEnum contentType,
                string description = null,
                bool? autoReorder = null,
                double? reorderQuantity = null)
            => CoreHelper.RunTask(CardUpdateAsync(cardId, contentType, description, autoReorder, reorderQuantity));

        /// <summary>
        /// Update the details of an existing card. You need only supply the unique identifier that was returned upon card creation.
        /// </summary>
        /// <param name="cardId">Required parameter: id of the card.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: Description of the card..</param>
        /// <param name="autoReorder">Optional parameter: Allows for auto reordering.</param>
        /// <param name="reorderQuantity">Optional parameter: The quantity of items to be reordered (only required when auto_reorder is true)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Card response from the API call.</returns>
        public async Task<Models.Card> CardUpdateAsync(
                string cardId,
                Models.ContentTypeEnum contentType,
                string description = null,
                bool? autoReorder = null,
                double? reorderQuantity = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Card>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/cards/{card_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("card_id", cardId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("auto_reorder", autoReorder))
                      .Form(_form => _form.Setup("reorder_quantity", reorderQuantity))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an existing card. You need only supply the unique identifier that was returned upon card creation.
        /// </summary>
        /// <param name="cardId">Required parameter: id of the card.</param>
        /// <returns>Returns the Models.CardsResponse5 response from the API call.</returns>
        public Models.CardsResponse5 CardDelete(
                string cardId)
            => CoreHelper.RunTask(CardDeleteAsync(cardId));

        /// <summary>
        /// Delete an existing card. You need only supply the unique identifier that was returned upon card creation.
        /// </summary>
        /// <param name="cardId">Required parameter: id of the card.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardsResponse5 response from the API call.</returns>
        public async Task<Models.CardsResponse5> CardDeleteAsync(
                string cardId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardsResponse5>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/cards/{card_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("card_id", cardId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}