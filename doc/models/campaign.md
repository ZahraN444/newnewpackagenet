
# Campaign

## Structure

`Campaign`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"campaign"` |
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
| `Creatives` | [`List<Creative>`](../../doc/models/creative.md) | Required | An array of creatives that have been associated with this campaign.<br>**Constraints**: *Minimum Items*: `0` |
| `Uploads` | [`List<Upload>`](../../doc/models/upload.md) | Required | A single-element array containing the upload object that is assocated with this campaign.<br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1` |

## Example (as JSON)

```json
{
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "campaign",
  "name": "name8",
  "description": "description8",
  "schedule_type": "immediate",
  "use_type": {
    "key1": "val1",
    "key2": "val2"
  },
  "auto_cancel_if_ncoa": false,
  "id": "id8",
  "is_draft": false,
  "creatives": [
    {
      "date_created": "2016-03-13T12:52:32.123Z",
      "date_modified": "2016-03-13T12:52:32.123Z",
      "deleted": false,
      "object": "creative",
      "resource_type": "postcard",
      "details": {
        "double_sided": true,
        "mail_type": "usps_first_class",
        "size": "6x11",
        "front_original_url": "front_original_url4",
        "back_original_url": "back_original_url6",
        "address_placement": "top_first_page"
      },
      "from": "String5",
      "description": "description8",
      "metadata": {
        "key0": "metadata5"
      },
      "id": "crv_2a3b096c409b32c",
      "template_preview_urls": {
        "key1": "val1",
        "key2": "val2"
      },
      "template_previews": [
        {
          "key1": "val1",
          "key2": "val2"
        }
      ],
      "campaigns": [
        {
          "id": "cmp_ed76e33e7ac4d0bd",
          "name": "My postman Campaign 2",
          "description": "Created via postman again",
          "schedule_type": "immediate",
          "send_date": "2016-03-13T12:52:32.123Z",
          "target_delivery_date": "2016-03-13T12:52:32.123Z",
          "cancel_window_campaign_minutes": 124,
          "metadata": {},
          "use_type": {
            "key1": "val1",
            "key2": "val2"
          },
          "is_draft": true,
          "deleted": false,
          "creatives": [],
          "uploads": [],
          "auto_cancel_if_ncoa": false,
          "date_created": "2022-07-26T20:20:25.016Z",
          "date_modified": "2022-07-26T20:20:25.016Z",
          "object": "campaign",
          "billing_group_id": "billing_group_id8"
        }
      ]
    }
  ],
  "uploads": [
    {
      "campaignId": "campaignId8",
      "requiredAddressColumnMapping": {
        "name": "name0",
        "address_line1": "address_line14",
        "address_city": "address_city0",
        "address_state": "address_state2",
        "address_zip": "address_zip8"
      },
      "optionalAddressColumnMapping": {
        "address_line2": "address_line24",
        "company": "company2",
        "address_country": "address_country6"
      },
      "metadata": {
        "columns": [
          "columns6",
          "columns7",
          "columns8"
        ]
      },
      "mergeVariableColumnMapping": {
        "name": "recipient_name",
        "gift_code": "code"
      },
      "id": "id2",
      "accountId": "fa9ea650fc7b31a89f92",
      "mode": "test",
      "failuresUrl": "https://www.example.com",
      "originalFilename": "my_audience.csv",
      "state": "Validating",
      "totalMailpieces": 100,
      "failedMailpieces": 5,
      "validatedMailpieces": 95,
      "bytesProcessed": 17268,
      "dateCreated": "2016-03-13T12:52:32.123Z",
      "dateModified": "2016-03-13T12:52:32.123Z"
    }
  ],
  "deleted": false,
  "billing_group_id": "billing_group_id0",
  "target_delivery_date": "2016-03-13T12:52:32.123Z",
  "send_date": "2016-03-13T12:52:32.123Z",
  "cancel_window_campaign_minutes": 38
}
```

