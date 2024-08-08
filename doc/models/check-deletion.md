
# Check Deletion

Lob uses RESTful HTTP response codes to indicate success or failure of an API request. In general, 2xx indicates success, 4xx indicate an input error, and 5xx indicates an error on Lob's end.

## Structure

`CheckDeletion`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique identifier prefixed with `chk_`.<br>**Constraints**: *Pattern*: `^chk_[a-zA-Z0-9]+$` |
| `Deleted` | `bool?` | Optional | Only returned if the resource has been successfully deleted. |

## Example (as JSON)

```json
{
  "id": "id8",
  "deleted": false
}
```
