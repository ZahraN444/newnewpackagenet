// <copyright file="URLShortenerController.cs" company="APIMatic">
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
    /// URLShortenerController.
    /// </summary>
    public class URLShortenerController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="URLShortenerController"/> class.
        /// </summary>
        internal URLShortenerController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve details for a single domain.
        /// </summary>
        /// <param name="domainId">Required parameter: Unique identifier for a domain..</param>
        /// <returns>Returns the Models.DomainResponse response from the API call.</returns>
        public Models.DomainResponse DomainGet(
                string domainId)
            => CoreHelper.RunTask(DomainGetAsync(domainId));

        /// <summary>
        /// Retrieve details for a single domain.
        /// </summary>
        /// <param name="domainId">Required parameter: Unique identifier for a domain..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DomainResponse response from the API call.</returns>
        public async Task<Models.DomainResponse> DomainGetAsync(
                string domainId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DomainResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/domains/{domain_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("domain_id", domainId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a registered domain. This operation can only be performed if all associated links with the domain are deleted.
        /// </summary>
        /// <param name="domainId">Required parameter: Unique identifier for a domain..</param>
        /// <returns>Returns the Models.DomainResponse response from the API call.</returns>
        public Models.DomainResponse DomainDelete(
                string domainId)
            => CoreHelper.RunTask(DomainDeleteAsync(domainId));

        /// <summary>
        /// Delete a registered domain. This operation can only be performed if all associated links with the domain are deleted.
        /// </summary>
        /// <param name="domainId">Required parameter: Unique identifier for a domain..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DomainResponse response from the API call.</returns>
        public async Task<Models.DomainResponse> DomainDeleteAsync(
                string domainId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DomainResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/domains/{domain_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("domain_id", domainId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Add a new custom domain that can be used to create custom links.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="domain">Required parameter: The registered domain/hostname..</param>
        /// <returns>Returns the Models.DomainResponse response from the API call.</returns>
        public Models.DomainResponse DomainCreate(
                Models.ContentTypeEnum contentType,
                string domain)
            => CoreHelper.RunTask(DomainCreateAsync(contentType, domain));

        /// <summary>
        /// Add a new custom domain that can be used to create custom links.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="domain">Required parameter: The registered domain/hostname..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DomainResponse response from the API call.</returns>
        public async Task<Models.DomainResponse> DomainCreateAsync(
                Models.ContentTypeEnum contentType,
                string domain,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DomainResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/domains")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("domain", domain))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a list of all created domains.
        /// </summary>
        /// <returns>Returns the Models.DomainsResponse response from the API call.</returns>
        public Models.DomainsResponse DomainList()
            => CoreHelper.RunTask(DomainListAsync());

        /// <summary>
        /// Retrieve a list of all created domains.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DomainsResponse response from the API call.</returns>
        public async Task<Models.DomainsResponse> DomainListAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DomainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/domains")
                  .WithAuth("basicAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete all associated links for a domain.
        /// </summary>
        /// <param name="domainId">Required parameter: Unique identifier for a domain..</param>
        /// <returns>Returns the Models.DomainsResponse response from the API call.</returns>
        public Models.DomainsResponse DomainDeleteLinks(
                string domainId)
            => CoreHelper.RunTask(DomainDeleteLinksAsync(domainId));

        /// <summary>
        /// Delete all associated links for a domain.
        /// </summary>
        /// <param name="domainId">Required parameter: Unique identifier for a domain..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DomainsResponse response from the API call.</returns>
        public async Task<Models.DomainsResponse> DomainDeleteLinksAsync(
                string domainId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DomainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/domains/{domain_id}/links")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("domain_id", domainId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new DomainsLinks0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves a list of shortened links. The list is sorted by  creation date, with the most recently created appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <param name="campaignId">Optional parameter: Filter the links generated for a particular campaign using its campaign id..</param>
        /// <param name="clicked">Optional parameter: Retrieve the list of links that have been opened..</param>
        /// <param name="billingGroupId">Optional parameter: Filter the links generated for a particular billing group id..</param>
        /// <returns>Returns the Models.LinksResponse response from the API call.</returns>
        public Models.LinksResponse LinksList(
                int? limit = 10,
                int? offset = 0,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null,
                string campaignId = null,
                bool? clicked = null,
                string billingGroupId = null)
            => CoreHelper.RunTask(LinksListAsync(limit, offset, include, dateCreated, metadata, campaignId, clicked, billingGroupId));

        /// <summary>
        /// Retrieves a list of shortened links. The list is sorted by  creation date, with the most recently created appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="offset">Optional parameter: An integer that designates the offset at which to begin returning results. Defaults to 0..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <param name="campaignId">Optional parameter: Filter the links generated for a particular campaign using its campaign id..</param>
        /// <param name="clicked">Optional parameter: Retrieve the list of links that have been opened..</param>
        /// <param name="billingGroupId">Optional parameter: Filter the links generated for a particular billing group id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LinksResponse response from the API call.</returns>
        public async Task<Models.LinksResponse> LinksListAsync(
                int? limit = 10,
                int? offset = 0,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null,
                string campaignId = null,
                bool? clicked = null,
                string billingGroupId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LinksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/links")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("offset", offset ?? 0))
                      .Query(_query => _query.Setup("include", include))
                      .Query(_query => _query.Setup("date_created", dateCreated))
                      .Query(_query => _query.Setup("metadata", metadata))
                      .Query(_query => _query.Setup("campaign_id", campaignId))
                      .Query(_query => _query.Setup("clicked", clicked))
                      .Query(_query => _query.Setup("billing_group_id", billingGroupId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Links0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrievs a single shortened link.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier for a link..</param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public Models.LinkResponse LinksGet(
                string linkId)
            => CoreHelper.RunTask(LinksGetAsync(linkId));

        /// <summary>
        /// Retrievs a single shortened link.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier for a link..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public async Task<Models.LinkResponse> LinksGetAsync(
                string linkId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LinkResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/links/{link_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("link_id", linkId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Links0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update any of the properties of a shortened link.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier for a link..</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="redirectLink">Required parameter: The original target URL..</param>
        /// <param name="domain">Optional parameter: The registered domain to be used for the short URL..</param>
        /// <param name="slug">Optional parameter: The unique path for the shortened URL, if empty a unique path will be used..</param>
        /// <param name="metadataTag">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="billingGroupId">Optional parameter: An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information..</param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public Models.LinkResponse LinkUpdate(
                string linkId,
                Models.ContentTypeEnum contentType,
                string redirectLink,
                string domain = null,
                string slug = null,
                Dictionary<string, string> metadataTag = null,
                string billingGroupId = null)
            => CoreHelper.RunTask(LinkUpdateAsync(linkId, contentType, redirectLink, domain, slug, metadataTag, billingGroupId));

        /// <summary>
        /// Update any of the properties of a shortened link.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier for a link..</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="redirectLink">Required parameter: The original target URL..</param>
        /// <param name="domain">Optional parameter: The registered domain to be used for the short URL..</param>
        /// <param name="slug">Optional parameter: The unique path for the shortened URL, if empty a unique path will be used..</param>
        /// <param name="metadataTag">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="billingGroupId">Optional parameter: An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public async Task<Models.LinkResponse> LinkUpdateAsync(
                string linkId,
                Models.ContentTypeEnum contentType,
                string redirectLink,
                string domain = null,
                string slug = null,
                Dictionary<string, string> metadataTag = null,
                string billingGroupId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LinkResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/links/{link_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("link_id", linkId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("redirect_link", redirectLink))
                      .Form(_form => _form.Setup("domain", domain))
                      .Form(_form => _form.Setup("slug", slug))
                      .Form(_form => _form.Setup("metadata_tag", metadataTag))
                      .Form(_form => _form.Setup("billing_group_id", billingGroupId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete the shortened link.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier for a link..</param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public Models.LinkResponse LinksDelete(
                string linkId)
            => CoreHelper.RunTask(LinksDeleteAsync(linkId));

        /// <summary>
        /// Delete the shortened link.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier for a link..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public async Task<Models.LinkResponse> LinksDeleteAsync(
                string linkId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LinkResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/links/{link_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("link_id", linkId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Links0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Given a long URL, shorten your URL either by using a custom domain or Lob's own short domain.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="redirectLink">Required parameter: The original target URL..</param>
        /// <param name="domain">Optional parameter: The registered domain to be used for the short URL..</param>
        /// <param name="slug">Optional parameter: The unique path for the shortened URL, if empty a unique path will be used..</param>
        /// <param name="metadataTag">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="billingGroupId">Optional parameter: An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information..</param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public Models.LinkResponse LinkCreate(
                Models.ContentTypeEnum contentType,
                string redirectLink,
                string domain = null,
                string slug = null,
                Dictionary<string, string> metadataTag = null,
                string billingGroupId = null)
            => CoreHelper.RunTask(LinkCreateAsync(contentType, redirectLink, domain, slug, metadataTag, billingGroupId));

        /// <summary>
        /// Given a long URL, shorten your URL either by using a custom domain or Lob's own short domain.
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="redirectLink">Required parameter: The original target URL..</param>
        /// <param name="domain">Optional parameter: The registered domain to be used for the short URL..</param>
        /// <param name="slug">Optional parameter: The unique path for the shortened URL, if empty a unique path will be used..</param>
        /// <param name="metadataTag">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="billingGroupId">Optional parameter: An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See <a href="#tag/Billing-Groups">Billing Group API</a> for more information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LinkResponse response from the API call.</returns>
        public async Task<Models.LinkResponse> LinkCreateAsync(
                Models.ContentTypeEnum contentType,
                string redirectLink,
                string domain = null,
                string slug = null,
                Dictionary<string, string> metadataTag = null,
                string billingGroupId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LinkResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/links/shorten")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("redirect_link", redirectLink))
                      .Form(_form => _form.Setup("domain", domain))
                      .Form(_form => _form.Setup("slug", slug))
                      .Form(_form => _form.Setup("metadata_tag", metadataTag))
                      .Form(_form => _form.Setup("billing_group_id", billingGroupId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Shortens a list of links in a single request.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.LinksResponse response from the API call.</returns>
        public Models.LinksResponse LinkBulkCreate(
                List<Models.LinkSingle> body)
            => CoreHelper.RunTask(LinkBulkCreateAsync(body));

        /// <summary>
        /// Shortens a list of links in a single request.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LinksResponse response from the API call.</returns>
        public async Task<Models.LinksResponse> LinkBulkCreateAsync(
                List<Models.LinkSingle> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LinksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/links/shorten/bulk")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}