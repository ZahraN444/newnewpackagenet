// <copyright file="AddressesControllerTest.cs" company="APIMatic">
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
    /// AddressesControllerTest.
    /// </summary>
    [TestFixture]
    public class AddressesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private AddressesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.AddressesController;
        }

        /// <summary>
        /// Returns a list of your addresses. The addresses are returned sorted by creation date, with the most recently created addresses appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAddressesList()
        {
            // Parameters for the API call
            int? limit = 10;
            Standard.Models.Beforeafter beforeAfter = null;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            Dictionary<string, string> metadata = null;

            // Perform API call
            Standard.Models.AllAddresses result = null;
            try
            {
                result = await this.controller.AddressesListAsync(limit, beforeAfter, include, dateCreated, metadata);
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
                    "{\"data\":[{\"id\":\"adr_e68217bd744d65c8\",\"description\":\"Harry - Office\",\"name\":\"HARRY ZHANG\",\"company\":\"LOB\",\"phone\":\"5555555555\",\"email\":\"harry@lob.com\",\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2019-08-12T00:16:00.361Z\",\"date_modified\":\"2019-08-12T00:16:00.361Z\",\"object\":\"address\"},{\"id\":\"adr_asdi2y3riuasasoi\",\"description\":\"Harry - Office\",\"name\":\"Harry Zhang\",\"company\":\"Lob\",\"phone\":\"5555555555\",\"email\":\"harry@lob.com\",\"metadata\":{},\"address_line1\":\"370 WATER ST\",\"address_line2\":\"\",\"address_city\":\"SUMMERSIDE\",\"address_state\":\"PRINCE EDWARD ISLAND\",\"address_zip\":\"C1N 1C4\",\"address_country\":\"CANADA\",\"date_created\":\"2019-09-20T00:14:00.361Z\",\"date_modified\":\"2019-09-20T00:14:00.361Z\",\"object\":\"address\"}],\"object\":\"list\",\"next_url\":\"https://api.lob.com/v1/addresses?limit=2&after=eyJkYXRlT2Zmc2V0IjoiMjAxOS0wOC0wN1QyMTo1OTo0Ni43NjRaIiwiaWRPZmZzZXQiOiJhZHJfODMwYmYwZWFiZGFhYTQwOSJ9\",\"previous_url\":null,\"count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a new address given information.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestAddressCreate()
        {
            // Parameters for the API call
            object body = ApiHelper.JsonDeserialize<dynamic>("{\"description\":\"Harry - Office\",\"name\":\"Harry Zhang\",\"company\":\"Lob\",\"email\":\"harry@lob.com\",\"phone\":\"5555555555\",\"address_line1\":\"210 King St\",\"address_line2\":\"# 6100\",\"address_city\":\"San Francisco\",\"address_state\":\"CA\",\"address_zip\":\"94107\",\"address_country\":\"US\"}");

            // Perform API call
            object result = null;
            try
            {
                result = await this.controller.AddressCreateAsync(body);
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
                    "{\"id\":\"adr_d3489cd64c791ab5\",\"description\":\"Harry - Office\",\"name\":\"HARRY ZHANG\",\"company\":\"LOB\",\"phone\":\"5555555555\",\"email\":\"harry@lob.com\",\"address_line1\":\"210 KING ST STE 6100\",\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2017-09-05T17:47:53.767Z\",\"date_modified\":\"2017-09-05T17:47:53.767Z\",\"object\":\"address\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}