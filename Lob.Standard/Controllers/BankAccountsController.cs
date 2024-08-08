// <copyright file="BankAccountsController.cs" company="APIMatic">
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
    /// BankAccountsController.
    /// </summary>
    public class BankAccountsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountsController"/> class.
        /// </summary>
        internal BankAccountsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Verify a bank account in order to create a check.
        /// </summary>
        /// <param name="bankId">Required parameter: id of the bank account to be verified.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="amounts">Required parameter: In live mode, an array containing the two micro deposits (in cents) placed in the bank account. In test mode, no micro deposits will be placed, so any two integers between `1` and `100` will work..</param>
        /// <returns>Returns the Models.BankAccount response from the API call.</returns>
        public Models.BankAccount BankAccountVerify(
                string bankId,
                Models.ContentTypeEnum contentType,
                List<int> amounts)
            => CoreHelper.RunTask(BankAccountVerifyAsync(bankId, contentType, amounts));

        /// <summary>
        /// Verify a bank account in order to create a check.
        /// </summary>
        /// <param name="bankId">Required parameter: id of the bank account to be verified.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="amounts">Required parameter: In live mode, an array containing the two micro deposits (in cents) placed in the bank account. In test mode, no micro deposits will be placed, so any two integers between `1` and `100` will work..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccount response from the API call.</returns>
        public async Task<Models.BankAccount> BankAccountVerifyAsync(
                string bankId,
                Models.ContentTypeEnum contentType,
                List<int> amounts,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccount>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/bank_accounts/{bank_id}/verify")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("bank_id", bankId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("amounts", amounts))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing bank account. You need only supply the unique bank account identifier that was returned upon bank account creation.
        /// </summary>
        /// <param name="bankId">Required parameter: id of the bank account.</param>
        /// <returns>Returns the Models.BankAccount response from the API call.</returns>
        public Models.BankAccount BankAccountRetrieve(
                string bankId)
            => CoreHelper.RunTask(BankAccountRetrieveAsync(bankId));

        /// <summary>
        /// Retrieves the details of an existing bank account. You need only supply the unique bank account identifier that was returned upon bank account creation.
        /// </summary>
        /// <param name="bankId">Required parameter: id of the bank account.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccount response from the API call.</returns>
        public async Task<Models.BankAccount> BankAccountRetrieveAsync(
                string bankId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccount>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/bank_accounts/{bank_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("bank_id", bankId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Permanently deletes a bank account. It cannot be undone.
        /// </summary>
        /// <param name="bankId">Required parameter: id of the bank account.</param>
        /// <returns>Returns the Models.BankAccountsResponse1 response from the API call.</returns>
        public Models.BankAccountsResponse1 BankAccountDelete(
                string bankId)
            => CoreHelper.RunTask(BankAccountDeleteAsync(bankId));

        /// <summary>
        /// Permanently deletes a bank account. It cannot be undone.
        /// </summary>
        /// <param name="bankId">Required parameter: id of the bank account.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountsResponse1 response from the API call.</returns>
        public async Task<Models.BankAccountsResponse1> BankAccountDeleteAsync(
                string bankId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/bank_accounts/{bank_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("bank_id", bankId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of your bank accounts. The bank accounts are returned sorted by creation date, with the most recently created bank accounts appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <returns>Returns the Models.AllBankAccounts response from the API call.</returns>
        public Models.AllBankAccounts BankAccountsList(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null)
            => CoreHelper.RunTask(BankAccountsListAsync(limit, beforeAfter, include, dateCreated, metadata));

        /// <summary>
        /// Returns a list of your bank accounts. The bank accounts are returned sorted by creation date, with the most recently created bank accounts appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="dateCreated"><![CDATA[Optional parameter: Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤..]]></param>
        /// <param name="metadata">Optional parameter: Filter by metadata key-value pair`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllBankAccounts response from the API call.</returns>
        public async Task<Models.AllBankAccounts> BankAccountsListAsync(
                int? limit = 10,
                Models.Beforeafter beforeAfter = null,
                List<string> include = null,
                Dictionary<string, string> dateCreated = null,
                Dictionary<string, string> metadata = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllBankAccounts>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/bank_accounts")
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
        /// Creates a new bank account with the provided properties. Bank accounts created in live mode will need to be verified via micro deposits before being able to send live checks. The deposits will appear in the bank account in 2-3 business days and have the description "VERIFICATION".
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="routingNumber">Required parameter: Must be a <a href="https://www.frbservices.org/index.html" target="_blank">valid US routing number</a>..</param>
        /// <param name="accountNumber">Required parameter: Example: .</param>
        /// <param name="accountType">Required parameter: Example: .</param>
        /// <param name="signatory">Required parameter: The signatory associated with your account. This name will be printed on checks created with this bank account. If you prefer to use a custom signature image on your checks instead, please create your bank account from the <a href="https://dashboard.lob.com/#/login" target="_blank">Dashboard</a>..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="checkTemplate">Optional parameter: Example: .</param>
        /// <param name="fractionalRoutingNumber">Optional parameter: The fractional routing number for your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the fractional routing number associated with your home bank institution..</param>
        /// <param name="city">Optional parameter: The city associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the city associated with your home bank institution..</param>
        /// <param name="state">Optional parameter: The state associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the state associated with your home bank institution..</param>
        /// <param name="zipcode">Optional parameter: The zipcode associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the zipcode associated with your home bank institution..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <returns>Returns the Models.BankAccount response from the API call.</returns>
        public Models.BankAccount BankAccountCreate(
                Models.ContentTypeEnum contentType,
                string routingNumber,
                string accountNumber,
                Models.AccountTypeEnum accountType,
                string signatory,
                string description = null,
                Models.CheckTemplateEnum? checkTemplate = null,
                string fractionalRoutingNumber = null,
                string city = null,
                string state = null,
                string zipcode = null,
                Dictionary<string, string> metadata = null)
            => CoreHelper.RunTask(BankAccountCreateAsync(contentType, routingNumber, accountNumber, accountType, signatory, description, checkTemplate, fractionalRoutingNumber, city, state, zipcode, metadata));

        /// <summary>
        /// Creates a new bank account with the provided properties. Bank accounts created in live mode will need to be verified via micro deposits before being able to send live checks. The deposits will appear in the bank account in 2-3 business days and have the description "VERIFICATION".
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="routingNumber">Required parameter: Must be a <a href="https://www.frbservices.org/index.html" target="_blank">valid US routing number</a>..</param>
        /// <param name="accountNumber">Required parameter: Example: .</param>
        /// <param name="accountType">Required parameter: Example: .</param>
        /// <param name="signatory">Required parameter: The signatory associated with your account. This name will be printed on checks created with this bank account. If you prefer to use a custom signature image on your checks instead, please create your bank account from the <a href="https://dashboard.lob.com/#/login" target="_blank">Dashboard</a>..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="checkTemplate">Optional parameter: Example: .</param>
        /// <param name="fractionalRoutingNumber">Optional parameter: The fractional routing number for your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the fractional routing number associated with your home bank institution..</param>
        /// <param name="city">Optional parameter: The city associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the city associated with your home bank institution..</param>
        /// <param name="state">Optional parameter: The state associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the state associated with your home bank institution..</param>
        /// <param name="zipcode">Optional parameter: The zipcode associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the zipcode associated with your home bank institution..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccount response from the API call.</returns>
        public async Task<Models.BankAccount> BankAccountCreateAsync(
                Models.ContentTypeEnum contentType,
                string routingNumber,
                string accountNumber,
                Models.AccountTypeEnum accountType,
                string signatory,
                string description = null,
                Models.CheckTemplateEnum? checkTemplate = null,
                string fractionalRoutingNumber = null,
                string city = null,
                string state = null,
                string zipcode = null,
                Dictionary<string, string> metadata = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccount>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/bank_accounts")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("routing_number", routingNumber))
                      .Form(_form => _form.Setup("account_number", accountNumber))
                      .Form(_form => _form.Setup("account_type", ApiHelper.JsonSerialize(accountType).Trim('\"')))
                      .Form(_form => _form.Setup("signatory", signatory))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("check_template", (checkTemplate.HasValue) ? ApiHelper.JsonSerialize(checkTemplate.Value).Trim('\"') : null))
                      .Form(_form => _form.Setup("fractional_routing_number", fractionalRoutingNumber))
                      .Form(_form => _form.Setup("city", city))
                      .Form(_form => _form.Setup("state", state))
                      .Form(_form => _form.Setup("zipcode", zipcode))
                      .Form(_form => _form.Setup("metadata", metadata))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}