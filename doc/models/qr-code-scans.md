
# Qr Code Scans

## Structure

`QrCodeScans`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceId` | `string` | Optional | Unique identifier for each mail piece. |
| `DateCreated` | `DateTime?` | Optional | A timestamp in ISO 8601 format of the date the resource was created. |
| `NumberOfScans` | `double?` | Optional | Number of times the QR Code associated with this mail piece was scanned. |
| `Scans` | [`List<Scans>`](../../doc/models/scans.md) | Optional | Detailed scan information associated with each mail piece. |

## Example (as JSON)

```json
{
  "resource_id": "resource_id4",
  "date_created": "2016-03-13T12:52:32.123Z",
  "number_of_scans": 111.36,
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
```

