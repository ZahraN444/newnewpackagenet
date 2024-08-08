
# Letter Generated Base

## Structure

`LetterGeneratedBase`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `To` | [`object`](../../doc/models/m-object-enum.md) | Required | - |
| `Carrier` | `string` | Required, Constant | **Default**: `"USPS"` |
| `Thumbnails` | [`List<Thumbnail>`](../../doc/models/thumbnail.md) | Optional | - |
| `ExpectedDeliveryDate` | `DateTime?` | Optional | A date in YYYY-MM-DD format of the mailpiece's expected delivery date based on its `send_date`. |
| `DateCreated` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `From` | [`object`](../../doc/models/m-object-enum.md) | Required | - |
| `Url` | `string` | Optional | A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.<br>**Constraints**: *Pattern*: `^https://lob-assets\.com/(letters\|postcards\|bank-accounts\|checks\|self-mailers\|cards)/[a-z]{3,4}_[a-z0-9]{15,16}(\.pdf\|_thumb_[a-z]+_[0-9]+\.png)\?(version=[a-z0-9-]*&)?expires=[0-9]{10}&signature=[a-zA-Z0-9-_]+$` |
| `Id` | `string` | Required | Unique identifier prefixed with `ltr_`.<br>**Constraints**: *Pattern*: `^ltr_[a-zA-Z0-9]+$` |
| `TemplateId` | `string` | Optional | **Constraints**: *Pattern*: `^tmpl_[a-zA-Z0-9]+$` |
| `TemplateVersionId` | `string` | Optional | **Constraints**: *Pattern*: `^vrsn_[a-zA-Z0-9]+$` |
| `CampaignId` | `string` | Optional | The unique ID of the associated campaign if the resource was generated from a campaign. |
| `UseType` | [`object`](../../doc/models/m-object-enum.md) | Required | - |
| `Fsc` | `bool?` | Optional | This is in beta. Contact support@lob.com or your account contact to learn more. Not available for `A4` letter size.<br>**Default**: `false` |
| `Status` | [`ThestatusofthebuckslipEnum?`](../../doc/models/thestatusofthebuckslip-enum.md) | Optional | - |
| `FailureReason` | `string` | Optional | A string describing the reason for failure if the letter failed to render. |
| `MObject` | [`Object8Enum?`](../../doc/models/object-8-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "to": {
    "key1": "val1",
    "key2": "val2"
  },
  "carrier": "USPS",
  "from": {
    "key1": "val1",
    "key2": "val2"
  },
  "id": "id4",
  "use_type": {
    "key1": "val1",
    "key2": "val2"
  },
  "fsc": false,
  "thumbnails": [
    {
      "small": "small8",
      "medium": "medium8",
      "large": "large6"
    },
    {
      "small": "small8",
      "medium": "medium8",
      "large": "large6"
    },
    {
      "small": "small8",
      "medium": "medium8",
      "large": "large6"
    }
  ],
  "expected_delivery_date": "2016-03-13",
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "deleted": false
}
```

