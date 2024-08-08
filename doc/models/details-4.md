
# Details 4

## Structure

`Details4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Optional | - |
| `Size` | [`SelfMailerSizeEnum?`](../../doc/models/self-mailer-size-enum.md) | Optional | - |
| `QrCode` | [`QrCode1`](../../doc/models/qr-code-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "mail_type": "usps_first_class",
  "size": "12x9_bifold",
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

