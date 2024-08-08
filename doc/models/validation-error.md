
# Validation Error

## Structure

`ValidationError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Loc` | [`List<ValidationErrorLoc>`](../../doc/models/containers/validation-error-loc.md) | Required | This is List of a container for any-of cases. |
| `Msg` | `string` | Required | - |
| `Type` | `string` | Required | - |

## Example (as JSON)

```json
{
  "loc": [
    "String9",
    "String0"
  ],
  "msg": "msg4",
  "type": "type8"
}
```

