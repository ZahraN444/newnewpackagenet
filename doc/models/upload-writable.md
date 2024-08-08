
# Upload Writable

## Structure

`UploadWritable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CampaignId` | `string` | Required | **Constraints**: *Pattern*: `^cmp_[a-zA-Z0-9]+$` |
| `RequiredAddressColumnMapping` | [`RequiredAddressColumnMapping`](../../doc/models/required-address-column-mapping.md) | Optional | - |
| `OptionalAddressColumnMapping` | [`OptionalAddressColumnMapping`](../../doc/models/optional-address-column-mapping.md) | Optional | - |
| `Metadata` | [`Metadata1`](../../doc/models/metadata-1.md) | Optional | - |
| `MergeVariableColumnMapping` | [`object`](../../doc/models/m-object-enum.md) | Optional | The mapping of column headers in your file to the merge variables present in your creative. See our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#step-3-map-merge-variable-data-if-applicable-7" target="_blank">Campaign Audience Guide</a> for additional details. <br />If a merge variable has the same "name" as a "key" in the `requiredAddressColumnMapping` or `optionalAddressColumnMapping` objects, then they **CANNOT** have a different value in this object. If a different value is provided, then when the campaign is processing it will get overwritten with the mapped value present in the `requiredAddressColumnMapping` or `optionalAddressColumnMapping` objects. If using customized QR code redirect from the Audience file, then a `qr_code_redirect_url` must be mapped to the column header as used in the CSV. |

## Example (as JSON)

```json
{
  "campaignId": "campaignId0",
  "mergeVariableColumnMapping": {
    "name": "recipient_name",
    "gift_code": "code"
  },
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
  }
}
```

