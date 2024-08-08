// <copyright file="CampaignsControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities;
    using Lob.Standard;
    using Lob.Standard.Controllers;
    using Lob.Standard.Exceptions;
    using Lob.Standard.Http.Client;
    using Lob.Standard.Http.Response;
    using Lob.Standard.Models.Containers;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// CampaignsControllerTest.
    /// </summary>
    [TestFixture]
    public class CampaignsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private CampaignsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.CampaignsController;
        }

        /// <summary>
        /// Returns a list of your campaigns. The campaigns are returned sorted by creation date, with the most recently created campaigns appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCampaignsList()
        {
            // Parameters for the API call
            int? limit = 10;
            List<string> include = null;
            Standard.Models.Beforeafter beforeAfter = null;

            // Perform API call
            Standard.Models.AllCampaigns result = null;
            try
            {
                result = await this.controller.CampaignsListAsync(limit, include, beforeAfter);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"data\":[{\"id\":\"cmp_e05ee61ff80764b\",\"billing_group_id\":\"bg_fe3079dcdd80e5ae\",\"name\":\"My Campaign\",\"description\":\"My Campaign's description\",\"schedule_type\":\"immediate\",\"send_date\":null,\"target_delivery_date\":null,\"cancel_window_campaign_minutes\":60,\"metadata\":{},\"use_type\":\"marketing\",\"is_draft\":true,\"deleted\":false,\"creatives\":[],\"uploads\":[],\"auto_cancel_if_ncoa\":false,\"date_created\":\"2017-09-05T17:47:53.767Z\",\"date_modified\":\"2017-09-05T17:47:53.767Z\",\"object\":\"campaign\"}],\"object\":\"list\",\"previous_url\":null,\"next_url\":null,\"count\":1}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}