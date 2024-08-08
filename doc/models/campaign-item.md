
# Campaign Item

## Structure

`CampaignItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingGroupId` | `string` | Optional | Unique identifier prefixed with `bg_`.<br>**Constraints**: *Pattern*: `^bg_[a-zA-Z0-9]+$` |
| `Name` | `string` | Required | Name of the campaign. |
| `Description` | `string` | Required | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `ScheduleType` | `string` | Required, Constant | How the campaign should be scheduled. Only value available today is `immediate`.<br>**Default**: `"immediate"` |
| `TargetDeliveryDate` | `DateTime?` | Optional | If `schedule_type` is `target_delivery_date`, provide a targeted delivery date for mail pieces in this campaign. |
| `SendDate` | `DateTime?` | Optional | If `schedule_type` is `scheduled_send_date`, provide a date to send this campaign. |
| `CancelWindowCampaignMinutes` | `int?` | Optional | A window, in minutes, within which the campaign can be canceled. |
| `Metadata` | `Dictionary<string, string>` | Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `UseType` | [`object`](../../doc/models/m-object-enum.md) | Required | - |
| `AutoCancelIfNcoa` | `bool` | Required | Whether or not a mail piece should be automatically canceled and not sent if the address is updated via NCOA. |
| `Id` | `string` | Required | Unique identifier prefixed with `cmp_`.<br>**Constraints**: *Pattern*: `^cmp_[a-zA-Z0-9]+$` |
| `IsDraft` | `bool` | Required | Whether or not the campaign is still a draft. |
| `Creatives` | [`object`](../../doc/models/m-object-enum.md) | Required | An array of creatives that have been associated with this campaign. |
| `Uploads` | [`object`](../../doc/models/m-object-enum.md) | Required | A single-element array containing the upload object that is assocated with this campaign.<br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1` |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"campaign"` |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |

## Example (as JSON)

```json
{
  "name": "name2",
  "description": "description2",
  "schedule_type": "immediate",
  "use_type": {
    "key1": "val1",
    "key2": "val2"
  },
  "auto_cancel_if_ncoa": false,
  "id": "id2",
  "is_draft": false,
  "creatives": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "uploads": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "object": "campaign",
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "billing_group_id": "billing_group_id4",
  "target_delivery_date": "2016-03-13T12:52:32.123Z",
  "send_date": "2016-03-13T12:52:32.123Z",
  "cancel_window_campaign_minutes": 238,
  "metadata": {
    "key0": "metadata1",
    "key1": "metadata2"
  }
}
```

