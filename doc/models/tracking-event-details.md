
# Tracking Event Details

## Structure

`TrackingEventDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Event` | [`EventEnum`](../../doc/models/event-enum.md) | Required | - |
| `Description` | `string` | Required | The description as listed in the description for event. |
| `Notes` | `string` | Optional | Event-specific notes from USPS about the tracking event. |
| `ActionRequired` | `bool` | Required | `true` if action is required by the end recipient, `false` otherwise. |

## Example (as JSON)

```json
{
  "event": "contact_carrier",
  "description": "description4",
  "notes": "notes4",
  "action_required": false
}
```

