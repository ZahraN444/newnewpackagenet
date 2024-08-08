# Buckslip Orders

```csharp
BuckslipOrdersController buckslipOrdersController = client.BuckslipOrdersController;
```

## Class Name

`BuckslipOrdersController`

## Methods

* [Buckslip Orders Retrieve](../../doc/controllers/buckslip-orders.md#buckslip-orders-retrieve)
* [Buckslip Order Create](../../doc/controllers/buckslip-orders.md#buckslip-order-create)


# Buckslip Orders Retrieve

Retrieves the buckslip orders associated with the given buckslip id.

```csharp
BuckslipOrdersRetrieveAsync(
    string buckslipId,
    int? limit = 10,
    int? offset = 0)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `buckslipId` | `string` | Template, Required | The ID of the buckslip to which the buckslip orders belong. |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `offset` | `int?` | Query, Optional | An integer that designates the offset at which to begin returning results. Defaults to 0. |

## Response Type

[`Task<Models.BuckslipsOrdersResponse>`](../../doc/models/buckslips-orders-response.md)

## Example Usage

```csharp
string buckslipId = "buckslip_id6";
int? limit = 10;
int? offset = 0;
try
{
    BuckslipsOrdersResponse result = await buckslipOrdersController.BuckslipOrdersRetrieveAsync(
        buckslipId,
        limit,
        offset
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
  "data": [
    {
      "id": "bo_e0f8a0562a06bea7f",
      "buckslip_id": "bck_6afffd19045076c",
      "status": "available",
      "quantity_ordered": 5000,
      "unit_price": 0.75,
      "cancelled_reason": "No longer needed",
      "availability_date": "2021-10-12T21:41:48.326Z",
      "expected_availability_date": "2021-11-04T21:03:18.871Z",
      "date_created": "2021-10-07T21:03:18.871Z",
      "date_modified": "2021-10-16T01:00:30.144Z",
      "object": "buckslip_order"
    }
  ],
  "object": "list",
  "next_url": null,
  "previous_url": null,
  "count": 1
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |


# Buckslip Order Create

Creates a new buckslip order given information

```csharp
BuckslipOrderCreateAsync(
    string buckslipId,
    Models.ContentTypeEnum contentType,
    int quantity)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `buckslipId` | `string` | Template, Required | The ID of the buckslip to which the buckslip orders belong. |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `quantity` | `int` | Form, Required | The quantity of buckslips in the order (minimum 5,000). |

## Response Type

[`Task<Models.BuckslipOrder>`](../../doc/models/buckslip-order.md)

## Example Usage

```csharp
string buckslipId = "buckslip_id6";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
int quantity = 10000;
try
{
    BuckslipOrder result = await buckslipOrdersController.BuckslipOrderCreateAsync(
        buckslipId,
        contentType,
        quantity
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
  "id": "bo_e0f8a0562a06bea7f",
  "buckslip_id": "bck_6afffd19045076c",
  "status": "available",
  "quantity_ordered": 10000,
  "unit_price": 0.75,
  "cancelled_reason": "No longer needed",
  "availability_date": "2021-10-12T21:41:48.326Z",
  "expected_availability_date": "2021-11-04T21:03:18.871Z",
  "date_created": "2021-10-07T21:03:18.871Z",
  "date_modified": "2021-10-16T01:00:30.144Z",
  "object": "buckslip_order"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

