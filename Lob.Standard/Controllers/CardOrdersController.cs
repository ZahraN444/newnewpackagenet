// <copyright file="CardOrdersController.cs" company="APIMatic">
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
    /// CardOrdersController.
    /// </summary>
    public class CardOrdersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrdersController"/> class.
        /// </summary>
        internal CardOrdersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the card orders associated with the given card id.
        /// </summary>
        /// <param name="cardId">Required parameter: The ID of the card to which the card orders belong..</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <returns>Returns the Models.CardsOrdersResponse response from the API call.</returns>
        public Models.CardsOrdersResponse CardOrdersRetrieve(
                string cardId,
                int? limit = 10,
                int? offset = 0)
            => CoreHelper.RunTask(CardOrdersRetrieveAsync(cardId, limit, offset));

        /// <summary>
        /// Retrieves the card orders associated with the given card id.
        /// </summary>
        /// <param name="cardId">Required parameter: The ID of the card to which the card orders belong..</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardsOrdersResponse response from the API call.</returns>
        public async Task<Models.CardsOrdersResponse> CardOrdersRetrieveAsync(
                string cardId,
                int? limit = 10,
                int? offset = 0,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardsOrdersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/cards/{card_id}/orders")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("card_id", cardId))
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("offset", offset ?? 0))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new card order given information.
        /// </summary>
        /// <param name="cardId">Required parameter: The ID of the card to which the card orders belong..</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: The quantity of cards in the order (minimum 10,000)..</param>
        /// <returns>Returns the Models.CardOrder response from the API call.</returns>
        public Models.CardOrder CardOrderCreate(
                string cardId,
                Models.ContentTypeEnum contentType,
                int quantity)
            => CoreHelper.RunTask(CardOrderCreateAsync(cardId, contentType, quantity));

        /// <summary>
        /// Creates a new card order given information.
        /// </summary>
        /// <param name="cardId">Required parameter: The ID of the card to which the card orders belong..</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: The quantity of cards in the order (minimum 10,000)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardOrder response from the API call.</returns>
        public async Task<Models.CardOrder> CardOrderCreateAsync(
                string cardId,
                Models.ContentTypeEnum contentType,
                int quantity,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardOrder>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/cards/{card_id}/orders")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("card_id", cardId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("quantity", quantity))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}