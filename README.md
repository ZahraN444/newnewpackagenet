
# Getting Started with Lob

## Introduction

The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p>

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package MypackageSDK --version 4.5.5
```

You can also view the package at:
https://www.nuget.org/packages/MypackageSDK/4.5.5

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/client.md)

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

## Authorization

This API uses the following authentication schemes.

* [`basicAuth (Basic Authentication)`](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/$basicauth)

## List of APIs

* [Bank Accounts](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/bank-accounts.md)
* [Billing Groups](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/billing-groups.md)
* [Buckslip Orders](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/buckslip-orders.md)
* [Card Orders](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/card-orders.md)
* [Identity Validation](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/identity-validation.md)
* [Intl Autocompletions](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/intl-autocompletions.md)
* [Intl Verifications](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/intl-verifications.md)
* [QR Codes](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/qr-codes.md)
* [Reverse Geocode Lookups](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/reverse-geocode-lookups.md)
* [Self Mailers](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/self-mailers.md)
* [Template Versions](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/template-versions.md)
* [URL Shortener](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/url-shortener.md)
* [US Autocompletions](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/us-autocompletions.md)
* [US Verifications](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/us-verifications.md)
* [Zip Lookups](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/zip-lookups.md)
* [Addresses](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/addresses.md)
* [Buckslips](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/buckslips.md)
* [Campaigns](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/campaigns.md)
* [Cards](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/cards.md)
* [Checks](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/checks.md)
* [Creatives](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/creatives.md)
* [Letters](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/letters.md)
* [Postcards](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/postcards.md)
* [Templates](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/templates.md)
* [Uploads](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/controllers/uploads.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/http-request.md)
* [HttpResponse](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/http-string-response.md)
* [HttpContext](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/ZahraN444/newnewpackagenet/tree/4.5.5/doc/api-exception.md)

