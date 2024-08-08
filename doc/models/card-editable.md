
# Card Editable

## Structure

`CardEditable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | Description of the card.<br>**Constraints**: *Maximum Length*: `255` |
| `Size` | [`Size1Enum?`](../../doc/models/size-1-enum.md) | Optional | - |
| `Front` | [`CardEditableFront`](../../doc/models/containers/card-editable-front.md) | Required | This is a container for one-of cases. |
| `Back` | [`CardEditableBack`](../../doc/models/containers/card-editable-back.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "description": "description8",
  "size": "3.375x2.125",
  "front": "String9",
  "back": "String7"
}
```

