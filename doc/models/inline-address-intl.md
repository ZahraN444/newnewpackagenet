
# Inline Address Intl

## Structure

`InlineAddressIntl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressLine1` | `string` | Required | The primary number, street name, and directional information.<br>**Constraints**: *Maximum Length*: `200` |
| `AddressLine2` | `string` | Optional | An optional field containing any information which can't fit into line 1.<br>**Constraints**: *Maximum Length*: `200` |
| `AddressCity` | `string` | Required | **Constraints**: *Maximum Length*: `200` |
| `AddressState` | `string` | Required | **Constraints**: *Maximum Length*: `200` |
| `AddressZip` | `string` | Required | Optional postal code.<br>**Constraints**: *Maximum Length*: `40` |
| `Description` | `string` | Optional | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `Name` | `string` | Required | Either `name` or `company` is required, you may also add both. Must be no longer than 40 characters. If both `name` and `company` are provided, they will be printed on two separate lines above the rest of the address.<br>**Constraints**: *Maximum Length*: `40` |
| `Company` | `string` | Required | Either `name` or `company` is required, you may also add both. Must be no longer than 40 characters. If both `name` and `company` are provided, they will be printed on two separate lines above the rest of the address. This field can be used for any secondary recipient information which is not part of the actual mailing address (Company Name, Department, Attention Line, etc).<br>**Constraints**: *Maximum Length*: `40` |
| `Phone` | `string` | Optional | Must be no longer than 40 characters.<br>**Constraints**: *Maximum Length*: `40` |
| `Email` | `string` | Optional | Must be no longer than 100 characters.<br>**Constraints**: *Maximum Length*: `100` |
| `AddressCountry` | [`CountryExtendedEnum`](../../doc/models/country-extended-enum.md) | Required | - |
| `Metadata` | `Dictionary<string, string>` | Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |

## Example (as JSON)

```json
{
  "address_line1": "address_line12",
  "address_line2": "address_line20",
  "address_city": "address_city8",
  "address_state": "address_state0",
  "address_zip": "address_zip0",
  "description": "description8",
  "name": "name8",
  "company": "company2",
  "phone": "phone2",
  "email": "email8",
  "address_country": "LK",
  "metadata": {
    "key0": "metadata5",
    "key1": "metadata6"
  }
}
```
