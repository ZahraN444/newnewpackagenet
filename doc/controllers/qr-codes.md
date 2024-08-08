# QR Codes

```csharp
QRCodesController qRCodesController = client.QRCodesController;
```

## Class Name

`QRCodesController`


# Qr Codes List

Returns a list of your QR codes. The QR codes are returned sorted by scan date, with the most recently scanned QR codes appearing first.

```csharp
QrCodesListAsync(
    int? limit = 10,
    int? offset = 0,
    List<string> include = null,
    Dictionary<string, string> dateCreated = null,
    bool? scanned = null,
    object resourceIds = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | How many results to return. |
| `offset` | `int?` | Query, Optional | An integer that designates the offset at which to begin returning results. Defaults to 0. |
| `include` | `List<string>` | Query, Optional | Request that the response include the total count by specifying `include=["total_count"]`. |
| `dateCreated` | `Dictionary<string, string>` | Query, Optional | Filter by date created. Accepted formats are ISO-8601 date or datetime, e.g. `{ "gt": "2012-01-01", "lt": "2012-01-31T12:34:56Z" }` where `gt` is >, `lt` is <, `gte` is ≥, and `lte` is ≤. |
| `scanned` | `bool?` | Query, Optional | Filter list of responses to only include QR codes with at least one scan event. |
| `resourceIds` | [`object`](../../doc/models/m-object-enum.md) | Query, Optional | Filter by the resource ID. |

## Response Type

[`Task<Models.QrCodeAnalyticsResponse>`](../../doc/models/qr-code-analytics-response.md)

## Example Usage

```csharp
int? limit = 10;
int? offset = 0;
try
{
    QrCodeAnalyticsResponse result = await qRCodesController.QrCodesListAsync(
        limit,
        offset
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "resource_id": "ltr_d5a5a89da9106f8",
      "date_created": "2019-07-27T23:49:01.511Z",
      "number_of_scans": 2,
      "scans": [
        {
          "ip_location": "127.0.0.1",
          "scan_date": "2022-07-27T23:49:01.511Z"
        },
        {
          "ip_location": "127.0.0.1",
          "scan_date": "2022-07-29T23:45:00.436Z"
        }
      ]
    },
    {
      "resource_id": "psc_d5a5a89da9106f8",
      "date_created": "2022-09-27T23:49:01.511Z",
      "number_of_scans": 1,
      "scans": [
        {
          "ip_location": "127.0.0.1",
          "scan_date": "2022-09-27T23:49:01.511Z"
        }
      ]
    }
  ],
  "object": "list",
  "count": 2,
  "scanned_count": 2,
  "total_count": 2
}
```

