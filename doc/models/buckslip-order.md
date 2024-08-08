
# Buckslip Order

## Structure

`BuckslipOrder`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `MObject` | `string` | Required | Value is resource type. |
| `Id` | `string` | Optional | Unique identifier prefixed with `bo_`.<br>**Constraints**: *Pattern*: `^bo_[a-zA-Z0-9]+$` |
| `BuckslipId` | `string` | Optional | Unique identifier prefixed with `bck_`.<br>**Constraints**: *Pattern*: `^bck_[a-zA-Z0-9]+$` |
| `Status` | [`StatusEnum?`](../../doc/models/status-enum.md) | Optional | - |
| `QuantityOrdered` | `double?` | Optional | The quantity of buckslips ordered.<br>**Default**: `0` |
| `UnitPrice` | `double?` | Optional | The unit price for the buckslip order.<br>**Default**: `0` |
| `Inventory` | `double?` | Optional | The inventory of the buckslip order.<br>**Default**: `0` |
| `CancelledReason` | `string` | Optional | The reason for cancellation. |
| `AvailabilityDate` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date the resource was created. |
| `ExpectedAvailabilityDate` | `DateTime?` | Optional | The fixed deadline for the buckslips to be printed. |

## Example (as JSON)

```json
{
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "object2",
  "quantity_ordered": 0.0,
  "unit_price": 0,
  "inventory": 0,
  "deleted": false,
  "id": "id0",
  "buckslip_id": "buckslip_id6",
  "status": "cancelled"
}
```

