
# Card Order

## Structure

`CardOrder`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `MObject` | `string` | Required | Value is resource type. |
| `Id` | `string` | Optional | Unique identifier prefixed with `co_`.<br>**Constraints**: *Pattern*: `^co_[a-zA-Z0-9]+$` |
| `CardId` | `string` | Optional | Unique identifier prefixed with `card_`.<br>**Constraints**: *Pattern*: `^card_[a-zA-Z0-9]+$` |
| `Status` | [`Status2Enum?`](../../doc/models/status-2-enum.md) | Optional | - |
| `Inventory` | `double?` | Optional | The inventory of the card order.<br>**Default**: `0` |
| `QuantityOrdered` | `double?` | Optional | The quantity of cards ordered<br>**Default**: `0` |
| `UnitPrice` | `double?` | Optional | The unit price for the card order.<br>**Default**: `0` |
| `CancelledReason` | `string` | Optional | The reason for cancellation. |
| `AvailabilityDate` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date the resource was created. |
| `ExpectedAvailabilityDate` | `DateTime?` | Optional | The fixed deadline for the cards to be printed. |

## Example (as JSON)

```json
{
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "object8",
  "inventory": 0.0,
  "quantity_ordered": 0,
  "unit_price": 0,
  "deleted": false,
  "id": "id4",
  "card_id": "card_id0",
  "status": "depleted"
}
```

