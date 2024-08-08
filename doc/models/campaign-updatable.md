
# Campaign Updatable

## Structure

`CampaignUpdatable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Description` | `string` | Optional | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `ScheduleType` | [`CmpScheduleTypeEnum?`](../../doc/models/cmp-schedule-type-enum.md) | Optional | - |
| `TargetDeliveryDate` | `DateTime?` | Optional | If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign. |
| `SendDate` | `DateTime?` | Optional | If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign. |
| `CancelWindowCampaignMinutes` | `int?` | Optional | A window, in minutes, within which the campaign can be canceled. |
| `Metadata` | `Dictionary<string, string>` | Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `IsDraft` | `bool?` | Optional | Whether or not the campaign is still a draft. Can either be excluded or `false`. |
| `UseType` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `AutoCancelIfNcoa` | `bool?` | Optional | Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA. |

## Example (as JSON)

```json
{
  "name": "name4",
  "description": "description6",
  "schedule_type": "immediate",
  "target_delivery_date": "2016-03-13T12:52:32.123Z",
  "send_date": "2016-03-13T12:52:32.123Z"
}
```

