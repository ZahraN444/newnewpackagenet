
# Intl Verification

## Structure

`IntlVerification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Recipient` | `string` | Optional | The intended recipient, typically a person's or firm's name.<br>**Constraints**: *Maximum Length*: `500` |
| `PrimaryLine` | `string` | Optional | The primary delivery line (usually the street address) of the address.<br>**Constraints**: *Maximum Length*: `200` |
| `SecondaryLine` | `string` | Optional | The secondary delivery line of the address. This field is typically empty but may contain information if `primary_line` is too long.<br>**Constraints**: *Maximum Length*: `500` |
| `Id` | `string` | Optional | Unique identifier prefixed with `intl_ver_`.<br>**Constraints**: *Pattern*: `^intl_ver_[a-zA-Z0-9]+$` |
| `LastLine` | `string` | Optional | Combination of the following applicable `components`:<br><br>* `city`<br>* `state`<br>* `zip_code`<br>* `zip_code_plus_4` |
| `Country` | `string` | Optional | The country of the address. Will be returned as a 2 letter country short-name code (ISO 3166). |
| `Coverage` | [`CoverageEnum?`](../../doc/models/coverage-enum.md) | Optional | - |
| `Deliverability` | [`Deliverability1Enum?`](../../doc/models/deliverability-1-enum.md) | Optional | - |
| `Status` | [`Status1Enum?`](../../doc/models/status-1-enum.md) | Optional | - |
| `Components` | [`Components1`](../../doc/models/components-1.md) | Optional | - |
| `MObject` | [`Object2Enum?`](../../doc/models/object-2-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "country": "CA",
  "recipient": "recipient0",
  "primary_line": "primary_line8",
  "secondary_line": "secondary_line4",
  "id": "id8",
  "last_line": "last_line8"
}
```

