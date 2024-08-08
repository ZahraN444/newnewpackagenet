
# Writable

Properties that the postcards in your Creative should have. Check within in order to add a QR code to your creative.

## Structure

`Writable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Optional | - |
| `Size` | [`PostcardSizeEnum?`](../../doc/models/postcard-size-enum.md) | Optional | - |
| `QrCode` | [`QrCode1`](../../doc/models/qr-code-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "mail_type": "usps_first_class",
  "size": "6x9",
  "qr_code": {
    "position": "position2",
    "top": "top8",
    "right": "right2",
    "left": "left2",
    "bottom": "bottom4",
    "redirect_url": "String9",
    "width": "width0"
  }
}
```
