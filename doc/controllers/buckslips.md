# Buckslips

The Buckslips endpoint allows you to easily create buckslips that can later be used as add-ons for Letters Campaigns. Note that a Letter Campaign with Buckslip add-on requires a minimum send quantity of 5,000 letters.
The API provides endpoints for creating buckslips, retrieving individual buckslips, creating buckslip orders, and retrieving a list of buckslips.

<div class="back-to-top" ><a href="#" onclick="toTopLink()">back to top</a></div>


```csharp
BuckslipsController buckslipsController = client.BuckslipsController;
```

## Class Name

`BuckslipsController`

## Methods

* [Buckslips List](../../doc/controllers/buckslips.md#buckslips-list)
* [Buckslip Create](../../doc/controllers/buckslips.md#buckslip-create)
* [Buckslip Retrieve](../../doc/controllers/buckslips.md#buckslip-retrieve)
* [Buckslip Update](../../doc/controllers/buckslips.md#buckslip-update)
* [Buckslip Delete](../../doc/controllers/buckslips.md#buckslip-delete)


# Buckslips List

Returns a list of your buckslips. The buckslips are returned sorted by creation date, with the most recently created buckslips appearing first.

```csharp
BuckslipsListAsync(
    int? limit = 10,
    Models.Beforeafter beforeAfter = null,
    List<string> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `beforeAfter` | [`Beforeafter`](../../doc/models/beforeafter.md) | Query, Optional | `before` and `after` are both optional but only one of them can be in the query at a time. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |

## Response Type

[`Task<Models.BuckslipsResponse>`](../../doc/models/buckslips-response.md)

## Example Usage

```csharp
int? limit = 10;
try
{
    BuckslipsResponse result = await buckslipsController.BuckslipsListAsync(limit);
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


# Buckslip Create

Creates a new buckslip given information

```csharp
BuckslipCreateAsync(
    Models.BuckslipEditable body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`BuckslipEditable`](../../doc/models/buckslip-editable.md) | Body, Required | - |

## Response Type

[`Task<Models.Buckslip>`](../../doc/models/buckslip.md)

## Example Usage

```csharp
BuckslipEditable body = new BuckslipEditable
{
    Front = BuckslipEditableFront.FromString("https://s3-us-west-2.amazonaws.com/public.lob.com/assets/buckslip.pdf"),
    Description = "Test buckslip",
    Back = BuckslipEditableBack.FromString("https://s3-us-west-2.amazonaws.com/public.lob.com/assets/buckslip.pdf"),
};

try
{
    Buckslip result = await buckslipsController.BuckslipCreateAsync(body);
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


# Buckslip Retrieve

Retrieves the details of an existing buckslip. You need only supply the unique customer identifier that was returned upon buckslip creation.

```csharp
BuckslipRetrieveAsync(
    string buckslipId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `buckslipId` | `string` | Template, Required | id of the buckslip |

## Response Type

[`Task<Models.Buckslip>`](../../doc/models/buckslip.md)

## Example Usage

```csharp
string buckslipId = "buckslip_id6";
try
{
    Buckslip result = await buckslipsController.BuckslipRetrieveAsync(buckslipId);
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


# Buckslip Update

Update the details of an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.

```csharp
BuckslipUpdateAsync(
    string buckslipId,
    Models.ContentTypeEnum contentType,
    string description = null,
    bool? autoReorder = null,
    double? reorderQuantity = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `buckslipId` | `string` | Template, Required | id of the buckslip |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `description` | `string` | Form, Optional | Description of the buckslip. |
| `autoReorder` | `bool?` | Form, Optional | Allows for auto reordering |
| `reorderQuantity` | `double?` | Form, Optional | The quantity of items to be reordered (only required when auto_reorder is true). |

## Response Type

[`Task<Models.Buckslip>`](../../doc/models/buckslip.md)

## Example Usage

```csharp
string buckslipId = "buckslip_id6";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
string description = "Test buckslip";
bool? autoReorder = true;
try
{
    Buckslip result = await buckslipsController.BuckslipUpdateAsync(
        buckslipId,
        contentType,
        description,
        autoReorder
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


# Buckslip Delete

Delete an existing buckslip. You need only supply the unique identifier that was returned upon buckslip creation.

```csharp
BuckslipDeleteAsync(
    string buckslipId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `buckslipId` | `string` | Template, Required | id of the buckslip |

## Response Type

[`Task<Models.BuckslipsResponse1>`](../../doc/models/buckslips-response-1.md)

## Example Usage

```csharp
string buckslipId = "buckslip_id6";
try
{
    BuckslipsResponse1 result = await buckslipsController.BuckslipDeleteAsync(buckslipId);
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

