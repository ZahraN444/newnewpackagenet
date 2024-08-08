
# Address Fields Us

## Structure

`AddressFieldsUs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressLine1` | `string` | Required | The primary number, street name, and directional information.<br>**Constraints**: *Maximum Length*: `64` |
| `AddressLine2` | `string` | Optional | An optional field containing any information which can't fit into line 1.<br>**Constraints**: *Maximum Length*: `64` |
| `AddressCity` | `string` | Required | **Constraints**: *Maximum Length*: `200` |
| `AddressState` | `string` | Required | 2 letter state short-name code<br>**Constraints**: *Pattern*: `^[a-zA-Z]{2}$` |
| `AddressZip` | `string` | Required | Must follow the ZIP format of `12345` or ZIP+4 format of `12345-1234`.<br>**Constraints**: *Pattern*: `^\d{5}(-\d{4})?$` |

## Example (as JSON)

```json
{
  "address_line1": "address_line14",
  "address_line2": "address_line22",
  "address_city": "address_city0",
  "address_state": "address_state2",
  "address_zip": "address_zip2"
}
```

