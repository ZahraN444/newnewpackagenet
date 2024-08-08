
# All Self Mailers

## Structure

`AllSelfMailers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MObject` | `string` | Optional | Value is resource type. |
| `NextUrl` | `string` | Optional | Url of next page of items in list. |
| `PreviousUrl` | `string` | Optional | Url of previous page of items in list. |
| `Count` | `int?` | Optional | number of resources in a set |
| `TotalCount` | `int?` | Optional | Indicates the total number of records. Provided when the request specifies an "include" query parameter |
| `Data` | [`List<SelfMailer>`](../../doc/models/self-mailer.md) | Optional | list of self_mailers |

## Example (as JSON)

```json
{
  "object": "object2",
  "next_url": "next_url0",
  "previous_url": "previous_url2",
  "count": 76,
  "total_count": 240
}
```

