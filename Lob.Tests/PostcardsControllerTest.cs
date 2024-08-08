// <copyright file="PostcardsControllerTest.cs" company="APIMatic">
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
    /// PostcardsControllerTest.
    /// </summary>
    [TestFixture]
    public class PostcardsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private PostcardsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PostcardsController;
        }

        /// <summary>
        /// Returns a list of your postcards. The addresses are returned sorted by creation date, with the most recently created addresses appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostcardsList()
        {
            // Parameters for the API call
            int? limit = 10;
            Standard.Models.Beforeafter beforeAfter = null;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            Dictionary<string, string> metadata = null;
            List<Standard.Models.PostcardSizeEnum> size = null;
            bool? scheduled = null;
            object sendDate = null;
            Standard.Models.MailTypeEnum? mailType = null;
            Standard.Models.SortBy1 sortBy = null;

            // Perform API call
            Standard.Models.AllPostcards result = null;
            try
            {
                result = await this.controller.PostcardsListAsync(limit, beforeAfter, include, dateCreated, metadata, size, scheduled, sendDate, mailType, sortBy);
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
                    "{\"data\":[{\"id\":\"psc_208e45e48d271294\",\"description\":null,\"metadata\":{},\"to\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":\"LEORE AVIDAR\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"url\":\"https://lob-assets.com/postcards/psc_208e45e48d271294.pdf?version=v1&expires=1619218302&signature=NfHHLBSr5tOHA_Z4kij4dKqZG8f3vMDtwvuFVeeF9pV_lylcjLsVVODhNCE5hR6-2slUr6t9WMNsi429Pj7_DA\",\"carrier\":\"USPS\",\"front_template_id\":null,\"back_template_id\":null,\"front_template_version_id\":null,\"back_template_version_id\":null,\"date_created\":\"2021-03-24T22:51:42.838Z\",\"date_modified\":\"2021-03-24T22:51:42.838Z\",\"send_date\":\"2021-03-24T22:51:42.838Z\",\"use_type\":\"marketing\",\"object\":\"postcard\"},{\"id\":\"psc_0e03d1ad7d31f151\",\"description\":null,\"metadata\":{},\"to\":{\"id\":\"adr_c7cb63d68f8d6\",\"description\":null,\"name\":\"JANE DOE\",\"company\":\"LOB\",\"phone\":\"5555555555\",\"email\":\"jane.doe@lob.com\",\"address_line1\":\"370 WATER ST\",\"address_line2\":\"\",\"address_city\":\"SUMMERSIDE\",\"address_state\":\"PE\",\"address_zip\":\"C1N 1C4\",\"address_country\":\"CANADA\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\",\"recipient_moved\":false},\"from\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":\"LEORE AVIDAR\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"url\":\"https://lob-assets.com/postcards/psc_208e45e48d271294.pdf?version=v1&expires=1619218302&signature=NfHHLBSr5tOHA_Z4kij4dKqZG8f3vMDtwvuFVeeF9pV_lylcjLsVVODhNCE5hR6-2slUr6t9WMNsi429Pj7_DA\",\"carrier\":\"USPS\",\"front_template_id\":null,\"back_template_id\":null,\"front_template_version_id\":null,\"back_template_version_id\":null,\"tracking_events\":[],\"size\":\"6x11\",\"mail_type\":\"usps_first_class\",\"merge_variables\":{},\"thumbnails\":[{\"small\":\"https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_small_1.png?expires=1540372221&signature=a5fRBJ22ZA78Vgpg34M9UfmHWTS3eha\",\"medium\":\"https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_medium_1.png?expires=1540372221&signature=bAzL8sv935PY09FWSkpDpWKkyvGSWYF\",\"large\":\"https://lob-assets.com/letters/ltr_4868c3b754655f90_thumb_large_1.png?expires=1540372221&signature=gsKvxXgrm4v4iZD3bOibK7jApNkEMdW\"}],\"expected_delivery_date\":\"2021-03-30\",\"date_created\":\"2021-03-24T22:51:42.838Z\",\"date_modified\":\"2021-03-24T22:51:42.838Z\",\"send_date\":\"2021-03-24T22:51:42.838Z\",\"use_type\":\"marketing\",\"object\":\"postcard\"}],\"object\":\"list\",\"previous_url\":null,\"next_url\":null,\"count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a new postcard given information.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPostcardCreate()
        {
            // Parameters for the API call
            Standard.Models.PostcardEditable body = ApiHelper.JsonDeserialize<Standard.Models.PostcardEditable>("{\"description\":\"demo\",\"to\":{\"description\":\"Harry - Office\",\"name\":\"Harry Zhang\",\"company\":\"Lob\",\"email\":\"harry@lob.com\",\"phone\":\"5555555555\",\"address_line1\":\"210 King St\",\"address_line2\":\"# 6100\",\"address_city\":\"San Francisco\",\"address_state\":\"CA\",\"address_zip\":\"94107\",\"address_country\":\"US\"},\"from\":{\"description\":\"Harry - Office\",\"name\":\"Harry Zhang\",\"company\":\"Lob\",\"email\":\"harry@lob.com\",\"phone\":\"5555555555\",\"address_line1\":\"210 King St\",\"address_line2\":\"# 6100\",\"address_city\":\"San Francisco\",\"address_state\":\"CA\",\"address_zip\":\"94107\",\"address_country\":\"US\"},\"front\":\"tmpl_a1234dddg\",\"back\":\"tmpl_a1234dddg\",\"size\":\"6x9\",\"mail_type\":\"usps_first_class\",\"merge_variables\":{\"name\":\"Harry\"},\"metadata\":{\"spiffy\":\"true\"},\"send_date\":\"2017-11-01T00:00:00.000Z\",\"use_type\":\"marketing\",\"qr_code\":{\"position\":\"relative\",\"redirect_url\":\"https://www.lob.com\",\"width\":\"2.5\",\"top\":\"2.5\",\"right\":\"2.5\",\"pages\":\"front,back\"}}");
            string idempotencyKey = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";
            string idempotencyKey2 = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";

            // Perform API call
            Standard.Models.Postcard result = null;
            try
            {
                result = await this.controller.PostcardCreateAsync(body, idempotencyKey, idempotencyKey2);
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
                    "{\"id\":\"psc_208e45e48d271294\",\"description\":null,\"metadata\":{},\"to\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":null,\"company\":\"LOB\",\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"url\":\"https://lob-assets.com/postcards/psc_208e45e48d271294.pdf?version=v1&expires=1619218302&signature=NfHHLBSr5tOHA_Z4kij4dKqZG8f3vMDtwvuFVeeF9pV_lylcjLsVVODhNCE5hR6-2slUr6t9WMNsi429Pj7_DA\",\"carrier\":\"USPS\",\"front_template_id\":null,\"back_template_id\":null,\"date_created\":\"2021-03-24T22:51:42.838Z\",\"date_modified\":\"2021-03-24T22:51:42.838Z\",\"send_date\":\"2021-03-24T22:51:42.838Z\",\"use_type\":\"marketing\",\"object\":\"postcard\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}