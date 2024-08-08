// <copyright file="TemplateVersionsController.cs" company="APIMatic">
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
    /// TemplateVersionsController.
    /// </summary>
    public class TemplateVersionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVersionsController"/> class.
        /// </summary>
        internal TemplateVersionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the template version with the given template and version ids.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template to which the version belongs..</param>
        /// <param name="vrsnId">Required parameter: id of the template_version.</param>
        /// <returns>Returns the Models.TemplateVersion response from the API call.</returns>
        public Models.TemplateVersion TemplateVersionRetrieve(
                string tmplId,
                string vrsnId)
            => CoreHelper.RunTask(TemplateVersionRetrieveAsync(tmplId, vrsnId));

        /// <summary>
        /// Retrieves the template version with the given template and version ids.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template to which the version belongs..</param>
        /// <param name="vrsnId">Required parameter: id of the template_version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TemplateVersion response from the API call.</returns>
        public async Task<Models.TemplateVersion> TemplateVersionRetrieveAsync(
                string tmplId,
                string vrsnId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TemplateVersion>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/{tmpl_id}/versions/{vrsn_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))
                      .Template(_template => _template.Setup("vrsn_id", vrsnId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the template version with the given template and version ids.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template to which the version belongs..</param>
        /// <param name="vrsnId">Required parameter: id of the template_version.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="engine">Optional parameter: Example: .</param>
        /// <param name="requiredVars">Optional parameter: An array of required variables to be used in a template. Only available for `handlebars` templates..</param>
        /// <returns>Returns the Models.TemplateVersion response from the API call.</returns>
        public Models.TemplateVersion TemplateVersionUpdate(
                string tmplId,
                string vrsnId,
                Models.ContentTypeEnum contentType,
                string description = null,
                FileStreamInfo engine = null,
                List<string> requiredVars = null)
            => CoreHelper.RunTask(TemplateVersionUpdateAsync(tmplId, vrsnId, contentType, description, engine, requiredVars));

        /// <summary>
        /// Updates the template version with the given template and version ids.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template to which the version belongs..</param>
        /// <param name="vrsnId">Required parameter: id of the template_version.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="engine">Optional parameter: Example: .</param>
        /// <param name="requiredVars">Optional parameter: An array of required variables to be used in a template. Only available for `handlebars` templates..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TemplateVersion response from the API call.</returns>
        public async Task<Models.TemplateVersion> TemplateVersionUpdateAsync(
                string tmplId,
                string vrsnId,
                Models.ContentTypeEnum contentType,
                string description = null,
                FileStreamInfo engine = null,
                List<string> requiredVars = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TemplateVersion>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/templates/{tmpl_id}/versions/{vrsn_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))
                      .Template(_template => _template.Setup("vrsn_id", vrsnId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("engine", engine))
                      .Form(_form => _form.Setup("required_vars", requiredVars))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Permanently deletes a template version. A template's `published_version` can not be deleted.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template to which the version belongs..</param>
        /// <param name="vrsnId">Required parameter: id of the template_version.</param>
        /// <returns>Returns the Models.TemplatesVersionsResponse2 response from the API call.</returns>
        public Models.TemplatesVersionsResponse2 TemplateVersionDelete(
                string tmplId,
                string vrsnId)
            => CoreHelper.RunTask(TemplateVersionDeleteAsync(tmplId, vrsnId));

        /// <summary>
        /// Permanently deletes a template version. A template's `published_version` can not be deleted.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template to which the version belongs..</param>
        /// <param name="vrsnId">Required parameter: id of the template_version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TemplatesVersionsResponse2 response from the API call.</returns>
        public async Task<Models.TemplatesVersionsResponse2> TemplateVersionDeleteAsync(
                string tmplId,
                string vrsnId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TemplatesVersionsResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/templates/{tmpl_id}/versions/{vrsn_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))
                      .Template(_template => _template.Setup("vrsn_id", vrsnId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of template versions for the given template ID. The template versions are sorted by creation date, with the most recently created appearing first.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template associated with the retrieved versions.</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <returns>Returns the Models.AllTemplateVersions response from the API call.</returns>
        public Models.AllTemplateVersions TemplateVersionsList(
                string tmplId,
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null)
            => CoreHelper.RunTask(TemplateVersionsListAsync(tmplId, limit, beforeAfter, include, dateCreated));

        /// <summary>
        /// Returns a list of template versions for the given template ID. The template versions are sorted by creation date, with the most recently created appearing first.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template associated with the retrieved versions.</param>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllTemplateVersions response from the API call.</returns>
        public async Task<Models.AllTemplateVersions> TemplateVersionsListAsync(
                string tmplId,
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllTemplateVersions>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/{tmpl_id}/versions")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("before/after", beforeAfter))
                      .Query(_query => _query.Setup("include", include))
                      .Query(_query => _query.Setup("date_created", dateCreated))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new template version attached to the specified template.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template the new version will be attached to.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="html">Required parameter: An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details: - [Postcards](#operation/postcard_create) - `front` and `back` - [Self Mailers](#operation/self_mailer_create) - `inside` and `outside` - [Letters](#operation/letter_create) - `file` - [Checks](#operation/check_create) - `check_bottom` and `attachment` - [Cards](#operation/card_create) - `front` and `back`  If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="engine">Optional parameter: Example: .</param>
        /// <param name="requiredVars">Optional parameter: An array of required variables to be used in a template. Only available for `handlebars` templates..</param>
        /// <returns>Returns the Models.TemplateVersion response from the API call.</returns>
        public Models.TemplateVersion CreateTemplateVersion(
                string tmplId,
                Models.ContentTypeEnum contentType,
                string html,
                string description = null,
                FileStreamInfo engine = null,
                List<string> requiredVars = null)
            => CoreHelper.RunTask(CreateTemplateVersionAsync(tmplId, contentType, html, description, engine, requiredVars));

        /// <summary>
        /// Creates a new template version attached to the specified template.
        /// </summary>
        /// <param name="tmplId">Required parameter: The ID of the template the new version will be attached to.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="html">Required parameter: An HTML string of less than 100,000 characters to be used as the `published_version` of this template. See [here](#section/HTML-Examples) for guidance on designing HTML templates. Please see endpoint specific documentation for any other product-specific HTML details: - [Postcards](#operation/postcard_create) - `front` and `back` - [Self Mailers](#operation/self_mailer_create) - `inside` and `outside` - [Letters](#operation/letter_create) - `file` - [Checks](#operation/check_create) - `check_bottom` and `attachment` - [Cards](#operation/card_create) - `front` and `back`  If there is a syntax error with your variable names within your HTML, then an error will be thrown, e.g. using a `{{#users}}` opening tag without the corresponding closing tag `{{/users}}`..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="engine">Optional parameter: Example: .</param>
        /// <param name="requiredVars">Optional parameter: An array of required variables to be used in a template. Only available for `handlebars` templates..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TemplateVersion response from the API call.</returns>
        public async Task<Models.TemplateVersion> CreateTemplateVersionAsync(
                string tmplId,
                Models.ContentTypeEnum contentType,
                string html,
                string description = null,
                FileStreamInfo engine = null,
                List<string> requiredVars = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TemplateVersion>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/templates/{tmpl_id}/versions")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("tmpl_id", tmplId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("html", html))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("engine", engine))
                      .Form(_form => _form.Setup("required_vars", requiredVars))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}