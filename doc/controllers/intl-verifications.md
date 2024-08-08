# Intl Verifications

```csharp
IntlVerificationsController intlVerificationsController = client.IntlVerificationsController;
```

## Class Name

`IntlVerificationsController`

## Methods

* [Bulk Intl Verifications](../../doc/controllers/intl-verifications.md#bulk-intl-verifications)
* [Intl Verification](../../doc/controllers/intl-verifications.md#intl-verification)


# Bulk Intl Verifications

Verify a list of international (except US or US territories) address _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.

```csharp
BulkIntlVerificationsAsync(
    Models.ContentTypeEnum contentType,
    List<Models.MultipleComponentsIntl> addresses)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `addresses` | [`List<MultipleComponentsIntl>`](../../doc/models/multiple-components-intl.md) | Form, Required | - |

## Response Type

[`Task<Models.IntlVerifications>`](../../doc/models/intl-verifications.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
List<Models.MultipleComponentsIntl> addresses = new List<Models.MultipleComponentsIntl>
{
    new MultipleComponentsIntl
    {
        PrimaryLine = "370 Water St",
        Country = CountryExtendedEnum.CA,
        Recipient = "John Doe",
        SecondaryLine = "",
        City = "Summerside",
        State = "Prince Edwards Island",
        PostalCode = "C1N 1C4",
    },
    new MultipleComponentsIntl
    {
        PrimaryLine = "UL. DOLSKAYA 1",
        Country = CountryExtendedEnum.RU,
        Recipient = "Jane Doe",
        SecondaryLine = "",
        City = "MOSCOW",
        State = "MOSCOW G",
        PostalCode = "115569",
    },
};

try
{
    IntlVerifications result = await intlVerificationsController.BulkIntlVerificationsAsync(
        contentType,
        addresses
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "addresses": [
    {
      "id": "intl_ver_c7cb63d68f8d6",
      "recipient": null,
      "primary_line": "370 WATER ST",
      "secondary_line": "",
      "last_line": "SUMMERSIDE PE C1N 1C4",
      "country": "CA",
      "coverage": "SUBBUILDING",
      "deliverability": "deliverable",
      "status": "LV4",
      "components": {
        "primary_number": "370",
        "street_name": "WATER ST",
        "city": "SUMMERSIDE",
        "state": "PE",
        "postal_code": "C1N 1C4"
      },
      "object": "intl_verification"
    }
  ],
  "errors": false
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Intl Verification

Verify an international (except US or US territories) address _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.

```csharp
IntlVerificationAsync(
    object body,
    Models.XLangOutput1Enum? xLangOutput = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`object`](../../doc/models/m-object-enum.md) | Body, Required | - |
| `xLangOutput` | [`XLangOutput1Enum?`](../../doc/models/x-lang-output-1-enum.md) | Header, Optional | * `native` - Translate response to the native language of the country in the request<br>* `match` - match the response to the language in the request<br><br>Default response is in English. |

## Response Type

[`Task<Models.IntlVerification>`](../../doc/models/intl-verification.md)

## Example Usage

```csharp
object body = ApiHelper.JsonDeserialize<object>("{\"recipient\":\"Harry Zhang\",\"primary_line\":\"370 Water St\",\"secondary_line\":\"\",\"city\":\"Summerside\",\"state\":\"Prince Edward Island\",\"postal code\":\"C1N 1C4\",\"country\":\"CA\"}");
try
{
    IntlVerification result = await intlVerificationsController.IntlVerificationAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "id": "intl_ver_c7cb63d68f8d6",
  "recipient": null,
  "primary_line": "370 WATER ST",
  "secondary_line": "",
  "last_line": "SUMMERSIDE PE C1N 1C4",
  "country": "CA",
  "coverage": "SUBBUILDING",
  "deliverability": "deliverable",
  "status": "LV4",
  "components": {
    "primary_number": "370",
    "street_name": "WATER ST",
    "city": "SUMMERSIDE",
    "state": "PE",
    "postal_code": "C1N 1C4"
  },
  "object": "intl_verification"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

