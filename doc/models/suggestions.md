
# Suggestions

## Structure

`Suggestions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrimaryLine` | `string` | Required | The primary delivery line (usually the street address) of the address.<br>Combination of the following applicable `components` (primary number &<br>secondary information may be missing or inaccurate):<br><br>* `primary_number`<br>* `street_predirection`<br>* `street_name`<br>* `street_suffix`<br>* `street_postdirection`<br>* `secondary_designator`<br>* `secondary_number`<br>* `pmb_designator`<br>* `pmb_number` |
| `City` | `string` | Required | **Constraints**: *Maximum Length*: `200` |
| `State` | `string` | Required | The <a href="https://en.wikipedia.org/wiki/ISO_3166-2" target="_blank">ISO 3166-2</a> two letter code for the state.<br>**Constraints**: *Maximum Length*: `2` |
| `ZipCode` | `string` | Required | **Constraints**: *Pattern*: `^\d{5}((-)?\d{4})?$` |
| `MObject` | [`Object13Enum?`](../../doc/models/object-13-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "primary_line": "primary_line6",
  "city": "city4",
  "state": "state8",
  "zip_code": "zip_code0",
  "object": "us_autocompletion"
}
```

