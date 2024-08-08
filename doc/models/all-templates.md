
# All Templates

## Structure

`AllTemplates`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MObject` | `string` | Optional | Value is resource type. |
| `NextUrl` | `string` | Optional | Url of next page of items in list. |
| `PreviousUrl` | `string` | Optional | Url of previous page of items in list. |
| `Count` | `int?` | Optional | number of resources in a set |
| `TotalCount` | `int?` | Optional | Indicates the total number of records. Provided when the request specifies an "include" query parameter |
| `Data` | [`List<Template>`](../../doc/models/template.md) | Optional | list of templates |

## Example (as JSON)

```json
{
  "object": "object8",
  "next_url": "next_url4",
  "previous_url": "previous_url8",
  "count": 22,
  "total_count": 142
}
```

