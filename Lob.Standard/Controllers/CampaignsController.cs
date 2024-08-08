// <copyright file="CampaignsController.cs" company="APIMatic">
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
    /// CampaignsController.
    /// </summary>
    public class CampaignsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsController"/> class.
        /// </summary>
        internal CampaignsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of your campaigns. The campaigns are returned sorted by creation date, with the most recently created campaigns appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <returns>Returns the Models.AllCampaigns response from the API call.</returns>
        public Models.AllCampaigns CampaignsList(
                int? limit = 10,
                List<string> include = null,
                Models.Beforeafter beforeAfter = null)
            => CoreHelper.RunTask(CampaignsListAsync(limit, include, beforeAfter));

        /// <summary>
        /// Returns a list of your campaigns. The campaigns are returned sorted by creation date, with the most recently created campaigns appearing first.
        /// </summary>
        /// <param name="limit">Optional parameter: How many results to return..</param>
        /// <param name="include">Optional parameter: Request that the response include the total count by specifying `include=["total_count"]`..</param>
        /// <param name="beforeAfter">Optional parameter: `before` and `after` are both optional but only one of them can be in the query at a time..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllCampaigns response from the API call.</returns>
        public async Task<Models.AllCampaigns> CampaignsListAsync(
                int? limit = 10,
                List<string> include = null,
                Models.Beforeafter beforeAfter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllCampaigns>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/campaigns")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 10))
                      .Query(_query => _query.Setup("include", include))
                      .Query(_query => _query.Setup("before/after", beforeAfter))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new campaign with the provided properties. See how to launch your first campaign [here](https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/launch-your-first-campaign).
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Name of the campaign..</param>
        /// <param name="scheduleType">Required parameter: Example: .</param>
        /// <param name="useType">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <param name="billingGroupId">Optional parameter: Unique identifier prefixed with `bg_`..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="targetDeliveryDate">Optional parameter: If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign..</param>
        /// <param name="sendDate">Optional parameter: If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign..</param>
        /// <param name="cancelWindowCampaignMinutes">Optional parameter: A window, in minutes, within which the campaign can be canceled..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="autoCancelIfNcoa">Optional parameter: Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA..</param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public Models.Campaign CampaignCreate(
                Models.ContentTypeEnum contentType,
                string name,
                Models.CmpScheduleTypeEnum scheduleType,
                FileStreamInfo useType,
                Models.XLangOutput1Enum? xLangOutput = null,
                string billingGroupId = null,
                string description = null,
                DateTime? targetDeliveryDate = null,
                DateTime? sendDate = null,
                int? cancelWindowCampaignMinutes = null,
                Dictionary<string, string> metadata = null,
                bool? autoCancelIfNcoa = null)
            => CoreHelper.RunTask(CampaignCreateAsync(contentType, name, scheduleType, useType, xLangOutput, billingGroupId, description, targetDeliveryDate, sendDate, cancelWindowCampaignMinutes, metadata, autoCancelIfNcoa));

        /// <summary>
        /// Creates a new campaign with the provided properties. See how to launch your first campaign [here](https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/launch-your-first-campaign).
        /// </summary>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Name of the campaign..</param>
        /// <param name="scheduleType">Required parameter: Example: .</param>
        /// <param name="useType">Required parameter: Example: .</param>
        /// <param name="xLangOutput">Optional parameter: * `native` - Translate response to the native language of the country in the request * `match` - match the response to the language in the request  Default response is in English..</param>
        /// <param name="billingGroupId">Optional parameter: Unique identifier prefixed with `bg_`..</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="targetDeliveryDate">Optional parameter: If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign..</param>
        /// <param name="sendDate">Optional parameter: If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign..</param>
        /// <param name="cancelWindowCampaignMinutes">Optional parameter: A window, in minutes, within which the campaign can be canceled..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="autoCancelIfNcoa">Optional parameter: Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public async Task<Models.Campaign> CampaignCreateAsync(
                Models.ContentTypeEnum contentType,
                string name,
                Models.CmpScheduleTypeEnum scheduleType,
                FileStreamInfo useType,
                Models.XLangOutput1Enum? xLangOutput = null,
                string billingGroupId = null,
                string description = null,
                DateTime? targetDeliveryDate = null,
                DateTime? sendDate = null,
                int? cancelWindowCampaignMinutes = null,
                Dictionary<string, string> metadata = null,
                bool? autoCancelIfNcoa = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Campaign>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/campaigns")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("name", name))
                      .Form(_form => _form.Setup("schedule_type", ApiHelper.JsonSerialize(scheduleType).Trim('\"')))
                      .Form(_form => _form.Setup("use_type", useType))
                      .Header(_header => _header.Setup("x-lang-output", (xLangOutput.HasValue) ? ApiHelper.JsonSerialize(xLangOutput.Value).Trim('\"') : null))
                      .Form(_form => _form.Setup("billing_group_id", billingGroupId))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("target_delivery_date", targetDeliveryDate.HasValue ? targetDeliveryDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Form(_form => _form.Setup("send_date", sendDate.HasValue ? sendDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Form(_form => _form.Setup("cancel_window_campaign_minutes", cancelWindowCampaignMinutes))
                      .Form(_form => _form.Setup("metadata", metadata))
                      .Form(_form => _form.Setup("auto_cancel_if_ncoa", autoCancelIfNcoa))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the details of an existing campaign. You need only supply the unique campaign identifier that was returned upon campaign creation.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public Models.Campaign CampaignRetrieve(
                string cmpId)
            => CoreHelper.RunTask(CampaignRetrieveAsync(cmpId));

        /// <summary>
        /// Retrieves the details of an existing campaign. You need only supply the unique campaign identifier that was returned upon campaign creation.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public async Task<Models.Campaign> CampaignRetrieveAsync(
                string cmpId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Campaign>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/campaigns/{cmp_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("cmp_id", cmpId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update the details of an existing campaign. You need only supply the unique identifier that was returned upon campaign creation.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="scheduleType">Optional parameter: Example: .</param>
        /// <param name="targetDeliveryDate">Optional parameter: If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign..</param>
        /// <param name="sendDate">Optional parameter: If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign..</param>
        /// <param name="cancelWindowCampaignMinutes">Optional parameter: A window, in minutes, within which the campaign can be canceled..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="isDraft">Optional parameter: Whether or not the campaign is still a draft. Can either be excluded or `false`..</param>
        /// <param name="useType">Optional parameter: Example: .</param>
        /// <param name="autoCancelIfNcoa">Optional parameter: Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA..</param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public Models.Campaign CampaignUpdate(
                string cmpId,
                Models.ContentTypeEnum contentType,
                string name = null,
                string description = null,
                Models.CmpScheduleTypeEnum? scheduleType = null,
                DateTime? targetDeliveryDate = null,
                DateTime? sendDate = null,
                int? cancelWindowCampaignMinutes = null,
                Dictionary<string, string> metadata = null,
                bool? isDraft = null,
                FileStreamInfo useType = null,
                bool? autoCancelIfNcoa = null)
            => CoreHelper.RunTask(CampaignUpdateAsync(cmpId, contentType, name, description, scheduleType, targetDeliveryDate, sendDate, cancelWindowCampaignMinutes, metadata, isDraft, useType, autoCancelIfNcoa));

        /// <summary>
        /// Update the details of an existing campaign. You need only supply the unique identifier that was returned upon campaign creation.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <param name="contentType">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="description">Optional parameter: An internal description that identifies this resource. Must be no longer than 255 characters..</param>
        /// <param name="scheduleType">Optional parameter: Example: .</param>
        /// <param name="targetDeliveryDate">Optional parameter: If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign..</param>
        /// <param name="sendDate">Optional parameter: If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign..</param>
        /// <param name="cancelWindowCampaignMinutes">Optional parameter: A window, in minutes, within which the campaign can be canceled..</param>
        /// <param name="metadata">Optional parameter: Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="isDraft">Optional parameter: Whether or not the campaign is still a draft. Can either be excluded or `false`..</param>
        /// <param name="useType">Optional parameter: Example: .</param>
        /// <param name="autoCancelIfNcoa">Optional parameter: Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public async Task<Models.Campaign> CampaignUpdateAsync(
                string cmpId,
                Models.ContentTypeEnum contentType,
                string name = null,
                string description = null,
                Models.CmpScheduleTypeEnum? scheduleType = null,
                DateTime? targetDeliveryDate = null,
                DateTime? sendDate = null,
                int? cancelWindowCampaignMinutes = null,
                Dictionary<string, string> metadata = null,
                bool? isDraft = null,
                FileStreamInfo useType = null,
                bool? autoCancelIfNcoa = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Campaign>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/campaigns/{cmp_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("cmp_id", cmpId))
                      .Header(_header => _header.Setup("Content-Type", ApiHelper.JsonSerialize(contentType).Trim('\"')))
                      .Form(_form => _form.Setup("name", name))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("schedule_type", (scheduleType.HasValue) ? ApiHelper.JsonSerialize(scheduleType.Value).Trim('\"') : null))
                      .Form(_form => _form.Setup("target_delivery_date", targetDeliveryDate.HasValue ? targetDeliveryDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Form(_form => _form.Setup("send_date", sendDate.HasValue ? sendDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Form(_form => _form.Setup("cancel_window_campaign_minutes", cancelWindowCampaignMinutes))
                      .Form(_form => _form.Setup("metadata", metadata))
                      .Form(_form => _form.Setup("is_draft", isDraft))
                      .Form(_form => _form.Setup("use_type", useType))
                      .Form(_form => _form.Setup("auto_cancel_if_ncoa", autoCancelIfNcoa))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an existing campaign. You need only supply the unique identifier that was returned upon campaign creation. Deleting a campaign also deletes any associated mail pieces that have been created but not sent. A campaign's `send_date` matches its associated mail pieces' `send_date`s.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <returns>Returns the Models.CampaignsResponse4 response from the API call.</returns>
        public Models.CampaignsResponse4 CampaignDelete(
                string cmpId)
            => CoreHelper.RunTask(CampaignDeleteAsync(cmpId));

        /// <summary>
        /// Delete an existing campaign. You need only supply the unique identifier that was returned upon campaign creation. Deleting a campaign also deletes any associated mail pieces that have been created but not sent. A campaign's `send_date` matches its associated mail pieces' `send_date`s.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CampaignsResponse4 response from the API call.</returns>
        public async Task<Models.CampaignsResponse4> CampaignDeleteAsync(
                string cmpId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CampaignsResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/campaigns/{cmp_id}")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("cmp_id", cmpId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sends a campaign. You need only supply the unique campaign identifier that was returned upon campaign creation.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public Models.Campaign CampaignSend(
                string cmpId)
            => CoreHelper.RunTask(CampaignSendAsync(cmpId));

        /// <summary>
        /// Sends a campaign. You need only supply the unique campaign identifier that was returned upon campaign creation.
        /// </summary>
        /// <param name="cmpId">Required parameter: id of the campaign.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Campaign response from the API call.</returns>
        public async Task<Models.Campaign> CampaignSendAsync(
                string cmpId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Campaign>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/campaigns/{cmp_id}/send")
                  .WithAuth("basicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("cmp_id", cmpId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error", (_reason, _context) => new Domains0Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}