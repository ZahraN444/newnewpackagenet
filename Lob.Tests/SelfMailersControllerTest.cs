// <copyright file="SelfMailersControllerTest.cs" company="APIMatic">
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
    /// SelfMailersControllerTest.
    /// </summary>
    [TestFixture]
    public class SelfMailersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SelfMailersController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SelfMailersController;
        }

        /// <summary>
        /// Returns a list of your self_mailers. The self_mailers are returned sorted by creation date, with the most recently created self_mailers appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSelfMailersList()
        {
            // Parameters for the API call
            int? limit = 10;
            Standard.Models.Beforeafter beforeAfter = null;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            Dictionary<string, string> metadata = null;
            List<Standard.Models.SelfMailerSizeEnum> size = null;
            bool? scheduled = null;
            object sendDate = null;
            Standard.Models.MailTypeEnum? mailType = null;
            Standard.Models.SortBy1 sortBy = null;

            // Perform API call
            Standard.Models.AllSelfMailers result = null;
            try
            {
                result = await this.controller.SelfMailersListAsync(limit, beforeAfter, include, dateCreated, metadata, size, scheduled, sendDate, mailType, sortBy);
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
                    "{\"data\":[{\"id\":\"sfm_7239rhwqkrfaskas\",\"description\":\"April Campaign\",\"metadata\":{},\"to\":{\"id\":\"adr_asdi2y3riuasasoi\",\"description\":\"Harry - Office\",\"name\":\"Harry Zhang\",\"company\":\"Lob\",\"phone\":\"5555555555\",\"email\":\"harry@lob.com\",\"metadata\":{},\"address_line1\":\"370 WATER ST\",\"address_line2\":\"\",\"address_city\":\"SUMMERSIDE\",\"address_state\":\"PRINCE EDWARD ISLAND\",\"address_zip\":\"C1N 1C4\",\"address_country\":\"CANADA\",\"recipient_moved\":false,\"date_created\":\"2019-09-20T00:14:00.361Z\",\"date_modified\":\"2019-09-20T00:14:00.361Z\",\"object\":\"address\"},\"from\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":null,\"company\":\"LOB\",\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"url\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf.pdf?version=v1&expires=1618781264&signature=YP_bCwrgVA2lz1Gr1YVCJN1f-WspUGsH0aJp2ihjfLXU7lDUV12_xRv4uPch0mfWeOOxEqpyP8hGpgvjmQKNAw\",\"outside_template_id\":\"tmpl_a3cb937f26d7eec\",\"inside_template_id\":\"tmpl_a3cb937f26d7eec\",\"inside_template_version_id\":\"vrsn_bfdf70893b00a85\",\"outside_template_version_id\":\"vrsn_bfdf70893b00a85\",\"carrier\":\"USPS\",\"tracking_events\":[],\"thumbnails\":[{\"small\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_small_1.png?version=v1&expires=1618781264&signature=A7q5HbRO53sUYYnwGlmP5mTS6ylLE7kS2mYhfcEOdexjyqG7UseK0MD26DppE4Q0aE4u2msDVMxd5ukjMerYCg\",\"medium\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_medium_1.png?version=v1&expires=1618781264&signature=b9pynuawVpU_vrhnT_mTpksdE-FLF_ZjdIBOFR_ltIzEGlx-VKD4VvZrqP98lG2D8V7UKQ7SdRr2nUAk4LxvCg\",\"large\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_large_1.png?version=v1&expires=1618781264&signature=g2jifhCselPqIj8au6lsbJMNFN8ZX3aM6GkLoAXiHBCS8X5mF9nhVbmO0odpnmwNlV1CWIp-MXVsZkC3NmxqBQ\"},{\"small\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_small_2.png?version=v1&expires=1618781264&signature=biJY4-ZbNNRydPYg3cZkq7wxjILbPBK_nIVyoyQsg5X5q4jlsa-2fzeMa48V9jprUetsC6WEuYvasHosRfG_DQ\",\"medium\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_medium_2.png?version=v1&expires=1618781264&signature=xEAX7bURyc8fSphacuo5yb7iVIpT8Xvq05KgMaNQS4r3aCpx0z1p42wbPmW758B5Ae0li1YDYvVyzS7qJIoWAw\",\"large\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_large_2.png?version=v1&expires=1618781264&signature=NieHDnoQ7STZUvofHrFt7S987CzIkUJWpaSgpVQPZw-C3_wwTPsIrvxYdXEuFrr6ciTUcxRBFPlE0lurmMkyCA\"}],\"merge_variables\":{\"name\":null},\"size\":\"6x18_bifold\",\"mail_type\":\"usps_first_class\",\"expected_delivery_date\":\"2021-03-24\",\"date_created\":\"2021-03-16T18:40:40.504Z\",\"date_modified\":\"2021-03-16T18:41:06.691Z\",\"send_date\":\"2021-03-16T18:45:40.493Z\",\"deleted\":true,\"use_type\":\"marketing\",\"fsc\":false,\"object\":\"self_mailer\"},{\"id\":\"sfm_8ffbe811dea49dcf\",\"description\":\"April Campaign\",\"metadata\":{},\"to\":{\"id\":\"adr_f9228b743884ff98\",\"description\":null,\"name\":\"AYA\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"2812 PARK RD\",\"address_line2\":null,\"address_city\":\"CHARLOTTE\",\"address_state\":\"NC\",\"address_zip\":\"28209-1314\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2021-03-16T18:40:40.410Z\",\"date_modified\":\"2021-03-16T18:40:40.410Z\",\"deleted\":true,\"object\":\"address\"},\"from\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":null,\"company\":\"LOB\",\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2018-12-08T03:01:07.651Z\",\"date_modified\":\"2018-12-08T03:01:07.651Z\",\"object\":\"address\"},\"url\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf.pdf?version=v1&expires=1618781264&signature=YP_bCwrgVA2lz1Gr1YVCJN1f-WspUGsH0aJp2ihjfLXU7lDUV12_xRv4uPch0mfWeOOxEqpyP8hGpgvjmQKNAw\",\"outside_template_id\":\"tmpl_a3cb937f26d7eec\",\"inside_template_id\":\"tmpl_a3cb937f26d7eec\",\"inside_template_version_id\":\"vrsn_bfdf70893b00a85\",\"outside_template_version_id\":\"vrsn_bfdf70893b00a85\",\"carrier\":\"USPS\",\"tracking_events\":[],\"thumbnails\":[{\"small\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_small_1.png?version=v1&expires=1618781264&signature=A7q5HbRO53sUYYnwGlmP5mTS6ylLE7kS2mYhfcEOdexjyqG7UseK0MD26DppE4Q0aE4u2msDVMxd5ukjMerYCg\",\"medium\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_medium_1.png?version=v1&expires=1618781264&signature=b9pynuawVpU_vrhnT_mTpksdE-FLF_ZjdIBOFR_ltIzEGlx-VKD4VvZrqP98lG2D8V7UKQ7SdRr2nUAk4LxvCg\",\"large\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_large_1.png?version=v1&expires=1618781264&signature=g2jifhCselPqIj8au6lsbJMNFN8ZX3aM6GkLoAXiHBCS8X5mF9nhVbmO0odpnmwNlV1CWIp-MXVsZkC3NmxqBQ\"},{\"small\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_small_2.png?version=v1&expires=1618781264&signature=biJY4-ZbNNRydPYg3cZkq7wxjILbPBK_nIVyoyQsg5X5q4jlsa-2fzeMa48V9jprUetsC6WEuYvasHosRfG_DQ\",\"medium\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_medium_2.png?version=v1&expires=1618781264&signature=xEAX7bURyc8fSphacuo5yb7iVIpT8Xvq05KgMaNQS4r3aCpx0z1p42wbPmW758B5Ae0li1YDYvVyzS7qJIoWAw\",\"large\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_large_2.png?version=v1&expires=1618781264&signature=NieHDnoQ7STZUvofHrFt7S987CzIkUJWpaSgpVQPZw-C3_wwTPsIrvxYdXEuFrr6ciTUcxRBFPlE0lurmMkyCA\"}],\"merge_variables\":{\"name\":null},\"size\":\"6x18_bifold\",\"mail_type\":\"usps_first_class\",\"expected_delivery_date\":\"2021-03-24\",\"date_created\":\"2021-03-16T18:40:40.504Z\",\"date_modified\":\"2021-03-16T18:41:06.691Z\",\"send_date\":\"2021-03-16T18:45:40.493Z\",\"deleted\":true,\"use_type\":\"marketing\",\"fsc\":true,\"object\":\"self_mailer\"}],\"object\":\"list\",\"next_url\":null,\"previous_url\":null,\"count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Creates a new self_mailer given information.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSelfMailerCreate()
        {
            // Parameters for the API call
            Standard.Models.SelfMailerEditable body = ApiHelper.JsonDeserialize<Standard.Models.SelfMailerEditable>("{\"description\":\"Demo Self Mailer job\",\"to\":\"adr_bae820679f3f536b\",\"from\":\"adr_210a8d4b0b76d77b\",\"inside\":\"https://lob.com/selfmailerinside.pdf\",\"outside\":\"https://lob.com/selfmaileroutside.pdf\",\"size\":\"12x9_bifold\",\"metadata\":{\"spiffy\":\"true\"},\"mail_type\":\"usps_standard\",\"merge_variables\":{\"name\":\"Harry\"},\"send_date\":\"2017-11-01T00:00:00.000Z\",\"use_type\":\"marketing\",\"qr_code\":{\"position\":\"relative\",\"redirect_url\":\"https://www.lob.com\",\"width\":\"2.5\",\"top\":\"2.5\",\"right\":\"2.5\",\"pages\":\"inside,outside\"},\"fsc\":true}");
            string idempotencyKey = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";
            string idempotencyKey2 = "026e7634-24d7-486c-a0bb-4a17fd0eebc5";

            // Perform API call
            Standard.Models.SelfMailer result = null;
            try
            {
                result = await this.controller.SelfMailerCreateAsync(body, idempotencyKey, idempotencyKey2);
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
                    "{\"id\":\"sfm_8ffbe811dea49dcf\",\"description\":\"April Campaign\",\"metadata\":{},\"to\":{\"id\":\"adr_bae820679f3f536b\",\"description\":null,\"name\":\"HARRY ZHANG\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2017-09-05T17:47:53.767Z\",\"date_modified\":\"2017-09-05T17:47:53.767Z\",\"deleted\":true,\"object\":\"address\"},\"from\":{\"id\":\"adr_210a8d4b0b76d77b\",\"description\":null,\"name\":\"LEORE AVIDAR\",\"company\":null,\"phone\":null,\"email\":null,\"address_line1\":\"210 KING ST STE 6100\",\"address_line2\":null,\"address_city\":\"SAN FRANCISCO\",\"address_state\":\"CA\",\"address_zip\":\"94107-1741\",\"address_country\":\"UNITED STATES\",\"metadata\":{},\"date_created\":\"2017-09-05T17:47:53.767Z\",\"date_modified\":\"2017-09-05T17:47:53.767Z\",\"deleted\":true,\"object\":\"address\"},\"url\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf.pdf?version=v1&expires=1618512040&signature=qvyCqXI1ndBvc4AjvG8FlirqLXEcfmYo4sDrRtabaXMOsX88to9G3K49uIk_aqevvZXe8HoRYD_nWydbQHqaCA\",\"outside_template_id\":\"tmpl_a3cb937f26d7eec\",\"inside_template_id\":\"tmpl_a3cb937f26d7eec\",\"inside_template_version_id\":\"vrsn_bfdf70893b00a85\",\"outside_template_version_id\":\"vrsn_bfdf70893b00a85\",\"carrier\":\"USPS\",\"tracking_events\":[],\"thumbnails\":[{\"small\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_small_1.png?version=v1&expires=1618512040&signature=-bipeUHP-hAMcCBSrWM0ZH1VwRdSPNVGGZN9hAZKr6Lh4ly6uxvratVd5LXJCK_zOEMYk_mTWASt0ge7OY6SDA\",\"medium\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_medium_1.png?version=v1&expires=1618512040&signature=ryxN7bsXGtw_GRFSP3Cs3A3IYjxZi3cW9BHDCNgMt6p3nobVmsc_iFHt2e-S7ndAXhhN7nP-MQVov3bt3r37BQ\",\"large\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_large_1.png?version=v1&expires=1618512040&signature=kBrm00xkyCkJNJRHxH8HshFaebtOxnzjVWOs1VVmGMuw8H6OBNcMAMxt9s49K0jlpHoh3Nr9uSncEZMQaaNjAg\"},{\"small\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_small_2.png?version=v1&expires=1618512040&signature=3gTgU7Fd3KoT_vNlQnTGptRps5ZgnkhSnPrAwk7L98higIzSwfKoLvuu_DIpMM48dHbxckKT9waR8euJ4KSDBQ\",\"medium\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_medium_2.png?version=v1&expires=1618512040&signature=Ue1lw5CMj7KRx6cMQL8xPeazaHCdJzWcACd1w3acuYPnWkVIpSt62OIO7hAtpAQK9xm1dhhlFj0rqRZMdRMMBA\",\"large\":\"https://lob-assets.com/self-mailers/sfm_8ffbe811dea49dcf_thumb_large_2.png?version=v1&expires=1618512040&signature=cICc7HEm1xG_eyM4a_wtvPk2FqoLRmtgGa29kJisWnMIYBL0OkyzG4ZCYGMhp-5cZpJlSpXfTgGKh_Qmeo1TDw\"}],\"merge_variables\":{\"name\":null},\"size\":\"6x18_bifold\",\"mail_type\":\"usps_first_class\",\"expected_delivery_date\":\"2021-03-24\",\"date_created\":\"2021-03-16T18:40:40.504Z\",\"date_modified\":\"2021-03-16T18:40:40.504Z\",\"send_date\":\"2021-03-16T18:45:40.493Z\",\"use_type\":\"marketing\",\"fsc\":false,\"object\":\"self_mailer\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}