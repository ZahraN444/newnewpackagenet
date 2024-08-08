
# All Letters

## Structure

`AllLetters`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MObject` | `string` | Optional | Value is resource type. |
| `NextUrl` | `string` | Optional | Url of next page of items in list. |
| `PreviousUrl` | `string` | Optional | Url of previous page of items in list. |
| `Count` | `int?` | Optional | number of resources in a set |
| `TotalCount` | `int?` | Optional | Indicates the total number of records. Provided when the request specifies an "include" query parameter |
| `Data` | [`List<Letter>`](../../doc/models/containers/letter.md) | Optional | list of letters |

## Example (as JSON)

```json
{
  "object": "object0",
  "next_url": "next_url2",
  "previous_url": "previous_url0",
  "count": 230,
  "total_count": 190
}
```

