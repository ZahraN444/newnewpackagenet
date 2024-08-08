// <copyright file="IdentityValidationController.cs" company="APIMatic">
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
    /// IdentityValidationController.
    /// </summary>
    public class IdentityValidationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityValidationController"/> class.
        /// </summary>
        internal IdentityValidationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Validates whether a given name is associated with an address.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the IdentityValidation response from the API call.</returns>
        public IdentityValidation IdentityValidation(
                object body)
            => CoreHelper.RunTask(IdentityValidationAsync(body));

        /// <summary>
        /// Validates whether a given name is associated with an address.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the IdentityValidation response from the API call.</returns>
        public async Task<IdentityValidation> IdentityValidationAsync(
                object body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<IdentityValidation>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/identity_validation")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}