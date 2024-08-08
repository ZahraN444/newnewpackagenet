
# Tracking Event Normal

## Structure

`TrackingEventNormal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Unique identifier prefixed with `evnt_`.<br>**Constraints**: *Pattern*: `^evnt_[a-zA-Z0-9]+$` |
| `Time` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date USPS registered the event. |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `MObject` | [`Object3Enum`](../../doc/models/object-3-enum.md) | Required | - |
| `Type` | `string` | Required, Constant | non-Certified postcards, self mailers, letters, and checks<br>**Default**: `"normal"` |
| `Name` | [`NameEnum`](../../doc/models/name-enum.md) | Required | - |
| `Details` | [`object`](../../doc/models/m-object-enum.md) | Optional | Will be `null` for `type=normal` events |
| `Location` | `string` | Optional | The zip code in which the scan event occurred. Null for `Mailed` events. |

## Example (as JSON)

```json
{
  "id": "id0",
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "tracking_event",
  "type": "normal",
  "name": "Delivered",
  "time": "2016-03-13T12:52:32.123Z",
  "details": {
    "key1": "val1",
    "key2": "val2"
  },
  "location": "location4"
}
```

