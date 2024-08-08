// <copyright file="LettersControllerTest.cs" company="APIMatic">
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
    /// LettersControllerTest.
    /// </summary>
    [TestFixture]
    public class LettersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private LettersController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.LettersController;
        }

        /// <summary>
        /// Returns a list of your letters. The letters are returned sorted by creation date, with the most recently created letters appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestLettersList()
        {
            // Parameters for the API call
            int? limit = 10;
            Standard.Models.Beforeafter beforeAfter = null;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            Dictionary<string, string> metadata = null;
            bool? color = null;
            bool? scheduled = null;
            object sendDate = null;
            Standard.Models.MailTypeEnum? mailType = null;
            Standard.Models.SortBy1 sortBy = null;

            // Perform API call
            Standard.Models.AllLetters result = null;
            try
            {
                result = await this.controller.LettersListAsync(limit, beforeAfter, include, dateCreated, metadata, color, scheduled, sendDate, mailType, sortBy);
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
                    "{\"data\":[{\"id\":\"ltr_5ba44b462c79f07c\",\"description\":\"Demo Letter\",\"metadata\":{},\"to\":{\"id\":\"adr_asdi2y3riuasasoi\",\"description\":\"Harry - Office\",\"name\":\"Harry Zhang\",\"company\":\"Lob\",\"phone\":\"5555555555\",\"email\":\"harry@lob.com\",\"metadata\":{},\"address_line1\":\"370 WATER ST\",\"address_line2\":\"\",\"address_city\":\"SUMMERSIDE\",\"address_state\":\"PRINCE EDWARD ISLAND\",\"address_zip\":\"C1N 1C4\",\"address_country\":\"CANADA\",\"recipient_moved\":false,\"date_created\":\"2019-09-20T00:14:00.361Z\",\"date_modified\":\"2019-09-20T00:14:00.361Z\",\"object\":\"address\"},\"from\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":\"LEORE AVIDAR\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"color\":true,\"double_sided\":false,\"address_placement\":\"top_first_page\",\"return_envelope\":false,\"perforated_page\":null,\"extra_service\":\"certified\",\"custom_envelope\":null,\"template_id\":\"tmpl_a\",\"template_version_id\":\"vrsn_a\",\"mail_type\":\"usps_first_class\",\"url\":\"https://lob-assets.com/letters/ltr_5ba44b462c79f07c.pdf?version=v1&expires=1568239830&signature=Ob-DUPLJLM4scWQeCDNadPJ4j33MZw16pykOxwv2us-bA7utTYi6oZ8WrEtBYDBBo09XkapR3gdJf0NEr90xAA\",\"merge_variables\":null,\"carrier\":\"USPS\",\"tracking_number\":\"92071902358909000011275538\",\"tracking_events\":[{\"id\":\"evnt_9e84094c9368cfb\",\"type\":\"certified\",\"name\":\"Delivered\",\"details\":{\"event\":\"delivered\",\"description\":\"Package has been delivered.\",\"notes\":\"Delivered, Front Desk/Reception/Mail Room\",\"action_required\":false},\"location\":\"33408\",\"time\":\"2019-10-08T19:41:00Z\",\"date_created\":\"2019-10-08T19:41:00Z\",\"date_modified\":\"2019-10-08T19:41:00Z\",\"object\":\"tracking_event\"}],\"thumbnails\":[{\"small\":\"https://lob-assets.com/letters/ltr_5ba44b462c79f07c_thumb_small_1.png?version=v1&expires=1568239830&signature=xZUmE8rq8wSECHPEb9c37cUDZBzGUO3XK5LsIPZhI6dOXgm6zJEn8_7tKuZ3JWBmvNJNXdTl_ufkNu4avjQUDw\",\"medium\":\"https://lob-assets.com/letters/ltr_5ba44b462c79f07c_thumb_medium_1.png?version=v1&expires=1568239830&signature=H7354Qpcm9S4aXbrMsBe6QJ6lSNi9IWPgMJtLWLi4Kyx9tHF8Mp9YEc_IL9x89Jfw4-yRzKDXA410X4W0PssBQ\",\"large\":\"https://lob-assets.com/letters/ltr_5ba44b462c79f07c_thumb_large_1.png?version=v1&expires=1568239830&signature=54LUIDKZyItA9pnC87d1pJVAuw8bhKLCsMpNWkB3LgdVWxPxxb_c1IyIWAbSR-dyOYEOlDBCc40J4Kns-O_mAg\"}],\"expected_delivery_date\":\"2019-08-16\",\"date_created\":\"2019-08-08T17:09:14.514Z\",\"date_modified\":\"2019-08-08T17:09:16.850Z\",\"send_date\":\"2019-08-08\",\"use_type\":\"marketing\",\"fsc\":false,\"object\":\"letter\"},{\"id\":\"ltr_da8267c6a6545cd6\",\"description\":\"Demo Letter\",\"metadata\":{},\"to\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":\"LEORE AVIDAR\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"from\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":\"LEORE AVIDAR\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"color\":true,\"double_sided\":false,\"address_placement\":\"top_first_page\",\"return_envelope\":false,\"perforated_page\":null,\"extra_service\":null,\"custom_envelope\":null,\"mail_type\":\"usps_first_class\",\"url\":\"https://lob-assets.com/letters/ltr_da8267c6a6545cd6.pdf?version=v1&expires=1568239830&signature=HH-5RnbD4x0eJcnEC9HhqKSvQGsbkjovzvqSKgBijUHKIXwEKQJ4CbYhKs_U2q2A1k20Xefcaw7bfdPKozuqCQ\",\"merge_variables\":null,\"carrier\":\"USPS\",\"tracking_number\":null,\"tracking_events\":[],\"thumbnails\":[{\"small\":\"https://lob-assets.com/letters/ltr_da8267c6a6545cd6_thumb_small_1.png?version=v1&expires=1568239830&signature=C1Rs83187HpWGhsg_pJIOhDIKlDtC_IgBBxHiocCEzJ8CncJwqrq5yHke-p97Dv7o81G_pfhFmirai589O6DCw\",\"medium\":\"https://lob-assets.com/letters/ltr_da8267c6a6545cd6_thumb_medium_1.png?version=v1&expires=1568239830&signature=gz63l0yi3sK_sXjYfIVdLSvkknJFr_O5TWRulo_iKIgS-PosIl6J0tDR6bx_Tv5Ab_w7DABg3qdKZ846MZ7TCw\",\"large\":\"https://lob-assets.com/letters/ltr_da8267c6a6545cd6_thumb_large_1.png?version=v1&expires=1568239830&signature=4Y1OIymaWkSO3aBIHCeshFAVnF-pDcF2FFqkx_jovaUFuk4FT1SI24L7_POwTRXQHlETMGlzkP_CGgqselRUAA\"}],\"expected_delivery_date\":\"2019-08-16\",\"date_created\":\"2019-08-08T17:08:12.224Z\",\"date_modified\":\"2019-08-08T17:08:13.990Z\",\"send_date\":\"2019-08-08T17:08:12.224Z\",\"cards\":null,\"use_type\":\"marketing\",\"fsc\":true,\"object\":\"letter\"}],\"object\":\"list\",\"next_url\":\"https://api.lob.com/v1/letters?limit=2&after=eyJkYXRlT2Zmc2V0IjoiMjAxOS0wOC0wOFQxNzowODoxMi4yMjRaIiwiaWRPZmZzZXQiOiJsdHJfZGE4MjY3YzZhNjU0NWNkNiJ9\",\"previous_url\":null,\"count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}