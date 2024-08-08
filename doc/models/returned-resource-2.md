
# Returned Resource 2

## Structure

`ReturnedResource2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | `string` | Required, Constant | Mailpiece type for the creative<br>**Default**: `"self_mailer"` |
| `Details` | [`Details7`](../../doc/models/details-7.md) | Required | - |
| `From` | [`object`](../../doc/models/m-object-enum.md) | Optional | - |
| `Description` | `string` | Optional | An internal description that identifies this resource. Must be no longer than 255 characters.<br>**Constraints**: *Maximum Length*: `255` |
| `Metadata` | `Dictionary<string, string>` | Optional | Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters `"` and `\`. i.e. '{"customer_id" : "NEWYORK2015"}' Nested objects are not supported.  See [Metadata](#section/Metadata) for more information. |

## Example (as JSON)

```json
{
  "resource_type": "self_mailer",
  "details": {
    "mail_type": "usps_first_class",
    "size": "6x18_bifold",
    "inside_original_url": "inside_original_url2",
    "outside_original_url": "outside_original_url4"
  },
  "from": {
    "key1": "val1",
    "key2": "val2"
  },
  "description": "description4",
  "metadata": {
    "key0": "metadata1"
  }
}
```

