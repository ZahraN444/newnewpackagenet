
# Intl Autocompletions

## Structure

`IntlAutocompletions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique identifier prefixed with `intl_auto_`.<br>**Constraints**: *Pattern*: `^intl_auto_[a-zA-Z0-9]+$` |
| `Suggestions` | [`List<IntlSuggestions>`](../../doc/models/intl-suggestions.md) | Optional | An array of objects representing suggested addresses.<br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `10` |

## Example (as JSON)

```json
{
  "id": "id8",
  "suggestions": [
    {
      "primary_number_range": "primary_number_range8",
      "primary_line": "primary_line6",
      "city": "city4",
      "country": "HN",
      "state": "state8",
      "zip_code": "zip_code0"
    }
  ]
}
```

