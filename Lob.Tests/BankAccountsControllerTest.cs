// <copyright file="BankAccountsControllerTest.cs" company="APIMatic">
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
    /// BankAccountsControllerTest.
    /// </summary>
    [TestFixture]
    public class BankAccountsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private BankAccountsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.BankAccountsController;
        }

        /// <summary>
        /// Returns a list of your bank accounts. The bank accounts are returned sorted by creation date, with the most recently created bank accounts appearing first..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestBankAccountsList()
        {
            // Parameters for the API call
            int? limit = 10;
            Standard.Models.Beforeafter beforeAfter = null;
            List<string> include = null;
            Dictionary<string, string> dateCreated = null;
            Dictionary<string, string> metadata = null;

            // Perform API call
            Standard.Models.AllBankAccounts result = null;
            try
            {
                result = await this.controller.BankAccountsListAsync(limit, beforeAfter, include, dateCreated, metadata);
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
                    "{\"data\":[{\"id\":\"bank_0e3fb07eba0b35b\",\"signature_url\":\"https://lob-assets.com/letters/asd_asdfghjklqwertyu.pdf?version=45&expires=1234567890&signature=a\",\"description\":\"Example bank account\",\"metadata\":{},\"routing_number\":\"122100024\",\"account_number\":\"1234564789\",\"account_type\":\"company\",\"signatory\":\"John Doe\",\"bank_name\":\"JPMORGAN CHASE BANK, NA\",\"verified\":true,\"date_created\":\"2019-03-30T13:13:22.200Z\",\"date_modified\":\"2019-03-30T13:13:23.385Z\",\"object\":\"bank_account\"},{\"id\":\"bank_eba93f7de3c02d9\",\"description\":\"Example bank account\",\"metadata\":{},\"routing_number\":\"122100024\",\"account_number\":\"1234564789\",\"account_type\":\"company\",\"signatory\":\"John Doe\",\"bank_name\":\"JPMORGAN CHASE BANK, NA\",\"verified\":true,\"date_created\":\"2019-03-30T13:11:06.809Z\",\"date_modified\":\"2019-03-30T13:11:07.872Z\",\"object\":\"bank_account\"}],\"object\":\"list\",\"next_url\":\"https://api.lob.com/v1/bank_accounts?limit=2&after=eyJkYXRlT2Zmc2V0IjoiMjAxOS0wMy0zMFQxMzoxMTowNi44MDlaIiwiaWRPZmZzZXQiOiJiYW5rX2ViYTkzZjdkZTNjMDJkOSJ9\",\"previous_url\":null,\"count\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}