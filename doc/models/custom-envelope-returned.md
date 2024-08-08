
# Custom Envelope Returned

A nested custom envelope object containing more information about the custom envelope used or `null` if a custom envelope was not used.

## Structure

`CustomEnvelopeReturned`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The unique identifier of the custom envelope used.<br>**Constraints**: *Maximum Length*: `40` |
| `Url` | `string` | Required | The url of the envelope asset used. |
| `MObject` | `string` | Required, Constant | **Default**: `"envelope"` |

## Example (as JSON)

```json
{
  "id": "id6",
  "url": "url0",
  "object": "envelope"
}
```

