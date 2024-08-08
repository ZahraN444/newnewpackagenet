
# Zip

## Structure

`Zip`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ZipCode` | `string` | Required | A 5-digit ZIP code.<br>**Constraints**: *Pattern*: `^\d{5}$` |
| `Id` | `string` | Required | Unique identifier prefixed with `us_zip_`.<br>**Constraints**: *Pattern*: `^us_zip_[a-zA-Z0-9]+$` |
| `Cities` | [`List<ZipLookupCity>`](../../doc/models/zip-lookup-city.md) | Required | An array of city objects containing valid cities for the `zip_code`. Multiple cities will be returned if more than one city is associated with the input ZIP code. |
| `ZipCodeType` | [`ZipCodeTypeEnum`](../../doc/models/zip-code-type-enum.md) | Required | - |
| `MObject` | `string` | Required, Constant | Value is resource type.<br>**Default**: `"us_zip_lookup"` |

## Example (as JSON)

```json
{
  "zip_code": "94107",
  "id": "id6",
  "cities": [
    {
      "city": "city6",
      "state": "state2",
      "county": "county0",
      "county_fips": "county_fips6",
      "preferred": true
    }
  ],
  "zip_code_type": "unique",
  "object": "us_zip_lookup"
}
```

