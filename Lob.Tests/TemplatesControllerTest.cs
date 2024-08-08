// <copyright file="TemplatesControllerTest.cs" company="APIMatic">
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
    /// TemplatesControllerTest.
    /// </summary>
    [TestFixture]
    public class TemplatesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private TemplatesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.TemplatesController;
        }

        /// <summary>
        /// Returns a list of your templates. The templates are returned sorted by creation date, with the most recently created templates appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestTemplatesList()
        {
            // Parameters for the API call
            int? limit = 10;
            Standard.Models.Beforeafter beforeAfter = null;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            Dictionary<string, string> metadata = null;

            // Perform API call
            Standard.Models.AllTemplates result = null;
            try
            {
                result = await this.controller.TemplatesListAsync(limit, beforeAfter, include, dateCreated, metadata);
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
                    "{\"data\":[{\"id\":\"tmpl_d5a5a89da9106f8\",\"description\":\"Test Template\",\"versions\":[{\"id\":\"vrsn_232a02fb8224791\",\"suggest_json_editor\":true,\"description\":\"Test Template\",\"engine\":\"legacy\",\"html\":\"HTML for \",\"date_created\":\"2019-07-27T23:49:01.512Z\",\"date_modified\":\"2019-07-27T23:49:01.512Z\",\"object\":\"version\"}],\"published_version\":{\"id\":\"vrsn_232a02fb8224791\",\"suggest_json_editor\":false,\"description\":\"Test Template\",\"engine\":\"handlebars\",\"html\":\"HTML for \",\"date_created\":\"2019-07-27T23:49:01.512Z\",\"date_modified\":\"2019-07-27T23:49:01.512Z\",\"object\":\"version\"},\"metadata\":{},\"date_created\":\"2019-07-27T23:49:01.511Z\",\"date_modified\":\"2019-07-27T23:49:01.511Z\",\"object\":\"template\"},{\"id\":\"tmpl_59b2150ae120887\",\"description\":\"Test Template\",\"versions\":[{\"id\":\"vrsn_2a7eb63ccb795b9\",\"description\":\"Test Template\",\"html\":\"HTML for \",\"date_created\":\"2019-03-29T10:22:34.643Z\",\"date_modified\":\"2019-03-29T10:22:34.643Z\",\"object\":\"version\"}],\"published_version\":{\"id\":\"vrsn_2a7eb63ccb795b9\",\"description\":\"Test Template\",\"html\":\"HTML for \",\"date_created\":\"2019-03-29T10:22:34.643Z\",\"date_modified\":\"2019-03-29T10:22:34.643Z\",\"object\":\"version\"},\"metadata\":{},\"date_created\":\"2019-03-29T10:22:34.642Z\",\"date_modified\":\"2019-03-29T10:22:34.642Z\",\"object\":\"template\"}],\"object\":\"list\",\"previous_url\":null,\"next_url\":\"https://api.lob.com/v1/templates?limit=2&after=eyJkYXRlT2Zmc2V0IjoiMjAxOS0wMy0yOVQxMDoyMjozNC42NDJaIiwiaWRPZmZzZXQiOiJ0bXBsXzU5YjIxNTBhZTEyMDg4NyJ9\",\"count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}