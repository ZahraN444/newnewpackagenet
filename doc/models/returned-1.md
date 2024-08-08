
# Returned 1

Properties that the postcards in your Creative should have. Check within in order to add a QR code to your creative.

## Structure

`Returned1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Optional | - |
| `Size` | [`PostcardSizeEnum?`](../../doc/models/postcard-size-enum.md) | Optional | - |
| `FrontOriginalUrl` | `string` | Optional | The original URL of the `front` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `BackOriginalUrl` | `string` | Optional | The original URL of the `back` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `AddressPlacement` | [`AddressPlacementEnum?`](../../doc/models/address-placement-enum.md) | Optional | - |
| `Buckslips` | `List<string>` | Optional | A single-element array containing an existing buckslip id in a string format. See [buckslips](#tag/Buckslips) for more information.<br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1`, *Pattern*: `^bck_[a-zA-Z0-9]+$` |
| `Cards` | `List<string>` | Optional | A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information.<br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1`, *Pattern*: `^card_[a-zA-Z0-9]+$` |
| `CustomEnvelope` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `Color` | `bool?` | Optional | Set this key to `true` if you would like to print in color. Set to `false` if you would like to print in black and white. |
| `DoubleSided` | `bool?` | Optional | Set this attribute to `true` for double sided printing, or `false` for for single sided printing. Defaults to `true`.<br>**Default**: `true` |
| `ExtraService` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `FileOriginalUrl` | `string` | Optional | The original URL of the `file` template. |
| `InsideOriginalUrl` | `string` | Optional | The original URL of the `inside` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |
| `OutsideOriginalUrl` | `string` | Optional | The original URL of the `outside` template.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2083` |

## Example (as JSON)

```json
{
  "double_sided": true,
  "mail_type": "usps_first_class",
  "size": "6x11",
  "front_original_url": "front_original_url8",
  "back_original_url": "back_original_url4",
  "address_placement": "bottom_first_page_center"
}
```

