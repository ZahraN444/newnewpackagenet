
# Details 6

## Structure

`Details6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressPlacement` | [`AddressPlacementEnum?`](../../doc/models/address-placement-enum.md) | Optional | - |
| `Buckslips` | `List<string>` | Optional | A single-element array containing an existing buckslip id in a string format. See [buckslips](#tag/Buckslips) for more information.<br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1`, *Pattern*: `^bck_[a-zA-Z0-9]+$` |
| `Cards` | `List<string>` | Optional | A single-element array containing an existing card id in a string format. See [cards](#tag/Cards) for more information.<br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1`, *Pattern*: `^card_[a-zA-Z0-9]+$` |
| `CustomEnvelope` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `Color` | `bool?` | Optional | Set this key to `true` if you would like to print in color. Set to `false` if you would like to print in black and white. |
| `DoubleSided` | `bool?` | Optional | Set this attribute to `true` for double sided printing, or `false` for for single sided printing. Defaults to `true`.<br>**Default**: `true` |
| `ExtraService` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `FileOriginalUrl` | `string` | Optional | The original URL of the `file` template. |
| `MailType` | [`MailTypeEnum?`](../../doc/models/mail-type-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "double_sided": true,
  "address_placement": "top_first_page",
  "buckslips": [
    "buckslips0"
  ],
  "cards": [
    "cards5",
    "cards6",
    "cards7"
  ],
  "custom_envelope": {
    "key1": "val1",
    "key2": "val2"
  },
  "color": false
}
```

