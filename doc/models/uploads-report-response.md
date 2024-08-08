
# Uploads Report Response

## Structure

`UploadsReportResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Datum>`](../../doc/models/datum.md) | Required | - |
| `NextUrl` | `string` | Optional | Url of next page of items in list. |
| `PrevUrl` | `string` | Optional | Url of previous page of items in list. |
| `Count` | `int` | Required | number of resources in a set |
| `TotalCount` | `int` | Required | Indicates the total number of records. Provided when the request specifies an "include" query parameter |

## Example (as JSON)

```json
{
  "data": [
    {
      "rowNumber": 177.76,
      "status": "Processing",
      "errorMessage": "errorMessage8",
      "mailpieceId": "mailpieceId6",
      "originalData": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "count": 136,
  "total_count": 28,
  "next_url": "next_url8",
  "prev_url": "prev_url4"
}
```

