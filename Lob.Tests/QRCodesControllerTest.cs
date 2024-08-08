// <copyright file="QRCodesControllerTest.cs" company="APIMatic">
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
    /// QRCodesControllerTest.
    /// </summary>
    [TestFixture]
    public class QRCodesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private QRCodesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.QRCodesController;
        }

        /// <summary>
        /// Returns a list of your QR codes. The QR codes are returned sorted by scan date, with the most recently scanned QR codes appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestQrCodesList()
        {
            // Parameters for the API call
            int? limit = 10;
            int? offset = 0;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            bool? scanned = null;
            object resourceIds = null;

            // Perform API call
            Standard.Models.QrCodeAnalyticsResponse result = null;
            try
            {
                result = await this.controller.QrCodesListAsync(limit, offset, include, dateCreated, scanned, resourceIds);
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
                    "{\"data\":[{\"resource_id\":\"ltr_d5a5a89da9106f8\",\"date_created\":\"2019-07-27T23:49:01.511Z\",\"number_of_scans\":2,\"scans\":[{\"ip_location\":\"127.0.0.1\",\"scan_date\":\"2022-07-27T23:49:01.511Z\"},{\"ip_location\":\"127.0.0.1\",\"scan_date\":\"2022-07-29T23:45:00.436Z\"}]},{\"resource_id\":\"psc_d5a5a89da9106f8\",\"date_created\":\"2022-09-27T23:49:01.511Z\",\"number_of_scans\":1,\"scans\":[{\"ip_location\":\"127.0.0.1\",\"scan_date\":\"2022-09-27T23:49:01.511Z\"}]}],\"object\":\"list\",\"count\":2,\"scanned_count\":2,\"total_count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}