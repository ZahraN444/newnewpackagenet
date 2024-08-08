
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthCredentials` | [`BasicAuthCredentials`]($basicauth) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

```csharp
Lob.Standard.LobClient client = new Lob.Standard.LobClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "BasicAuthUserName",
            "BasicAuthPassword"
        )
        .Build())
    .Build();
```

## LobClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| AddressesController | Gets AddressesController controller. |
| BankAccountsController | Gets BankAccountsController controller. |
| BillingGroupsController | Gets BillingGroupsController controller. |
| BuckslipOrdersController | Gets BuckslipOrdersController controller. |
| BuckslipsController | Gets BuckslipsController controller. |
| CampaignsController | Gets CampaignsController controller. |
| CardOrdersController | Gets CardOrdersController controller. |
| CardsController | Gets CardsController controller. |
| ChecksController | Gets ChecksController controller. |
| CreativesController | Gets CreativesController controller. |
| IdentityValidationController | Gets IdentityValidationController controller. |
| IntlAutocompletionsController | Gets IntlAutocompletionsController controller. |
| IntlVerificationsController | Gets IntlVerificationsController controller. |
| LettersController | Gets LettersController controller. |
| PostcardsController | Gets PostcardsController controller. |
| QRCodesController | Gets QRCodesController controller. |
| ReverseGeocodeLookupsController | Gets ReverseGeocodeLookupsController controller. |
| SelfMailersController | Gets SelfMailersController controller. |
| TemplateVersionsController | Gets TemplateVersionsController controller. |
| TemplatesController | Gets TemplatesController controller. |
| UploadsController | Gets UploadsController controller. |
| URLShortenerController | Gets URLShortenerController controller. |
| USAutocompletionsController | Gets USAutocompletionsController controller. |
| USVerificationsController | Gets USVerificationsController controller. |
| ZipLookupsController | Gets ZipLookupsController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`]($basicauth) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the LobClient using the values provided for the builder. | `Builder` |

## LobClient Builder Class

Class to build instances of LobClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |

