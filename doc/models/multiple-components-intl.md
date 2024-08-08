
# Multiple Components Intl

## Structure

`MultipleComponentsIntl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Recipient` | `string` | Optional | The intended recipient, typically a person's or firm's name.<br>**Constraints**: *Maximum Length*: `500` |
| `PrimaryLine` | `string` | Required | The primary delivery line (usually the street address) of the address.<br>**Constraints**: *Maximum Length*: `200` |
| `SecondaryLine` | `string` | Optional | The secondary delivery line of the address. This field is typically empty but may contain information if `primary_line` is too long.<br>**Constraints**: *Maximum Length*: `500` |
| `City` | `string` | Optional | **Constraints**: *Maximum Length*: `200` |
| `State` | `string` | Optional | The name of the state. |
| `PostalCode` | `string` | Optional | The postal code.<br>**Constraints**: *Maximum Length*: `12` |
| `Country` | [`CountryExtendedEnum`](../../doc/models/country-extended-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "recipient": "recipient0",
  "primary_line": "primary_line8",
  "secondary_line": "secondary_line4",
  "city": "city8",
  "state": "state4",
  "postal_code": "postal_code0",
  "country": "CG"
}
```

