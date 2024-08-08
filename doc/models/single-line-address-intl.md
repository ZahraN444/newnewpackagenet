
# Single Line Address Intl

## Structure

`SingleLineAddressIntl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | `string` | Required | The entire address in one string (e.g., "370 Water St C1N 1C4").<br>**Constraints**: *Maximum Length*: `500` |
| `Country` | [`CountryExtendedEnum`](../../doc/models/country-extended-enum.md) | Required | - |

## Example (as JSON)

```json
{
  "address": "address6",
  "country": "CY"
}
```

