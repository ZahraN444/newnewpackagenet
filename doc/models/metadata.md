
# Metadata

The list of column headers in your file as an array that you want as metadata associated with each mailpiece. See our <a href="https://help.lob.com/print-and-mail/building-a-mail-strategy/campaign-or-triggered-sends/campaign-audience-guide#required-columns-2" target="_blank">Campaign Audience Guide</a> for additional details.

## Structure

`Metadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Columns` | `List<string>` | Required | The list of column names from the csv file which you want associated with each of your mailpieces |

## Example (as JSON)

```json
{
  "columns": [
    "recipient_name"
  ]
}
```

