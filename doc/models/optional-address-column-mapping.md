
# Optional Address Column Mapping

## Structure

`OptionalAddressColumnMapping`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressLine2` | `string` | Required | The column header from the csv file that should be mapped to the optional field "address_line2" |
| `Company` | `string` | Required | The column header from the csv file that should be mapped to the optional field "company" |
| `AddressCountry` | `string` | Required | The column header from the csv file that should be mapped to the optional field "address_country" |

## Example (as JSON)

```json
{
  "address_line2": "address_line28",
  "company": "company4",
  "address_country": "address_country2"
}
```

