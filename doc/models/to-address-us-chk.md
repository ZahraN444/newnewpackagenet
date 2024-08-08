
# To Address Us Chk

## Structure

`ToAddressUsChk`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was created. |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the resource was last modified. |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"address"` |
| `Id` | `string` | Required | Unique identifier prefixed with `adr_`.<br>**Constraints**: *Pattern*: `^adr_[a-zA-Z0-9]+$` |
| `Description` | `string` | Optional | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `Name` | `string` | Required | Either `name` or `company` is required, you may also add both. Must be no longer than 40 characters. If both `name` and `company` are provided, they will be printed on two separate lines above the rest of the address.<br>**Constraints**: *Maximum Length*: `40` |
| `Company` | `string` | Required | Either `name` or `company` is required, you may also add both. Must be no longer than 40 characters. If both `name` and `company` are provided, they will be printed on two separate lines above the rest of the address. This field can be used for any secondary recipient information which is not part of the actual mailing address (Company Name, Department, Attention Line, etc).<br>**Constraints**: *Maximum Length*: `40` |
| `Phone` | `string` | Optional | Must be no longer than 40 characters.<br>**Constraints**: *Maximum Length*: `40` |
| `Email` | `string` | Optional | Must be no longer than 100 characters.<br>**Constraints**: *Maximum Length*: `100` |
| `AddressLine1` | `string` | Required | The primary number, street name, and directional information.<br>**Constraints**: *Maximum Length*: `50` |
| `AddressLine2` | `string` | Optional | An optional field containing any information which can't fit into line 1.<br>**Constraints**: *Maximum Length*: `50` |
| `AddressCity` | `string` | Required | **Constraints**: *Maximum Length*: `200` |
| `AddressState` | `string` | Required | 2 letter state short-name code<br>**Constraints**: *Pattern*: `^[a-zA-Z]{2}$` |
| `AddressZip` | `string` | Required | Must follow the ZIP format of `12345` or ZIP+4 format of `12345-1234`.<br>**Constraints**: *Pattern*: `^\d{5}(-\d{4})?$` |
| `AddressCountry` | [`AddressCountryEnum?`](../../doc/models/address-country-enum.md) | Optional | **Constraints**: *Minimum Length*: `13`, *Maximum Length*: `13` |
| `Metadata` | `Dictionary<string, string>` | Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |
| `RecipientMoved` | `bool?` | Optional | Only returned for accounts on certain <a href="https://dashboard.lob.com/#/settings/editions" target="_blank">Print &amp; Mail Editions</a>. Value is `true` if the address was altered because the recipient filed for a <a href="#tag/National-Change-of-Address">National Change of Address Linkage (NCOALink)</a>, `false` if the NCOALink check was run but no altered address was found, and `null` if the NCOALink check was not run. The NCOALink check does not happen for non-US addresses, for non-deliverable US addresses, or for addresses created before the NCOALink feature was added to your account. |

## Example (as JSON)

```json
{
  "date_created": "2016-03-13T12:52:32.123Z",
  "date_modified": "2016-03-13T12:52:32.123Z",
  "object": "address",
  "id": "id8",
  "name": "name8",
  "company": "company2",
  "address_line1": "address_line18",
  "address_city": "address_city8",
  "address_state": "address_state0",
  "address_zip": "address_zip0",
  "deleted": false,
  "description": "description2",
  "phone": "phone2",
  "email": "email8",
  "address_line2": "address_line20"
}
```

