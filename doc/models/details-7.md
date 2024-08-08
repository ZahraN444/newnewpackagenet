
# Details 7

## Structure

`Details7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Optional | - |
| `Size` | [`SelfMailerSizeEnum?`](../../doc/models/self-mailer-size-enum.md) | Optional | - |
| `InsideOriginalUrl` | `string` | Optional | The original URL of the `inside` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `OutsideOriginalUrl` | `string` | Optional | The original URL of the `outside` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |

## Example (as JSON)

```json
{
  "mail_type": "usps_first_class",
  "size": "12x9_bifold",
  "inside_original_url": "inside_original_url0",
  "outside_original_url": "outside_original_url2"
}
```

