// <copyright file="BuckslipsControllerTest.cs" company="APIMatic">
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
    /// BuckslipsControllerTest.
    /// </summary>
    [TestFixture]
    public class BuckslipsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private BuckslipsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.BuckslipsController;
        }

        /// <summary>
        /// Returns a list of your buckslips. The buckslips are returned sorted by creation date, with the most recently created buckslips appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestBuckslipsList()
        {
            // Parameters for the API call
            int? limit = 10;
            Standard.Models.Beforeafter beforeAfter = null;
            List<string> include = null;

            // Perform API call
            Standard.Models.BuckslipsResponse result = null;
            try
            {
                result = await this.controller.BuckslipsListAsync(limit, beforeAfter, include);
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
        }

        /// <summary>
        /// Creates a new buckslip given information.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestBuckslipCreate()
        {
            // Parameters for the API call
            Standard.Models.BuckslipEditable body = ApiHelper.JsonDeserialize<Standard.Models.BuckslipEditable>("{\"description\":\"Test buckslip\",\"front\":\"https://s3-us-west-2.amazonaws.com/public.lob.com/assets/buckslip.pdf\",\"back\":\"https://s3-us-west-2.amazonaws.com/public.lob.com/assets/buckslip.pdf\"}");

            // Perform API call
            Standard.Models.Buckslip result = null;
            try
            {
                result = await this.controller.BuckslipCreateAsync(body);
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
        }
    }
}