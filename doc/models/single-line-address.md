
# Single Line Address

## Structure

`SingleLineAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | `string` | Required | The entire address in one string (e.g., "210 King Street 94107"). _Does not support a recipient and will error when other payload parameters are provided._<br>**Constraints**: *Maximum Length*: `500` |

## Example (as JSON)

```json
{
  "address": "address4"
}
```

