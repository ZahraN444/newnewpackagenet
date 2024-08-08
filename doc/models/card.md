
# Card

## Structure

`Card`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"card"` |
| `Description` | `string` | Required | Description of the card.<br>**Constraints**: *Maximum Length*: `255` |
| `Size` | [`Size1Enum?`](../../doc/models/size-1-enum.md) | Optional | - |
| `Id` | `string` | Required | Unique identifier prefixed with `card_`.<br>**Constraints**: *Pattern*: `^card_[a-zA-Z0-9]+$` |
| `Url` | `string` | Required | The signed link for the card.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `AutoReorder` | `bool` | Required | True if the cards should be auto-reordered. |
| `ReorderQuantity` | `int?` | Required | The number of cards to be reordered. |
| `RawUrl` | `string` | Required | The raw URL of the card.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `FrontOriginalUrl` | `string` | Required | The original URL of the front template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `BackOriginalUrl` | `string` | Required | The original URL of the back template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `Thumbnails` | [`List<Thumbnail>`](../../doc/models/thumbnail.md) | Required | - |
| `AvailableQuantity` | `int` | Required | The available quantity of cards. |
| `PendingQuantity` | `int` | Required | The pending quantity of cards. |
| `Status` | [`ThestatusofthecardEnum`](../../doc/models/thestatusofthecard-enum.md) | Required | - |
| `Orientation` | [`OrientationEnum`](../../doc/models/orientation-enum.md) | Required | - |
| `ThresholdAmount` | `int` | Required | The threshold amount of the card |

## Example (as JSON)

```json
{
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "card",
  "description": "description6",
  "id": "id6",
  "url": "url0",
  "auto_reorder": false,
  "reorder_quantity": 2,
  "raw_url": "raw_url8",
  "front_original_url": "front_original_url0",
  "back_original_url": "back_original_url2",
  "thumbnails": [
    {
      "small": "small8",
      "medium": "medium8",
      "large": "large6"
    }
  ],
  "available_quantity": 22,
  "pending_quantity": 140,
  "status": "processed",
  "orientation": "horizontal",
  "threshold_amount": 124,
  "deleted": false,
  "size": "3.375x2.125"
}
```

