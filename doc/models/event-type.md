
# Event Type

## Structure

`EventType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | [`EventTypeId`](../../doc/models/containers/event-type-id.md) | Required | This is a container for one-of cases. |
| `EnabledForTest` | `bool` | Required | Value is `true` if the event type is enabled in both the test and live environments and `false` if it is only enabled in the live environment. |
| `Resource` | [`ResourceEnum`](../../doc/models/resource-enum.md) | Required | - |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"event_type"` |

## Example (as JSON)

```json
{
  "id": "postcard.international_exit",
  "enabled_for_test": false,
  "resource": "addresses",
  "object": "event_type"
}
```

