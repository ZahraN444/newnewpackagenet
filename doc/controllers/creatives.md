# Creatives

The creatives endpoint allows you to create and view creatives. Creatives are used to create
reusable letter and postcard templates. The API provides endpoints for creating creatives, updating creatives,
retrieving individual creatives, and deleting creatives.

```csharp
CreativesController creativesController = client.CreativesController;
```

## Class Name

`CreativesController`

## Methods

* [Creative Create](../../doc/controllers/creatives.md#creative-create)
* [Creative Retrieve](../../doc/controllers/creatives.md#creative-retrieve)
* [Creative Update](../../doc/controllers/creatives.md#creative-update)


# Creative Create

Creates a new creative with the provided properties

```csharp
CreativeCreateAsync(
    object body,
    Models.XLangOutput1Enum? xLangOutput = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`object`](../../doc/models/m-object-enum.md) | Body, Required | - |
| `xLangOutput` | [`XLangOutput1Enum?`](../../doc/models/x-lang-output-1-enum.md) | Header, Optional | * `native` - Translate response to the native language of the country in the request<br>* `match` - match the response to the language in the request<br><br>Default response is in English. |

## Response Type

[`Task<Models.Creative>`](../../doc/models/creative.md)

## Example Usage

```csharp
object body = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}");
try
{
    Creative result = await creativesController.CreativeCreateAsync(body);
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


# Creative Retrieve

Retrieves the details of an existing creative. You need only supply the unique creative identifier that was returned upon creative creation.

```csharp
CreativeRetrieveAsync(
    string crvId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `crvId` | `string` | Template, Required | id of the creative |

## Response Type

[`Task<Models.Creative>`](../../doc/models/creative.md)

## Example Usage

```csharp
string crvId = "crv_2a3b096c409b32c";
try
{
    Creative result = await creativesController.CreativeRetrieveAsync(crvId);
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


# Creative Update

Update the details of an existing creative. You need only supply the unique identifier that was returned upon creative creation.

```csharp
CreativeUpdateAsync(
    string crvId,
    Models.ContentTypeEnum contentType,
    FileStreamInfo from = null,
    string description = null,
    Dictionary<string, string> metadata = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `crvId` | `string` | Template, Required | id of the creative |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `from` | `FileStreamInfo` | Form, Optional | - |
| `description` | `string` | Form, Optional | An internal description that identifies this resource. Must be no longer than 255 characters. |
| `metadata` | `Dictionary<string, string>` | Form, Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |

## Response Type

[`Task<Models.Creative>`](../../doc/models/creative.md)

## Example Usage

```csharp
string crvId = "crv_2a3b096c409b32c";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string description = "Test creative";
try
{
    Creative result = await creativesController.CreativeUpdateAsync(
        crvId,
        contentType,
        null,
        description
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

