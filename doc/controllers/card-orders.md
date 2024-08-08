# Card Orders

```csharp
CardOrdersController cardOrdersController = client.CardOrdersController;
```

## Class Name

`CardOrdersController`

## Methods

* [Card Orders Retrieve](../../doc/controllers/card-orders.md#card-orders-retrieve)
* [Card Order Create](../../doc/controllers/card-orders.md#card-order-create)


# Card Orders Retrieve

Retrieves the card orders associated with the given card id.

```csharp
CardOrdersRetrieveAsync(
    string cardId,
    int? limit = 10,
    int? offset = 0)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `cardId` | `string` | Template, Required | The ID of the card to which the card orders belong. |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `offset` | `int?` | Query, Optional | An integer that designates the offset at which to begin returning results. Defaults to 0. |

## Response Type

[`Task<Models.CardsOrdersResponse>`](../../doc/models/cards-orders-response.md)

## Example Usage

```csharp
string cardId = "card_id4";
int? limit = 10;
int? offset = 0;
try
{
    CardsOrdersResponse result = await cardOrdersController.CardOrdersRetrieveAsync(
        cardId,
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
      "id": "co_e0f8a0562a06bea7f",
      "card_id": "card_6afffd19045076c",
      "status": "available",
      "inventory": 9500,
      "quantity_ordered": 10000,
      "unit_price": 0.75,
      "cancelled_reason": "No longer needed",
      "availability_date": "2021-10-12T21:41:48.326Z",
      "expected_availability_date": "2021-11-04T21:03:18.871Z",
      "date_created": "2021-10-07T21:03:18.871Z",
      "date_modified": "2021-10-16T01:00:30.144Z",
      "object": "card_order"
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


# Card Order Create

Creates a new card order given information

```csharp
CardOrderCreateAsync(
    string cardId,
    Models.ContentTypeEnum contentType,
    int quantity)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `cardId` | `string` | Template, Required | The ID of the card to which the card orders belong. |
| `contentType` | [`ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `quantity` | `int` | Form, Required | The quantity of cards in the order (minimum 10,000). |

## Response Type

[`Task<Models.CardOrder>`](../../doc/models/card-order.md)

## Example Usage

```csharp
string cardId = "card_id4";
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationxwwwformurlencoded;
int quantity = 10000;
try
{
    CardOrder result = await cardOrdersController.CardOrderCreateAsync(
        cardId,
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
  "id": "co_e0f8a0562a06bea7f",
  "card_id": "card_6afffd19045076c",
  "status": "available",
  "inventory": 9500,
  "quantity_ordered": 10000,
  "unit_price": 0.75,
  "cancelled_reason": "No longer needed",
  "availability_date": "2021-10-12T21:41:48.326Z",
  "expected_availability_date": "2021-11-04T21:03:18.871Z",
  "date_created": "2021-10-07T21:03:18.871Z",
  "date_modified": "2021-10-16T01:00:30.144Z",
  "object": "card_order"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error | [`Domains0Error1Exception`](../../doc/models/domains-0-error-1-exception.md) |

