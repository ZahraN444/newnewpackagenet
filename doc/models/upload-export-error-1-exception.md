
# Upload Export Error 1 Exception

## Structure

`UploadExportError1Exception`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | [`Code1Enum`](../../doc/models/code-1-enum.md) | Required | - |
| `Message` | `string` | Required | A human-readable message with more details about the error |
| `Errors` | `List<string>` | Required | An array of pre-defined strings that identify an error |

## Example (as JSON)

```json
{
  "code": 400,
  "message": "Invalid body, check 'errors' property for more info.",
  "errors": [
    "type must be a string"
  ]
}
```

