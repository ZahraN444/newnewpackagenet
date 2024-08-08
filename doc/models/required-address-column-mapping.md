
# Required Address Column Mapping

## Structure

`RequiredAddressColumnMapping`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The column header from the csv file that should be mapped to the required field `name` |
| `AddressLine1` | `string` | Required | The column header from the csv file that should be mapped to the required field `address_line1` |
| `AddressCity` | `string` | Required | The column header from the csv file that should be mapped to the required field `address_city` |
| `AddressState` | `string` | Required | The column header from the csv file that should be mapped to the required field `address_state` |
| `AddressZip` | `string` | Required | The column header from the csv file that should be mapped to the required field `address_zip` |

## Example (as JSON)

```json
{
  "name": "name4",
  "address_line1": "address_line18",
  "address_city": "address_city4",
  "address_state": "address_state6",
  "address_zip": "address_zip6"
}
```

