
# Address Fields Intl

## Structure

`AddressFieldsIntl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressLine1` | `string` | Required | The primary number, street name, and directional information.<br>**Constraints**: *Maximum Length*: `200` |
| `AddressLine2` | `string` | Optional | An optional field containing any information which can't fit into line 1.<br>**Constraints**: *Maximum Length*: `200` |
| `AddressCity` | `string` | Optional | **Constraints**: *Maximum Length*: `200` |
| `AddressState` | `string` | Optional | **Constraints**: *Maximum Length*: `200` |
| `AddressZip` | `string` | Optional | Optional postal code.<br>**Constraints**: *Maximum Length*: `40` |

## Example (as JSON)

```json
{
  "address_line1": "address_line18",
  "address_line2": "address_line20",
  "address_city": "address_city8",
  "address_state": "address_state0",
  "address_zip": "address_zip0"
}
```

