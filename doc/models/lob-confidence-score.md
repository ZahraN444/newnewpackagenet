
# Lob Confidence Score

Lob Confidence Score is a nested object that provides a numerical value between 0-100 of the likelihood that an address is deliverable based on Lob’s mail delivery data to over half of US households.

## Structure

`LobConfidenceScore`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Score` | `double?` | Required | A numerical score between 0 and 100 that represents the percentage of mailpieces Lob has sent to this addresses that have been delivered successfully over the past 2 years. Will be `null` if no tracking data exists for this address.<br>**Constraints**: `>= 0`, `<= 100` |
| `Level` | [`LevelEnum`](../../doc/models/level-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "score": 86.86,
  "level": "high"
}
```

