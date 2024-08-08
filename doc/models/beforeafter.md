
# Beforeafter

## Structure

`Beforeafter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Before` | `string` | Required | A reference to a list entry used for paginating to the previous set of entries. This field is pre-populated in the `previous_url` field in the return response. |
| `After` | `string` | Required | A reference to a list entry used for paginating to the next set of entries. This field is pre-populated in the `next_url` field in the return response. |

## Example (as JSON)

```json
{
  "before": "before4",
  "after": "after6"
}
```

