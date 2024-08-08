# US Verifications

```csharp
USVerificationsController uSVerificationsController = client.USVerificationsController;
```

## Class Name

`USVerificationsController`

## Methods

* [Bulk Us Verifications](../../doc/controllers/us-verifications.md#bulk-us-verifications)
* [Us Verification](../../doc/controllers/us-verifications.md#us-verification)


# Bulk Us Verifications

Verify a list of US or US territory addresses _with a live API key_. Requests to this endpoint with a test API key will return a dummy response based on the primary line you input.

```csharp
BulkUsVerificationsAsync(
    Models.ContentTypeEnum contentType,
    List<Models.MultipleComponents> addresses,
    Models.Case2Enum? mCase = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `addresses` | [`List<MultipleComponents>`](../../doc/models/multiple-components.md) | Form, Required | - |
| `mCase` | [`Case2Enum?`](../../doc/models/case-2-enum.md) | Query, Optional | Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `recipient`, `primary_line`, `secondary_line`, `urbanization`, and `last_line`. Default casing is `upper`. |

## Response Type

[`Task<Models.UsVerifications>`](../../doc/models/us-verifications.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
List<Models.MultipleComponents> addresses = new List<Models.MultipleComponents>
{
    new MultipleComponents
    {
        PrimaryLine = "210 King Street",
        City = "San Francisco",
        State = "CA",
        ZipCode = "94107",
    },
    new MultipleComponents
    {
        PrimaryLine = "Ave Wilson Churchill 123",
        City = "RIO PIEDRAS",
        State = "PR",
        ZipCode = "00926",
        Recipient = "Walgreens",
        SecondaryLine = "",
        Urbanization = "URB FAIR OAKS",
    },
};

try
{
    UsVerifications result = await uSVerificationsController.BulkUsVerificationsAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Us Verification

Verify a US or US territory address _with a live API key_. The address can be in components (e.g. `primary_line` is "210 King Street", `zip_code` is "94107") or as a single string (e.g. "210 King Street 94107"), but not as both. Requests using a test API key validate required fields but return empty values unless specific `primary_line` values are provided. See the [US Verifications Test Environment](#section/US-Verifications-Test-Env) for details.

```csharp
UsVerificationAsync(
    object body,
    Models.Case2Enum? mCase = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`object`](../../doc/models/m-object-enum.md) | Body, Required | - |
| `mCase` | [`Case2Enum?`](../../doc/models/case-2-enum.md) | Query, Optional | Casing of the verified address. Possible values are `upper` and `proper` for uppercased (e.g. "PO BOX") and proper-cased (e.g. "PO Box"), respectively. Only affects `recipient`, `primary_line`, `secondary_line`, `urbanization`, and `last_line`. Default casing is `upper`. |

## Response Type

[`Task<Models.UsVerification>`](../../doc/models/us-verification.md)

## Example Usage

```csharp
object body = ApiHelper.JsonDeserialize<object>("{\"primary_line\":\"210 King Street\",\"city\":\"San Francisco\",\"state\":\"CA\",\"zip_code\":\"94107\"}");
try
{
    UsVerification result = await uSVerificationsController.UsVerificationAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

