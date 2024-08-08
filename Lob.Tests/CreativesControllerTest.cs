// <copyright file="CreativesControllerTest.cs" company="APIMatic">
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
    /// CreativesControllerTest.
    /// </summary>
    [TestFixture]
    public class CreativesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private CreativesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.CreativesController;
        }

        /// <summary>
        /// Retrieves the details of an existing creative. You need only supply the unique creative identifier that was returned upon creative creation..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreativeRetrieve()
        {
            // Parameters for the API call
            string crvId = "crv_2a3b096c409b32c";

            // Perform API call
            Standard.Models.Creative result = null;
            try
            {
                result = await this.controller.CreativeRetrieveAsync(crvId);
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