// <copyright file="IdentityValidationControllerTest.cs" company="APIMatic">
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
    /// IdentityValidationControllerTest.
    /// </summary>
    [TestFixture]
    public class IdentityValidationControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IdentityValidationController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.IdentityValidationController;
        }

        /// <summary>
        /// Validates whether a given name is associated with an address..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestIdentityValidation()
        {
            // Parameters for the API call
            object body = ApiHelper.JsonDeserialize<dynamic>("{\"recipient\":\"Larry Lobster\",\"primary_line\":\"210 King St.\",\"secondary_line\":\"\",\"city\":\"San Francisco\",\"state\":\"CA\",\"zip_code\":\"94107\"}");

            // Perform API call
            IdentityValidation result = null;
            try
            {
                result = await this.controller.IdentityValidationAsync(body);
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
        }
    }
}