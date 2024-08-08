
# Identity Validation 0 Error 1

## Structure

`IdentityValidation0Error1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | [`Error1`](../../doc/models/error-1.md) | Required | - |

## Example (as JSON)

```json
{
  "error": {
    "message": "Rate limit exceeded. Please wait 5 seconds and try your request again.",
    "status_code": 413,
    "code": "service_unavailable"
  }
}
```

