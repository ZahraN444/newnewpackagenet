
# Billing Group

## Structure

`BillingGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | Description of the billing group.<br>**Constraints**: *Maximum Length*: `255` |
| `Name` | `string` | Optional | Name of the billing group.<br>**Constraints**: *Maximum Length*: `255` |
| `Id` | `string` | Optional | Unique identifier prefixed with `bg_`.<br>**Constraints**: *Pattern*: `^bg_[a-zA-Z0-9]+$` |
| `DateCreated` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `MObject` | [`MObjectEnum`](../../doc/models/m-object-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "description": "description0",
  "name": "name0",
  "id": "id0",
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z"
}
```

