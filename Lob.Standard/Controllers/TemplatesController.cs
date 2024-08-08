// <copyright file="TemplatesController.cs" company="APIMatic">
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
    /// TemplatesController.
    /// </summary>
    public class TemplatesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesController"/> class.
        /// </summary>
        internal TemplatesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the details of an existing template. You need only supply the unique template identifier that was returned upon template creation.
        /// </summary>
        /// <param name="tmplId">Required parameter: id of the template.</param>
        /// <returns>Returns the Models.Template response from the API call.</returns>
        public Models.Template TemplateRetrieve(
                string tmplId)
            => CoreHelper.RunTask(TemplateRetrieveAsync(tmplId));

        /// <summary>
        /// Retrieves the details of an existing template. You need only supply the unique template identifier that was returned upon template creation.
        /// </summary>
        /// <param name="tmplId">Required parameter: id of the template.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Template response from the API call.</returns>
        public async Task<Models.Template> TemplateRetrieveAsync(
                string tmplId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Template>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/{tmpl_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the description and/or published version of the template with the given id. To update the template's html, create a new version of the template.
        /// </summary>
        /// <param name="tmplId">Required parameter: id of the template.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="publishedVersion">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.Template response from the API call.</returns>
        public Models.Template TemplateUpdate(
                string tmplId,
                Models.ContentTypeEnum contentType,
                string description = null,
                string publishedVersion = null)
            => CoreHelper.RunTask(TemplateUpdateAsync(tmplId, contentType, description, publishedVersion));

        /// <summary>
        /// Updates the description and/or published version of the template with the given id. To update the template's html, create a new version of the template.
        /// </summary>
        /// <param name="tmplId">Required parameter: id of the template.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="publishedVersion">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Template response from the API call.</returns>
        public async Task<Models.Template> TemplateUpdateAsync(
                string tmplId,
                Models.ContentTypeEnum contentType,
                string description = null,
                string publishedVersion = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Template>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/templates/{tmpl_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("published_version", publishedVersion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Permanently deletes a template. Deleting a template also deletes its associated versions. Deleted templates can not be used to create postcard, letter, or check resources.
        /// </summary>
        /// <param name="tmplId">Required parameter: id of the template.</param>
        /// <returns>Returns the Models.TemplatesResponse2 response from the API call.</returns>
        public Models.TemplatesResponse2 TemplateDelete(
                string tmplId)
            => CoreHelper.RunTask(TemplateDeleteAsync(tmplId));

        /// <summary>
        /// Permanently deletes a template. Deleting a template also deletes its associated versions. Deleted templates can not be used to create postcard, letter, or check resources.
        /// </summary>
        /// <param name="tmplId">Required parameter: id of the template.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TemplatesResponse2 response from the API call.</returns>
        public async Task<Models.TemplatesResponse2> TemplateDeleteAsync(
                string tmplId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TemplatesResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/templates/{tmpl_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of your templates. The templates are returned sorted by creation date, with the most recently created templates appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <returns>Returns the Models.AllTemplates response from the API call.</returns>
        public Models.AllTemplates TemplatesList(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null)
            => CoreHelper.RunTask(TemplatesListAsync(limit, beforeAfter, include, dateCreated, metadata));

        /// <summary>
        /// Returns a list of your templates. The templates are returned sorted by creation date, with the most recently created templates appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllTemplates response from the API call.</returns>
        public async Task<Models.AllTemplates> TemplatesListAsync(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllTemplates>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates")
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
        /// <![CDATA[
        /// Creates a new template for use with the Print & Mail API. In Live mode, you can only have as many non-deleted templates as allotted in your current <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a>. If you attempt to create a template past your limit, you will receive a `403` error. There is no limit in Test mode.
        /// ]]>
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="html">Required parameter: An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details: - [Postcards](#operation/postcard_create) - `front` and `back` - [Self Mailers](#operation/self_mailer_create) - `inside` and `outside` - [Letters](#operation/letter_create) - `file` - [Checks](#operation/check_create) - `check_bottom` and `attachment` - [Cards](#operation/card_create) - `front` and `back`  If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="engine">Optional parameter: Example: .</param>
        /// <param name="requiredVars">Optional parameter: An array of required variables to be used in a template. Only available for `handlebars` templates..</param>
        /// <returns>Returns the Models.Template response from the API call.</returns>
        public Models.Template CreateTemplate(
                Models.ContentTypeEnum contentType,
                string html,
                string description = null,
                Dictionary<string, string> metadata = null,
                FileStreamInfo engine = null,
                List<string> requiredVars = null)
            => CoreHelper.RunTask(CreateTemplateAsync(contentType, html, description, metadata, engine, requiredVars));

        /// <summary>
        /// <![CDATA[
        /// Creates a new template for use with the Print & Mail API. In Live mode, you can only have as many non-deleted templates as allotted in your current <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print & Mail Edition</a>. If you attempt to create a template past your limit, you will receive a `403` error. There is no limit in Test mode.
        /// ]]>
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="html">Required parameter: An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details: - [Postcards](#operation/postcard_create) - `front` and `back` - [Self Mailers](#operation/self_mailer_create) - `inside` and `outside` - [Letters](#operation/letter_create) - `file` - [Checks](#operation/check_create) - `check_bottom` and `attachment` - [Cards](#operation/card_create) - `front` and `back`  If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="engine">Optional parameter: Example: .</param>
        /// <param name="requiredVars">Optional parameter: An array of required variables to be used in a template. Only available for `handlebars` templates..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Template response from the API call.</returns>
        public async Task<Models.Template> CreateTemplateAsync(
                Models.ContentTypeEnum contentType,
                string html,
                string description = null,
                Dictionary<string, string> metadata = null,
                FileStreamInfo engine = null,
                List<string> requiredVars = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Template>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/templates")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("html", html))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("metadata", metadata))
                      .Form(_form => _form.Setup("engine", engine))
                      .Form(_form => _form.Setup("required_vars", requiredVars))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}