// <copyright file="BillingGroupsControllerTest.cs" company="APIMatic">
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
    /// BillingGroupsControllerTest.
    /// </summary>
    [TestFixture]
    public class BillingGroupsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private BillingGroupsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.BillingGroupsController;
        }

        /// <summary>
        /// Returns a list of your billing_groups. The billing_groups are returned sorted by creation date, with the most recently created billing_groups appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestBillingGroupsList()
        {
            // Parameters for the API call
            int? limit = 10;
            int? offset = 0;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            Dictionary<string, string> dateModified = null;
            Standard.Models.SortBy sortBy = null;

            // Perform API call
            Standard.Models.BillingGroupsResponse result = null;
            try
            {
                result = await this.controller.BillingGroupsListAsync(limit, offset, include, dateCreated, dateModified, sortBy);
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
                    "{\"data\":[{\"id\":\"bg_d5a5a89da9106f8\",\"description\":\"Test billing_group\",\"metadata\":{},\"date_created\":\"2019-07-27T23:49:01.511Z\",\"date_modified\":\"2019-07-27T23:49:01.511Z\",\"object\":\"billing_group\"},{\"id\":\"bg_59b2150ae120887\",\"description\":\"Test billing_group\",\"metadata\":{},\"date_created\":\"2019-03-29T10:22:34.642Z\",\"date_modified\":\"2019-03-29T10:22:34.642Z\",\"object\":\"billing_group\"}],\"object\":\"list\",\"next_url\":null,\"prev_url\":null,\"count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a new billing_group with the provided properties..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestBillingGroupCreate()
        {
            // Parameters for the API call
            Standard.Models.BillingGroupEditable body = ApiHelper.JsonDeserialize<Standard.Models.BillingGroupEditable>("{\"name\":\"Marketing Dept\",\"description\":\"Usage group used for the Marketing Dept resource sends\"}");

            // Perform API call
            Standard.Models.BillingGroup result = null;
            try
            {
                result = await this.controller.BillingGroupCreateAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("ratelimit-limit", null);
            headers.Add("ratelimit-remaining", null);
            headers.Add("ratelimit-reset", null);
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
                    "{\"id\":\"bg_c94e83ca2cd5121\",\"name\":\"Marketing Dept\",\"description\":\"Usage group used for the Marketing Dept resource sends\",\"date_created\":\"2017-11-07T22:56:10.962Z\",\"date_modified\":\"2017-11-07T22:56:10.962Z\",\"object\":\"billing_group\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}