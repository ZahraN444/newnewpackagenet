// <copyright file="LobClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using Lob.Standard.Authentication;
    using Lob.Standard.Controllers;
    using Lob.Standard.Http.Client;
    using Lob.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class LobClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.lob.com/v1" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallBack httpCallBack;
        private readonly Lazy<AddressesController> addresses;
        private readonly Lazy<BankAccountsController> bankAccounts;
        private readonly Lazy<BillingGroupsController> billingGroups;
        private readonly Lazy<BuckslipOrdersController> buckslipOrders;
        private readonly Lazy<BuckslipsController> buckslips;
        private readonly Lazy<CampaignsController> campaigns;
        private readonly Lazy<CardOrdersController> cardOrders;
        private readonly Lazy<CardsController> cards;
        private readonly Lazy<ChecksController> checks;
        private readonly Lazy<CreativesController> creatives;
        private readonly Lazy<IdentityValidationController> identityValidation;
        private readonly Lazy<IntlAutocompletionsController> intlAutocompletions;
        private readonly Lazy<IntlVerificationsController> intlVerifications;
        private readonly Lazy<LettersController> letters;
        private readonly Lazy<PostcardsController> postcards;
        private readonly Lazy<QRCodesController> qRCodes;
        private readonly Lazy<ReverseGeocodeLookupsController> reverseGeocodeLookups;
        private readonly Lazy<SelfMailersController> selfMailers;
        private readonly Lazy<TemplateVersionsController> templateVersions;
        private readonly Lazy<TemplatesController> templates;
        private readonly Lazy<UploadsController> uploads;
        private readonly Lazy<URLShortenerController> uRLShortener;
        private readonly Lazy<USAutocompletionsController> uSAutocompletions;
        private readonly Lazy<USVerificationsController> uSVerifications;
        private readonly Lazy<ZipLookupsController> zipLookups;

        private LobClient(
            Environment environment,
            BasicAuthModel basicAuthModel,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            BasicAuthModel = basicAuthModel;
            var basicAuthManager = new BasicAuthManager(basicAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"basicAuth", basicAuthManager},
                })
                .ApiCallback(httpCallBack)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            BasicAuthCredentials = basicAuthManager;

            this.addresses = new Lazy<AddressesController>(
                () => new AddressesController(globalConfiguration));
            this.bankAccounts = new Lazy<BankAccountsController>(
                () => new BankAccountsController(globalConfiguration));
            this.billingGroups = new Lazy<BillingGroupsController>(
                () => new BillingGroupsController(globalConfiguration));
            this.buckslipOrders = new Lazy<BuckslipOrdersController>(
                () => new BuckslipOrdersController(globalConfiguration));
            this.buckslips = new Lazy<BuckslipsController>(
                () => new BuckslipsController(globalConfiguration));
            this.campaigns = new Lazy<CampaignsController>(
                () => new CampaignsController(globalConfiguration));
            this.cardOrders = new Lazy<CardOrdersController>(
                () => new CardOrdersController(globalConfiguration));
            this.cards = new Lazy<CardsController>(
                () => new CardsController(globalConfiguration));
            this.checks = new Lazy<ChecksController>(
                () => new ChecksController(globalConfiguration));
            this.creatives = new Lazy<CreativesController>(
                () => new CreativesController(globalConfiguration));
            this.identityValidation = new Lazy<IdentityValidationController>(
                () => new IdentityValidationController(globalConfiguration));
            this.intlAutocompletions = new Lazy<IntlAutocompletionsController>(
                () => new IntlAutocompletionsController(globalConfiguration));
            this.intlVerifications = new Lazy<IntlVerificationsController>(
                () => new IntlVerificationsController(globalConfiguration));
            this.letters = new Lazy<LettersController>(
                () => new LettersController(globalConfiguration));
            this.postcards = new Lazy<PostcardsController>(
                () => new PostcardsController(globalConfiguration));
            this.qRCodes = new Lazy<QRCodesController>(
                () => new QRCodesController(globalConfiguration));
            this.reverseGeocodeLookups = new Lazy<ReverseGeocodeLookupsController>(
                () => new ReverseGeocodeLookupsController(globalConfiguration));
            this.selfMailers = new Lazy<SelfMailersController>(
                () => new SelfMailersController(globalConfiguration));
            this.templateVersions = new Lazy<TemplateVersionsController>(
                () => new TemplateVersionsController(globalConfiguration));
            this.templates = new Lazy<TemplatesController>(
                () => new TemplatesController(globalConfiguration));
            this.uploads = new Lazy<UploadsController>(
                () => new UploadsController(globalConfiguration));
            this.uRLShortener = new Lazy<URLShortenerController>(
                () => new URLShortenerController(globalConfiguration));
            this.uSAutocompletions = new Lazy<USAutocompletionsController>(
                () => new USAutocompletionsController(globalConfiguration));
            this.uSVerifications = new Lazy<USVerificationsController>(
                () => new USVerificationsController(globalConfiguration));
            this.zipLookups = new Lazy<ZipLookupsController>(
                () => new ZipLookupsController(globalConfiguration));
        }

        /// <summary>
        /// Gets AddressesController controller.
        /// </summary>
        public AddressesController AddressesController => this.addresses.Value;

        /// <summary>
        /// Gets BankAccountsController controller.
        /// </summary>
        public BankAccountsController BankAccountsController => this.bankAccounts.Value;

        /// <summary>
        /// Gets BillingGroupsController controller.
        /// </summary>
        public BillingGroupsController BillingGroupsController => this.billingGroups.Value;

        /// <summary>
        /// Gets BuckslipOrdersController controller.
        /// </summary>
        public BuckslipOrdersController BuckslipOrdersController => this.buckslipOrders.Value;

        /// <summary>
        /// Gets BuckslipsController controller.
        /// </summary>
        public BuckslipsController BuckslipsController => this.buckslips.Value;

        /// <summary>
        /// Gets CampaignsController controller.
        /// </summary>
        public CampaignsController CampaignsController => this.campaigns.Value;

        /// <summary>
        /// Gets CardOrdersController controller.
        /// </summary>
        public CardOrdersController CardOrdersController => this.cardOrders.Value;

        /// <summary>
        /// Gets CardsController controller.
        /// </summary>
        public CardsController CardsController => this.cards.Value;

        /// <summary>
        /// Gets ChecksController controller.
        /// </summary>
        public ChecksController ChecksController => this.checks.Value;

        /// <summary>
        /// Gets CreativesController controller.
        /// </summary>
        public CreativesController CreativesController => this.creatives.Value;

        /// <summary>
        /// Gets IdentityValidationController controller.
        /// </summary>
        public IdentityValidationController IdentityValidationController => this.identityValidation.Value;

        /// <summary>
        /// Gets IntlAutocompletionsController controller.
        /// </summary>
        public IntlAutocompletionsController IntlAutocompletionsController => this.intlAutocompletions.Value;

        /// <summary>
        /// Gets IntlVerificationsController controller.
        /// </summary>
        public IntlVerificationsController IntlVerificationsController => this.intlVerifications.Value;

        /// <summary>
        /// Gets LettersController controller.
        /// </summary>
        public LettersController LettersController => this.letters.Value;

        /// <summary>
        /// Gets PostcardsController controller.
        /// </summary>
        public PostcardsController PostcardsController => this.postcards.Value;

        /// <summary>
        /// Gets QRCodesController controller.
        /// </summary>
        public QRCodesController QRCodesController => this.qRCodes.Value;

        /// <summary>
        /// Gets ReverseGeocodeLookupsController controller.
        /// </summary>
        public ReverseGeocodeLookupsController ReverseGeocodeLookupsController => this.reverseGeocodeLookups.Value;

        /// <summary>
        /// Gets SelfMailersController controller.
        /// </summary>
        public SelfMailersController SelfMailersController => this.selfMailers.Value;

        /// <summary>
        /// Gets TemplateVersionsController controller.
        /// </summary>
        public TemplateVersionsController TemplateVersionsController => this.templateVersions.Value;

        /// <summary>
        /// Gets TemplatesController controller.
        /// </summary>
        public TemplatesController TemplatesController => this.templates.Value;

        /// <summary>
        /// Gets UploadsController controller.
        /// </summary>
        public UploadsController UploadsController => this.uploads.Value;

        /// <summary>
        /// Gets URLShortenerController controller.
        /// </summary>
        public URLShortenerController URLShortenerController => this.uRLShortener.Value;

        /// <summary>
        /// Gets USAutocompletionsController controller.
        /// </summary>
        public USAutocompletionsController USAutocompletionsController => this.uSAutocompletions.Value;

        /// <summary>
        /// Gets USVerificationsController controller.
        /// </summary>
        public USVerificationsController USVerificationsController => this.uSVerifications.Value;

        /// <summary>
        /// Gets ZipLookupsController controller.
        /// </summary>
        public ZipLookupsController ZipLookupsController => this.zipLookups.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        internal HttpCallBack HttpCallBack => this.httpCallBack;

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        public BasicAuthModel BasicAuthModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the LobClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallBack(httpCallBack)
                .HttpClientConfig(config => config.Build());

            if (BasicAuthModel != null)
            {
                builder.BasicAuthCredentials(BasicAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> LobClient.</returns>
        internal static LobClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("LOB_STANDARD_ENVIRONMENT");
            string basicAuthUserName = System.Environment.GetEnvironmentVariable("LOB_STANDARD_BASIC_AUTH_USER_NAME");
            string basicAuthPassword = System.Environment.GetEnvironmentVariable("LOB_STANDARD_BASIC_AUTH_PASSWORD");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (basicAuthUserName != null && basicAuthPassword != null)
            {
                builder.BasicAuthCredentials(new BasicAuthModel
                .Builder(basicAuthUserName, basicAuthPassword)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = Lob.Standard.Environment.Production;
            private BasicAuthModel basicAuthModel = new BasicAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthUserName">BasicAuthUserName.</param>
            /// <param name="basicAuthPassword">BasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            [Obsolete("This method is deprecated. Use BasicAuthCredentials(basicAuthModel) instead.")]
            public Builder BasicAuthCredentials(string basicAuthUserName, string basicAuthPassword)
            {
                basicAuthModel = basicAuthModel.ToBuilder()
                    .Username(basicAuthUserName)
                    .Password(basicAuthPassword)
                    .Build();
                return this;
            }

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthModel">BasicAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(BasicAuthModel basicAuthModel)
            {
                if (basicAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(basicAuthModel));
                }

                this.basicAuthModel = basicAuthModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }


           

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the LobClient using the values provided for the builder.
            /// </summary>
            /// <returns>LobClient.</returns>
            public LobClient Build()
            {
                if (basicAuthModel.Username == null || basicAuthModel.Password == null)
                {
                    basicAuthModel = null;
                }
                return new LobClient(
                    environment,
                    basicAuthModel,
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}
