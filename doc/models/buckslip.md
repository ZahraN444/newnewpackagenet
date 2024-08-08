
# Buckslip

## Structure

`Buckslip`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"buckslip"` |
| `Description` | `string` | Required | Description of the buckslip.<br>**Constraints**: *Maximum Length*: `255` |
| `Size` | [`SizeEnum?`](../../doc/models/size-enum.md) | Optional | - |
| `Id` | `string` | Required | Unique identifier prefixed with `bck_`.<br>**Constraints**: *Pattern*: `^bck_[a-zA-Z0-9]+$` |
| `AutoReorder` | `bool` | Required | True if the buckslips should be auto-reordered. |
| `ReorderQuantity` | `int?` | Required | The number of buckslips to be reordered. |
| `ThresholdAmount` | `int` | Required | The threshold amount of the buckslip |
| `Url` | `string` | Required | The signed link for the buckslip.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `RawUrl` | `string` | Required | The raw URL of the buckslip.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `FrontOriginalUrl` | `string` | Required | The original URL of the front template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `BackOriginalUrl` | `string` | Required | The original URL of the back template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `Thumbnails` | [`List<Thumbnail>`](../../doc/models/thumbnail.md) | Required | - |
| `AvailableQuantity` | `double` | Required | The available quantity of buckslips. |
| `AllocatedQuantity` | `double` | Required | The allocated quantity of buckslips. |
| `OnhandQuantity` | `double` | Required | The onhand quantity of buckslips. |
| `PendingQuantity` | `double` | Required | The pending quantity of buckslips. |
| `ProjectedQuantity` | `double` | Required | The sum of pending and onhand quantities of buckslips. |
| `BuckslipOrders` | [`List<BuckslipOrder>`](../../doc/models/buckslip-order.md) | Required | An array of buckslip orders that are associated with the buckslip.<br>**Constraints**: *Minimum Items*: `0` |
| `Stock` | [`ThestockofthebuckslipEnum`](../../doc/models/thestockofthebuckslip-enum.md) | Required | - |
| `Weight` | `string` | Required, Constant | **Default**: `"80#"` |
| `Finish` | [`ThefinishofthebuckslipEnum`](../../doc/models/thefinishofthebuckslip-enum.md) | Required | - |
| `Status` | [`ThestatusofthebuckslipEnum`](../../doc/models/thestatusofthebuckslip-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "buckslip",
  "description": "description0",
  "id": "id0",
  "auto_reorder": false,
  "reorder_quantity": 254,
  "threshold_amount": 120,
  "url": "url4",
  "raw_url": "raw_url2",
  "front_original_url": "front_original_url6",
  "back_original_url": "back_original_url6",
  "thumbnails": [
    {
      "small": "small8",
      "medium": "medium8",
      "large": "large6"
    }
  ],
  "available_quantity": 89.78,
  "allocated_quantity": 3.82,
  "onhand_quantity": 14.26,
  "pending_quantity": 175.52,
  "projected_quantity": 156.88,
  "buckslip_orders": [
    {
      "date_created": "2016-03-13T12:52:32.123Z",
      "date_modified": "2016-03-13T12:52:32.123Z",
      "object": "object0",
      "quantity_ordered": 0.0,
      "unit_price": 0,
      "inventory": 0,
      "deleted": false,
      "id": "id2",
      "buckslip_id": "buckslip_id8",
      "status": "printing"
    }
  ],
  "stock": "text",
  "weight": "80#",
  "finish": "gloss",
  "status": "rendered",
  "deleted": false,
  "size": "8.75x3.75"
}
```

