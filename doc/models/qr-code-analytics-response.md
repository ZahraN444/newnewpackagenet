
# Qr Code Analytics Response

## Structure

`QrCodeAnalyticsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MObject` | `string` | Optional | Value is resource type. |
| `Count` | `int?` | Optional | number of resources in a set |
| `TotalCount` | `int?` | Optional | Indicates the total number of records. Provided when the request specifies an "include" query parameter |
| `ScannedCount` | `int?` | Optional | Indicates the number of QR Codes out of `count` that were scanned atleast once. |
| `Data` | [`List<QrCodeScans>`](../../doc/models/qr-code-scans.md) | Optional | List of QR code analytics |

## Example (as JSON)

```json
{
  "object": "object0",
  "count": 52,
  "total_count": 112,
  "scanned_count": 74,
  "data": [
    {
      "resource_id": "resource_id6",
      "date_created": "2016-03-13T12:52:32.123Z",
      "number_of_scans": 198.84,
      "scans": [
        {
          "ip_location": "ip_location0",
          "scan_date": "scan_date4"
        },
        {
          "ip_location": "ip_location0",
          "scan_date": "scan_date4"
        },
        {
          "ip_location": "ip_location0",
          "scan_date": "scan_date4"
        }
      ]
    },
    {
      "resource_id": "resource_id6",
      "date_created": "2016-03-13T12:52:32.123Z",
      "number_of_scans": 198.84,
      "scans": [
        {
          "ip_location": "ip_location0",
          "scan_date": "scan_date4"
        },
        {
          "ip_location": "ip_location0",
          "scan_date": "scan_date4"
        },
        {
          "ip_location": "ip_location0",
          "scan_date": "scan_date4"
        }
      ]
    }
  ]
}
```

