// <copyright file="IntlVerificationsControllerTest.cs" company="APIMatic">
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
    /// IntlVerificationsControllerTest.
    /// </summary>
    [TestFixture]
    public class IntlVerificationsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IntlVerificationsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.IntlVerificationsController;
        }

        /// <summary>
        /// Verify an international (except US or US territories) address _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestIntlVerification()
        {
            // Parameters for the API call
            object body = ApiHelper.JsonDeserialize<dynamic>("{\"recipient\":\"Harry Zhang\",\"primary_line\":\"370 Water St\",\"secondary_line\":\"\",\"city\":\"Summerside\",\"state\":\"Prince Edward Island\",\"postal code\":\"C1N 1C4\",\"country\":\"CA\"}");
            Standard.Models.XLangOutput1Enum? xLangOutput = null;

            // Perform API call
            Standard.Models.IntlVerification result = null;
            try
            {
                result = await this.controller.IntlVerificationAsync(body, xLangOutput);
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
                    "{\"id\":\"intl_ver_c7cb63d68f8d6\",\"recipient\":null,\"primary_line\":\"370 WATER ST\",\"secondary_line\":\"\",\"last_line\":\"SUMMERSIDE PE C1N 1C4\",\"country\":\"CA\",\"coverage\":\"SUBBUILDING\",\"deliverability\":\"deliverable\",\"status\":\"LV4\",\"components\":{\"primary_number\":\"370\",\"street_name\":\"WATER ST\",\"city\":\"SUMMERSIDE\",\"state\":\"PE\",\"postal_code\":\"C1N 1C4\"},\"object\":\"intl_verification\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}