// <copyright file="UploadsControllerTest.cs" company="APIMatic">
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
    /// UploadsControllerTest.
    /// </summary>
    [TestFixture]
    public class UploadsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private UploadsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.UploadsController;
        }

        /// <summary>
        /// Returns a list of your uploads. Optionally, filter uploads by campaign..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUploadsList()
        {
            // Parameters for the API call
            string campaignId = null;

            // Perform API call
            List<Standard.Models.Upload> result = null;
            try
            {
                result = await this.controller.UploadsListAsync(campaignId);
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
                    "[{\"id\":\"upl_71be866e430b11e9\",\"accountId\":\"fa9ea650fc7b31a89f92\",\"campaignId\":\"cmp_1933ad629bae1408\",\"mode\":\"test\",\"failuresUrl\":\"https://www.example.com\",\"originalFilename\":\"my_audience.csv\",\"state\":\"Draft\",\"totalMailpieces\":100,\"failedMailpieces\":5,\"validatedMailpieces\":95,\"bytesProcessed\":17268,\"dateCreated\":\"2017-09-05T17:47:53.767Z\",\"dateModified\":\"2017-09-05T17:47:53.767Z\",\"requiredAddressColumnMapping\":{\"name\":\"recipient_name\",\"address_line1\":\"primary_line\",\"address_city\":\"city\",\"address_state\":\"state\",\"address_zip\":\"zip_code\"},\"optionalAddressColumnMapping\":{\"address_line2\":\"secondary_line\",\"company\":\"company\",\"address_country\":\"country\"},\"mergeVariableColumnMapping\":{\"gift_code\":\"code\"},\"metadata\":{\"columns\":[\"recipient_name\",\"zip_code\"]}}]",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}