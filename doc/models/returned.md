
# Returned

Properties that the postcards in your Creative should have. Check within in order to add a QR code to your creative.

## Structure

`Returned`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Optional | - |
| `Size` | [`PostcardSizeEnum?`](../../doc/models/postcard-size-enum.md) | Optional | - |
| `FrontOriginalUrl` | `string` | Optional | The original URL of the `front` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `BackOriginalUrl` | `string` | Optional | The original URL of the `back` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |

## Example (as JSON)

```json
{
  "mail_type": "usps_first_class",
  "size": "4x6",
  "front_original_url": "front_original_url4",
  "back_original_url": "back_original_url8"
}
```

