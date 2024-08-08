
# Us Autocompletions Writable

## Structure

`UsAutocompletionsWritable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressPrefix` | `string` | Required | Only accepts numbers and street names in an alphanumeric format. |
| `City` | `string` | Optional | An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations. |
| `State` | `string` | Optional | An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations. |
| `ZipCode` | `string` | Optional | An optional ZIP Code input used to filter suggestions. Matches partial entries. |
| `GeoIpSort` | `bool?` | Optional | If `true`, sort suggestions by proximity to the IP set in the `X-Forwarded-For` header. |

## Example (as JSON)

```json
{
  "address_prefix": "address_prefix8",
  "city": "city0",
  "state": "state6",
  "zip_code": "zip_code4",
  "geo_ip_sort": false
}
```

