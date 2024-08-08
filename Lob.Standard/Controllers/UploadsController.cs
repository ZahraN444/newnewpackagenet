// <copyright file="UploadsController.cs" company="APIMatic">
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
    /// UploadsController.
    /// </summary>
    public class UploadsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsController"/> class.
        /// </summary>
        internal UploadsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of your uploads. Optionally, filter uploads by campaign.
        /// </summary>
        /// <param name="campaignId">Optional parameter: id of the campaign.</param>
        /// <returns>Returns the List of Models.Upload response from the API call.</returns>
        public List<Models.Upload> UploadsList(
                string campaignId = null)
            => CoreHelper.RunTask(UploadsListAsync(campaignId));

        /// <summary>
        /// Returns a list of your uploads. Optionally, filter uploads by campaign.
        /// </summary>
        /// <param name="campaignId">Optional parameter: id of the campaign.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Upload response from the API call.</returns>
        public async Task<List<Models.Upload>> UploadsListAsync(
                string campaignId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Upload>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/uploads")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("campaignId", campaignId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new upload with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Upload response from the API call.</returns>
        public Models.Upload UploadCreate(
                Models.UploadWritable body)
            => CoreHelper.RunTask(UploadCreateAsync(body));

        /// <summary>
        /// Creates a new upload with the provided properties.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Upload response from the API call.</returns>
        public async Task<Models.Upload> UploadCreateAsync(
                Models.UploadWritable body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Upload>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/uploads")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Validation Error", (_reason, _context) => new HTTPValidationError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing upload. You need only supply the unique upload identifier that was returned upon upload creation.
        /// </summary>
        /// <param name="uplId">Required parameter: id of the upload.</param>
        /// <returns>Returns the Models.Upload response from the API call.</returns>
        public Models.Upload UploadRetrieve(
                string uplId)
            => CoreHelper.RunTask(UploadRetrieveAsync(uplId));

        /// <summary>
        /// Retrieves the details of an existing upload. You need only supply the unique upload identifier that was returned upon upload creation.
        /// </summary>
        /// <param name="uplId">Required parameter: id of the upload.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Upload response from the API call.</returns>
        public async Task<Models.Upload> UploadRetrieveAsync(
                string uplId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Upload>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/uploads/{upl_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("upl_id", uplId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation Error", (_reason, _context) => new HTTPValidationError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update the details of an existing upload. You need only supply the unique identifier that was returned upon upload creation.
        /// </summary>
        /// <param name="uplId">Required parameter: id of the upload.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Upload response from the API call.</returns>
        public Models.Upload UploadUpdate(
                string uplId,
                Models.UploadUpdatable body)
            => CoreHelper.RunTask(UploadUpdateAsync(uplId, body));

        /// <summary>
        /// Update the details of an existing upload. You need only supply the unique identifier that was returned upon upload creation.
        /// </summary>
        /// <param name="uplId">Required parameter: id of the upload.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Upload response from the API call.</returns>
        public async Task<Models.Upload> UploadUpdateAsync(
                string uplId,
                Models.UploadUpdatable body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Upload>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/uploads/{upl_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("upl_id", uplId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation Error", (_reason, _context) => new HTTPValidationError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an existing upload. You need only supply the unique identifier that was returned upon upload creation.
        /// </summary>
        /// <param name="uplId">Required parameter: id of the upload.</param>
        public void UploadDelete(
                string uplId)
            => CoreHelper.RunVoidTask(UploadDeleteAsync(uplId));

        /// <summary>
        /// Delete an existing upload. You need only supply the unique identifier that was returned upon upload creation.
        /// </summary>
        /// <param name="uplId">Required parameter: id of the upload.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UploadDeleteAsync(
                string uplId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/uploads/{upl_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("upl_id", uplId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Upload an [audience file](https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide) and associate it with an upload.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="file">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.UploadFile response from the API call.</returns>
        public Models.UploadFile UploadFile(
                string uplId,
                FileStreamInfo file = null)
            => CoreHelper.RunTask(UploadFileAsync(uplId, file));

        /// <summary>
        /// Upload an [audience file](https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide) and associate it with an upload.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="file">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UploadFile response from the API call.</returns>
        public async Task<Models.UploadFile> UploadFileAsync(
                string uplId,
                FileStreamInfo file = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UploadFile>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/uploads/{upl_id}/file")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("upl_id", uplId))
                      .Form(_form => _form.Setup("file", file))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Validation Error", (_reason, _context) => new HTTPValidationError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Campaign Exports can help you understand exactly which records in a campaign could not be created. By initiating and retrieving an export, you will get row-by-row errors for your campaign. For a step-by-step walkthrough of creating a campaign and exporting failures, see our [Campaigns Guide](https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/launch-your-first-campaign).
        /// Create an export file associated with an upload.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UploadCreateExport response from the API call.</returns>
        public Models.UploadCreateExport UploadExportCreate(
                string uplId,
                Models.UploadsExportsRequest body)
            => CoreHelper.RunTask(UploadExportCreateAsync(uplId, body));

        /// <summary>
        /// Campaign Exports can help you understand exactly which records in a campaign could not be created. By initiating and retrieving an export, you will get row-by-row errors for your campaign. For a step-by-step walkthrough of creating a campaign and exporting failures, see our [Campaigns Guide](https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/launch-your-first-campaign).
        /// Create an export file associated with an upload.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UploadCreateExport response from the API call.</returns>
        public async Task<Models.UploadCreateExport> UploadExportCreateAsync(
                string uplId,
                Models.UploadsExportsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UploadCreateExport>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/uploads/{upl_id}/exports")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("upl_id", uplId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("402", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("405", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("407", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("408", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("410", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("411", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("412", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("413", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("414", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("416", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("417", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("418", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("419", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("420", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("421", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("423", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("424", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("425", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("426", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("427", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("428", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("430", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("431", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("432", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("433", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("434", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("435", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("436", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("437", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("438", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("439", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("440", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("441", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("442", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("443", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("444", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("445", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("446", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("447", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("448", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("449", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("450", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("451", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("452", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("453", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("454", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("455", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("456", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("457", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("458", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("459", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("460", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("461", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("462", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("463", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("464", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("465", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("466", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("467", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("468", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("469", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("470", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("471", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("472", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("473", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("474", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("475", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("476", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("477", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("478", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("479", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("480", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("481", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("482", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("483", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("484", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("485", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("486", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("487", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("488", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("489", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("490", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("491", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("492", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("493", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("494", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("495", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("496", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("497", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("498", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context)))
                  .ErrorCase("499", CreateErrorCase("Create Export Error", (_reason, _context) => new UploadExportError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the line item data for each row from the csv file associated with the upload id record. NOTE: This endpoint is currently feature flagged. Please reach out to Lob's support team if you  would like access to this API endpoint.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="status">Optional parameter: The status of line items to filter and retrieve. By default all line items are returned..</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <returns>Returns the Models.UploadsReportResponse response from the API call.</returns>
        public Models.UploadsReportResponse ReportRetrieve(
                string uplId,
                Models.Status31Enum? status = null,
                int? limit = 100,
                int? offset = 0)
            => CoreHelper.RunTask(ReportRetrieveAsync(uplId, status, limit, offset));

        /// <summary>
        /// Retrieves the line item data for each row from the csv file associated with the upload id record. NOTE: This endpoint is currently feature flagged. Please reach out to Lob's support team if you  would like access to this API endpoint.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="status">Optional parameter: The status of line items to filter and retrieve. By default all line items are returned..</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UploadsReportResponse response from the API call.</returns>
        public async Task<Models.UploadsReportResponse> ReportRetrieveAsync(
                string uplId,
                Models.Status31Enum? status = null,
                int? limit = 100,
                int? offset = 0,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UploadsReportResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/uploads/{upl_id}/report")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("upl_id", uplId))
                      .Query(_query => _query.Setup("status", (status.HasValue) ? ApiHelper.JsonSerialize(status.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("limit", limit ?? 100))
                      .Query(_query => _query.Setup("offset", offset ?? 0))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden Error", (_reason, _context) => new UploadsReport403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing export. You need only supply the unique export identifier that was returned upon export creation. If you try retrieving an export immediately after creating one (i.e., before we're done processing the export), you will get back an export object with `state = in_progress`.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="exId">Required parameter: ID of the export.</param>
        /// <returns>Returns the Models.UploadsExportsResponse response from the API call.</returns>
        public Models.UploadsExportsResponse ExportRetrieve(
                string uplId,
                string exId)
            => CoreHelper.RunTask(ExportRetrieveAsync(uplId, exId));

        /// <summary>
        /// Retrieves the details of an existing export. You need only supply the unique export identifier that was returned upon export creation. If you try retrieving an export immediately after creating one (i.e., before we're done processing the export), you will get back an export object with `state = in_progress`.
        /// </summary>
        /// <param name="uplId">Required parameter: ID of the upload.</param>
        /// <param name="exId">Required parameter: ID of the export.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UploadsExportsResponse response from the API call.</returns>
        public async Task<Models.UploadsExportsResponse> ExportRetrieveAsync(
                string uplId,
                string exId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UploadsExportsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/uploads/{upl_id}/exports/{ex_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("upl_id", uplId))
                      .Template(_template => _template.Setup("ex_id", exId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}