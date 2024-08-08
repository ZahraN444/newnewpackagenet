
# Us Verifications

## Structure

`UsVerifications`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Addresses` | [`List<UsVerificationsAddresses>`](../../doc/models/containers/us-verifications-addresses.md) | Required | This is List of a container for one-of cases. |
| `Errors` | `bool` | Required | Indicates whether any errors occurred during the verification process. |

## Example (as JSON)

```json
{
  "addresses": [
    {
      "id": "id8",
      "recipient": "recipient0",
      "primary_line": "primary_line8",
      "secondary_line": "secondary_line4",
      "urbanization": "urbanization0"
    },
    {
      "id": "id8",
      "recipient": "recipient0",
      "primary_line": "primary_line8",
      "secondary_line": "secondary_line4",
      "urbanization": "urbanization0"
    },
    {
      "id": "id8",
      "recipient": "recipient0",
      "primary_line": "primary_line8",
      "secondary_line": "secondary_line4",
      "urbanization": "urbanization0"
    }
  ],
  "errors": false
}
```

