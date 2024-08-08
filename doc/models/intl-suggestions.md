
# Intl Suggestions

## Structure

`IntlSuggestions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrimaryNumberRange` | `string` | Required | The primary number range of the address that identifies a building at street level. |
| `PrimaryLine` | `string` | Required | The primary delivery line (usually the street address) of the address.<br>Combination of the following applicable `components` (primary number &<br>secondary information may be missing or inaccurate):<br><br>* `primary_number`<br>* `street_predirection`<br>* `street_name`<br>* `street_suffix`<br>* `street_postdirection`<br>* `secondary_designator`<br>* `secondary_number`<br>* `pmb_designator`<br>* `pmb_number` |
| `City` | `string` | Required | **Constraints**: *Maximum Length*: `200` |
| `Country` | [`CountryExtendedEnum`](../../doc/models/country-extended-enum.md) | Required | - |
| `State` | `string` | Required | The <a href="https://en.wikipedia.org/wiki/ISO_3166-2" target="_blank">ISO 3166-2</a> two letter code for the state.<br>**Constraints**: *Maximum Length*: `2` |
| `ZipCode` | `string` | Required | The postal code.<br>**Constraints**: *Maximum Length*: `12` |

## Example (as JSON)

```json
{
  "primary_number_range": "primary_number_range2",
  "primary_line": "primary_line2",
  "city": "city8",
  "country": "BZ",
  "state": "state2",
  "zip_code": "zip_code6"
}
```

