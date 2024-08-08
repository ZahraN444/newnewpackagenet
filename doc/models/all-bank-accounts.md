
# All Bank Accounts

## Structure

`AllBankAccounts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MObject` | `string` | Optional | Value is resource type. |
| `NextUrl` | `string` | Optional | Url of next page of items in list. |
| `PreviousUrl` | `string` | Optional | Url of previous page of items in list. |
| `Count` | `int?` | Optional | number of resources in a set |
| `TotalCount` | `int?` | Optional | Indicates the total number of records. Provided when the request specifies an "include" query parameter |
| `Data` | [`List<BankAccount>`](../../doc/models/bank-account.md) | Optional | list of bank_accounts |

## Example (as JSON)

```json
{
  "object": "object4",
  "next_url": "next_url8",
  "previous_url": "previous_url4",
  "count": 110,
  "total_count": 54
}
```

