
# Buckslip Editable

## Structure

`BuckslipEditable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | Description of the buckslip.<br>**Constraints**: *Maximum Length*: `255` |
| `Size` | [`SizeEnum?`](../../doc/models/size-enum.md) | Optional | - |
| `Front` | [`BuckslipEditableFront`](../../doc/models/containers/buckslip-editable-front.md) | Required | This is a container for one-of cases. |
| `Back` | [`BuckslipEditableBack`](../../doc/models/containers/buckslip-editable-back.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "description": "description2",
  "size": "8.75x3.75",
  "front": "String9",
  "back": "String5"
}
```

