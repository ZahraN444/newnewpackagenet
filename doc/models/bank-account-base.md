
# Bank Account Base

## Structure

`BankAccountBase`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `RoutingNumber` | `string` | Required | Must be a <a href="https://www.frbservices.org/index.html" target="_blank">valid US routing number</a>.<br>**Constraints**: *Minimum Length*: `9`, *Maximum Length*: `9` |
| `AccountNumber` | `string` | Required | **Constraints**: *Maximum Length*: `17` |
| `AccountType` | [`AccountTypeEnum`](../../doc/models/account-type-enum.md) | Required | - |
| `Signatory` | `string` | Required | The signatory associated with your account. This name will be printed on checks created with this bank account. If you prefer to use a custom signature image on your checks instead, please create your bank account from the <a href="https://dashboard.lob.com/#/login" target="_blank">Dashboard</a>.<br>**Constraints**: *Maximum Length*: `30` |
| `CheckTemplate` | [`CheckTemplateEnum?`](../../doc/models/check-template-enum.md) | Optional | - |
| `FractionalRoutingNumber` | `string` | Optional | The fractional routing number for your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the fractional routing number associated with your home bank institution. |
| `City` | `string` | Optional | The city associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the city associated with your home bank institution. |
| `State` | `string` | Optional | The state associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the state associated with your home bank institution. |
| `Zipcode` | `string` | Optional | The zipcode associated with your home bank account. Required for the `jpm` check template only. Please contact a bank representative if you do not know the zipcode associated with your home bank institution. |
| `Metadata` | `Dictionary<string, string>` | Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |

## Example (as JSON)

```json
{
  "description": "description6",
  "routing_number": "routing_number0",
  "account_number": "account_number6",
  "account_type": "company",
  "signatory": "signatory0",
  "check_template": "common",
  "fractional_routing_number": "fractional_routing_number6",
  "city": "city6",
  "state": "state2"
}
```

