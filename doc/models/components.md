
# Components

A nested object containing a breakdown of each component of a reverse geocoded response.

## Structure

`Components`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ZipCode` | `string` | Required | The 5-digit ZIP code<br>**Constraints**: *Pattern*: `^\d{5}$` |
| `ZipCodePlus4` | `string` | Required | **Constraints**: *Pattern*: `^\d{4}$` |

## Example (as JSON)

```json
{
  "zip_code": "zip_code0",
  "zip_code_plus_4": "zip_code_plus_48"
}
```

