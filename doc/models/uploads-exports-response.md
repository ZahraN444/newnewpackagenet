
# Uploads Exports Response

## Structure

`UploadsExportsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Unique identifier prefixed with `ex_`.<br>**Constraints**: *Pattern*: `^ex_[a-zA-Z0-9]+$` |
| `DateCreated` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the export was created |
| `DateModified` | `DateTime` | Required | A timestamp in ISO 8601 format of the date the export was last modified |
| `Deleted` | `bool` | Required | Returns as `true` if the resource has been successfully deleted. |
| `S3Url` | `string` | Required | The URL for the generated export file. |
| `State` | [`StateEnum`](../../doc/models/state-enum.md) | Required | - |
| `Type` | [`Type1Enum`](../../doc/models/type-1-enum.md) | Required | - |
| `UploadId` | `string` | Required | Unique identifier prefixed with `upl_`.<br>**Constraints**: *Pattern*: `^upl_[a-zA-Z0-9]+$` |

## Example (as JSON)

```json
{
  "id": "id8",
  "dateCreated": "2016-03-13T12:52:32.123Z",
  "dateModified": "2016-03-13T12:52:32.123Z",
  "deleted": false,
  "s3Url": "s3Url8",
  "state": "succeeded",
  "type": "failures",
  "uploadId": "uploadId8"
}
```

