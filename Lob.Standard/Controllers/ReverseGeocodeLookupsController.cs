// <copyright file="ReverseGeocodeLookupsController.cs" company="APIMatic">
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
    /// ReverseGeocodeLookupsController.
    /// </summary>
    public class ReverseGeocodeLookupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeLookupsController"/> class.
        /// </summary>
        internal ReverseGeocodeLookupsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Reverse geocode a valid US location with a live API key.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="latitude">Required parameter: A positive or negative decimal indicating the geographic latitude of the address, specifying the north-to-south position of a location. This should be input with `longitude` to pinpoint locations on a map..</param>
        /// <param name="longitude">Required parameter: A positive or negative decimal indicating the geographic longitude of the address, specifying the north-to-south position of a location. This should be input with `latitude` to pinpoint locations on a map..</param>
        /// <param name="size">Optional parameter: Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations..</param>
        /// <returns>Returns the Models.ReverseGeocode response from the API call.</returns>
        public Models.ReverseGeocode ReverseGeocodeLookup(
                Models.ContentTypeEnum contentType,
                double? latitude,
                double? longitude,
                int? size = 5)
            => CoreHelper.RunTask(ReverseGeocodeLookupAsync(contentType, latitude, longitude, size));

        /// <summary>
        /// Reverse geocode a valid US location with a live API key.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="latitude">Required parameter: A positive or negative decimal indicating the geographic latitude of the address, specifying the north-to-south position of a location. This should be input with `longitude` to pinpoint locations on a map..</param>
        /// <param name="longitude">Required parameter: A positive or negative decimal indicating the geographic longitude of the address, specifying the north-to-south position of a location. This should be input with `latitude` to pinpoint locations on a map..</param>
        /// <param name="size">Optional parameter: Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReverseGeocode response from the API call.</returns>
        public async Task<Models.ReverseGeocode> ReverseGeocodeLookupAsync(
                Models.ContentTypeEnum contentType,
                double? latitude,
                double? longitude,
                int? size = 5,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReverseGeocode>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/us_reverse_geocode_lookups")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("latitude", latitude))
                      .Form(_form => _form.Setup("longitude", longitude))
                      .Query(_query => _query.Setup("size", size ?? 5))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}