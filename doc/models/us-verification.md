
# Us Verification

## Structure

`UsVerification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique identifier prefixed with `us_ver_`.<br>**Constraints**: *Pattern*: `^us_ver_[a-zA-Z0-9_]+$` |
| `Recipient` | `string` | Optional | The intended recipient, typically a person's or firm's name.<br>**Constraints**: *Maximum Length*: `500` |
| `PrimaryLine` | `string` | Optional | The primary delivery line (usually the street address) of the address.<br>Combination of the following applicable `components`:<br><br>* `primary_number`<br>* `street_predirection`<br>* `street_name`<br>* `street_suffix`<br>* `street_postdirection`<br>* `secondary_designator`<br>* `secondary_number`<br>* `pmb_designator`<br>* `pmb_number`<br>**Constraints**: *Maximum Length*: `500` |
| `SecondaryLine` | `string` | Optional | The secondary delivery line of the address. This field is typically empty but may contain information if `primary_line` is too long.<br>**Constraints**: *Maximum Length*: `500` |
| `Urbanization` | `string` | Optional | Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See <a href="https://pe.usps.com/text/pub28/28api_008.htm#:~:text=I51.,-4%20Urbanizations&text=In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name." target="_blank">USPS documentation</a> for clarification.<br>**Constraints**: *Maximum Length*: `500` |
| `LastLine` | `string` | Optional | Combination of the following applicable `components`:<br><br>* City (`city`)<br>* State (`state`)<br>* ZIP code (`zip_code`)<br>* ZIP+4 (`zip_code_plus_4`) |
| `Deliverability` | [`DeliverabilityEnum?`](../../doc/models/deliverability-enum.md) | Optional | - |
| `ValidAddress` | `bool?` | Optional | This field indicates whether an address was found in a more comprehensive address dataset that includes sources from the USPS, open source mapping data, and our proprietary mail delivery data.<br>This field can be interpreted as a representation of whether an address is a real location or not. Additionally a valid address may contradict the deliverability field since an address can be a real valid location but the USPS may not deliver to that address. |
| `Components` | [`Components4`](../../doc/models/components-4.md) | Optional | - |
| `DeliverabilityAnalysis` | [`DeliverabilityAnalysis1`](../../doc/models/deliverability-analysis-1.md) | Optional | - |
| `LobConfidenceScore` | [`LobConfidenceScore1`](../../doc/models/lob-confidence-score-1.md) | Optional | - |
| `MObject` | [`Object1Enum?`](../../doc/models/object-1-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id8",
  "recipient": "recipient0",
  "primary_line": "primary_line8",
  "secondary_line": "secondary_line4",
  "urbanization": "urbanization0"
}
```

